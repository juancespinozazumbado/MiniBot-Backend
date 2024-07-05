# Mini Chatbot

Contiene el Backend de la aplicacion Chatbot. El mismo esta en su version inicial y puede ser+
escalado a una solucion que se pueda integrarse con tecnologias de IA como OpenAI, Azure AI, 
Modelos de Aprendizaje, entre otras. La Api esta estructurada con la finalidad de que pueda
ser facilmente escalable.

## tecnologias usadas: 
  - C#| .Net como principal lenguaje de programacion.
  - .Net core como Framework web.
  - Entity Framework core como ORM.
  - SQL Server / Sqlite como Bases de datos.
  - Docker para el desarollo y debugueo local.
  - Arquitectura en capas para asegurar la calidad e integridad del servicio.
  - Se pude desplegar como tanto en IIS como en entornos Linux o bien en contenedores.

### Funcioanlidades

 La funcionalidad principal es el procesamiento de las consultas del chat.
 El cliente puede de esta aplicacion se puede ver en [Chatboot-Frontend](https://github.com/juancespinozazumbado/Minibot-Cliente).

Para instalar la aplicacion local siga los siguentes pasos:
   clone el repositorio donde prefiera 

   `git clone https://github.com/juancespinozazumbado/MiniBot-Backend.git`
   
   pocicionece en la carpeta del projectyo (Rooot) `cd src`

   instale las dependencias `dotnet restore`

   ejecute en development `dotnet run src/MiniChatbot.Servicio/MiniChatbot.Servicio.csproj`

   Para desplegar o ejecutar en Debug usando docker 

   `docker-compose build -d .` o `docker-compose up --build`
   