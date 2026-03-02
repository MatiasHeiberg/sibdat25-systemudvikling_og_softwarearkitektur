// --- DESIGN PARAMETRE ---
#let body-font = "Roboto"
#let heading-font = "Roboto"
#let code-font = "Fira Code"
#let primary-color = rgb("#005ba3")
#let font-size = 11pt
#let target-width = 30 * font-size

// --- HOVED FUNKTIONEN ---
#let project(
  title: "",
  authors: (),
  date: none,
  body,
) = {
  // 1. DOKUMENT OPSÆTNING
  set document(author: authors, title: title)
  set text(font: body-font, lang: "da", size: font-size)
  set page(
    paper: "a4",
    margin: (x: 3cm, y: 3cm),
    numbering: none, // Ingen sidetal på forside/TOC
  )

  set bibliography(style: "apa")

  // 2. TEKST FORMATERING
  set par(justify: true, leading: 0.8em)

  // Funktion der begrænser bredden og centrerer indholdet (padding på begge sider)
  let limit-width(it) = layout(size => {
    if size.width > target-width {
      let margin = (size.width - target-width) / 2
      pad(x: margin, it)
    } else {
      it
    }
  })

  // Vi anvender reglen på både tekstafsnit, lister og overskrifter over en bred kam
  show par: limit-width
  show list: limit-width
  show enum: limit-width
  show terms: limit-width
  show heading: limit-width

  // 3. OVERSKRIFTER
  set heading(numbering: "1.1")
  show heading: it => {
    set text(font: heading-font, weight: "bold", fill: primary-color)
    v(0.5em)
    block(it)
    v(0.5em)
  }

  // 4. KODE BLOKKE
  show raw.where(block: true): block.with(
    fill: luma(240),
    inset: 10pt,
    radius: 4pt,
    width: 100%,
  )
  show raw: set text(font: code-font)

  // 5. FORSIDEN
  align(center)[
    #v(3em)
    #image("assets/logo.png", width: 30%)
    #v(2em)
    #text(weight: "bold", size: 24pt, title)
    #v(1em)
    #text(size: 14pt, date)
    #v(2em)

    #grid(
      columns: (1fr,) * calc.min(3, authors.len()),
      gutter: 1em,
      ..authors.map(author => strong(author)),
    )
    #v(2fr)

    // Semester info
    Teknisk Rapport \
    Datamatiker uddannelsen \
    #datetime.today().display("[day]. [month repr:long] [year]")

    #v(2em)

    // --- MANUELT FORMALIA FELT ---
    // Her skriver I bare tallene ind manuelt til sidst
    #block(
      fill: luma(250),
      stroke: luma(200),
      inset: 1em,
      radius: 4pt,
      align(left)[
        *Formalia* \
        Antal anslag: [SKRIV HER] \
        Antal normalsider: [SKRIV HER]
      ],
    )
  ]

  pagebreak()

  // 6. INDHOLDSFORTEGNELSE
  outline(depth: 2, indent: auto)
  pagebreak()

  // 7. HOVEDINDHOLD
  set page(numbering: "1 / 1") // Sidetal starter her
  counter(page).update(1)
  body
}
