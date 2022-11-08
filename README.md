#LA1200 

Gruppenprojekt von Angelov, Atputharasa,Marku,Tanner,von Rogall

# Projekt-Dokumentation


Elefant:Angelov, Atputharasa,Marku,Tanner,von Rogall

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   25.10.22    | 0.0.1   | IPE-Erstellen der Projektdokumentation, Informieren, Planen und Entscheiden 
|   01.11.22    |0.0.2 |  Implementieren der zugeteilten Arbeitspackete                                                          |
|  08.11.22     | 0.0.3   |            Implementieren der übrigen Arbeitspackete                                                     |

## 1 Informieren

### 1.1 Ihr Projekt

In unserem Projekt erstellen wir mit C# eine Anmeldung zu verschiedenen Workshops. Man soll seine drei Favoriten angeben können und dann soll der Benutzer basierend seiner Eingabe einem Workshop zugeteilt werden. Die Liste der Workshops und Ihren zugeteilten Teilnehmern wird am Schluss ausgegeben. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   Muss              | Funktional     | Als ein Kunde möchte ich, dass der Benutzer seinen Namen eingeben kann, damit das Programm weiss wem es die favourisierten Kurse zuteilt.|
| 2  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass der Benutzer zwischen einer Auswahl an Kursen 3 Favouriten auswählen kann. |
| 3  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm den Namen des Benutzers, gefolgt von dessen drei Favouriten, in eine Textdatei abspeichert, damit man eine übersichtliche Auflistung aller Teilnehmer hat.                                  |
| 4  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm die Benutzer automatisch den Kursen zuteilt, bestmöglich bekommt jeder Teilnehmer den Kurs seiner höchsten Priortät, damit jeder Benutzer zufriedengestellt wird.                                  |
| 5  |   Muss              |  Funktional     |  Als ein Kunde möchte ich, dass das Programm die Workshops so einteilt, dass jeder Workshop mindestens 4 und maximal 20 Teilnehmer besitzt, damit die Workshops stattfinden können.|                                  


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Apk gestartet, wartet auf Benutzereingabe            | angel.angelov@bbbaden.ch (mail)        | Geben sie bitte ihre Erste Priorität                  |
| 2.1  |   Apk gestartet, wartet auf Benutzereingabe            |  Basketball       |  Geben sie bitte ihre zweite Priorität                 |
| 3.1  |   Apk gestartet, wartet auf Benutzereingabe            | Volleyball        | Geben sie bitte ihre zweite Priorität                  |
| 4.1  |   Apk gestartet, wartet auf Benutzereingabe            | Fussball        | angel.angelov@bbbaden.ch;Fussball;Volleyball;Basketball Möchten sie noch ein Person eingeben [y|n]|
| 5.1  |   Apk gestartet, wartet auf Benutzereingabe            |  nein       |  Programm wird beendet                 |



### 1.4 Diagramme

<img width="129" alt="image" src="https://user-images.githubusercontent.com/110892351/199209496-f9373377-7b44-4204-80ce-f9f17155f529.png">




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 01.11.22     |   Angelov        |    Die Eingabe des Namen des Benutzers wird gespeichert. |    40min    |
| 1.B  | 08.11.22      |    Angelov       |     Das Programm ist absturzsicher.       |   20min      |
| 2.A  | 01.11.22      |   Marku        | Die Eingaben der Favoriten des Benutzers werden gespeichert.  |   60min   |
| 2.B  | 08.11.22      | Marku     | Das Programm ist absturzsicher.         |     15min          |
| 2.C  | 08.11.22      |  Marku     | Wenn eine Eingabe keinem Kurs entspricht, muss die Eingabe wiederholt werden.          |     40min   |
| 3.A  | 01.11.22      |  Atputharasa     | Alle Eingaben des Benutzers werden in eine Datei abgespeichert.  |  90min  |
| 3.B  | 01.11.22      |  Atputharasa     | Der Benutzer kann den Speicherort und den Namen der Datei frei wählen.             |     25min          |
| 3.C  | 08.11.22      |  Atputharasa     | Nicht existierende Speicherorte geben einen Fehler aus und der Benutzer muss die Eingabe erneut tätigen.   | 30min  |
| 3.D  | 08.11.22      |  Atputharasa     | Das Programm ist absturzsicher.            |     15min          |
| 4.A  | 01.11.22      |  Tanner, von Rogall     | Das Programm schaut, welche Kurse die Mindestanforderung (4 Teilnehmer) erfüllen.         |     60min          |
| 4.B  | 01.11.22      |  Tanner, von Rogall     | Das Programm wählt mit Hilfe einer Nutzwertanalyse die Kurse aus (Anzahl Teinehmer / 4), die am meisten gewählt wurden.          |     90min          |
| 4.C  | 01.11.22      |  Tanner, von Rogall     | Die Teilnehmer werden den vom Programm ausgewählten Kursen zugeteilt.          |     120min          |
| 4.D  | 01.11.22      |  Tanner, von Rogall     | Im besten Fall bekommt jeder Teilnehmer den Kurs der höchsten Priorität.           |     120min          |
| 4.E  | 08.11.22      |  Tanner, von Rogall     | Jeder Kurs kann mindestens 4 & maximal 20 Teilnehmer haben.          |     60min          |
| 4.F  | 08.11.22      |  Tanner, von Rogall     | Das Programm ist absturzsicher.             |     30min          |


Total: 725min


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
