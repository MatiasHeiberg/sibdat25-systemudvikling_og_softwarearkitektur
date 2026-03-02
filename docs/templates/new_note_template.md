---
created: <% tp.date.now("YYYY-MM-DD") %>
section: 
exclude: false
sortKey: <%*
  // 1. LÅS CONFIG-FIL TIL "docs/" MAPPEN
  const configPath = "docs/ProjectConfig.md"; 
  let epoch;
  
  // Prøv at finde filen præcis i docs/ mappen
  let configFile = app.vault.getAbstractFileByPath(configPath);
  
  if (!configFile) {
      // Første gang: Sæt startdato til "NU" og tving filen ind i docs/
      const todayStr = tp.date.now("YYYY-MM-DD");
      epoch = new Date(todayStr).getTime();
      const content = "---\nproject_start: " + todayStr + "\n---\n# Projekt Konfiguration\nMå ikke slettes! Sikrer fælles sortering.";
      
      // Opret filen direkte på den specifikke sti
      configFile = await app.vault.create(configPath, content);
  } else {
      // Hvis den findes: Hent startdato fra filen
      const cache = app.metadataCache.getFileCache(configFile);
      if (cache && cache.frontmatter && cache.frontmatter.project_start) {
          epoch = new Date(cache.frontmatter.project_start).getTime();
      } else {
          epoch = new Date("2026-01-01").getTime(); // Fallback
      }
  }

  // 2. BEREGN DAGE (Decimaler til sortering)
  const now = Date.now();
  const daysDiff = (now - epoch) / 86400000;
  tR += daysDiff.toFixed(5); 
%>
---