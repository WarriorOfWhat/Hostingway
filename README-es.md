# Hostingway

Hostingway es una herramienta de utilidad para gestores de locales que ayuda a realizar un seguimiento de los clientes dentro de su establecimiento. Incluye un botón que permite enviar un mensaje privado (DM) personalizable para saludarlos, añadir notas sobre cada visitante para ofrecer una experiencia personalizada en futuras visitas, y un botón para añadirlos a una rueda de premios para sorteos y otros eventos. Esta información puede sincronizarse entre el personal utilizando un linkshell compartido.

Repo: https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Sincronización

La sincronización funciona mediante el envío de un mensaje <strike>oculto</strike> por parte del complemento en el linkshell configurado, que es detectado por cualquier persona en ese linkshell que use el complemento. Esto ayuda a evitar saludar dos veces a los mismos invitados; además, si el personal necesita hacer una nota, pueden insertarla ellos mismos y tú también la recibirás. <br>
**TENGA EN CUENTA:** Las notas serán sobrescritas por la última persona que introduzca una nota y pulse guardar.<br>
(NOTA 08/05/26): Es posible que el mensaje no esté oculto en este momento. Estoy trabajando en ello.

## Guía 

## Greetingway

<img width="580" height="413" alt="image" src="https://github.com/user-attachments/assets/9952811a-39d3-467d-8fe8-09e9fbfc78cf" />

**Arrived (Llegada):** A qué hora llegó un invitado.<br>

**Status (Estado):** Si todavía están presentes, o a qué hora se fueron.<br>

**Guest Info (Info del Invitado):**<br>
Nombre @ Mundo - Nombre del invitado y su mundo de origen<br>
<ins>Colores</ins><br>
$\color{yellow}{\text{Oro}}$: Nuevo, aún no saludado<br>
Blanco: Saludado<br>
$\color{grey}{\text{Gris}}$: Ya no está en el local<br>
'[*]' - Solo aparece si existe una nota. Se puede pasar el ratón por encima para ver las notas escritas por ti o por el personal.

**Greet (Saludar):** Envía un DM personalizado (pestaña Settings) para saludar a tu invitado con información importante, como tu sitio web, Discord o normas. Una vez pulsado, recuerda quién ha sido saludado, incluso si se va y vuelve.

**Note (Nota):** Notas para ayudarte a recordar a un invitado y ofrecerle una experiencia más personalizada. Límite de 100 caracteres.

**+Wheel (+Rueda):** Añade al jugador a la rueda de Spinningway. Ver más abajo.<br>

**Reset Session Greets (Reiniciar saludos de sesión):** Recomendamos usar esto antes de usar **Clear Offline History** si quieres saludar a todo el mundo de la misma manera cada noche, incluidos los clientes habituales. Si no, puedes ignorarlo.<br>

**Clear Offline History (Limpiar historial desconectado):** Si los invitados se han ido del local y quieres una lista más limpia, puedes usar esto para borrar a cualquiera que haya salido del recinto. Esto conservará todas las notas.<br>

## Spinningway

<img width="583" height="748" alt="image" src="https://github.com/user-attachments/assets/763391b3-b4fa-419a-a24b-a9cfc839cf6f" />

Spinningway es una rueda de premios para ayudar al personal del local con sorteos y otros concursos.
Es bastante sencillo. Aunque está pensado para sorteos de nombres, también puede usarse para otros juegos.

**Bulk Entry (Entrada masiva):** Permite copiar y pegar nombres desde una lista externa para la rueda.<br>

**Add Target (Añadir objetivo):** Permite hacer clic en alguien y añadirlo a la rueda.<br>

**Add Nearby (Añadir cercanos):** Añadirá a todos los que estén en un radio de 20 yalms a la rueda.<br>

**Manual:** También puedes escribir un nombre para añadirlo manualmente.<br>

**Clear wheel (Limpiar rueda)** eliminará todos los nombres.<br>

Puedes hacer **clic derecho en un nombre** para eliminarlo.<br>

## Raffleway

<img width="582" height="542" alt="image" src="https://github.com/user-attachments/assets/bfbf14c9-b00b-4fd1-aa94-6c7605a2cdda" />

Raffleway es un esfuerzo para que los dueños de locales dejen de usar hojas de cálculo cuando organizan sus rifas. También anuncia a los ganadores en el juego y sigue utilizando /random para mayor transparencia.

**Raffle Chat Channel (Canal de chat de rifa):** Donde se anunciarán las tiradas de la rifa, el ganador, etc.<br>

