# GEN_01_ConsultorIdealista
# Bienvenido! Proyecto RPA

Este proyecto fue desarrollado utilizando **UiPath** para automatizar el proceso de recolección de información sobre viviendas publicadas en el portal inmobiliario [Idealista](https://www.idealista.com). 
El objetivo principal es extraer de forma eficiente datos clave como el precio, la ubicación, los metros cuadrados, el número de habitaciones y enviarlo al cliente por correo electrónico con los requisitos que pidió. Luego se creara una tabla, y se enviara los datos mediante correo.


# Funcionalidad

La funcionalidad de este proyecto de RPA, es facilitar al cliente a la hora de realizar una búsqueda mediante idealista para que se realice automáticamente.

El proyecto consiste en varias funciones que son:

 1. Recibir el correo ( mediante un correo asociado )
 2. Copiar ese mensaje y transcribir el mensaje mediante un prompt por chatgpt
 3. Enviar esos datos necesarios facilitados por el prompt anterior a UIPATH Orchestator ( para ordenar los datos que necesita el cliente ) (Tendrá en cuenta Nº de Habitaciones, Metros, Precio y adonde quiere realizar la búsqueda)
 4. Entrar dentro de [Idealista](https://www.idealista.com). 
 5. Recibir esos datos (Items) del orchestator, y realizar las busquedas de las viviendas dentro de [Idealista](https://www.idealista.com)
 6. Y escribir un mensaje con los datos recogidos, con una tabla en HTML al cliente.

![Resultado del Correo](https://imgur.com/7omUI62)


# Video
[Video demostracion](https://youtu.be/ZHp1q98Hp9Y)
