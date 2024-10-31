# Consulta integrada en el lenguaje

En terminos generales, es escribir consultas SQL en el código.


## Ejemplo de grup by en sql:

tenemos una tabla de personas y una tabla de localidad.
Queremos contar la cantidad de personas por localidad.

select l.nombre localidad, COUNT(p.nombre) cant
from persona p
join localidades l on l.id = p.localidad_id
group by l.nombre;

mockaroo: Página para hacer un mock, es decir simular una db.
Se usa mucho para el testing, ya que son muchos datos simulando un caso de uso real.

En lugar de un where, si utilizamos un group by hay que utilizar un heaving