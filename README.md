# testBrandCard

##VERSION NUEVA DEL PROYECTO YA QUE ESTE PROYECTO NO SUFRIRA NINGUN CAMBIO EN EL FUTURO. EL ENLACE AL NUEVO ES: https://github.com/elunadanilo/TestCarBrand.git

# Ejecucion del proyecto

Para poder ejecutar el proyecto en Docker se debe ejecutar el siguiente comando:
docker-compose up --build -d

# Ejecucion de pruebas

 dotnet test --collect:"XPlat Code Coverage" --settings coverlet.runsettings

 El archivo generado en este paso debe ser copiado al directorio raiz para posteriormente generar el reporte web

Generacion del reporte
Previo a generar el reporte 
reportgenerator -reports:"{path_to_your_project}\coverage.opencover.xml" -targetdir:"coveragereport" -reporttypes:Html

#Alcance de cobertura de pruebas
Actualmente cubre el 100%
![Imagen de WhatsApp 2024-05-09 a las 15 00 42_324c0c39](https://github.com/elunadanilo/testBrandCard/assets/60908456/5c7cc00a-81c5-42f0-be79-1937f42709cc)

#Verificacion
Al ejecutar el comando compose debera aparecerte un status similar en tu DockerDesktop
![image](https://github.com/elunadanilo/testBrandCard/assets/60908456/6054c5b7-8a8c-4c90-9395-561d58e0d619)
Posteriormente puedes acceder a la api por medio de http://localhost:5434/swagger/index.html 
![image](https://github.com/elunadanilo/testBrandCard/assets/60908456/da870935-486c-445b-acfe-fd7bdbf5197d)
