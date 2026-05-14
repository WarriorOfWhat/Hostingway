# [English](README.md) | [Français](README-fr.md) | [Deutsch] | [Español](README-es.md)

# Hostingway

Hostingway ist ein Hilfswerkzeug für Location-Manager, das dabei hilft, Gäste in deiner Location im Blick zu behalten. Es bietet eine Schaltfläche zum Senden einer anpassbaren privaten Nachricht (DM) zur Begrüßung, ermöglicht das Hinzufügen von Notizen zu jedem Besucher für eine persönlichere Erfahrung bei zukünftigen Besuchen und enthält eine Schaltfläche, um Gäste direkt zu einem Glücksrad für Giveaways und andere Events hinzuzufügen. Diese Informationen können durch die Nutzung eines gemeinsamen Linkshells mit dem Personal synchronisiert werden.

Repo: https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Synchronisierung

Die Synchronisierung funktioniert so, dass das Plugin eine <strike>versteckte</strike> Nachricht in den festgelegten Linkshell sendet, die von jedem im Linkshell empfangen wird, der das Plugin ebenfalls nutzt. Dies hilft dabei, doppelte Begrüßungen zu vermeiden. Wenn Mitarbeiter eine Notiz machen müssen, können sie diese selbst einfügen, und du erhältst die Notiz ebenfalls. <br>
**BITTE BEACHTEN:** Notizen werden von der Person überschrieben, die die letzte Notiz eingibt und auf Speichern drückt.<br>
(HINWEIS 08.05.26): Die Nachricht ist zu diesem Zeitpunkt eventuell nicht versteckt. Ich arbeite daran.

## Guide 

## Greetingway

<img width="580" height="413" alt="image" src="https://github.com/user-attachments/assets/9952811a-39d3-467d-8fe8-09e9fbfc78cf" />

**Arrived (Ankunft):** Zeit, zu der ein Gast angekommen ist.<br>

**Status:** Ob sie noch anwesend sind oder wann sie gegangen sind.<br>

**Guest Info (Gast-Infos):**<br>
Name @ Welt - Name des Gastes und seine Heimatwelt<br>
<ins>Farben</ins><br>
$\color{yellow}{\text{Gold}}$: Neu, noch nicht begrüßt<br>
Weiß: Begrüßt<br>
$\color{grey}{\text{Grau}}$: Nicht mehr in der Location<br>
'[*]' - Erscheint nur, wenn eine Notiz existiert. Kann mit der Maus berührt werden, um Notizen von dir oder dem Personal zu sehen.

**Greet (Begrüßen):** Sendet eine angepasste DM (Tab "Settings"), um deinen Gast mit wichtigen Informationen wie deiner Website, Discord oder Regeln zu begrüßen. Sobald die Taste gedrückt wurde, merkt sich das System, wer begrüßt wurde, selbst wenn die Person die Location verlässt und wiederkommt.

**Note (Notiz):** Notizen, die dir helfen, dich an einen Gast zu erinnern, für eine persönlichere Erfahrung. Limit von 100 Zeichen.

**+Wheel (+Rad):** Fügt den Spieler dem Spinningway-Glücksrad hinzu. Siehe unten.<br>

**Reset Session Greets (Sitzungs-Begrüßungen zurücksetzen):** Wir empfehlen dies, bevor du **Clear Offline History** verwendest, wenn du jeden Abend jeden gleich begrüßen möchtest (einschließlich Stammgästen). Wenn nicht, kann dies ignoriert werden.<br>

**Clear Offline History (Offline-Verlauf löschen):** Wenn Gäste die Location verlassen haben und du eine sauberere Liste möchtest, kannst du dies verwenden, um alle zu entfernen, die die Location verlassen haben. Alle Notizen bleiben dabei erhalten.<br>

## Spinningway

<img width="583" height="748" alt="image" src="https://github.com/user-attachments/assets/763391b3-b4fa-419a-a24b-a9cfc839cf6f" />

