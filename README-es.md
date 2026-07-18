# [English](README.md) | [Français](README-fr.md) | [Deutsch](README-de.md) | [Español]
---

# Hostingway

Hostingway es una herramienta de utilidad para gestores de locales que ayuda a hacer seguimiento de los invitados en tu establecimiento, con un botón que permite enviar un mensaje privado personalizable para saludarlos, agregar notas sobre cada visitante para ofrecer una experiencia personalizada en futuras visitas, además de un botón para añadirlos a una rueda de premios para sorteos y otros eventos. Esta información se puede sincronizar entre el personal utilizando un linkshell compartido.

Repositorio: https://WarriorOfWhat.github.io/WhatRepo/repo.json

## Sincronización

La sincronización funciona enviando un mensaje <strike>oculto</strike> al linkshell configurado, el cual es recibido por cualquiera que use el plug-in en ese linkshell. Esto ayuda a evitar saludar dos veces a los invitados, y si el personal necesita añadir una nota, puede insertarla y tú también la recibirás.<br>
**TEN EN CUENTA:** Las notas serán sobrescritas por quien introduzca la última nota y pulse guardar.<br>
(NOTA 08/05/26): Es posible que el mensaje no esté oculto por el momento. Estoy trabajando en ello.

## Guía

## Greetingway

<img width="765" height="272" alt="image" src="https://github.com/user-attachments/assets/7bd150b7-3f97-4cd4-994b-89ea46b1f6cc" />

**Llegada:** A qué hora llegó un invitado.<br>

**Estado:** Si aún están presentes, o a qué hora se fueron.<br>

**Info del invitado:**<br>
Nombre @ Mundo - Nombre del invitado y su mundo de origen<br>
<ins>Colores</ins><br>
$\color{yellow}{\text{Amarillo}}$: Nuevo, aún no saludado<br>
Blanco: Saludado<br>
$\color{purple}{\text{Morado}}$: VIP<br>
$\color{grey}{\text{Gris}}$: Ya no está en el establecimiento<br>
«[*]» - Solo aparece si existe una nota. Se puede pasar el cursor por encima para ver las notas escritas por ti o por el personal.

**Saludar/Saludar VIP:** Envía un mensaje privado personalizado (pestaña Configuración) para saludar a tu invitado con información importante, como tu sitio web, Discord o reglas. Una vez pulsado, recuerda quién ha sido saludado, incluso si se va y regresa.<br>

**Omitir:** Omite un saludo / lo marca como saludado sin enviar un mensaje privado.<br>

**Nota:** Notas para ayudarte a recordar a un invitado y ofrecer una experiencia más personalizada. Límite de 100 caracteres.<br>

**VIP/Quitar VIP:** Añadir/Quitar de la base de datos de VIP.<br>

**Restablecer saludos de la sesión:** Recomendamos usar esto antes de usar **Borrar historial fuera de línea** si quieres saludar a todos por igual cada noche, incluidos los habituales. Si no, puedes ignorar esta opción.<br>

**Borrar historial fuera de línea:** Si los invitados han salido del establecimiento y quieres una lista más limpia, puedes usar esto para eliminar a todos los que hayan salido del lugar. Esto conservará todas las notas.<br>

## Spinningway

<img width="766" height="714" alt="image" src="https://github.com/user-attachments/assets/f73a52d4-8b93-48aa-9724-7c8eb46980ea" />

Spinningway es una rueda de premios para ayudar al personal del establecimiento con sorteos y otros concursos. Es bastante sencillo. Aunque está pensado para el sorteo de nombres, también puede usarse para otros juegos.<br>

**Entrada masiva:** Te permite copiar y pegar nombres desde una lista externa para la rueda.<br>

**Añadir objetivo:** Te permite hacer clic en alguien y añadirlo a la rueda.<br>

**Añadir cercanos:** Añadirá a todos los que estén dentro de 20 yalms a la rueda. Esto debería cubrir todo tu establecimiento.<br>

**Manual:** También puedes escribir un nombre manualmente para añadirlo.<br>

Puedes **pulsar la X** para eliminar un nombre.<br>

**Vaciar rueda** eliminará todos los nombres.<br>

## Raffleway

<img width="771" height="721" alt="image" src="https://github.com/user-attachments/assets/c4d28657-5d93-4913-ae07-8a6e8a81dca3" />

Raffleway es un esfuerzo por alejar a los propietarios de locales de las hojas de cálculo cuando organizan sus rifas. También anuncia a los ganadores dentro del juego, y sigue utilizando /random para mayor transparencia.<br>

**Canal de chat de la rifa:** Dónde anunciar las tiradas, el ganador, etc.<br>

