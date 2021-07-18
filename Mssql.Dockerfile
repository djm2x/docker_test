FROM mcr.microsoft.com/mssql/server:2017-latest AS base
EXPOSE 1433

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrong@Passw0rd
ENV SSQL_PID=Express

# COPY . .
# COPY ["Db/Scripts/*", "Db/Scripts/"]
VOLUME sql_server_data:/var/opt/mssql/data

# HEALTHCHECK --interval=10s --timeout=5s --start-period=10s --retries=10 \
#     CMD /opt/mssql-tools/bin/sqlcmd -S . -U sa -P Password123 -i Db/Scripts/SetupDb.sql || exit 1