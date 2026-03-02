# 🚀 Semester Projekt Template (C# & Typst)

Velkommen til projektet! Denne template er sat op for at sikre en professionel arbejdsgang med **C# udvikling**, **levende dokumentation** og **automatiseret rapportskrivning**.

Vi bruger en "Best-of-Breed" tilgang:
* 💜 **Visual Studio** til C# Code & Tests.
* 💙 **VS Code** til Rapport (Typst) & Markdown.
* 🖤 **Obsidian** til Viden & Dokumentation.

---

## 📂 Projekt Struktur

| Mappe | Indhold | Værktøj |
| :--- | :--- | :--- |
| `src/` | **Kildekoden** (C# Projekter). | Visual Studio |
| `tests/` | **Unit Tests** (xUnit/NUnit). | Visual Studio |
| `docs/` | **Dokumentation**, noter & dagbog. | Obsidian |
| `report/` | **Rapporten** skrevet i Typst. | VS Code |
| `.vscode/` | Projekt-indstillinger (Rør ikke). | - |

---

## 🛠️ Kom godt i gang

### 1. Klon Projektet
```bash
git clone <REPO-URL>
cd <REPO-NAVN>
```

### 2. Opsætning af Værktøjer
Projektet er konfigureret til at foreslå de nødvendige udvidelser og indstillinger automatisk.

* **Åbn mappen i VS Code:**
    * Installer de anbefalede extensions (klik "Install" i pop-up).
    * Dette aktiverer C# Dev Kit og Typst (Tinymist).

* **Åbn HELE mappen i Obsidian:**
    * Vælg "Open folder as vault" og vælg **roden** af projektet (ikke kun `docs/`).
    * Accepter "Trust author" for at aktivere plugins.
    * *Bemærk:* Obsidian er konfigureret til automatisk at skjule støj som `bin/`, `obj/` og `.vs/`, så du kun ser det vigtige.

---

## 📝 Workflow Guide

### 💻 C# Udvikling (Visual Studio 2022)
Al kode-udvikling foregår i Visual Studio (den lilla).
* Åbn `.sln` filen (hvis den ikke findes endnu, opretter vi den i roden).
* Kør tests via "Test Explorer".
* **VIGTIGT:** `.gitignore` ignorerer automatisk build-filer.

### 📄 Rapport Skrivning (VS Code + Typst)
Vi skriver rapporten i **Typst** via VS Code.
1.  Åbn filen `report/main.typ` i VS Code.
2.  Extensionen **Tinymist** starter automatisk og viser Live Preview.
3.  Gem (`Ctrl+S`) for at generere PDF.
* **Fonts:** Ligger i `report/fonts/` og loades automatisk.
* **Bibliografi:** Vi bruger `report/bibliography.bib`.

### 🧠 Dokumentation (Obsidian)
Da vi har åbnet roden, kan du linke direkte fra en note til koden:
* *"Se logikken her: [[PaymentService.cs]]"*
* **Obsidian Git:** Pluginnet er sat til **Manuel Mode**.
    * Brug `Ctrl+P` -> `Git: Commit` når du vil gemme noter.

## 📚 Opsætning af Kilder (Zotero)

Vi styrer alle kilder via Zotero. For at kilderne automatisk synkroniseres med vores rapport, skal du gøre følgende:

1. **Accepter invitationen** til vores Zotero Group Library på zotero.org og synkroniser din Zotero-app.
2. **Installer Better BibTeX:** Download `.xpi` filen fra [Better BibTeX's GitHub](https://retorque.re/zotero-better-bibtex/) og installer den i Zotero via *Tools -> Add-ons -> (Tandhjulet) -> Install Add-on From File*. Genstart Zotero.
3. **Start Live-Eksport:** - Højreklik på vores gruppe i Zotero og vælg *Export Library*.
   - Vælg formatet **Better BibLaTeX**.
   - Sæt flueben i **Keep updated**.
   - Gem filen inde i projektets mappe under `report/references.bib`. (Overskriv den bare, hvis den allerede findes).

Nu kan du bruge `Alt + C` inde i Obsidian for at indsætte kilder! Husk at pushe `references.bib` via GitHub Desktop, når du har tilføjet nye kilder til Zotero.

---

## ⚠️ Git Regler (Læs venligst!)

For at undgå konflikter og ødelagte builds:

1.  **Ingen Auto-Commit:** Brug aldrig scripts, der committer automatisk hvert 5. minut.
2.  **Test Før Push:** Push aldrig kode i `src/`, der ikke kan compile.
3.  **Mixed State (Vigtigt):**
    * Hvis du har rettet i både kode (`.cs`) og dokumentation (`.md`), men koden er i stykker:
    * Commit **KUN** dine `.md` filer (via Obsidian eller `git add docs/`).
    * Vent med at committe koden, til den virker.

---

## 🆘 Troubleshooting

* **Jeg ser mærkelige filer i Obsidian (bin/obj)?**
    * Genstart Obsidian. Den burde indlæse `.obsidian/app.json` og skjule dem.
* **Jeg kan ikke se PDF'en i VS Code?**
    * Tryk på "Preview" ikonet oppe i højre hjørne af din `.typ` fil.