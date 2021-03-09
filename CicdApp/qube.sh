

dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /k:"project-key" /d:sonar.host.url="https://sonarqube-pnqi3qjntuz2a.azurewebsites.net": /d:sonar.login="$AZUREQUBETOKEN"
dotnet build
dotnet sonarscanner end /d:sonar.login="$AZUREQUBETOKEN"