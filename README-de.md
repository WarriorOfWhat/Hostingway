# [English](README.md) | [Français](README-fr.md) | [Deutsch] | [Español](README-es.md)
---

# Hostingway

Hostingway ist ein Dienstprogramm für Betreiber von Veranstaltungsorten, das dabei hilft, Gäste in deinem Lokal im Blick zu behalten. Es bietet eine Schaltfläche zum Senden einer anpassbaren Privatnachricht zur Begrüßung, ermöglicht das Hinzufügen von Notizen zu jedem Besucher für ein persönlicheres Erlebnis bei zukünftigen Besuchen, sowie eine Schaltfläche, um sie einem Glücksrad für Verlosungen und andere Events hinzuzufügen. Diese Informationen können über das Personal synchronisiert werden, indem ein gemeinsamer Linkshell verwendet wird.

Repository: https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Synchronisierung

Die Synchronisierung funktioniert, indem das Plug-in eine <strike>versteckte</strike> Nachricht in den festgelegten Linkshell sendet, die von jedem, der das Plug-in in diesem Linkshell verwendet, empfangen wird. Dies hilft, doppelte Begrüßungen von Gästen zu vermeiden, und wenn Personal eine Notiz hinzufügen muss, kann es dies selbst tun, und du erhältst die Notiz ebenfalls.<br>
**BITTE BEACHTEN:** Notizen werden von der Person überschrieben, die zuletzt eine Notiz einträgt und speichert.<br>
(HINWEIS 08.05.26): Die Nachricht ist derzeit möglicherweise nicht versteckt. Ich arbeite daran.

## Anleitung

## Greetingway

<img width="765" height="272" alt="image" src="https://github.com/user-attachments/assets/7bd150b7-3f97-4cd4-994b-89ea46b1f6cc" />

**Angekommen:** Zu welcher Uhrzeit ein Gast angekommen ist.<br>

**Status:** Ob sie noch anwesend sind, oder zu welcher Uhrzeit sie gegangen sind.<br>

**Gastinfo:**<br>
Name @ Welt - Name des Gastes und seine Heimatwelt<br>
<ins>Farben</ins><br>
$\color{yellow}{\text{Gold}}$: Neu, noch nicht begrüßt<br>
Weiß: Begrüßt<br>
$\color{purple}{\text{Lila}}$: VIP<br>
$\color{grey}{\text{Grau}}$: Nicht mehr im Lokal<br>
„[*]" - Erscheint nur, wenn eine Notiz existiert. Kann mit dem Mauszeiger überfahren werden, um Notizen von dir oder dem Personal anzuzeigen.

**Begrüßen/VIP begrüßen:** Sendet eine angepasste Privatnachricht (Tab Einstellungen), um deinen Gast mit wichtigen Informationen zu begrüßen, wie deiner Website, Discord oder den Regeln. Sobald geklickt, merkt sich das Plug-in, wer begrüßt wurde, selbst wenn die Person geht und zurückkommt.<br>

**Überspringen:** Überspringt eine Begrüßung / markiert sie als begrüßt, ohne eine Nachricht zu senden.<br>

**Notiz:** Notizen, die dir helfen, dich an einen Gast zu erinnern, für ein persönlicheres Erlebnis. Begrenzung auf 100 Zeichen.<br>

**VIP/VIP entfernen:** Zur VIP-Datenbank hinzufügen/daraus entfernen.<br>

**Sitzungsbegrüßungen zurücksetzen:** Wir empfehlen, dies vor der Nutzung von **Offline-Verlauf löschen** zu verwenden, wenn du jeden Abend jeden gleich begrüßen möchtest, auch Stammgäste. Falls nicht, kann dies ignoriert werden.<br>

**Offline-Verlauf löschen:** Wenn Gäste das Lokal verlassen haben und du eine übersichtlichere Liste möchtest, kannst du damit alle entfernen, die das Lokal verlassen haben. Alle Notizen bleiben dabei erhalten.<br>

## Spinningway

<img width="766" height="714" alt="image" src="https://github.com/user-attachments/assets/f73a52d4-8b93-48aa-9724-7c8eb46980ea" />

