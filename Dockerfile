FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
# coming from outside
EXPOSE 5000
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["asp_api.csproj", "./"]
RUN dotnet restore 
#"asp_api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "asp_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asp_api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# COPY './entrypoint.sh' .

ENTRYPOINT ["dotnet", "asp_api.dll"]

# RUN chmod +x ./entrypoint.sh
# CMD /bin/bash ./entrypoint.sh