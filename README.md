# Real-estate-agency-api
Seminarski rad iz predmeta Razvoj softvera II na temu agencije za nektrenine.

* DOCKER SQL IMAGE https://hub.docker.com/_/microsoft-mssql-server
    docker pull mcr.microsoft.com/mssql/server:2019-latest
    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=RealEstate2021' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

* NUGET Microsoft.Apnetcore.app (db, security, loggng etc)

* EF CORE
    https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

* Automapper https://code-maze.com/automapper-net-core/

* Pristupni podaci:
    Administrator -> Username: Administrator, Password: Adm1n1strat0r
    Agent -> Username: Agent, Password: Agent0007
    Klijent -> Username: Client, Password: Client12#

* Podaci za stripe payment servis:
    Broj krediten kartice: 4242424242424242 (ili bilo koji drug broj kartice sa stranice https://stripe.com/docs/testing)
    CVC: bilo koja 3 broja
