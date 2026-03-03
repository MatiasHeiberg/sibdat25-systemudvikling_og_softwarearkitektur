---
created: 2026-03-02
section: dag 3
exclude: false
sortKey: 0.39866
---
	Info: Arbejde videre på jeres opgave fra tidligere idag. 
	Opgave:
	1. Noter jeres risks ift. projektet.
	2. Hvordan bør opgaverne prioriteres (Value/Cost/Risk)
	3. Planlæg rækkefølgen, hvad kunne være en god iteration?
	4. Lav et risk registre document. (Optional)

# 1
- Vores antagelser var forkerte, var der overhoved behov for at få løst de problemer vores software adresserede.
- Eksisterer den sociale barriere overhoved?

> [!MOSCOW]-
> - **Must:**
> 	- [[User]] skal kunne oprette [[Session]] og bestemme [[Spiller]] antal, samt skrive hvilket spil der spilles.
> 	- [[User]] kan tilmelde sig en [[Session]]
> 	- [[Admin]] skal have mulighed for at se tidligere og kommende [[Session]]er.
> 	- [[User]] skal have overblik over kommende [[Session]].
> 	- Kunne læse [[User]] fra en json fil.
> 
> - **Should:**
> 	- [[Admin]] kan se aktivitetshistorik for den enkelte [[User]]
> 	- [[Admin]] skal kunne tilføje [[Game]] og indstille min og maks [[Game]]lere.
> 	- [[Admin]] skal kunne tilføje datoer.
> 	- [[Admin]] kan fjerne [[User]] fra systemet ^694f3c
> 	- [[Admin]] skal kan kunne se [[User]]profiler
> 	- Det skal være muligt at oprette en [[User]]profil.
> 	- Gamemaster har rettighed til at slette og tilføje ekstra tekst (beskrivelse) til sessioner vedkommende har oprettet.
> 	- [[User]] får tildelt Gamemaster rollen, når de har oprettet en [[Session]].
> 	- [[Session]] skal være grupperet efter dato
> 	- [[ListOfGame]] skal kunne indeholde data på hvor mange copier der er af hver [[Game]]titel.
> 	- Systemmet skal have en [[ListOfGame]] med x antal spil.
> 	- [[User]]profiler skal have et [[User]]navn.
> 
> - **Could:**
> 	 - [[Admin]] skal kunne vælge tilgængelige [[Game]] til hver dato/arrangement.
> 
> - **Would:** 
> 	- [[User]]en kan optjene points for at oprette sig som gamemaster eller for at deltage i fysiske arrangementer via systemet

# 2
- Svar **value** fordi: når man arbejder i sprints/iterationer er tiden/scope låst, cost (arbejdstimer) kan varieres men værdiskabelsen er aftagende sådan at fordobler man arbejdstimerne leveres der ikke dobbelt så meget værdi. Tilbage er der value, altså hvor mange bugs får man fikset, hvor mange nye features får man implementeret.  Det skærer man ned på.
# 3
1. Kunne læse [[User]] fra en json fil/database.
2. [[User]] skal kunne oprette [[Session]] og bestemme [[Spiller]] antal, samt skrive hvilket spil der spilles.
3. [[User]] kan tilmelde sig en [[Session]]
4. [[User]] skal have overblik over kommende [[Session]].
5. [[Admin]] skal have mulighed for at se tidligere og kommende [[Session]]er.
## Inception
- Ingen programmering
## Elaboration 1
- 1
## Elabortion 2
- 2 + 3
## Elaboration 3
- 4 + 5
