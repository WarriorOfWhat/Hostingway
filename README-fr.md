# [English](README.md) | [Français] | [Deutsch](README-de.md) | [Español](README-es.md)
---

# Hostingway

Hostingway est un outil utilitaire de gestion pour les responsables d'établissement qui aide à suivre les invités dans votre lieu grâce à un bouton permettant d'envoyer un message privé personnalisable pour les accueillir, d'ajouter des notes sur chaque visiteur afin d'offrir une expérience personnalisée lors de leurs prochaines visites, ainsi qu'un bouton pour les ajouter à une roue de la fortune pour des tirages au sort et autres événements. Ces informations peuvent être synchronisées entre le personnel en utilisant un linkshell partagé.

Dépôt : https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Synchronisation

La synchronisation fonctionne en envoyant un message <strike>caché</strike> dans le linkshell défini, qui est capté par toute personne utilisant l'extension dans ce linkshell. Cela permet d'éviter d'accueillir un invité deux fois, et si un membre du personnel doit ajouter une note, il peut le faire lui-même et vous recevrez également la note.<br>
**VEUILLEZ NOTER :** Les notes seront remplacées par la dernière personne qui insère une note et appuie sur enregistrer.<br>
(NOTE 08/05/26) : Le message pourrait ne pas être caché pour le moment. J'y travaille.

## Guide 

## Greetingway

<img width="765" height="272" alt="image" src="https://github.com/user-attachments/assets/7bd150b7-3f97-4cd4-994b-89ea46b1f6cc" />

**Arrivée :** L'heure à laquelle un invité est arrivé.<br>

**Statut :** S'ils sont toujours présents, ou l'heure à laquelle ils sont partis.<br>

**Infos sur l'invité :**<br>
Nom @ Monde - Nom de l'invité et son monde d'origine<br>
<ins>Couleurs</ins><br>
$\color{yellow}{\text{Jaune}}$ : Nouveau, pas encore accueilli<br>
Blanc : Accueilli<br>
$\color{purple}{\text{Violet}}$ : VIP<br>
$\color{grey}{\text{Gris}}$ : N'est plus dans l'établissement<br>
« [*] » - N'apparaît que si une note existe. Peut être survolé pour consulter les notes écrites par vous ou le personnel.

**Accueillir/Accueillir VIP :** Envoie un MP personnalisé (onglet Paramètres) pour accueillir votre invité avec des informations importantes, comme votre site web, votre Discord ou vos règles. Une fois cliqué, le plug-in se souvient de qui a été accueilli, même s'il part et revient.<br>

**Passer :** Passe un accueil / le marque comme accueilli sans envoyer de MP.<br>

**Note :** Notes pour vous aider à vous souvenir d'un invité afin d'offrir une expérience plus personnalisée. Limite de 100 caractères.<br>

**VIP/Retirer VIP :** Ajouter/Retirer de la base de données VIP.<br>

**Réinitialiser les accueils de la session :** Nous recommandons d'utiliser ceci avant d'utiliser **Effacer l'historique hors ligne** si vous souhaitez accueillir tout le monde de la même façon chaque soir, y compris les habitués. Sinon, vous pouvez ignorer cette option.<br>

**Effacer l'historique hors ligne :** Si des invités ont quitté l'établissement et que vous souhaitez une liste plus propre, vous pouvez utiliser ceci pour supprimer tous ceux qui ont quitté le lieu. Cela conservera toutes les notes.<br>

## Spinningway

<img width="766" height="714" alt="image" src="https://github.com/user-attachments/assets/f73a52d4-8b93-48aa-9724-7c8eb46980ea" />

Spinningway est une roue de la fortune pour aider le personnel de l'établissement avec les tirages au sort et autres concours. C'est assez simple. Bien qu'elle soit conçue pour tirer des noms, elle peut aussi être utilisée pour d'autres jeux.<br>

**Ajout en masse :** Vous permet de copier-coller des noms depuis une liste externe pour la roue.<br>

**Ajouter la cible :** Vous permet de cliquer sur quelqu'un et de l'ajouter à la roue.<br>

**Ajouter les personnes proches :** Ajoutera tout le monde dans un rayon de 20 yalms à la roue. Cela devrait couvrir tout votre établissement.<br>

**Manuel :** Vous pouvez aussi taper un nom manuellement pour l'ajouter.<br>

Vous pouvez **cliquer sur le X** pour retirer un nom.<br>

**Vider la roue** supprimera tous les noms.<br>

## Raffleway

<img width="771" height="721" alt="image" src="https://github.com/user-attachments/assets/c4d28657-5d93-4913-ae07-8a6e8a81dca3" />

Raffleway vise à éloigner les propriétaires d'établissement des tableurs lorsqu'ils organisent leurs tombolas. Il annonce également les gagnants en jeu, tout en utilisant toujours /random pour la transparence.<br>

**Canal de discussion de la tombola :** Où annoncer les tirages, le gagnant, etc.<br>

