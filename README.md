#LA1200 

Gruppenprojekt von Angelov, Atputharasa,Marku,Tanner,von Rogall

# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.


Elefant:Angelov, Atputharasa,Marku,Tanner,von Rogall

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   25.10.22    | 0.0.1   | IPE-Erstellen der Projektdokumentation, Informieren, Planen und Entscheiden |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   Muss              | Funktional     | Als ein Kunde möchte ich, dass der Benutzer seinen Namen eingeben kann, damit das Programm weiss wem es die favourisierten Kurse zuteilt.|
| 2  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass der Benutzer zwischen einer Auswahl an Kursen 3 Favouriten auswählen kann. |
| 3  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm den Namen des Benutzers, gefolgt von dessen drei Favouriten, in eine Textdatei abspeichert, damit man eine übersichtliche Auflistung aller Teilnehmer hat.                                  |
| 4  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm die Benutzer automatisch den Kursen zuteilt, bestmöglich bekommt jeder Teilnehmer den Kurs seiner höchsten Priortät, damit jeder Benutzer zufriedengestellt wird.                                  |
| 5  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm die Workshops so einteilt, dass jeder Workshop mindestens 4 und maximal 20 Teilnehmer besitzt, damit die Workshops stattfinden können.|                                  

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Apk gestartet, wartet auf Benutzereingabe            | angel.angelov@bbbaden.ch (mail)        | Geben sie bitte ihre Erste Priorität                  |
| 2.1  |   Apk gestartet, wartet auf Benutzereingabe            |  Basketball       |  Geben sie bitte ihre zweite Priorität                 |
| 3.1  |   Apk gestartet, wartet auf Benutzereingabe            | Volleyball        | Geben sie bitte ihre zweite Priorität                  |
| 4.1  |   Apk gestartet, wartet auf Benutzereingabe            | Fussball        | angel.angelov@bbbaden.ch;Fussball;Volleyball;Basketball Möchten sie noch ein Person eingeben [y|n]|
| 5.1  |   Apk gestartet, wartet auf Benutzereingabe            |  nein       |  Programm wird beendet                 |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 01.11.22     |   Angelov        |    Die Eingabe des Namen des Benutzers wird gespeichert. |    40min    |
| 1.B  | 01.11.22      |    Angelov       |     Das Programm ist absturzsicher.       |   20min      |
| 2.A  | 01.11.22      |   Marku        | Die Eingaben der Favouriten des Benutzers werden gespeichert.  |   60min   |
| 2.B  | 01.11.22      | Marku     | Das Programm ist absturzsicher.         |     15min          |
| 2.C  | 01.11.22      |  Marku     | Wenn eine Eingabe keinem Kurs entspricht, muss die Eingabe wiederholt werden.          |     40min   |
| 3.A  | 01.11.22      |  Atputharasa     | Alle Eingaben des Benutzers werden in eine Datei abgespeichert.  |  90min  |
| 3.B  | 01.11.22      |  Atputharasa     | Der Benutzer kann den Speicherort und den Namen der Datei frei wählen.             |     25min          |
| 3.C  | 01.11.22      |  Atputharasa     | Nicht existierende Speicherorte geben einen Fehler aus und der Benutzer muss die Eingabe erneut tätigen.   | 30min  |
| 3.D  | 01.11.22      |  Atputharasa     | Das Programm ist absturzsicher.            |     15min          |
| 4.A  | 08.11.22      |  Tanner, von Rogall     | Das Programm teilt die Teilnehmer automatisch den Kursen zu.          |     120min          |
| 4.B  | 08.11.22      |  Tanner, von Rogall     | Im besten Fall bekommt jeder Teilnehmer den Kurs der höchsten Prirität.           |     120min          |
| 4.C  | 08.11.22      |  Tanner, von Rogall     | Jeder Kurs kann mindestens 4 & maximal 20 Teilnehmer haben.          |     120min          |
| 4.D  | 08.11.22      |  Tanner, von Rogall     | Das Programm ist absturzsicher.             |     30min          |


Total: 725min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
