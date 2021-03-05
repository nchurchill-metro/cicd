FROM mcr.microsoft.com/dotnet/sdk:3.1.406-focal


ENV ASPNETCORE_URLS="http://+:80"

COPY CicdApp/bin/Debug/netcoreapp3.1/linux-x64/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "CicdApp.dll"]