**Prix du ticket :** Indiquez ici le coût par ticket de tombola pour un calcul correct de votre cagnotte.<br>

**Cagnotte de départ :** Si vous souhaitez avoir une cagnotte de départ.<br>

**Achat de tickets :** Tapez le nom du joueur et le nombre de tickets qu'il a achetés. Cliquez sur Ajouter une entrée une fois terminé. Si le joueur revient acheter plus de tickets ou si vous faites une erreur, vous pouvez simplement ajouter à nouveau le reste des entrées et cela créera une nouvelle ligne.<br>

**% de prélèvement :** Si votre tombola est en 50/50, 70/30, 90/10, etc., indiquez le pourcentage que vous souhaitez conserver sur les entrées et cela recalculera la cagnotte totale. Mettez 0 si vous ne souhaitez pas de prélèvement.<br>

**Tombola standard (< 999 entrées) :** Cliquez sur « Tirer un gagnant » et votre texte d'ambiance (dans les paramètres) annoncera que vous vous préparez à tirer, et pour combien de tickets. (ex. /random 350)<br>

**Tombola multi-blocs (> 999 entrées) :** Si vous dépassez 999 entrées (félicitations !), la manière la plus équitable de tirer est de procéder par blocs. Vous cliquez d'abord sur « Tirer le bloc », puis faites /random #. Ensuite, vous cliquez sur Tirer un gagnant, et faites un autre /random # basé sur les entrées restantes. Par exemple : votre tombola compte 1100 tickets. Vous tirez le bloc et obtenez 2. Le bloc 2 correspond aux tickets n°1000 à n°1100. Vous tirez ensuite dans ce bloc et obtenez 60. Le calcul sera fait automatiquement, et le ticket n°1059 est le gagnant.<br>

**Annoncer le gagnant :** Une fois que vous avez un numéro de ticket gagnant, le plug-in détectera qui possède ce ticket et annoncera son nom.<br>

**Réinitialiser le tirage :** Réinitialise le numéro de ticket tiré au cas où quelque chose se serait mal passé. Les noms resteront.<br>

**Effacer toutes les entrées :** Supprime tous les noms et numéros de tickets. Une confirmation sera demandée avant, donc faites attention.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway a été demandé pour les jeux où la personne doit obtenir le score le plus haut, le plus bas, le plus proche, ou exact pour gagner quelque chose.

**Canal de discussion Randomway :** Où annoncer le gagnant.<br>

**Inclure l'hôte dans le classement :** Ceci inclura la personne qui utilise l'extension dans les tirages. Sinon, elle ignorera vos propres tirages.<br>

**Condition de victoire :** Le plus haut, le plus bas, le plus proche de la cible, ou exact - comme leur nom l'indique.<br>

**Le plus proche de la cible/Exact :** Vous pouvez soit entrer ce nombre manuellement, soit utiliser Tirer pour la cible, qui attendra alors que vous fassiez /random et placera automatiquement le nombre dans la case.<br>

**COMMENCER LE SCAN :** Nous recommandons d'appuyer sur ce bouton AVANT de dire aux gens de commencer à faire /random. Il détectera alors chaque /random dans le journal au fur et à mesure qu'il apparaît. Il ne prendra en compte que le premier /random effectué par une personne, et si vous avez sélectionné l'option pour inclure les tirages de l'hôte, il le fera. Sinon, il ignorera les tirages de l'hôte.<br>

**Tout effacer :** Supprime tous les noms et nombres. Une confirmation sera demandée avant, donc faites attention.<br>

## Quizzingway

<img width="761" height="732" alt="image" src="https://github.com/user-attachments/assets/5c1bb8f1-a120-4952-9f18-10c16bd7bc71" />

Quizzingway est là pour vous aider lors des soirées quiz ! Il vous permet de préparer les questions à l'avance, d'autoriser plusieurs variantes de réponse, et tient compte des fautes de frappe avec une marge d'erreur de 25 %.<br>

**Canal de discussion Quizzingway :** Où annoncer la question et le gagnant.<br>

**Gérer les questions enregistrées :** C'est ici que vous créez les questions, la ou les réponses que vous accepterez, puis vous pouvez « Enregistrer dans la banque » une fois terminé. Lorsque vous « Chargez » la question, elle réapparaîtra également ici, ce qui est nécessaire pour commencer le quiz.<br>

**Démarrer la question :** Une fois la question chargée, appuyez sur ce bouton pour annoncer la question sur le canal de discussion sélectionné, et l'extension scannera le chat à la recherche de la réponse la plus proche ou exacte.<br>

**Contrôle qualité :** Ce tableau vous montrera le nom et la réponse potentielle fournie par cette personne. Vous sélectionnez ensuite « RÉCOMPENSER » pour choisir le gagnant.<br>

## Deathway

