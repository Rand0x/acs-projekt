# IT-Projekt SoSe2023 - WS2023/24
Titel: Entwicklung eines E Mail Plugins, um sensible Personendaten zu ermitteln und nach einer Frist zu löschen

Anforderungen an die Software:
- Das Plugin soll für die neuste Microsoft-Outlook Version entwickelt werden
- Gelöschte Mails kommen in einen extra Ordner, um dann gelöschte Mails überprüfen zu können: Anschließend nach 3 Tagen endgültig löschen
- Erkennung von persönlichen Daten wie z.B.: Kreditkartennummer, Namen, Vornamen, Geburtsort, Geburtstag etc.
- Es soll eine Konfigurationsmöglichkeit geben, um einzustellen nach welchen Daten gesucht werden soll (z.B. nur nach Kreditkartennummern filtern)
- Das Plugin soll eine Meldung ausgeben, wenn sensible Daten gefunden wurden
- Das Alter der Mail soll erkannt werden (Wie lange liegt diese schon im Postfach?)
- Eine Meldung vom Plugin soll kommen, wenn Outlook gestartet wird (Wie viele Mails werden in x Tagen gelöscht)

# Git-Bash-Cheatsheet

Dies ist ein einfaches Cheatsheet für die Verwendung von Git-Bash. 

## Grundlegende Befehle

- `git init`: Initialisiert ein neues Git-Repository.
- `git status`: Zeigt den Status des aktuellen Repositories an.
- `git add <file>`: Fügt eine Datei zur Staging-Zone hinzu.
- `git commit -m "<message>"`: Committet die Dateien, die zur Staging-Zone hinzugefügt wurden, mit einer Nachricht.
- `git log`: Zeigt die Commit-Historie.

## Branching und Merging

- `git branch`: Listet alle Branches im aktuellen Repository auf.
- `git branch <branch>`: Erstellt einen neuen Branch.
- `git checkout <branch>`: Wechselt zu einem bestimmten Branch.
- `git merge <branch>`: Fügt die Änderungen eines bestimmten Branches in den aktuellen Branch ein.

## Remote Repositories

- `git remote add <name> <url>`: Fügt ein Remote-Repository hinzu.
- `git push -u <name> <branch>`: Schickt die Commits zum Remote-Repository.
- `git clone <url>`: Klont ein Remote-Repository.
- `git pull <name> <branch>`: Holt die Änderungen vom Remote-Repository und führt ein Merge durch.

## Fortgeschrittene Befehle

- `git revert <commit>`: Kehrt die Änderungen eines bestimmten Commits um.
- `git reset --hard`: Setzt das Repository auf den letzten Commit zurück und verwirft alle uncommitteten Änderungen.
- `git stash`: Legt alle uncommitteten Änderungen beiseite und lässt das Repository sauber zurück.
- `git stash apply`: Wendet die zuletzt abgelegten Änderungen an.
