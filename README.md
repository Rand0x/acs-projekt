# IT-Projekt SoSe2023 - WS2023/24
Titel: Entwicklung eines E Mail Plugins, um sensible Personendaten zu ermitteln und nach einer Frist zu löschen

Anforderungen an die Software:
•	Das Plugin soll für die neuste Microsoft-Outlook Version entwickelt werden
•	Gelöschte Mails kommen in einen extra Ordner, um dann gelöschte Mails überprüfen zu können: Anschließend nach 3 Tagen endgültig löschen
•	Erkennung von persönlichen Daten wie z.B.: Kreditkartennummer, Namen, Vornamen, Geburtsort, Geburtstag etc.
•	Es soll eine Konfigurationsmöglichkeit geben, um einzustellen nach welchen Daten gesucht werden soll (z.B. nur nach Kreditkartennummern filtern)
•	Das Plugin soll eine Meldung ausgeben, wenn sensible Daten gefunden wurden
•	Das Alter der Mail soll erkannt werden (Wie lange liegt diese schon im Postfach?)
•	Eine Meldung vom Plugin soll kommen, wenn Outlook gestartet wird (Wie viele Mails werden in x Tagen gelöscht)