**Ticket Price (Precio del ticket):** Introduce aquí tu coste por ticket de rifa para calcular correctamente el bote de premios.<br>

**Ticket Purchase (Compra de tickets):** Escribe el nombre del jugador y cuántos tickets ha comprado. Haz clic en Add Entry cuando termines. Si el jugador vuelve para comprar más tickets o cometes un error, simplemente añade el resto de las entradas de nuevo y se creará una nueva fila.<br>

**% Cut (Porcentaje de comisión):** Si tu rifa es 50/50, 70/30, 90/10, etc., pon el porcentaje que desees quedarte de las entradas y recalculará el total del bote de premios. Pon 0 si no quieres comisión.<br>

**Standard Raffle (Rifa estándar < 999 entradas):** Haz clic en "Roll for Winner" y tu texto de ambiente (en ajustes) anunciará que te estás preparando para tirar y para cuántos tickets. (ej. /random 350)<br>

**Multi-Block Raffle (Rifa multibloque > 999 entradas):** Si superas las 999 entradas, la forma más justa de tirar es mediante el sistema de bloques. Haz clic primero en "Roll for Block" y luego haz /random #. Después, haz clic en Roll for Winner y haz otro /random # basado en las entradas restantes. Por ejemplo: Tu rifa tiene 1100 tickets. Tiras por bloque y sale un 2. El bloque 2 son los tickets del #1000 al #1100. Luego tiras dentro de ese bloque y sale 60. El sistema hará el cálculo y el ticket #1059 será el ganador.<br>

**Announce Winner (Anunciar ganador):** Una vez que tengas un número de ticket ganador, detectará a quién pertenece el ticket y anunciará su nombre.<br>

**Reset Drawing (Reiniciar sorteo):** Reinicia el número de ticket extraído por si algo sale mal. Los nombres permanecerán.<br>

**Clear All Entries (Borrar todas las entradas):** Borra todos los nombres y números de tickets. Se verificará antes de hacerlo, así que ten cuidado.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway fue solicitado para juegos donde la persona necesita sacar el número más alto, el más bajo, el más cercano o el exacto para ganar algo.

**Randomway Chat Channel:** Donde anunciar al ganador.<br>

**Win Condition (Condición de victoria):** El más alto, el más bajo, el más cercano al objetivo o exacto.<br>

**Closest to Target/Exact:** Puedes introducir este número manualmente o usar "Roll for Target", que esperará a que hagas /random e introducirá automáticamente el número en la casilla.<br>

**START SCANNING (Iniciar escaneo):** Recomendamos pulsar este botón ANTES de decir a la gente que empiece a hacer /random. Detectará cada /random en el registro a medida que aparezca. Solo registrará el primer /random de cada persona.<br>

**Clear All (Borrar todo):** Borra todos los nombres y números. Se verificará antes de hacerlo.<br>

## Shoutingway

<img width="583" height="772" alt="image" src="https://github.com/user-attachments/assets/8240b050-9ac1-4f30-b4b5-389b46240b6e" />

Shoutingway es solo un medio para reducir tu carga de macros o de copiar/pegar insertando un mensaje y haciendo clic en shout/yell (según tu preferencia) para ejecutarlo. Pensado para ayudar con anuncios ocasionales que los gestores suelen hacer para publicitar sus sitios web, Discord u otros eventos en el local.<br>

## Settings (Ajustes)

**Language Settings (Ajustes de idioma):** Soporta inglés, francés y alemán. El español está incluido para los menús, pero no para las mecánicas de tirada porque Square no soporta el español por alguna razón. Tendrás que hacer /random en inglés. Disculpas.<br>

**Lock Venue to This Zone / Unlock (Bloquear local a esta zona):** Para que no recibas 5 mil millones de alertas cuando vayas a Limsa, puedes bloquear el complemento para que solo mire en tu local. Debes hacer esto DENTRO. Unlock desbloquea la zona.<br>

**Enable Doorbell (Activar timbre):** Usa un chat de eco para avisarte de que alguien ha llegado. Se puede cambiar el sonido de notificación.<br>

**Greeting Template (Plantilla de saludo):** Lo que se envía cuando pulsas "Greet".<br>

**Staff Sync (Sincronización de personal):** El linkshell que usarás para sincronizar los mensajes. Se puede desactivar.<br>

**Flavor Text (Texto de ambiente):** Personaliza cómo quieres que suenen tus anuncios.
