# testBrandCard

# Ejecucion del proyecto

Para poder ejecutar el proyecto en Docker se debe ejecutar el siguiente comando:
docker-compose up --build -d

# Ejecucion de pruebas

 dotnet test --collect:"XPlat Code Coverage" --settings coverlet.runsettings

 El archivo generado en este paso debe ser copiado al directorio raiz para posteriormente generar el reporte web

Generacion del reporte
Previo a generar el reporte 
reportgenerator -reports:"{path_to_your_project}\coverage.opencover.xml" -targetdir:"coveragereport" -reporttypes:Html
