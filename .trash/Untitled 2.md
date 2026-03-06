---
created: 2026-03-06
section:
exclude: false
sortKey: 4.37946
---
<!DOCTYPE html>

<html lang="da">

<head>

  <meta charset="UTF-8">

  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <title>01_01 — Tæt Kobling — Softwarearktitektur</title>

  <style>

    /* ================================================================

       STYLING — REDIGER IKKE MEDMINDRE DU VED HVAD DU GØR

       ================================================================ */

  

    *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

  

    body {

      font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif;

      background: #f0f2f5;

      color: #1a1a1a;

      line-height: 1.65;

      font-size: 15px;

    }

  

    /* --- Header --- */

    header {

      background: #1e3a5f;

      color: white;

      padding: 2rem 3rem 1.75rem;

      border-bottom: 4px solid #e8a000;

    }

    .header-badge {

      display: inline-block;

      background: #e8a000;

      color: #1a1a00;

      font-weight: 700;

      font-size: 0.72rem;

      padding: 0.18rem 0.65rem;

      border-radius: 3px;

      text-transform: uppercase;

      letter-spacing: 0.06em;

      margin-bottom: 0.6rem;

    }

    header h1 {

      font-size: 1.75rem;

      font-weight: 700;

      line-height: 1.2;

    }

    header .subtitle {

      margin-top: 0.35rem;

      opacity: 0.75;

      font-size: 0.95rem;

    }

  

    /* --- Layout --- */

    main {

      max-width: 1000px;

      margin: 2rem auto;

      padding: 0 1.5rem 3rem;

    }

  

    /* --- Tekst-sektioner --- */

    .section {

      background: white;

      border-radius: 8px;

      padding: 1.6rem 2rem;

      margin-bottom: 1.25rem;

      box-shadow: 0 1px 4px rgba(0,0,0,0.07);

    }

    .section h2 {

      font-size: 1.05rem;

      font-weight: 700;

      color: #1e3a5f;

      border-bottom: 2px solid #e8eef6;

      padding-bottom: 0.5rem;

      margin-bottom: 0.9rem;

    }

    .section h3 {

      font-size: 0.95rem;

      font-weight: 700;

      color: #333;

      margin: 1.1rem 0 0.4rem;

    }

    .section h3:first-child { margin-top: 0; }

    .section p { margin-bottom: 0.7rem; }

    .section p:last-child { margin-bottom: 0; }

    .section ul, .section ol {

      padding-left: 1.4rem;

      margin: 0.5rem 0 0.7rem;

    }

    .section li { margin-bottom: 0.35rem; }

  

    code {

      font-family: 'Cascadia Code', 'Consolas', 'Courier New', monospace;

      background: #f0f0f0;

      padding: 0.15em 0.4em;

      border-radius: 3px;

      font-size: 0.87em;

    }

  

    /* Badge til SOLID-principper eller lignende */

    .badge {

      display: inline-flex;

      align-items: center;

      justify-content: center;

      width: 28px; height: 28px;

      background: #1e3a5f;

      color: white;

      border-radius: 50%;

      font-weight: 700;

      font-size: 0.88rem;

      margin-right: 0.4rem;

      vertical-align: middle;

      flex-shrink: 0;

    }

    .badge-header {

      display: flex;

      align-items: center;

      gap: 0.4rem;

      margin: 1rem 0 0.4rem;

    }

    .badge-header:first-child { margin-top: 0; }

    .badge-header h3 { margin: 0; }

  

    /* --- Farvede øvelsesblokke (Grøn / Gul / Rød) --- */

    .exercise-block {

      border-radius: 8px;

      margin-bottom: 1.25rem;

      box-shadow: 0 1px 4px rgba(0,0,0,0.07);

      overflow: hidden;

    }

    .ex-header {

      display: flex;

      align-items: center;

      gap: 0.55rem;

      padding: 0.65rem 1.6rem;

    }

    .ex-dot {

      width: 10px; height: 10px;

      border-radius: 50%;

      flex-shrink: 0;

    }

    .ex-label {

      font-size: 0.7rem;

      font-weight: 700;

      text-transform: uppercase;

      letter-spacing: 0.09em;

    }

    .ex-title {

      font-size: 0.97rem;

      font-weight: 700;

      margin-left: 0.5rem;

      border-left: 1px solid rgba(0,0,0,0.15);

      padding-left: 0.75rem;

    }

    .ex-body {

      background: white;

      padding: 1.5rem 1.75rem;

    }

    .ex-body h3 {

      font-size: 0.95rem;

      font-weight: 700;

      color: #333;

      margin: 1.1rem 0 0.4rem;

    }

    .ex-body h3:first-child { margin-top: 0; }

    .ex-body p { margin-bottom: 0.7rem; }

    .ex-body p:last-child { margin-bottom: 0; }

    .ex-body ul, .ex-body ol { padding-left: 1.4rem; margin: 0.5rem 0 0.7rem; }

    .ex-body li { margin-bottom: 0.35rem; }

    /* Green */

    .ex-green .ex-header { background: #e8f5ec; border-bottom: 1px solid #c3e6cb; }

    .ex-green .ex-dot    { background: #2d7a40; }

    .ex-green .ex-label  { color: #2d7a40; }

    .ex-green .ex-title  { color: #1e5530; border-left-color: #a8d5b5; }

    /* Yellow */

    .ex-yellow .ex-header { background: #fff8e1; border-bottom: 1px solid #ffe082; }

    .ex-yellow .ex-dot    { background: #c8800a; }

    .ex-yellow .ex-label  { color: #c8800a; }

    .ex-yellow .ex-title  { color: #7a4d00; border-left-color: #ffd54f; }

    /* Red */

    .ex-red .ex-header { background: #fdecea; border-bottom: 1px solid #f5c6c2; }

    .ex-red .ex-dot    { background: #c0392b; }

    .ex-red .ex-label  { color: #c0392b; }

    .ex-red .ex-title  { color: #7a1a10; border-left-color: #f5c6c2; }

  

    /* Acceptkriterier-liste med talcirkler */

    .accept-list {

      list-style: none;

      padding: 0;

      counter-reset: ac;

    }

    .accept-list li {

      display: flex;

      align-items: flex-start;

      gap: 0.65rem;

      padding: 0.45rem 0;

      border-bottom: 1px solid #f0f0f0;

    }

    .accept-list li:last-child { border-bottom: none; }

    .accept-list li::before {

      content: counter(ac);

      counter-increment: ac;

      display: inline-flex;

      align-items: center;

      justify-content: center;

      min-width: 22px; height: 22px;

      background: #e8f0ff;

      color: #1e3a5f;

      border-radius: 50%;

      font-size: 0.75rem;

      font-weight: 700;

      margin-top: 0.1rem;

    }

  

    /* --- Diagram-container --- */

    .diagram-section {

      background: white;

      border-radius: 8px;

      padding: 1.25rem 1.5rem 1.5rem;

      margin-bottom: 1.25rem;

      box-shadow: 0 1px 4px rgba(0,0,0,0.07);

      overflow-x: auto;

    }

    .diagram-label {

      font-size: 0.78rem;

      font-weight: 600;

      color: #888;

      text-transform: uppercase;

      letter-spacing: 0.07em;

      margin-bottom: 0.3rem;

    }

    .diagram-hint {

      font-size: 0.78rem;

      color: #aaa;

      font-style: italic;

      margin-bottom: 0.85rem;

    }

    svg.uml { display: block; overflow: visible; }

  

    /* Hover-effekt på klasse-boxes */

    .cls-group { cursor: default; }

    .cls-group[data-pseudo] { cursor: pointer; }

    .cls-group[data-pseudo]:hover .cls-header { filter: brightness(1.15); }

    .cls-group[data-pseudo]:hover .cls-border { stroke-width: 2; }

  

    /* --- Tooltip --- */

    #tooltip {

      position: fixed;

      display: none;

      z-index: 9999;

      background: #16213e;

      color: #d8e8ff;

      border: 1px solid #3a5a8a;

      border-radius: 8px;

      padding: 1.1rem 1.4rem;

      max-width: 420px;

      min-width: 220px;

      pointer-events: none;

      box-shadow: 0 6px 24px rgba(0,0,0,0.5);

    }

    #tooltip-label {

      font-size: 0.7rem;

      color: #6a8ab8;

      text-transform: uppercase;

      letter-spacing: 0.08em;

      margin-bottom: 0.6rem;

    }

    #tooltip-code {

      font-family: 'Cascadia Code', 'Consolas', monospace;

      font-size: 0.8rem;

      line-height: 1.6;

      white-space: pre-wrap;

      word-break: break-word;

      margin: 0;

      color: #c8e0ff;

    }

  

    /* Keyword highlighting in tooltip */

    .kw  { color: #7ec8e3; font-weight: bold; }  /* CLASS, INTERFACE, METHOD, etc. */

    .cm  { color: #6a8a6a; font-style: italic; } /* comments */

    .lit { color: #f0c060; }                       /* literals */

  </style>

</head>

<body>

  

<!-- ================================================================

     HEADER — REDIGER: badge, h1, subtitle

     ================================================================ -->

<header>

  <div class="header-badge">Dag 01 — Softwarearktitektur</div>

  <h1>01_01 — Tæt Kobling</h1>

  <div class="subtitle">Implementér et ordre-system og observer problemerne ved tæt kobling</div>

</header>

  

<main>

  

  <!-- ================================================================

       SEKTION: Systembeskrivelse

       Beskriv hvad systemet gør og hvilke typer der indgår

       ================================================================ -->

  <section class="section">

    <h2>Systemet</h2>

    <p>

      Du skal implementere et simpelt ordre-system for en butik.

      Systemet tager imod et produktnavn, en pris og et antal fra brugeren og opretter en ordre med den samlede totalpris.

    </p>

    <ul>

      <li><strong>Product</strong> — en vare med navn og stykpris</li>

      <li><strong>Order</strong> — en bestilling med produkt, antal og udregnet totalpris</li>

      <li><strong>PriceCalculator</strong> — beregner totalpris som pris × antal</li>

      <li><strong>ConsoleLogger</strong> — logger beskeder til konsollen med <code>[LOG]</code>-præfix</li>

      <li><strong>OrderService</strong> — opretter en ordre og koordinerer de øvrige klasser</li>

    </ul>

    <p>

      Problemet i denne implementering er, at <code>OrderService</code> selv opretter

      <code>PriceCalculator</code> og <code>ConsoleLogger</code> med <code>new</code> inde i metoden.

      Det kaldes <em>tæt kobling</em> — vi kan ikke skifte dem ud, og det er svært at teste i isolation.

      Løsningen på dette vises i næste øvelse.

    </p>

  </section>

  

  <!-- ================================================================

       DIAGRAM

       id="diagram-X" skal matche id'et i DIAGRAMS-arrayet nedenfor.

       Tilføj flere <div class="diagram-section"> + <svg> for flere diagrammer.

       ================================================================ -->

  <div class="diagram-section">

    <div class="diagram-label">Klassediagram — Systemet (nuværende)</div>

    <div class="diagram-hint">Hold musen over en klasse for at se pseudo kode</div>

    <svg id="diagram-1" class="uml"></svg>

  </div>

  

  <!-- GRØN ØVELSE -->

  <div class="exercise-block ex-green">

    <div class="ex-header">

      <span class="ex-dot"></span>

      <span class="ex-label">Grøn</span>

      <span class="ex-title">Implementér systemet</span>

    </div>

    <div class="ex-body">

      <p>

        Implementér systemet ud fra klassediagrammet ovenfor.

        Du bestemmer selv om du bruger Console eller WPF.

        Bruger du WPF, kan du bruge <code>Debug.WriteLine</code> til at skrive ud til Output-vinduet.

      </p>

  

      <h3>1 — Product og Order</h3>

      <p>

        Opret <code>Product</code> med properties <code>Name</code> (string) og <code>Price</code> (decimal).

        Opret <code>Order</code> med properties <code>Product</code>, <code>Quantity</code> (int) og <code>TotalPrice</code> (decimal).

      </p>

  

      <h3>2 — PriceCalculator</h3>

      <p>

        Opret <code>PriceCalculator</code> med metoden <code>CalculateTotal(price, quantity)</code>

        der returnerer <code>price * quantity</code>.

      </p>

  

      <h3>3 — ConsoleLogger</h3>

      <p>

        Opret <code>ConsoleLogger</code> med metoden <code>Log(message)</code>

        der printer <code>[LOG] message</code> til konsollen.

      </p>

  

      <h3>4 — OrderService</h3>

      <p>

        Opret <code>OrderService</code> med metoden <code>CreateOrder(productName, price, quantity)</code>.

        Metoden skal selv oprette <code>PriceCalculator</code> og <code>ConsoleLogger</code> med <code>new</code>,

        bygge et <code>Product</code>- og <code>Order</code>-objekt, logge resultatet og returnere ordren.

      </p>

  

      <h3>5 — Program</h3>

      <p>

        Læs produktnavn, pris og antal fra brugeren. Opret en <code>OrderService</code> og kald

        <code>CreateOrder</code>. Vis ordre-resuméet til brugeren.

      </p>

  

      <h3>Acceptkriterier</h3>

      <ol class="accept-list">

        <li><code>CreateOrder("Tastatur", 500, 2)</code> returnerer en ordre med <code>TotalPrice = 1000</code></li>

        <li><code>CreateOrder("Mus", 200, 3)</code> returnerer en ordre med <code>TotalPrice = 600</code></li>

        <li><code>CreateOrder("Gratis vare", 0, 1)</code> returnerer en ordre med <code>TotalPrice = 0</code></li>

        <li><code>CreateOrder("Skærm", 1500, 1)</code> returnerer en ordre hvor <code>Product.Name = "Skærm"</code></li>

      </ol>

    </div>

  </div>

  

  <!-- GUL ØVELSE -->

  <div class="exercise-block ex-yellow">

    <div class="ex-header">

      <span class="ex-dot"></span>

      <span class="ex-label">Gul</span>

      <span class="ex-title">Skriv unit tests</span>

    </div>

    <div class="ex-body">

      <p>

        Skriv unit tests der bekræfter at <code>OrderService.CreateOrder()</code> beregner og returnerer korrekt.

      </p>

  

      <h3>Hvad skal du teste?</h3>

      <ol class="accept-list">

        <li>En ordre med mængde 3 og enhedspris 200 kr. giver <code>TotalPrice = 600</code></li>

        <li>En ordre med enhedspris 0 kr. giver <code>TotalPrice = 0</code></li>

        <li>Produktnavnet på den returnerede ordre er det samme som det der sendes ind</li>

      </ol>

  

      <h3>Refleksion</h3>

      <p>Kig i Output-vinduet mens dine tests kører:</p>

      <ul>

        <li>Hvad printer <code>ConsoleLogger</code>?</li>

        <li>Er det ønskeligt i en unit test?</li>

        <li>Hvad ville du skulle ændre i designet for at undgå det?</li>

      </ul>

    </div>

  </div>

  

</main>

  

<!-- Tooltip (redigér ikke) -->

<div id="tooltip">

  <div id="tooltip-label">Pseudo kode</div>

  <pre id="tooltip-code"></pre>

</div>

  

<script>

/* ================================================================

   DIAGRAMDATA — REDIGER KUN DENNE SEKTION

   ================================================================

  

   Tilføj ét objekt per diagram i DIAGRAMS-arrayet.

   id skal matche <svg id="..."> i HTML'en ovenfor.

  

   KLASSE-OBJEKT:

   ┌─────────────────────────────────────────────────────────────────┐

   │ name:       Klassenavn (string)                                  │

   │ stereotype: null | "«interface»" | "«abstract»" | "«record»"    │

   │             (null = normal klasse)                               │

   │ fields:     Array af felter, fx ["- navn: string"]               │

   │ methods:    Array af metoder, fx ["+ Beregn(): decimal"]         │

   │ col:        Kolonneindeks (0-baseret, venstre → højre)           │

   │ row:        Rækkeindeks   (0-baseret, top → bund)                │

   │ pseudoCode: Tekst der vises i tooltip ved hover.                 │

   │             Brug backticks for flerlinjet tekst.                 │

   │             Sæt til "" eller null for ingen tooltip.             │

   └─────────────────────────────────────────────────────────────────┘

  

   RELATION-OBJEKT:

   ┌─────────────────────────────────────────────────────────────────┐

   │ from: Klassenavn (string)                                        │

   │ to:   Klassenavn (string)                                        │

   │ type: "implements"  — stiplet linje, hul trekant                 │

   │       "inherits"    — solid linje,  hul trekant                  │

   │       "uses"        — stiplet linje, åben pil                    │

   │       "associates"  — solid linje,  åben pil                     │

   │       "has"         — solid linje,  fyldt diamant                │

   └─────────────────────────────────────────────────────────────────┘

*/

  

const DIAGRAMS = [

  {

    id: "diagram-1",

    classes: [

      {

        name: "Product",

        stereotype: null,

        fields: [

          "+<<get,set>> Name : string",

          "+<<get,set>> Price : decimal"

        ],

        methods: [],

        col: 1, row: 0,

        pseudoCode:

`CLASS Product

  PROPERTY Name (string)

  PROPERTY Price (decimal)`

      },

      {

        name: "Order",

        stereotype: null,

        fields: [

          "+<<get,set>> Product : Product",

          "+<<get,set>> Quantity : int",

          "+<<get,set>> TotalPrice : decimal"

        ],

        methods: [],

        col: 2, row: 0,

        pseudoCode:

`CLASS Order

  PROPERTY Product (a Product object)

  PROPERTY Quantity (integer)

  PROPERTY TotalPrice (decimal)`

      },

      {

        name: "Program",

        stereotype: null,

        fields: [],

        methods: [

          "+ Run() : void"

        ],

        col: 0, row: 1,

        pseudoCode:

`START

  orderService = NEW OrderService

  

  PRINT "Produktnavn: "

  READ name FROM user

  

  PRINT "Pris: "

  READ price FROM user

  

  PRINT "Antal: "

  READ quantity FROM user

  

  order = orderService.CreateOrder(name, price, quantity)

  

  PRINT order summary

END`

      },

      {

        name: "OrderService",

        stereotype: null,

        fields: [],

        methods: [

          "+ CreateOrder(productName : string, price : decimal, quantity : int)",

          "    : Order"

        ],

        col: 1, row: 1,

        pseudoCode:

`CLASS OrderService

  

  METHOD CreateOrder(productName, price, quantity)

  

    // Tight coupling — created here

    calculator = NEW PriceCalculator

    logger     = NEW ConsoleLogger

  

    product = NEW Product

      WITH Name = productName, Price = price

    total = calculator.CalculateTotal(price, quantity)

    order = NEW Order

      WITH Product = product,

           Quantity = quantity,

           TotalPrice = total

  

    logger.Log("Ordre oprettet: "

      + quantity + "x " + productName

      + " = " + total + " kr.")

  

    RETURN order

  END METHOD

END CLASS`

      },

      {

        name: "ConsoleLogger",

        stereotype: null,

        fields: [],

        methods: [

          "+ Log(message : string) : void"

        ],

        col: 2, row: 1,

        pseudoCode:

`CLASS ConsoleLogger

  

  METHOD Log(message)

    PRINT "[LOG] " + message

  END METHOD

END CLASS`

      },

      {

        name: "PriceCalculator",

        stereotype: null,

        fields: [],

        methods: [

          "+ CalculateTotal(price : decimal, quantity : int) : decimal"

        ],

        col: 1, row: 2,

        pseudoCode:

`CLASS PriceCalculator

  

  METHOD CalculateTotal(price, quantity)

    RETURN price * quantity

  END METHOD

END CLASS`

      }

    ],

    relationships: [

      { from: "Program",       to: "OrderService",   type: "uses" },

      { from: "OrderService",  to: "Product",         type: "uses" },

      { from: "OrderService",  to: "Order",           type: "uses" },

      { from: "OrderService",  to: "PriceCalculator", type: "uses" },

      { from: "OrderService",  to: "ConsoleLogger",   type: "uses" }

    ]

  }

];

  

/* ================================================================

   UML RENDERER — REDIGER IKKE NEDENFOR DENNE LINJE

   ================================================================ */

  

const CFG = {

  boxW:    240,   // Bredde på klasse-boxes (px)

  colGap:  50,    // Vandret afstand mellem kolonner

  rowGap:  48,    // Lodret afstand mellem rækker

  pad:     22,    // Canvas-margin

  lineH:   19,    // Højde per felt/metode-linje

  secPad:  8,     // Top/bund-padding i felt- og metode-sektion

  hdrMin:  40,    // Minimum header-højde

  stereoH: 16,    // Ekstra højde til stereotype-tekst

  nameH:   20,    // Højde til klassenavn

  textPad: 14,    // Vandret padding til tekst i felter og metoder

};

  

const REL_LABELS = {

  implements:

`Realisering / implementering

Stiplet linje · hul hvid trekant

  

Klassen opfylder interfacets kontrakt.

Pilen peger altid mod interfacet.

Metoderne gentages i subklassen.`,

  

  inherits:

`Nedarvning (arv)

Solid linje · hul hvid trekant

  

Subklassen arver felter og metoder

fra superklassen.

Pilen peger altid mod superklassen.`,

  

  uses:

`Dependency (afhængighed)

Stiplet linje · åben pil

  

Funktionalitet i én klasse afhænger

af den anden klasse.

Pilen peger mod den klasse

vi er afhængige af.`,

  

  has:

`Composition (ejerskab)

Solid linje · fyldt diamant

  

Forældre-barn relation: barnet kan ikke

eksistere uden forælderen.

Forælderen opretter selv barnet (new).

Diamanten peger mod forælderen (ejeren).`,

  

  associates:

`Aggregation

Solid linje · hul diamant

  

Begge klasser kan eksistere uafhængigt.

Klassen modtager objektet udefra (injiceres).

Diamanten peger mod den klasse

der bruger den anden.`,

};

  

const NS = "http://www.w3.org/2000/svg";

  

function el(tag, attrs, children) {

  const e = document.createElementNS(NS, tag);

  for (const [k, v] of Object.entries(attrs)) e.setAttribute(k, v);

  if (children) children.forEach(c => e.appendChild(c));

  return e;

}

function txt(s, attrs) {

  const e = document.createElementNS(NS, "text");

  e.setAttribute("font-family", "inherit");

  for (const [k, v] of Object.entries(attrs)) e.setAttribute(k, v);

  e.textContent = s;

  return e;

}

  

// --- Text wrapping helpers ---

const _mCanvas = document.createElement("canvas");

const _mCtx    = _mCanvas.getContext("2d");

function measureText(str) {

  _mCtx.font = "10.5px Cascadia Code, Consolas, monospace";

  return _mCtx.measureText(str).width;

}

function wrapLines(lines, maxW) {

  const out = [];

  for (const line of lines) {

    if (measureText(line) <= maxW) { out.push(line); continue; }

    const indent = (line.match(/^\s+/) || [""])[0];

    const words  = line.trimStart().split(" ");

    let cur = indent;

    for (const word of words) {

      const test = cur === indent ? indent + word : cur + " " + word;

      if (measureText(test) <= maxW) { cur = test; }

      else { if (cur !== indent) out.push(cur); cur = indent + "  " + word; }

    }

    if (cur !== indent) out.push(cur);

  }

  return out.length ? out : lines;

}

  

function boxHeight(cls) {

  const maxW   = CFG.boxW - CFG.textPad * 2;

  const fields  = wrapLines(cls.fields,  maxW);

  const methods = wrapLines(cls.methods, maxW);

  const hH = Math.max(CFG.hdrMin,

    (cls.stereotype ? CFG.stereoH : 0) + CFG.nameH + CFG.secPad * 2);

  const fH = Math.max(CFG.secPad * 2,

    fields.length  * CFG.lineH + CFG.secPad * 2);

  const mH = Math.max(CFG.secPad * 2,

    methods.length * CFG.lineH + CFG.secPad * 2);

  return hH + fH + mH;

}

  

function layout(classes) {

  const rH = {}, cW = {};

  for (const c of classes) {

    const h = boxHeight(c);

    rH[c.row] = Math.max(rH[c.row] || 0, h);

    cW[c.col] = Math.max(cW[c.col] || 0, CFG.boxW);

  }

  const maxC = Math.max(...classes.map(c => c.col));

  const maxR = Math.max(...classes.map(c => c.row));

  const cx = {}, ry = {};

  let x = CFG.pad;

  for (let c = 0; c <= maxC; c++) { cx[c] = x; x += (cW[c] || CFG.boxW) + CFG.colGap; }

  let y = CFG.pad;

  for (let r = 0; r <= maxR; r++) { ry[r] = y; y += (rH[r] || 80) + CFG.rowGap; }

  const pos = {};

  for (const c of classes) {

    pos[c.name] = { x: cx[c.col], y: ry[c.row], w: CFG.boxW, h: boxHeight(c) };

  }

  return { pos, W: x - CFG.colGap + CFG.pad, H: y - CFG.rowGap + CFG.pad };

}

  

function edge(box, toward) {

  const cx = box.x + box.w / 2, cy = box.y + box.h / 2;

  const tx = toward.x + toward.w / 2, ty = toward.y + toward.h / 2;

  const dx = tx - cx, dy = ty - cy;

  if (Math.abs(dy) / box.h >= Math.abs(dx) / box.w) {

    return dy >= 0

      ? { x: cx, y: box.y + box.h }

      : { x: cx, y: box.y };

  } else {

    return dx >= 0

      ? { x: box.x + box.w, y: cy }

      : { x: box.x,         y: cy };

  }

}

  

function makeMarker(id, type) {

  const m = el("marker", {

    id, markerWidth: "13", markerHeight: "10",

    refX: "12", refY: "5", orient: "auto", markerUnits: "userSpaceOnUse"

  });

  if (type === "inherits" || type === "implements") {

    m.appendChild(el("polygon", {

      points: "1,1 12,5 1,9",

      fill: "white", stroke: "#4a6a90", "stroke-width": "1.5"

    }));

  } else if (type === "has") {

    m.appendChild(el("polygon", {

      points: "0,5 5,1 12,5 5,9",

      fill: "#4a6a90", stroke: "#4a6a90", "stroke-width": "1"

    }));

  } else {

    // uses / associates

    m.appendChild(el("polyline", {

      points: "1,1 11,5 1,9",

      fill: "none", stroke: "#4a6a90", "stroke-width": "1.5"

    }));

  }

  return m;

}

  

function getSide(point, box) {

  if (Math.abs(point.y - box.y)            < 2) return "top";

  if (Math.abs(point.y - (box.y + box.h))  < 2) return "bottom";

  if (Math.abs(point.x - box.x)            < 2) return "left";

  return "right";

}

  

function orthogonalD(f, t, fBox, tBox) {

  const fSide = getSide(f, fBox);

  const tSide = getSide(t, tBox);

  const fVert = fSide === "top" || fSide === "bottom";

  const tVert = tSide === "top" || tSide === "bottom";

  if (fVert && tVert) {

    const midY = (f.y + t.y) / 2;

    return `M${f.x},${f.y} L${f.x},${midY} L${t.x},${midY} L${t.x},${t.y}`;

  }

  if (!fVert && !tVert) {

    const midX = (f.x + t.x) / 2;

    return `M${f.x},${f.y} L${midX},${f.y} L${midX},${t.y} L${t.x},${t.y}`;

  }

  if (fVert && !tVert) {

    return `M${f.x},${f.y} L${f.x},${t.y} L${t.x},${t.y}`;

  }

  return `M${f.x},${f.y} L${t.x},${f.y} L${t.x},${t.y}`;

}

  

function renderRelation(rel, pos, defs) {

  const fb = pos[rel.from], tb = pos[rel.to];

  if (!fb || !tb) return null;

  const f = edge(fb, tb), t = edge(tb, fb);

  const markId = `m-${rel.type}`;

  if (!defs.querySelector(`#${markId}`)) defs.appendChild(makeMarker(markId, rel.type));

  const isDash = rel.type === "implements" || rel.type === "uses";

  const d = orthogonalD(f, t, fb, tb);

  

  const g = el("g", { "class": "rel-group", style: "cursor:help" });

  

  // Synlig pil

  g.appendChild(el("path", {

    d,

    stroke: "#4a6a90", "stroke-width": "1.5",

    fill: "none",

    "marker-end": `url(#${markId})`,

    "pointer-events": "none",

    ...(isDash ? { "stroke-dasharray": "6,4" } : {})

  }));

  

  // Usynlig bred hit-area så pilen er nem at ramme

  g.appendChild(el("path", {

    d,

    stroke: "black", "stroke-width": "16",

    fill: "none",

    opacity: "0", "pointer-events": "stroke"

  }));

  

  // Tooltip-indhold

  const content = `${rel.from}  →  ${rel.to}\n\n${REL_LABELS[rel.type] || rel.type}`;

  g.addEventListener("mouseenter", e => {

    tooltipLabel.textContent = "Notation";

    tooltipCode.textContent  = content;

    tooltip.style.display    = "block";

    placeTooltip(e);

  });

  g.addEventListener("mousemove",  placeTooltip);

  g.addEventListener("mouseleave", () => { tooltip.style.display = "none"; });

  

  return g;

}

  

function renderClass(cls, box, defs) {

  const { x, y, w } = box;

  const h = boxHeight(cls);

  

  const isIface = cls.stereotype === "«interface»";

  const isAbstr = cls.stereotype === "«abstract»";

  const hdrFill = isIface ? "#1b6b55" : isAbstr ? "#5a3a7a" : "#1e3a5f";

  const border  = isIface ? "#1b6b55" : isAbstr ? "#5a3a7a" : "#2a5080";

  const strokeD = (isIface || isAbstr) ? "6,3" : null;

  

  // Clip path for text overflow

  const clipId = `cp-${cls.name.replace(/\W/g, "")}`;

  defs.appendChild(el("clipPath", { id: clipId }, [

    el("rect", { x: x + 2, y, width: w - 4, height: h })

  ]));

  

  const hH = Math.max(CFG.hdrMin,

    (cls.stereotype ? CFG.stereoH : 0) + CFG.nameH + CFG.secPad * 2);

  const fH = Math.max(CFG.secPad * 2,

    cls.fields.length  * CFG.lineH + CFG.secPad * 2);

  

  const g = el("g", {

    "class": "cls-group",

    ...(cls.pseudoCode ? { "data-pseudo": cls.pseudoCode } : {})

  });

  

  // Outer border

  g.appendChild(el("rect", {

    "class": "cls-border",

    x, y, width: w, height: h,

    fill: "white", stroke: border, "stroke-width": "1.5", rx: "4",

    ...(strokeD ? { "stroke-dasharray": strokeD } : {})

  }));

  

  // Header background (rounded top corners only)

  g.appendChild(el("rect", {

    "class": "cls-header",

    x, y, width: w, height: hH, fill: hdrFill, rx: "4"

  }));

  // Cover bottom curve of header (so divider line shows clean)

  g.appendChild(el("rect", {

    x, y: y + hH - 4, width: w, height: 4, fill: hdrFill

  }));

  

  // Stereotype text

  let yOff = y + CFG.secPad;

  if (cls.stereotype) {

    g.appendChild(txt(cls.stereotype, {

      x: x + w / 2, y: yOff + 12, "text-anchor": "middle",

      fill: "rgba(255,255,255,0.7)", "font-size": "10.5",

      "font-style": "italic", "clip-path": `url(#${clipId})`

    }));

    yOff += CFG.stereoH;

  }

  

  // Class name

  g.appendChild(txt(cls.name, {

    x: x + w / 2, y: yOff + 15, "text-anchor": "middle",

    fill: "white", "font-size": "13", "font-weight": "bold",

    ...(isAbstr ? { "font-style": "italic" } : {}),

    "clip-path": `url(#${clipId})`

  }));

  

  // Divider after header

  g.appendChild(el("line", {

    x1: x, y1: y + hH, x2: x + w, y2: y + hH,

    stroke: border, "stroke-width": "1"

  }));

  

  // Fields (auto-wrapped)

  const maxW       = w - CFG.textPad * 2;

  const fieldLines = wrapLines(cls.fields,  maxW);

  const fH_actual  = Math.max(CFG.secPad * 2, fieldLines.length * CFG.lineH + CFG.secPad * 2);

  let fY = y + hH + CFG.secPad;

  for (const f of fieldLines) {

    g.appendChild(txt(f, {

      x: x + CFG.textPad, y: fY + 13, fill: "#2a2a2a", "font-size": "10.5",

      "font-family": "Cascadia Code,Consolas,monospace"

    }));

    fY += CFG.lineH;

  }

  

  // Divider after fields

  g.appendChild(el("line", {

    x1: x, y1: y + hH + fH_actual, x2: x + w, y2: y + hH + fH_actual,

    stroke: border, "stroke-width": "1", "stroke-opacity": "0.4"

  }));

  

  // Methods (auto-wrapped)

  const methodLines = wrapLines(cls.methods, maxW);

  let mY = y + hH + fH_actual + CFG.secPad;

  for (const m of methodLines) {

    g.appendChild(txt(m, {

      x: x + CFG.textPad, y: mY + 13, fill: "#2a2a2a", "font-size": "10.5",

      "font-family": "Cascadia Code,Consolas,monospace"

    }));

    mY += CFG.lineH;

  }

  

  return g;

}

  

function renderDiagram(cfg) {

  const svg = document.getElementById(cfg.id);

  if (!svg) return;

  svg.innerHTML = "";

  const { pos, W, H } = layout(cfg.classes);

  svg.setAttribute("viewBox", `0 0 ${W} ${H}`);

  svg.setAttribute("width", W);

  svg.setAttribute("height", H);

  svg.style.maxWidth = "100%";

  svg.style.height = "auto";

  

  const defs = el("defs", {});

  svg.appendChild(defs);

  

  // Relations first (rendered behind boxes)

  for (const rel of cfg.relationships) { const rg = renderRelation(rel, pos, defs); if (rg) svg.appendChild(rg); }

  

  // Class boxes

  for (const cls of cfg.classes) {

    const g = renderClass(cls, pos[cls.name], defs);

    svg.appendChild(g);

    // Tooltip event handlers

    if (cls.pseudoCode) {

      g.addEventListener("mouseenter", e => {

        tooltipLabel.textContent = "Pseudo kode";

        tooltipCode.textContent  = cls.pseudoCode;

        tooltip.style.display    = "block";

        placeTooltip(e);

      });

      g.addEventListener("mousemove", placeTooltip);

      g.addEventListener("mouseleave", () => { tooltip.style.display = "none"; });

    }

  }

}

  

// === Tooltip ===

const tooltip     = document.getElementById("tooltip");

const tooltipLabel = document.getElementById("tooltip-label");

const tooltipCode  = document.getElementById("tooltip-code");

  

function placeTooltip(e) {

  const W  = tooltip.offsetWidth  || 300;

  const H  = tooltip.offsetHeight || 100;

  const vw = window.innerWidth, vh = window.innerHeight;

  let lx = e.clientX + 18, ly = e.clientY + 14;

  if (lx + W > vw - 8) lx = e.clientX - W - 10;

  if (ly + H > vh - 8) ly = e.clientY - H - 10;

  tooltip.style.left = `${lx}px`;

  tooltip.style.top  = `${ly}px`;

}

  

// === Render alle diagrammer ved sideload ===

for (const d of DIAGRAMS) renderDiagram(d);

</script>

</body>

</html>