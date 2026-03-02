Write-Host "🚀 Starter byggeproces for Typst rapport..." -ForegroundColor Cyan

$outDir = "report/sections"
if (-not (Test-Path $outDir)) { New-Item -ItemType Directory -Path $outDir | Out-Null }

$notes = @()
$files = Get-ChildItem -Path "docs" -Filter "*.md" -Recurse -File

Write-Host "🔍 Scanner noter for metadata..." -ForegroundColor DarkGray

foreach ($file in $files) {
    $lines = Get-Content $file.FullName
    $yamlCount = 0
    $section = $null
    $sortKey = $null
    $exclude = $null
    
    foreach ($line in $lines) {
        if ($line -match "^---$") {
            $yamlCount++
            if ($yamlCount -eq 2) { break }
            continue
        }
        if ($yamlCount -eq 1) {
            if ($line -match "^section:\s*(.+)$") { $section = $matches[1].Trim() }
            if ($line -match "^sortKey:\s*(.+)$") { $sortKey = $matches[1].Trim() }
            if ($line -match "^exclude:\s*(.+)$") { $exclude = $matches[1].Trim().ToLower() }
        }
    }
    
    # Samlet på én linje for at undgå parsing-fejl
    if (![string]::IsNullOrWhiteSpace($section) -and $section -ne "None" -and ![string]::IsNullOrWhiteSpace($sortKey) -and $exclude -ne "true") {
        $numericSortKey = [double]($sortKey -replace ',', '.')
        $notes += [PSCustomObject]@{ Section = $section; SortKey = $numericSortKey; Path = $file.FullName }
    }
}

$sections = $notes | Select-Object -ExpandProperty Section -Unique

foreach ($sec in $sections) {
    $fileName = $sec.ToLower().Replace(" ", "_")
    $outTyp = "$outDir\$fileName.typ"
    
    if (Test-Path $outTyp) {
        $head = Get-Content $outTyp -TotalCount 20
        if ($head -match "// LOCKED") {
            Write-Host "🔒 Skipper sektion: $sec (Filen er LÅST for manuel redigering)" -ForegroundColor Yellow
            continue
        }
    }
    
    Write-Host "📄 Samler sektion: $sec..." -ForegroundColor Cyan
    $tempMd = "temp_$fileName.md"
    $mdContent = New-Object System.Text.StringBuilder
    
    $sectionNotes = $notes | Where-Object { $_.Section -eq $sec } | Sort-Object SortKey
    
    foreach ($note in $sectionNotes) {
        $lines = Get-Content $note.Path
        $yamlCount = 0
        $inMermaid = $false
        $mermaidCode = @()
        
        foreach ($line in $lines) {
            if ($line -match "^---$") { $yamlCount++; continue }
            if ($yamlCount -ge 1 -and $yamlCount -lt 2) { continue }
            
            if ($line -match "^```mermaid") { $inMermaid = $true; continue }
            if ($inMermaid -and $line -match "^```$") {
                $inMermaid = $false
                $mermaidString = $mermaidCode -join "`n"
                $mdContent.AppendLine("````{=typst}`n#import `"@preview/mermaid:0.1.1`": *`n#mermaid(```````n$mermaidString`n```````)`n````") | Out-Null
                $mermaidCode = @()
                continue
            }
            if ($inMermaid) { $mermaidCode += $line; continue }
            
            $processedLine = [regex]::Replace($line, '!\[\[([^\]]+)\]\]', '![](/docs/attachments/$1)')
            $mdContent.AppendLine($processedLine) | Out-Null
        }
        $mdContent.AppendLine("`n`n") | Out-Null
    }
    
    Set-Content -Path $tempMd -Value $mdContent.ToString() -Encoding UTF8
    $tempPandoc = "temp_pandoc.typ"
    
    pandoc $tempMd -o $tempPandoc
    
    $header = "// ======================================================================`n" +
              "// ⚠️ ADVARSEL: DENNE FIL ER AUTO-GENERERET AF SCRIPTET.`n" +
              "//`n" +
              "// Dette afsnit er genereret ud fra jeres rå noter i Obsidian.`n" +
              "// Alt manuelt arbejde i denne fil vil blive overskrevet næste gang`n" +
              "// bygge-scriptet køres.`n" +
              "//`n" +
              "// 🔒 LÅSE-FUNKTION:`n" +
              "// Når I er færdige med `"note-fasen`" og vil begynde at renskrive dette`n" +
              "// afsnit manuelt her i VS Code, skal I ændre 'UNLOCKED' til 'LOCKED'.`n" +
              "// Så vil scriptet springe denne fil over fremover, og jeres manuelle `n" +
              "// Typst-kode er fredet.`n" +
              "// `n" +
              "// UNLOCKED`n" +
              "// ======================================================================`n`n"
    
    Set-Content -Path $outTyp -Value $header -Encoding UTF8
    Get-Content -Path $tempPandoc | Add-Content -Path $outTyp -Encoding UTF8
    
    Remove-Item $tempMd, $tempPandoc -ErrorAction SilentlyContinue
    Write-Host "✅ Færdig: $outTyp" -ForegroundColor Green
}

Write-Host "🎉 Processen er færdig! Ulåste afsnit er opdateret i report/sections/" -ForegroundColor Magenta