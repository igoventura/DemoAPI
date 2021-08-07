# DemoAPI

## Creating Docker Database

1. Run the docker command below

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=StrongPassword!!" -p 1433:1433 --name mssql -d mcr.microsoft.com/mssql/server:2019-latest
```

2. Run, in order, the scripts from **DemoAPI.Infrastructure.Data\DBScripts\**