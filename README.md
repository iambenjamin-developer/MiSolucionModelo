## Descargar imagen
```
docker pull mcr.microsoft.com/mssql/server:2019-latest
```

## Correr imagen
```
docker run --name sqlserver -p 1450:1433 -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Mypassword*7" -d mcr.microsoft.com/mssql/server:2019-latest
```

## Opciones

-d, --detach    
Run container in background and print container ID

-p, --publish list                   
Publish a container's port(s) to the host

-e, --env list  
Set environment variables

--name string                    
Assign a name to the container

-h, --hostname string                
Container host name

-d, --detach                         
Run container in background and print container ID

===============================================

```
docker rmi -f $(docker images -aq)
```