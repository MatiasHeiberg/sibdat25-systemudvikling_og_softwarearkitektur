#import "template.typ": project

// Anvender templaten på hele dokumentet
#show: project.with(
  title: "Vores Semesterprojekt",
  authors: ("Fornavn Efternavn", "Fornavn Efternavn", "Fornavn Efternavn"),
  date: "Maj 2026",
)
#metadata("start") <start-formalia>
= Introduktion
#include "sections/indledning.typ"
= Arbejdsprocess
#include "sections/arbejdsmetode.typ"
= Analyse
#include "sections/analyse.typ"
#metadata("stop") <stop-formalia>

#pagebreak()
#bibliography("references.bib")