<img width="713" height="335" alt="image" src="https://github.com/user-attachments/assets/2add0564-3516-4ff1-a538-bd4bd26edd68" /> <img width="699" height="599" alt="image" src="https://github.com/user-attachments/assets/5efee64f-631a-4093-a458-76bbd0b95beb" />

Deathway est un assistant de tournoi de Death Roll.<br>

La première image représente le groupe de joueurs initial. Vous pouvez soit ajouter le joueur ciblé, soit taper son nom. **Le nom doit être exact* ou les tirages de ce joueur ne seront pas détectés.**<br>

La seconde image montre les brackets du tournoi. Juste en dessous est indiquée la phase dans laquelle vous vous trouvez. Veuillez noter : l'extension n'est pas conçue pour avancer automatiquement après la phase du Tirage 10 sans intervention de l'utilisateur. Ceci afin d'éviter les faux positifs. Une fois la phase Tirage 10 terminée, vous cliquez sur « Démarrer le Deathroll 999 » et l'extension commencera à suivre les tirages des joueurs en compétition.<br>

L'extension détecte également les tirages ratés et vous alertera, mais elle n'arrêtera pas tout automatiquement, donc une surveillance par l'hôte reste nécessaire. Nous avons inclus des boutons d'abandon pour les joueurs qui abandonnent ou trichent, afin de vous aider en cas de faux pas.<br>

Si quelque chose se passe mal et que vous souhaitez recommencer le match en cours, cliquez sur « Réinitialiser le match en cours ».<br>

« Annuler le tournoi » réinitialisera *tout*, donc faites attention à ne pas cliquer sur ce bouton à moins d'avoir l'intention de recommencer le tournoi entier depuis le début.<br>

## Payingway

Payingway est une autre tentative pour éloigner votre personnel des tableurs, en les ajoutant à une base de données, en les activant pour une soirée donnée, et en suivant combien vous leur devez ainsi que le coût total en fin de soirée.<br>

**__Onglet Registre nocturne__**

<img width="762" height="257" alt="image" src="https://github.com/user-attachments/assets/231e9b96-cc2d-4b23-97a5-d72cf19f340d" />

**Réinitialiser le solde du registre :** Ceci réinitialisera l'ensemble du registre nocturne avec confirmation.

**Échange/Échange Dropbox :** Ceci trouvera la cible la plus proche portant ce nom et la ciblera pour vous. Si vous avez Dropbox installé, cela initiera l'échange pour commencer à les payer. Sinon, cela ouvrira simplement une fenêtre d'échange pour vous et suivra combien vous leur avez payé. Vous pouvez également consulter « Historique des échanges » pour vérifier l'état de vos échanges.

**__Base de données du personnel__**

Ici est où vous documentez les membres de votre personnel (obtenez les noms exacts pour utiliser le bouton d'échange), leur rôle, et leur salaire de base (ce que vous comptez leur payer).

**__Historique des échanges__**

Documente tous les échanges effectués, à qui et pour quel montant.

## Shoutingway

<img width="583" height="772" alt="image" src="https://github.com/user-attachments/assets/8240b050-9ac1-4f30-b4b5-389b46240b6e" />

Shoutingway est simplement un moyen de réduire votre charge de macros ou de copier-coller en insérant un message et en cliquant sur crier/héler (selon votre préférence) pour l'exécuter. Conçu pour aider aux annonces occasionnelles que les gérants aiment faire pour promouvoir leur site web, leur Discord, ou d'autres événements se déroulant dans l'établissement ce soir-là.

## Paramètres

**Bascules :** Vous pouvez activer/désactiver les onglets que vous utilisez pour vous simplifier la vie.

**Paramètres de langue :** Prend en charge l'anglais, le français et l'allemand. L'espagnol est inclus pour les menus eux-mêmes, mais pas pour les mécanismes de tirage réels, car Square ne prend pas en charge l'espagnol pour une raison quelconque. Vous devrez faire /random en anglais. Toutes nos excuses.<br>

**Verrouiller l'établissement sur cette zone / Déverrouiller :** Pour éviter de recevoir des milliards d'alertes lorsque vous allez à Limsa comme quoi des gens sont arrivés, vous pouvez verrouiller l'extension pour qu'elle ne surveille que votre établissement. Vous devez faire cela À L'INTÉRIEUR. Vous pourriez techniquement l'utiliser à l'extérieur, mais cela devient peu fiable. Déverrouiller efface la zone.<br>

**Activer la sonnette :** Utilise un message d'écho pour vous signaler l'arrivée de quelqu'un. Vous pouvez changer le son de notification que vous souhaitez utiliser.<br>

**Modèle d'accueil :** Ce qui est envoyé lorsque vous appuyez sur « Accueillir ».<br>

**Synchronisation du personnel :** Le linkshell que vous utiliserez pour synchroniser les messages. Ceci peut être désactivé.<br>

**Texte d'ambiance :** Personnalisez la façon dont vous souhaitez que vos annonces sonnent.