**Precio del boleto:** Introduce aquí el costo por boleto de rifa para calcular correctamente tu bolsa de premios.<br>

**Bolsa inicial:** Si quieres tener una bolsa inicial.<br>

**Compra de boletos:** Escribe el nombre del jugador y cuántos boletos ha comprado. Haz clic en Añadir entrada cuando termines. Si el jugador vuelve a comprar más boletos o cometes un error, simplemente puedes añadir el resto de las entradas de nuevo y creará una nueva fila.<br>

**% de comisión:** Si tu rifa es 50/50, 70/30, 90/10, etc., introduce el porcentaje que deseas quedarte de las entradas y recalculará la bolsa de premios total. Pon 0 si no quieres quedarte una comisión.<br>

**Rifa estándar (< 999 entradas):** Haz clic en «Sortear ganador» y tu texto ambiental (en configuración) anunciará que te estás preparando para sortear y para cuántos boletos. (ej. /random 350)<br>

**Rifa multi-bloque (> 999 entradas):** Si superas las 999 entradas (¡enhorabuena!), la forma más justa de sortear es por bloques. Primero haces clic en «Sortear bloque», luego haces /random #. Después haces clic en Sortear ganador, y haces otro /random # basado en las entradas restantes. Por ejemplo: tu rifa tiene 1100 boletos. Sorteas el bloque y obtienes un 2. El bloque 2 son los boletos del n.º 1000 al n.º 1100. Luego sorteas dentro de ese bloque y obtienes 60. Se hará el cálculo automáticamente, y el boleto n.º 1059 es el ganador.<br>

**Anunciar ganador:** Una vez que tengas un número de boleto ganador, detectará quién posee ese boleto y anunciará su nombre.<br>

**Restablecer sorteo:** Restablece el número de boleto sorteado en caso de que algo salga mal. Los nombres permanecerán.<br>

**Borrar todas las entradas:** Elimina todos los nombres y números de boleto. Se pedirá confirmación antes de hacerlo, así que ten cuidado.<br>

## Randomway

<img width="581" height="559" alt="image" src="https://github.com/user-attachments/assets/ce2f47c6-8278-4abd-bc3e-5b22baa990fc" />

Randomway fue solicitado para juegos en los que la persona necesita obtener la tirada más alta, más baja, más cercana, o exacta para ganar algo.

**Canal de chat de Randomway:** Dónde anunciar al ganador.<br>

**Incluir al anfitrión en la clasificación:** Esto incluirá a la persona que ejecuta el plug-in en las tiradas. De lo contrario, ignorará tus propias tiradas.<br>

**Condición de victoria:** Más alta, más baja, más cercana al objetivo, o exacta - tal como suenan.<br>

**Más cercana al objetivo/Exacta:** Puedes introducir este número manualmente, o usar Sortear objetivo, que esperará a que hagas /random y colocará automáticamente el número en la casilla.<br>

**COMENZAR ESCANEO:** Recomendamos pulsar este botón ANTES de decirle a la gente que empiece a hacer /random. Luego detectará cada /random en el registro a medida que aparezca. Solo tomará en cuenta el primer /random que haga una persona, y si has seleccionado la opción de incluir las tiradas del anfitrión, lo hará. De lo contrario, ignorará las tiradas del anfitrión.<br>

**Borrar todo:** Elimina todos los nombres y números. Se pedirá confirmación antes de hacerlo, así que ten cuidado.<br>

## Quizzingway

<img width="761" height="732" alt="image" src="https://github.com/user-attachments/assets/5c1bb8f1-a120-4952-9f18-10c16bd7bc71" />

¡Quizzingway está aquí para ayudar con las noches de trivia! Te permite preparar las preguntas de antemano, permitir múltiples variantes de la respuesta, y tiene en cuenta los errores tipográficos con un margen de error del 25 %.<br>

**Canal de chat de Quizzingway:** Dónde anunciar la pregunta y el ganador.<br>

**Gestionar preguntas guardadas:** Aquí es donde creas las preguntas, la(s) respuesta(s) que aceptarás, y luego puedes «Guardar en el banco» cuando termines. Cuando «Cargas» la pregunta, también reaparecerá aquí, lo cual es necesario para comenzar el quiz.<br>

**Iniciar pregunta:** Una vez que hayas cargado la pregunta, pulsa este botón para anunciar la pregunta en el canal de chat seleccionado, y el plug-in escaneará el chat en busca de la respuesta más cercana o exacta.<br>

**Control de calidad:** Esta tabla te mostrará el nombre y la posible respuesta proporcionada por esa persona. Luego seleccionas «PREMIAR» para elegir al ganador.<br>

