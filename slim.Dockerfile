FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

COPY ./publish .

ENTRYPOINT ["dotnet", "asp_api.dll"]