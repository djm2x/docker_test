docker build . -t asp_api
docker build --network=host -f ./Dockerfile . -t test

docker run test -p 5000:5000 -p 5001:5001
docker run test -p 5000:5000 -p 5001:5001 -e ASPNETCORE_URLS="http://+:5000;https://+:5001"


docker build --network=host -t test2 .
docker run -it --rm -p 80:8081 --name aspnetcore_sample test


docker run -ti test2 bash


docker-compose up --build
docker pull mcr.microsoft.com/mssql/server

docker run -d --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123' -p 1433:1433 mcr.microsoft.com/mssql/server -v sqldata1:/var/opt/mssql

##inside container sqlserver 
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P '<YourPassword>'

docker exec -it <Container ID or name> /opt/mssql-tools/bin/sqlcmd \
-S localhost -U SA -P '<YourStrong!Passw0rd>' \
-Q 'SELECT @@VERSION'