Spinningway ist ein Glücksrad, das dem Personal bei Verlosungen und anderen Wettbewerben hilft. Es ist ziemlich unkompliziert. Obwohl es für das Ziehen von Namen gedacht ist, kann es auch für andere Spiele verwendet werden.<br>

**Massenerfassung:** Ermöglicht das Kopieren und Einfügen von Namen aus einer externen Liste für das Rad.<br>

**Ziel hinzufügen:** Ermöglicht es dir, jemanden anzuklicken und ihn dem Rad hinzuzufügen.<br>

**In der Nähe hinzufügen:** Fügt jeden innerhalb von 20 Yalms dem Rad hinzu. Dies sollte dein gesamtes Lokal abdecken.<br>

**Manuell:** Du kannst auch einen Namen manuell eingeben, um ihn hinzuzufügen.<br>

Du kannst **das X anklicken**, um einen Namen zu entfernen.<br>

**Rad leeren** entfernt alle Namen.<br>

## Raffleway

<img width="771" height="721" alt="image" src="https://github.com/user-attachments/assets/c4d28657-5d93-4913-ae07-8a6e8a81dca3" />

Raffleway ist ein Versuch, Betreiber von Veranstaltungsorten von Tabellenkalkulationen bei ihren Verlosungen wegzubringen. Es kündigt Gewinner außerdem im Spiel an und nutzt weiterhin /random zur Transparenz.<br>

**Verlosungs-Chatkanal:** Wo die Würfe, der Gewinner usw. angekündigt werden.<br>

**Ticketpreis:** Trage hier deinen Preis pro Verlosungsticket für die korrekte Berechnung deines Gewinnpools ein.<br>

**Startpool:** Falls du einen Startpool haben möchtest.<br>

**Ticketkauf:** Gib den Namen des Spielers und die Anzahl der gekauften Tickets ein. Klicke auf Eintrag hinzufügen, wenn fertig. Wenn der Spieler zurückkommt, um mehr Tickets zu kaufen, oder du einen Fehler machst, kannst du einfach die restlichen Einträge erneut hinzufügen, und es wird eine neue Zeile erstellt.<br>

**% Anteil:** Wenn deine Verlosung 50/50, 70/30, 90/10 usw. ist, gib den Prozentsatz ein, den du von den Einträgen behalten möchtest, und der gesamte Gewinnpool wird neu berechnet. Setze 0, wenn du keinen Anteil möchtest.<br>

**Standardverlosung (< 999 Einträge):** Klicke auf „Gewinner auslosen", und dein Ambiente-Text (in den Einstellungen) wird ankündigen, dass du dich auf das Auslosen vorbereitest und für wie viele Tickets. (z. B. /random 350)<br>

**Mehrblock-Verlosung (> 999 Einträge):** Wenn du 999 Einträge überschreitest (Glückwunsch!), ist die fairste Methode zum Auslosen das Blockauslosen. Du klickst zuerst auf „Block auslosen", dann machst du /random #. Danach klickst du auf Gewinner auslosen und machst ein weiteres /random # basierend auf den verbleibenden Einträgen. Zum Beispiel: Deine Verlosung hat 1100 Tickets. Du losst den Block aus und erhältst eine 2. Block 2 sind die Tickets Nr. 1000 bis Nr. 1100. Dann losst du innerhalb dieses Blocks aus und erhältst 60. Es wird automatisch berechnet, und Ticket Nr. 1059 ist der Gewinner.<br>

**Gewinner ankündigen:** Sobald du eine Gewinn-Ticketnummer hast, erkennt das Plug-in, wem sie gehört, und kündigt den Namen an.<br>

**Auslosung zurücksetzen:** Setzt die ausgeloste Ticketnummer zurück, falls etwas schiefgelaufen ist. Die Namen bleiben erhalten.<br>

**Alle Einträge löschen:** Löscht alle Namen und Ticketnummern. Dies wird vorher bestätigt, also sei vorsichtig.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway wurde für Spiele angefragt, bei denen die Person entweder den höchsten, niedrigsten, nächstgelegenen oder exakten Wurf erzielen muss, um etwas zu gewinnen.

**Randomway-Chatkanal:** Wo der Gewinner angekündigt wird.<br>