Spinningway ist ein Glücksrad, um das Personal bei Giveaways und anderen Wettbewerben zu unterstützen.
Es ist sehr einfach zu bedienen. Obwohl es für Namensziehungen gedacht ist, kann es auch für andere Spiele verwendet werden.

**Bulk Entry (Masseneintrag):** Ermöglicht das Kopieren und Einfügen von Namen aus einer externen Liste für das Rad.<br>

**Add Target (Ziel hinzufügen):** Ermöglicht es, jemanden anzuklicken und zum Rad hinzuzufügen.<br>

**Add Nearby (Umgebung hinzufügen):** Fügt jeden im Umkreis von 20 Yalms zum Rad hinzu.<br>

**Manual (Manuell):** Du kannst einen Namen auch manuell eintippen.<br>

**Clear wheel (Rad leeren)** entfernt alle Namen.<br>

Du kannst einen **Rechtsklick auf einen Namen** machen, um ihn zu entfernen.<br>

## Raffleway

<img width="582" height="542" alt="image" src="https://github.com/user-attachments/assets/bfbf14c9-b00b-4fd1-aa94-6c7605a2cdda" />

Raffleway ist ein Versuch, Location-Besitzer bei ihren Verlosungen von Tabellenkalkulationen wegzubringen. Es verkündet Gewinner im Spiel und nutzt weiterhin /random für die Transparenz.

**Raffle Chat Channel:** Wo die Verlosungswürfe, Gewinner usw. angekündigt werden.<br>

**Ticket Price (Ticketpreis):** Gib hier den Preis pro Ticket ein, damit dein Preispool korrekt berechnet wird.<br>

**Ticket Purchase (Ticketkauf):** Gib den Namen des Spielers ein und wie viele Tickets er gekauft hat. Klicke auf "Add Entry". Wenn der Spieler zurückkommt, um mehr Tickets zu kaufen, füge die restlichen Einträge einfach erneut hinzu – es wird eine neue Zeile erstellt.<br>

**% Cut (Anteil):** Wenn deine Verlosung 50/50, 70/30, 90/10 usw. ist, gib den Prozentsatz ein, den du von den Einnahmen behalten möchtest, und der Preispool wird neu berechnet. Gib 0 ein, wenn du keinen Anteil möchtest.<br>

**Standard Raffle (< 999 Einträge):** Klicke auf "Roll for Winner" und dein Flavor-Text (in den Einstellungen) wird ankündigen, dass du dich auf den Wurf vorbereitest und für wie viele Tickets (z. B. /random 350).<br>

**Multi-Block Raffle (> 999 Einträge):** Wenn du 999 Einträge überschreitest, ist das Block-Rollen der fairste Weg. Klicke zuerst auf "Roll for Block", dann mache /random #. Klicke dann auf "Roll for Winner" und mache ein weiteres /random # basierend auf den verbleibenden Einträgen. Beispiel: Deine Verlosung hat 1100 Tickets. Du rollst für den Block und erhältst eine 2. Block 2 sind die Tickets #1000 bis #1100. Dann rollst du innerhalb dieses Blocks und erhältst eine 60. Das System rechnet nach und Ticket #1059 ist der Gewinner.<br>

**Announce Winner (Gewinner bekanntgeben):** Sobald du eine Gewinn-Ticketnummer hast, erkennt das System, wem das Ticket gehört, und gibt den Namen bekannt.<br>

**Reset Drawing (Ziehung zurücksetzen):** Setzt die gezogene Ticketnummer zurück, falls etwas schiefgeht. Die Namen bleiben erhalten.<br>

**Clear All Entries (Alle Einträge löschen):** Löscht alle Namen und Ticketnummern. Dies muss bestätigt werden, also sei vorsichtig.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway wurde für Spiele angefragt, bei denen eine Person entweder den höchsten, niedrigsten, am nächsten liegenden oder exakten Wurf erzielen muss, um etwas zu gewinnen.