## Deathway

<img width="713" height="335" alt="image" src="https://github.com/user-attachments/assets/2add0564-3516-4ff1-a538-bd4bd26edd68" /> <img width="699" height="599" alt="image" src="https://github.com/user-attachments/assets/5efee64f-631a-4093-a458-76bbd0b95beb" />

Deathway es un asistente de torneos de Death Roll.<br>

La primera imagen representa el grupo inicial de jugadores. Puedes añadir al jugador objetivo o escribir su nombre. **El nombre *tiene que ser exacto* o las tiradas de ese jugador no serán detectadas.**<br>

La segunda imagen muestra el cuadro del torneo. Justo debajo se indica la fase en la que te encuentras. Ten en cuenta: el plug-in no está diseñado para avanzar automáticamente después de la fase de Tirada 10 sin la intervención del usuario. Esto es para evitar falsos positivos. Una vez completada la fase de Tirada 10, haces clic en «Iniciar Deathroll 999» y el plug-in comenzará a seguir las tiradas de los jugadores en competencia.<br>

El plug-in también detecta tiradas erróneas y te alertará, sin embargo no detendrá todo automáticamente, por lo que sigue siendo necesario que el anfitrión lo supervise. Hemos incluido botones de abandono para jugadores que abandonan o hacen trampa, para ayudar con cualquier percance.<br>

Si algo sale mal y quieres reiniciar la partida actual, haz clic en «Reiniciar partida actual».<br>

«Cancelar torneo» reiniciará *todo*, así que ten cuidado de no pulsar este botón a menos que quieras comenzar todo el torneo desde cero.<br>

## Payingway

Payingway es otro intento de alejar a tu personal de las hojas de cálculo, añadiéndolos a una base de datos, activándolos para una noche determinada, y llevando un registro de cuánto les debes y cuál será el costo total al final de la noche.<br>

**__Pestaña de Registro Nocturno__**

<img width="762" height="257" alt="image" src="https://github.com/user-attachments/assets/231e9b96-cc2d-4b23-97a5-d72cf19f340d" />

**Restablecer saldo del registro:** Esto restablecerá todo el registro nocturno con confirmación.

**Intercambio/Intercambio con Dropbox:** Esto encontrará el objetivo más cercano con ese nombre y lo enfocará por ti. Si tienes Dropbox instalado, iniciará el intercambio para comenzar a pagarles. Si no lo tienes, simplemente abrirá una ventana de intercambio para ti y llevará un registro de cuánto les has pagado. También puedes consultar el «Historial de intercambios» para verificar el estado de tus intercambios.

**__Base de datos del personal__**

Aquí es donde documentas a los miembros de tu personal (usa nombres exactos para poder usar el botón de intercambio), su rol, y cuál es su salario base (lo que planeas pagarles).

**__Historial de intercambios__**

Documenta todos los intercambios completados, a quién y por qué monto.

## Shoutingway

<img width="583" height="772" alt="image" src="https://github.com/user-attachments/assets/8240b050-9ac1-4f30-b4b5-389b46240b6e" />

Shoutingway es simplemente un medio para reducir tu carga de macros o de copiar y pegar, insertando un mensaje y haciendo clic en gritar/vocear (según tu preferencia) para ejecutarlo. Pensado para ayudar con los anuncios ocasionales que a los gestores les gusta hacer para promocionar su sitio web, Discord, u otros eventos que ocurran en el establecimiento esa noche.

## Configuración

**Interruptores:** Puedes activar/desactivar las pestañas que uses para facilitarte la vida.

**Configuración de idioma:** Compatible con inglés, francés y alemán. El español está incluido para los menús en sí, pero no para los mecanismos reales de sorteo, porque Square no admite el español por alguna razón. Tendrás que usar /random en inglés. Disculpas.<br>

**Bloquear el establecimiento a esta zona / Desbloquear:** Para que no recibas mil millones de alertas cuando vayas a Limsa de que ha llegado gente, puedes bloquear el plug-in para que solo observe tu establecimiento. Debes hacer esto DENTRO. Técnicamente podrías usarlo fuera, pero se vuelve poco fiable. Desbloquear borra la zona.<br>

**Activar timbre:** Usa un mensaje de eco para avisarte de que alguien ha llegado. Puedes cambiar el sonido de notificación que quieras usar.<br>

**Plantilla de saludo:** Lo que se envía cuando pulsas «Saludar».<br>

**Sincronización de personal:** El linkshell que usarás para sincronizar los mensajes. Esto se puede desactivar.<br>

**Texto ambiental:** Personaliza cómo quieres que suenen tus anuncios.
