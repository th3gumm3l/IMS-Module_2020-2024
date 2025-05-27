# M152 - Starter Projekt

## Vorbereitung

Erstellen Sie einen Ordner und öffnen Sie diesen im VSCode.

Danach führen Sie alle hier aufgeführten Befehle Zeile für Zeile im Terminal aus.

## Projekt klonen und installieren

```ssh
git clone https://github.com/Andi-Moser/M152-Starter.git .
rm -rf .git # Oder .git Ordner via File Explorer löschen
npm install
```

## Git Repository initialisieren

```ssh
git init
git remote add origin <<URL>>
git add .
git commit -m "First commit"
git push
```

## Projekt starten

```ssh
npm run dev
```

# Empfohlene VS Code Plugins

## Vetur

https://marketplace.visualstudio.com/items?itemName=octref.vetur

# Dokumentationslinks

## Vue Tutorial

https://vuejs.org/tutorial/#step-1

| Achtung: Bei der `API Preference` müssen die Optionen `Composition` und `SFC` ausgewählt werden!