**Gastgeber in Bestenliste einbeziehen:** Dies bezieht die Person, die das Plug-in verwendet, in die Würfe mit ein. Andernfalls werden deine eigenen Würfe ignoriert.<br>

**Gewinnbedingung:** Höchster, niedrigster, nächster am Ziel, oder exakt - genau wie sie klingen.<br>

**Nächster am Ziel/Exakt:** Du kannst diese Zahl entweder manuell eingeben oder „Ziel auslosen" verwenden, wodurch gewartet wird, bis du /random machst, und die Zahl automatisch in das Feld eingetragen wird.<br>

**SCAN STARTEN:** Wir empfehlen, diese Schaltfläche zu drücken, BEVOR du die Leute bittest, mit /random zu beginnen. Es wird dann jedes /random im Log erkennen, sobald es erscheint. Es wird nur den ersten /random-Wurf einer Person berücksichtigen, und wenn du die Option zum Einbeziehen der Würfe des Gastgebers ausgewählt hast, wird dies getan. Andernfalls werden die Würfe des Gastgebers ignoriert.<br>

**Alles löschen:** Löscht alle Namen und Zahlen. Dies wird vorher bestätigt, also sei vorsichtig.<br>

## Quizzingway

<img width="761" height="732" alt="image" src="https://github.com/user-attachments/assets/5c1bb8f1-a120-4952-9f18-10c16bd7bc71" />

Quizzingway hilft bei Quizabenden! Es ermöglicht dir, Fragen im Voraus vorzubereiten, mehrere Varianten der Antwort zuzulassen, und berücksichtigt Tippfehler mit einer Fehlertoleranz von 25 %.<br>

**Quizzingway-Chatkanal:** Wo die Frage und der Gewinner angekündigt werden.<br>

**Gespeicherte Fragen verwalten:** Hier erstellst du die Fragen, die Antwort(en), die du akzeptierst, und kannst dann „In Bank speichern" klicken, wenn fertig. Wenn du die Frage „Lädst", erscheint sie hier ebenfalls wieder, was erforderlich ist, um das Quiz zu starten.<br>

**Frage starten:** Sobald du die Frage geladen hast, drückst du diese Schaltfläche, um die Frage im ausgewählten Chatkanal anzukündigen, und das Plug-in durchsucht den Chat nach der nächstgelegenen oder exakten Antwort.<br>

**Qualitätskontrolle:** Diese Tabelle zeigt dir den Namen und die mögliche Antwort dieser Person. Du wählst dann „VERGEBEN", um den Gewinner auszuwählen.<br>

## Deathway

<img width="713" height="335" alt="image" src="https://github.com/user-attachments/assets/2add0564-3516-4ff1-a538-bd4bd26edd68" /> <img width="699" height="599" alt="image" src="https://github.com/user-attachments/assets/5efee64f-631a-4093-a458-76bbd0b95beb" />

Deathway ist ein Helfer für Death-Roll-Turniere.<br>

Das erste Bild zeigt den anfänglichen Spielerpool. Du kannst entweder den Zielspieler hinzufügen oder seinen Namen eingeben. **Der Name muss exakt* sein, sonst werden die Würfe dieses Spielers nicht erkannt.**<br>

Das zweite Bild zeigt die Turnierbaum-Übersicht. Direkt darunter wird angezeigt, in welcher Phase du dich befindest. Bitte beachten: Das Plug-in ist nicht dafür ausgelegt, nach der Wurf-10-Phase ohne Eingabe des Nutzers automatisch fortzufahren. Dies dient dazu, falsch-positive Ergebnisse zu verhindern. Sobald die Wurf-10-Phase abgeschlossen ist, klickst du auf „999-Deathroll starten", und das Plug-in beginnt, die Würfe der teilnehmenden Spieler zu verfolgen.<br>

Das Plug-in erkennt auch Fehlwürfe und wird dich benachrichtigen, stoppt jedoch nicht automatisch alles, sodass eine Überwachung durch den Gastgeber weiterhin erforderlich ist. Wir haben Aufgabe-Schaltflächen für aufgebende/betrügende Spieler eingefügt, um bei Fehltritten zu helfen.<br>

