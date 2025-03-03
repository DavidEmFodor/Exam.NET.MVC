En el Management de SQL Server, crearéis una base de datos que se llame “Futbol”, a continuación seleccionáis “File” -> “Open” -> “File” y seleccionáis el archivo “Futbol.sql” que os he dejado en el Site y que contiene la estructura de tablas y los datos de la base de datos que vais a utilizar para el ejercicio y que consta de las siguientes tablas:
- Paises de los que tenemos el Nombre y el enlace a su bandera. 
- Competiciones de las que tenemos el Nombre y el tipo de competición, el enlace al logo de la competición y el campo “countryId” que relaciona la competición con el país en la que se juega.
- Equipos de los que tenemos el Nombre, su código, el año de su fundación, un enlace al logo del equipo y el campo “paisId” que relaciona al equipo con su país.
- CompeticionesEquipos relaciona a cada Equipo con las Competiciones que juega.  Esta tabla está vacía inicialmente.

La creación de una estructura de modelos completa vale 1 puntos.

a) Sacar un listado de los equipos mostrando de cada equipo, en la primera columna su nombre y entre paréntesis el código, en la segunda el año de fundación, en la tercera la foto de su logo, en la cuarta la bandera de su país, en la quinta el nombre de las competiciones en las que participa y en la sexta un enlace a editar los datos de ese equipo .  3 puntos.

b) Formulario de edición de un equipo con un input para el nombre, otro para el código, otro para el año de fundación, otro para el string del logo, un select para poder elegir el país y un select múltiple para que podamos seleccionar las competiciones en las que participa el equipo.  3 puntos.

c) Hacer un listado de países en el que se vea la bandera y el nombre, ambos campos serán un enlace que llevará a un listado en cuyo encabezado aparezca el nombre y la bandera del país y debajo te aparecerá el listado de los equipos de ese país y las competiciones que se juegan en el mismo.  3 puntos.


