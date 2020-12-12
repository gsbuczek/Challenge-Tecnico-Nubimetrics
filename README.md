# Challenge-Nubimetrics
<h1>Challenge Técnico Nubimetrics - Buczek Guillermo Sebastian</h1>

<h3>¿Porque usar patrones de diseño?</h3>

Pienso en los patrones de diseño como aquello que ayuda al programador a <strong>organizar, moldear y estandarizar</strong> la escritura del codigo,
siendo una herramienta indispensable para lograr un resultado prolijo, legible para nosotros y para todo aquel que en un futuro vea nuestro codigo.

<h3>INSTRUCCIONES DE USO DE LA APLICACION</h3>

Para poder utilizar el endpoint de Paises debe hacer una solicitud GET. https://localhost:44356/api/pais?pais=AR

Para poder utilizar el endpoint de Busqueda debe hacer una solicitud por GET a. https://localhost:44356/api/Busqueda?buscar=iphone

<h3>INSTRUCCIONES DEL ABM USUARIOS</h3>

Se adjunta el script de la base de datos en el archivo script.txt para configuracion de la misma, la cual se encuentra adjunta como scriptDBChallenge.sql

Para CREAR un usuario debo realizar una solicitud POST a la direccion https://localhost:44356/api/Usuarios con 
siguiente Json como estructira y los valores del usuario.


{
        "Nombre": "Persona",
        "Apellido": "ApellidoPersona",
        "Email": "ejemplo@gmail.com",
        "Pass": "1234567890"
}

Para LISTAR los usuarios debo realizar una solicitud GET e ingresar la siguiente direccion https://localhost:44356/api/Usuarios

Para MODIFICAR un usuario debe hacer una solicitud PUT a la siguiente direccion https://localhost:44356/api/Usuarios 
paso siguiente modificar el parametro, con la siguiente estructura.

{
        "ID": 1,
        "Nombre": "Persona",
        "Apellido": "ApellidoPersona",
        "Email": "ejemplo@gmail.com",
        "Pass": "1234567890"
}

Para ELIMINAR un usuario debe hacer una solicitud DELETE a la siguiente direccion https://localhost:44356/api/Usuarios
paso siguiente modificar el parametro, con la siguiente estructura.

{
        "ID": INT_VALOR
}


