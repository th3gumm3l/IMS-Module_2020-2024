## SCSS ##

### Was ist SCSS? ###

SCSS ist eine Erweiterung für CSS die es für den Entwickler einfacher macht, komplexen CSS
Code zu schreiben. SCSS unterstützt z.B. Variablen oder die Verschachtelung von CSS Definitionen.

Beim Einsatz von SCSS sind folgende Punkte zu beachten:

- Der Browser selbst versteht kein SCSS. SCSS wird zuerst zu CSS kompiliert.
- SCSS ist eine Erweiterung zu CSS. Jeder valide CSS Code ist auch in SCSS valide.

### SCSS vs SASS ###

Häufig verwenden diese beiden Begriffe austauschbar verwendet. Ursprünglich hiess diese Technik nur
`SASS` und verzichtete auf die geschweiften Klammern. Um die Lesbarkeit zu erhöhen wurde bald `SCSS` als Dialekt
von `SASS` eingeführt (`Sassy CSS`).

Unterdessen ist die SCSS Syntax der Standard für SASS weshalb man oft zu SASS auch SCSS sagt.

### Funktionsweise ###

HTML besitzt seit jeher die verschachtelte Schreibweise. Dies gibt auch Sinn, denn HTML basiert auf XML und wir müssen
Elemente verschachteln um eine Struktur zu erhalten.

CSS wurde jedoch nie mit diesem Ansatz entwickelt. CSS bestand schon immer nur aus einer Regel, bestehend aus einem
Selektor und mehreren Properties:

```css
/* CSS Regel */
.button { /* Selektor */
    /* Attribute */
    color: blue;
}
```

Die am meisten verwendete Eigenschaft von SCSS ist die Verschachtelung von CSS Regeln, analog zum HTML.
So kann das CSS mehr oder weniger analog zum HTML verschachtelt werden was uns als Entwickler einiges mehr an Übersicht
und weniger duplikatem Code bietet.

```html
<nav>
    <a href="#">Link</a>
    <a href="#">Link</a>
    <a href="#">Link</a>
</nav>
```

```scss
nav {
  display: flex;
  
  a {
    padding: 10px;
    background-color: blue;
  }
}
```

Dieses obenstehende SCSS Snippet wird kompiliert und ergibt schliesslich folgendes CSS:

```css
nav {
    display: flex;
}
nav a {
    padding: 10px;
    background-color: blue;
}
```

#### & Selektor ####

Ein weiterer, sehr zeitsparender Kniff ist der `&` Selektor.

In einem verschachtelten Kontext bezieht sich das Zeichen `&` immer auf den nächst höheren Selektor, wie wir beim nächsten Beispiel sehen:

```scss
/* SCSS */
a {
  color: blue;
  &:hover {
    color: red;
  }
}

.button {
  background-color: teal;
  &--primary {
    background-color: coral;
  }
}
```
```css
/* CSS */
a {
    color: blue;
}
a:hover {
    color: red;
}

.button {
    background-color: teal;
}
.button--primary {
    background-color: coral;
}
```


### Installation ###

Bei einem Vue/Vite Projekt ist die Installation von SCSS sehr simpel:

```shell
npm install -D sass
```

Danach muss nur noch bei den Style Tags die Sprache umgestellt werden:

**CSS**
```vue
<style scoped>
```

**SCSS**
```vue
<style scoped lang="scss">
```