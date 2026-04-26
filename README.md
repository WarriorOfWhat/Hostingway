# Hostingway

Hostingway is a venue manager's utility tool that assists in tracking guests within your venue location with a button that lets you send a customizable DM to greet them, add notes about each visitor to provide a personal experience for future visits, as well as gives you a button to add them to a prize wheel for giveaways and other events. This information can be synced through staff by utilizing a shared linkshell.

## Syncing

Syncing works by the plug-in sending a hidden message into the set linkshell, which is picked up by anyone in that linkshell using the plug-in. This helps to avoid double greeting guests, as well as if staff needs to make a note, they can insert it themselves and you will get the note as well.
**PLEASE NOTE:** Notes will be overriden by whoever puts the last note in and presses save.

### Guide 

<img width="600" height="372" alt="hosting-example" src="https://github.com/user-attachments/assets/ff7d702e-2af6-45a7-8ffa-7edab25e1819" />

### Guest List

**Arrived:** What time a guest arrived.<br>
**Status:** Are they still present, or what time they left.<br>

**Guest Info:**<br>
Name @ World - Guest name and their home world<br>
<ins>Colors</ins><br>
$\color{yellow}{\text{Gold}}$: New, not greeted yet<br>
White: Greeted<br>
$\color{grey}{\text{Grey}}$: No longer in the venue<br>
'[*]' - Only appears if a note exists. Can be hovered to view notes written by you or staff.

**Greet:** Sends customized DM (Settings tab) to greet your guest with important information, like your website, discord, or rules. Once pressed, it remembers who has been greeted, even if they leave and come back.<br>
**Note:** Notes to help you remember a guest for a more personalized experience. 100 character limit.<br>
**+Wheel:** Adds player to the Spinningway wheel. See below.<br>

**Reset Session Greets:** We recommend using this before using **Clear Offline History** if you want to greet everyone the same every night, including regulars. If not, this can be ignored.<br>
**Clear Offline History:** If guests have left the venue and you want a cleaner list, you can use this to wipe out anyone that has exited the venue. This will still preserve all notes.

### Spinningway

Spinningway is another plug-in from this repo integrated into Hostingway. It's a prize wheel to help venue staff with giveaways and other contests.
It's pretty straightforward. While it's intended for name drawing, it can also be used for other games.

**Bulk entry** lets you copy and paste names from an external list for the wheel.
**Add Target** let's you click someone and add them to the wheel.
**Add nearby** will add everyone within 20 yalms to the wheel.
You can also type a name in to manually add them.
**Clear wheel** will remove all names.
You can **right-click a name** to remove it.

### Settings

**Enable Doorbell** uses an echo chat to ping you that someone has arrived.
**Greeting Template** is what sends when you press "Greet".
**Staff Sync** is the linkshell you will use to sync the messages. This can be disabled.

Disclosure: Hostingway was written with the assistance of AI with the creator as a Co-pilot. The co-pilot is currently trying to learn C# through AI assistance, so code is susceptible to having errors or being messy, but has been tested and driven by extensive human input. Random comments were left for the co-pilot to remember why things are a certain way. Thank you for any understanding.
