## Pseudo-Elemente ##

Pseudo-Elemente sind ein mächtiges Werkzeug um die Gestaltung einer Website zu verbessern.

Ein Pseudo-Element ist quasi ein HTML Tag welches vom Browser selbst eingefügt wurde. Nehmen wir als
Beispiel ein Input Tag:

```html
<input type="text" name="name" placeholder="Nachname">
```

Der Placeholder wird im Element dargestellt, solange es leer ist. Dies wird vom Browser selbst eingefügt
und ausgeblendet, sobald im Element Text vorhanden ist.

Doch was passiert, wenn wir dieses Element stylen möchten?

### Pseudo-Selektoren ###

Hier kommen die Pseudo-Selektoren ins Spiel. Mit ihnen kann man via CSS auf ein Pseudo-Element zugreifen.

Pseudo-Selektoren beginnen immer mit `::`. So kann mit folgendem CSS der Placeholder Text gestaltet werden:

```css
input::placeholder {
    color: gray;
}
```

### `::before` und `::after` ##

Die zwei mächtigstens Pseudo-Elemente sind das `before` und `after`. Diese sind bei jedem Tag vorhanden
und erlauben es uns, vor oder nach dem Element noch etwas einzufügen.

```html
<button class="btn">Mehr erfahren</button>
```

Wenn wir bei diesem Button nach dem Text noch ein Pfeil (`→`) einfügen wollen, so können wir dies wie folgt umsetzen:

```css
button.btn::after {
    content: '→'
    /* Weitere Styles */
}
```

Das `content` Property legt fest, welchen Inhalt das Pseudo-Element hat. Es ist jedoch auch gut möglich,
dies als Bild umzusetzen:

```scss
button.btn {
  postition: relative;
  padding-right: 30px;
  
  &::after {
    position: absolute;
    display: block;
    right: 5px;
    top: 5px;
    width: 20px;
    height: 20px;
    background-image: url('assets/arrow-right.svg');
  }
}
```

Im obigen Beispiel wird das Pseudo Element fix auf 20x20px gesetzt und in die obere rechte Ecke platziert.
Über `background-image` wird dann das Bild als Hintergrundbild hineingeladen.

> Doch Moment mal... Wenn wir den HTML Code selbst schreiben, können wir dieses Element ja auch direkt im HTML einfügen?
> 
> Stimmt! Doch wir haben nicht in allen Fällen die Kontrolle über das HTML. Wird dieses von einem CMS generiert,
> haben wir nur bestimmten Einfluss auf die Gestaltung.
> 
> In folgendem Beispiel wird jedem Link welcher auf eine .pdf Datei verlinkt noch ein entsprechendes Icon davor gehängt:

```scss
a[href*=.pdf] {
    postition: relative;
    padding-right: 30px;

    &::after {
      position: absolute;
      display: block;
      right: 5px;
      top: 5px;
      width: 20px;
      height: 20px;
      background-image: url('assets/icons/pdf.svg');
    }
}
```

### Liste aller Pseudo-Selektoren ###

[Unter diesem Link](https://developer.mozilla.org/en-US/docs/Web/CSS/Pseudo-elements?retiredLocale=de#alphabetical_index)
findet sich die Liste aller Pseude-Selektoren und -Elemente. Viele davon sind jedoch noch experimentell und sollten nur
vorsichtig verwendet werden.