Falls etwas schiefgeht und du das aktuelle Match neu starten möchtest, klicke auf „Aktuelles Match zurücksetzen".<br>

„Turnier abbrechen" setzt *alles* zurück, sei also vorsichtig, diese Schaltfläche nur zu drücken, wenn du beabsichtigst, das gesamte Turnier von vorne zu beginnen.<br>

## Payingway

Payingway ist ein weiterer Versuch, dein Personal von Tabellenkalkulationen wegzubringen, indem sie zu einer Datenbank hinzugefügt, für einen bestimmten Abend aktiviert werden, und verfolgt wird, wie viel du ihnen schuldest und wie hoch die Gesamtkosten am Ende des Abends sein werden.<br>

**__Tab Nächtliches Kassenbuch__**

<img width="762" height="257" alt="image" src="https://github.com/user-attachments/assets/231e9b96-cc2d-4b23-97a5-d72cf19f340d" />

**Kassenbuchsaldo zurücksetzen:** Dies setzt das gesamte nächtliche Kassenbuch mit Bestätigung zurück.

**Handel/Dropbox-Handel:** Dies findet das nächstgelegene Ziel mit diesem Namen und fokussiert es für dich. Wenn du Dropbox installiert hast, wird der Handel initiiert, um mit der Auszahlung zu beginnen. Falls nicht, wird lediglich ein Handelsfenster für dich geöffnet und verfolgt, wie viel du bereits ausgezahlt hast. Du kannst auch den „Handelsverlauf" einsehen, um den Status deiner Handel zu überprüfen.

**__Personaldatenbank__**

Hier dokumentierst du deine Personalmitglieder (verwende exakte Namen, um die Handelsschaltfläche zu nutzen), ihre Rolle, und wie hoch ihr Grundgehalt ist (was du ihnen zu zahlen beabsichtigst).

**__Handelsverlauf__**

Dokumentiert alle abgeschlossenen Handel, an wen und in welcher Höhe.

## Shoutingway

<img width="583" height="772" alt="image" src="https://github.com/user-attachments/assets/8240b050-9ac1-4f30-b4b5-389b46240b6e" />

Shoutingway ist einfach ein Mittel, um deinen Aufwand für Makros oder Kopieren/Einfügen zu reduzieren, indem du eine Nachricht einfügst und auf Rufen/Schreien klickst (je nach Vorliebe), um sie auszuführen. Gedacht, um bei gelegentlichen Ankündigungen zu helfen, die Betreiber gerne machen, um ihre Website, Discord oder andere Veranstaltungen im Lokal an diesem Abend zu bewerben.

## Einstellungen

**Umschalter:** Du kannst Tabs, die du verwendest, aktivieren/deaktivieren, um dir das Leben zu erleichtern.

**Spracheinstellungen:** Unterstützt Englisch, Französisch und Deutsch. Spanisch ist für die Menüs selbst enthalten, jedoch nicht für die eigentlichen Auslosungsmechanismen, da Square aus irgendeinem Grund kein Spanisch unterstützt. Du musst /random auf Englisch verwenden. Entschuldigung.<br>

**Lokal auf diese Zone sperren / Entsperren:** Damit du nicht Milliarden von Benachrichtigungen bekommst, wenn du nach Limsa gehst, dass Leute angekommen sind, kannst du das Plug-in so sperren, dass es nur dein Lokal beobachtet. Du musst dies IM INNEREN tun. Du könntest es technisch auch draußen verwenden, aber es wird unzuverlässig. Entsperren löscht die Zone.<br>

**Türklingel aktivieren:** Verwendet eine Echo-Nachricht, um dich zu benachrichtigen, dass jemand angekommen ist. Du kannst den Benachrichtigungston wechseln, den du verwenden möchtest.<br>

**Begrüßungsvorlage:** Was gesendet wird, wenn du auf „Begrüßen" drückst.<br>

**Personal-Synchronisierung:** Der Linkshell, den du zur Synchronisierung der Nachrichten verwendest. Dies kann deaktiviert werden.<br>

**Ambiente-Text:** Passe an, wie deine Ankündigungen klingen sollen.
