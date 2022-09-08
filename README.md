# Projekt-Dokumentation

Amraya

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 01.09 | 0.0.1   | Ich habe den Randomiser programmiert.                        |
| 08.09 | 0.0.2   | Ich habe das System programmiert(erneut spielen können, falsch und richtig zeigen)|
| 15.09 | 0.0.3   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein MatheQuiz, mit neuen zufälligen Zahlen jedes Mal.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | Muss      |Funktional| Als ein Spieler, möchte ich ein Zahl eingebe, damit ich gewinnen kann.|
|2  | Muss      |Funktional|Als ein Spieler, möchte ich ein Restart Button zu haben, damit ich erneut spielen kann. |
|3  |Muss     |Qualität| Als ein Spieler, möchte ich die richtige Lösung sehen, damit ich von meinen Fehlern lernen kann.| 
|   |            |           |      |                                    |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Visual studio | gibt eine Zahl ein.| zeigt entweder richtig oder falsch. |
| 1.2  |  Visual studio  | versucht die richtige lösung einzugeben.| zeigt dass die eingegebene Zahl ist richtig. |
| 1.3  |  Visual studio  | versucht eine falsche lösung einzugeben.|zeigt dass die eingegenbene Zahl ist falsch. |
| 1.4  | Visual Studio | versucht eine falsche lösung , dann y drücken | das Quiz fängt vom Strat nocheinmal an.|
| 1.5 | Visual Studio | versucht eine richtige lösung, dann n drücken | zeit dass er nicht schlau ist und kann nicht mehr tippen.|
| 1.6 | Visual Studio | versucht eine richtige oder falsche lösung einzugeben, dann irgend einen Buchstabe eingeben(ausserdem n,y)| zeigt was eingegeben wird und macht nichts, bis y oder n eingegeben sind |

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 29.09 |Mohamad| programmieren den Randomiser. | 45 minuten  |
| 1.B | 29.09 | Mohamad | Programmieren und erstellen das Layout.    | 45 minuten  |
| 1.C | 29.09 |Mohamad  | Programmieren den Rechner, damit es richtig rechnen kann.| 45 minuten  |
| 1.D | 29.09 | Mohamad | programmieren , was es gezeigt wird, wenn es falsch oder richtig ist. | 30 minuten |      
| 1.E|  29.09 | Mohamad |Programmieren die Möglichkeit erneut spielen zu können. | 45 minuten |


## 3 Entscheiden

Wir haben uns entschieden, das Quiz mit C# zu programmieren. Wir machen den "Randomiser" und den Rand als erste Schritte.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 08.09  |Mohamad  | 150 minuten   |  150 minuten       |
| ...  |       |           |               |                   |


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