**Randomway Chat Channel:** Wo der Gewinner bekanntgegeben wird.<br>

**Win Condition (Siegbedingung):** Höchster, Niedrigster, Am nächsten am Ziel oder Exakt.<br>

**Closest to Target/Exact (Zielnähe/Exakt):** Du kannst diese Zahl entweder manuell eingeben oder "Roll for Target" verwenden, das darauf wartet, dass du /random machst, und die Zahl automatisch in das Feld einträgt.<br>

**START SCANNING:** Wir empfehlen, diesen Button zu drücken, BEVOR du die Leute bittest, /random zu machen. Er erkennt dann jedes /random im Log. Es wird nur der erste Wurf einer Person gezählt.<br>

**Clear All (Alles löschen):** Löscht alle Namen und Zahlen. Muss bestätigt werden.<br>

## Quizzingway

<img width="761" height="732" alt="image" src="https://github.com/user-attachments/assets/5c1bb8f1-a120-4952-9f18-10c16bd7bc71" />

Quizzingway hilft dir bei deinen Quiz-Abenden! Es ermöglicht dir, Fragen vorzubereiten, verschiedene Antwortvarianten zu hinterlegen und berücksichtigt Tippfehler mit einer Fehlertoleranz von 25 %.

**Quizzingway-Chat-Kanal:** Hier werden die Fragen und die Gewinner angekündigt.<br>

**Gespeicherte Fragen verwalten:** Hier kannst du Fragen sowie die akzeptierten Antworten (auch mehrere Varianten) erstellen. Klicke auf „Save to Bank“, wenn du fertig bist. Wenn du eine Frage lädst („Load“), erscheint sie wieder hier – dies ist erforderlich, um das Quiz zu starten.<br>

**Frage starten:** Sobald die Frage geladen ist, klicke auf diesen Button, um die Frage im ausgewählten Chat-Kanal zu posten. Das Plugin scannt den Chat dann nach der genauesten oder ähnlichsten Antwort.<br>

**Qualitätsprüfung:** Diese Tabelle zeigt den Namen und die mögliche Antwort der jeweiligen Person an. Wähle „AWARD“, um den Gewinner zu küren.<br>

## Shoutingway

<img width="583" height="772" alt="image" src="https://github.com/user-attachments/assets/8240b050-9ac1-4f30-b4b5-389b46240b6e" />

Shoutingway dient dazu, deine Makro- oder Copy/Paste-Last zu reduzieren, indem du eine Nachricht einfügst und auf Shout/Yell klickst, um sie auszuführen. Gedacht für gelegentliche Ankündigungen über Websites, Discord oder andere Events in der Location.<br>

## Settings (Einstellungen)

**Language Settings:** Unterstützt Englisch, Französisch und Deutsch. Spanisch ist für die Menüs enthalten, aber nicht für die eigentliche Würfel-Mechanik, da Square Enix Spanisch nicht offiziell unterstützt. Du musst /random auf Englisch verwenden.<br>

**Lock Venue to This Zone / Unlock (Location an Zone binden):** Damit du nicht 5 Milliarden Benachrichtigungen erhältst, wenn du nach Limsa gehst, kannst du das Plugin so sperren, dass es nur in deiner Location sucht. Dies muss INNERHALB der Location gemacht werden.<br>

**Enable Doorbell (Türklingel aktivieren):** Verwendet einen Echo-Chat, um dich zu benachrichtigen, wenn jemand angekommen ist. Der Benachrichtigungston kann geändert werden.<br>

**Greeting Template (Begrüßungsvorlage):** Was gesendet wird, wenn du auf "Greet" drückst.<br>

**Staff Sync (Personal-Synchronisierung):** Der Linkshell, den du zum Synchronisieren der Nachrichten verwendest. Kann deaktiviert werden.<br>

**Flavor Text:** Passe an, wie deine Ankündigungen klingen sollen.
