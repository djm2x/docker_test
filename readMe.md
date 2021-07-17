docker build . -t asp_api
docker build --network=host -f ./Dockerfile . -t test

docker run test -p 5000:5000 -p 5001:5001
docker run test -p 5000:5000 -p 5001:5001 -e ASPNETCORE_URLS="http://+:5000;https://+:5001"


docker build --network=host -t test2 .
docker run -it --rm -p 80:8081 --name aspnetcore_sample test
code . --user-data-dir

docker run -ti test2 bash


docker-compose up --build
docker pull mcr.microsoft.com/mssql/server

docker run -d --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=YourStrong@Passw0rd' -p 1433:1433 -v sql-vol2:/var/opt/mssql/data mcr.microsoft.com/mssql/server:2017-latest

sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=123" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server

##inside container sqlserver 
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P '<YourPassword>'

docker exec -it <Container ID or name> /opt/mssql-tools/bin/sqlcmd \
-S localhost -U SA -P '<YourStrong!Passw0rd>' \
-Q 'SELECT @@VERSION'

## How to Stop All Docker Containers
```
docker kill $(docker ps -q)
```

## How to Remove All Docker Containers
```
docker rm $(docker ps -a -q)
```

## sees the docker volumes
```
docker volume ls
```

```
docker inspect volume sql-vol2
```