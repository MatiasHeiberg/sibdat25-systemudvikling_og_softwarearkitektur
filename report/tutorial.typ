#set page(numbering: "1/1")
#set heading(numbering: "1.1")

= Typst Cheatsheet for Gruppen
Velkommen til! Denne fil er skrevet i Typst. Kigger du i koden, kan du se præcis hvordan resultatet her på siden er lavet.

== De Tre Tilstande (Scopes)
I Typst skifter vi mellem tre "verdener":
- *Markup:* Det du læser lige nu. Ren tekst med simple symboler (stjerner for fed, bindestreg for lister).
- *Code:* Når vi skal bruge funktioner eller logik, bruger vi et hashtag. F.eks. er dagens dato sat ind med kode her: #datetime.today().display()
- *Math:* Matematik skrives mellem dollartegn. F.eks. $A = pi r^2$. Hvis vi bruger to dollartegn, centreres det:
  $ sum_(i=1)^n i = (n(n+1)) / 2 $

== Billeder og Figurer
For at sætte et billede ind og give det en tekst, bruger vi en figur-funktion:

#figure(
  rect(width: 50%, height: 50pt, fill: blue.lighten(80%))[Indsæt `#image("sti.png")` her],
  caption: [Dette er en figurtekst],
) <min_flotte_figur>

== Referencer
Det fede ved labels som `<min_flotte_figur>` ovenfor, er at vi nu kan referere til den automatisk med et snabel-a. Se bare her: Som vi kan se på @min_flotte_figur, er Typst ret smart!

== Set og Show Rules (Styling)
*Set-regler* ændrer standarden for hele dokumentet.
#set text(fill: red)
Nu er alt tekst pludselig rødt!
#set text(fill: black)
Og nu er vi tilbage til sort.

*Show-regler* ændrer på specifikke elementer. Lad os sige vi vil have en speciel baggrund på rå kode:
#show raw: it => box(
  rect(
    fill: luma(240),
    radius: 3pt,
    inset: (x: 3pt, y: 0pt), // Mindre inset på y-aksen holder linjeafstanden pæn
    outset: (y: 3pt), // Gør at boksen stikker lidt ud uden at skubbe linjen
    stroke: none,
  )[#it],
)

Nu vil et stykke inline kode som `print("Hello")` have en grå boks omkring sig!

== Variabler
Bliver du træt af at skrive et langt ord? Gem det i en variabel!
#let boss = "Projektleder Jens"
Når vi skal bruge det, skriver vi bare: Hej med dig, #boss.

== Multiline Scopes (Blokke over flere linjer)
I Typst er der tre meget vigtige måder at skrive ting over flere linjer på. Det er afgørende at kende forskel på de tre typer klammer/tegn, for de gør tre helt forskellige ting!

=== Content Scopes (Indhold): Firkantede klammer `[ ]`
Firkantede klammer betyder "Herinde er der almindelig tekst/markup". Alt inden i klammerne behandles præcis som resten af dokumentet. Det er genialt til at gemme hele afsnit i en variabel eller sende tekstblokke ind i en funktion (som f.eks. en farvet boks).

Sådan ser det ud i koden:
```typst
#let min_tekstblok = [
  Dette er en tekst over flere linjer!
  - Du kan bruge *fed* og _kursiv_ herinde.

  Det hele er gemt som én stor indholdsblok.
]

// Her kalder vi en grå boks og smider vores blok ind i den:
#rect(fill: luma(240), inset: 10pt)[
  #min_tekstblok
]
```

=== Code Scopes (Logik): Tuborgklammer `{ }`
Tuborgklammer betyder "Herinde skriver vi ren programmeringskode". Når du er inde i tuborgklammer, behøver du *ikke* starte hver linje med et `#`. Typst ved allerede, at alt herinde er logik.

*Vigtigt:* Hvis du vil printe tekst inde fra et code scope, skal du skifte tilbage til et content scope med `[ ]`!

```typst
#{
  // Herinde er vi i rent "kode-land"
  let a = 10
  let b = 5
  let sum = a + b

  // Vi skifter til [ ] for at printe resultatet som rigtig tekst
  if sum > 10 [
    *Resultat:* Summen er #sum, hvilket er større end 10!
  ] else [
    *Resultat:* Summen er lille.
  ]
}
```

=== Math Scopes (Matematik): Dollartegn `$ $`
Når du vil have matematiske udregninger til at stå centreret som en stor blok over flere linjer, laver du blot et linjeskift mellem dine dollartegn.
Brug `\` for at skifte linje, og sæt et `&`-tegn foran de ting, der skal flugte under hinanden (typisk lighedstegnene).

```typst
$
  f(x) &= (x + 2)^2 \
       &= (x + 2)(x + 2) \
       &= x^2 + 4x + 4
$
```

*Bonus: Forgreninger (Cases)*
Hvis du har en stykkevis funktion, kan du bruge `cases`. Læg mærke til, at rigtige ord skal i `"gåseøjne"`, ellers tror Typst fejlagtigt at det er variabler, der ganges med hinanden:

```typst
$
  f(x) = cases(
    1  &"hvis" x > 0,
    0  &"hvis" x = 0,
    -1 &"hvis" x < 0
  )
$
```

== Tabeller (The Typst Way)
Tabeller i Typst er bygget op omkring `#table`-funktionen. Du fortæller den først, hvordan dine kolonner skal se ud, og derefter fylder du bare cellerne ind én efter én (fra venstre mod højre). Når Typst løber tør for kolonner, skifter den automatisk til en ny række!

=== En simpel tabel
Når vi definerer kolonner, kan vi styre bredden meget præcist:
- `auto`: Kolonnen bliver præcis så bred som den længste tekst i den.
- `1fr` (fraction): Kolonnen strækker sig og fylder resten af den ledige plads.

```typst
#table(
  // Vi beder om 3 kolonner
  columns: (auto, 1fr, 1fr),
  align: center, // Centrerer al tekst i cellerne

  // Række 1: Overskrifter (vi gør teksten fed)
  [*ID*], [*Navn*], [*Rolle*],

  // Række 2: Første sæt data
  [1], [Jens Hansen], [Projektleder],

  // Række 3: Andet sæt data
  [2], [Hanne Jensen], [Udvikler]
)
```

=== Avancerede tabeller (Header og Styling)
Når tabeller bliver lange og måske strækker sig over flere sider, er det smart at bruge `table.header`. Så ved Typst nemlig, at den skal gentage overskriften øverst på den nye side.
Vi kan også ændre på stregerne (stroke) for at gøre den pænere:

```typst
#table(
  columns: 3,
  // Gør kanten lysegrå i stedet for kulsort
  stroke: 0.5pt + luma(150),

  // Definerer overskriften specifikt
  table.header(
    [*Opgave*], [*Ansvarlig*], [*Status*]
  ),

  [Database opsætning], [Hanne], [Færdig],
  [API integration],    [Jens],  [I gang],
  [Frontend styling],   [Peter], [Mangler]
)
```

=== Celler over flere kolonner (Colspan)
Hvis du har brug for, at en enkelt celle strækker sig over to eller flere kolonner (f.eks. til en underoverskrift), bruger du `table.cell`:

```typst
#table(
  columns: 2,

  table.cell(colspan: 2, fill: luma(240))[*Sprint 1 - Planlægning*],

  [Startdato], [1. Marts],
  [Slutdato],  [14. Marts]
)
```
