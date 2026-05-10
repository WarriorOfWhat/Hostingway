# Hostingway

Hostingway is a venue manager's utility tool that assists in tracking guests within your venue location with a button that lets you send a customizable DM to greet them, add notes about each visitor to provide a personal experience for future visits, as well as gives you a button to add them to a prize wheel for giveaways and other events. This information can be synced through staff by utilizing a shared linkshell.

Repo: https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Syncing

Syncing works by the plug-in sending a <strike>hidden</strike> message into the set linkshell, which is picked up by anyone in that linkshell using the plug-in. This helps to avoid double greeting guests, as well as if staff needs to make a note, they can insert it themselves and you will get the note as well. <br>
**PLEASE NOTE:** Notes will be overriden by whoever puts the last note in and presses save.<br>
(NOTE 5/8/26): The message might not be hidden at this time. I'm working on it.

## Guide 

## Greetingway

<img width="580" height="413" alt="image" src="https://github.com/user-attachments/assets/9952811a-39d3-467d-8fe8-09e9fbfc78cf" />

**Arrived:** What time a guest arrived.<br>

**Status:** Are they still present, or what time they left.<br>

**Guest Info:**<br>
Name @ World - Guest name and their home world<br>
<ins>Colors</ins><br>
$\color{yellow}{\text{Gold}}$: New, not greeted yet<br>
White: Greeted<br>
$\color{grey}{\text{Grey}}$: No longer in the venue<br>
'[*]' - Only appears if a note exists. Can be hovered to view notes written by you or staff.

**Greet:** Sends customized DM (Settings tab) to greet your guest with important information, like your website, discord, or rules. Once pressed, it remembers who has been greeted, even if they leave and come back.

**Note:** Notes to help you remember a guest for a more personalized experience. 100 character limit.

**+Wheel:** Adds player to the Spinningway wheel. See below.<br>

**Reset Session Greets:** We recommend using this before using **Clear Offline History** if you want to greet everyone the same every night, including regulars. If not, this can be ignored.<br>

**Clear Offline History:** If guests have left the venue and you want a cleaner list, you can use this to wipe out anyone that has exited the venue. This will still preserve all notes.<br>

## Spinningway

<img width="583" height="748" alt="image" src="https://github.com/user-attachments/assets/763391b3-b4fa-419a-a24b-a9cfc839cf6f" />

Spinningway is a prize wheel to help venue staff with giveaways and other contests.
It's pretty straightforward. While it's intended for name drawing, it can also be used for other games.

**Bulk Entry:** Lets you copy and paste names from an external list for the wheel.<br>

**Add Target:** Lets you click someone and add them to the wheel.<br>

**Add Nearby:** Will add everyone within 20 yalms to the wheel.<br>

**Manual:** You can also type a name in to manually add them.<br>

**Clear wheel** will remove all names.<br>

You can **right-click a name** to remove it.<br>

## Raffleway

<img width="582" height="542" alt="image" src="https://github.com/user-attachments/assets/bfbf14c9-b00b-4fd1-aa94-6c7605a2cdda" />

Raffleway is an effort to move venue owners away from spreadsheets when they run their raffles. It also announces winners in game, and still utilizes /random for transparency.

**Raffle Chat Channel:** Where to announce the raffle rolls, winner, etc.<br>

**Ticket Price:** Insert your cost per raffle ticket here for proper calculations of your prize pool.<br>

**Ticket Purchase:** Type in the player's name and how many tickets they've purchased. Click Add Entry when done. If the player comes back to buy more tickets or you make a mistake, you can simply add the rest of the entries again and it'll make a new row.<br>

**% Cut:** If your raffle is 50/50, 70/30, 90/10, etc., put the percentage you wish to keep from the entries and it'll recalculate the total prize pool. Put 0 if you don't want a cut.<br>

**Standard Raffle (< 999 entries):** Click "Roll for Winner" and your flavor text (in settings) will announce you're preparing to roll and for how many tickets. (ex. /random 350)<br>

**Multi-Block Raffle (> 999 entries):** If you exceed 999 entries (good for you!), the most fair way to roll is by block rolling. You click "Roll for Block" first, then do /random #. Then you click to Roll for Winner, and do another /random # based on the remaining entries. For example: Your raffle has 1100 tickets. You block roll and get a 2. Block 2 is Tickets #1000 to #1100. Then you roll within that block and get 60. It will do the math, and ticket #1059 is the winner.<br>

**Announce Winner:** One you have a Winning Ticket number, it'll detect who owns the ticket and announce their name.<br>

**Reset Drawing:** Resets the drawn ticket number in case something goes amiss. The names will remain.<br>

**Clear All Entries:** Delete all the names and ticket numbers. It'll verify this before you do it so be careful.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway was requested for games where the person needs to either get the highest, lowest, closest, or exact roll to win something.

**Randomway Chat Channel:** Where to announce the winner.<br>

**Win Condition:** Highest, Lowest, Closest to Target, or Exact - just like they sound.<br>

**Closest to Target/Exact:** You can either enter this number manually, or use Roll for Target, which will then wait for you to do /random and automatically put the number into the box.<br>

**START SCANNING:** We recommend you hit this button BEFORE you tell people to start doing /random. It'll then detect every /random in the log as it pops up. It'll only pick up the first /random a person does and will not pick up the person running the plug-in if they accidentally /random into their own drawing.<br>

**Clear All:** Delete all the names and numbers. It'll verify this before you do it so be careful.<br>

## Shoutingway

<img width="583" height="685" alt="image" src="https://github.com/user-attachments/assets/8471dbea-0584-4eea-a52d-fcee676ac0f6" />

Shoutingway is just a means to reduce your macro or copy/paste load by inserting a message and clicking shout/yell (whatever your preference) to execute it. Meant to help with occassional announcements managers like to do to advertise their websites, discord, or other events occurring at the venue that evening.

## Settings

**Lock Venue to This Zone / Unlock:** So you don't get 5 billion alerts when you go to Limsa that people have arrived, you can lock the plug-in to only look at your venue. You have to do this INSIDE. You could technically use it outside, but it becomes unreliable. Unlock clears the zone.<br>

**Enable Doorbell:** Uses an echo chat to ping you that someone has arrived. Can swap what notification sound you want to use.<br>

**Greeting Template:** What sends when you press "Greet".<br>

**Staff Sync:** The linkshell you will use to sync the messages. This can be disabled.<br>

**Spinning/Raffle/Randomway Flavor Text:** Customize how you want your announcements to sound.
