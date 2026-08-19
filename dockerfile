FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app

COPY bin/Release/net9.0/publish/ .

EXPOSE 8080

ENTRYPOINT ["dotnet","Descision.Api.dll"]

