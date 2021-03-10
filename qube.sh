

dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /k:"project-key" /d:sonar.host.url="https://sonarqube-pnqi3qjntuz2a.azurewebsites.net": /d:sonar.login="$(AZUREQUBETOKEN)" /d:sonar.cs.opencover.reportsPaths="/home/vsts/work/1/s/CicdAppTests/TestResults/coverage.opencover.xml" /d:sonar.cs.vstest.reportsPaths="/home/vsts/work/1/s/CicdAppTests/TestResults/results.trx"
dotnet build CicdApp/*.csproj && dotnet test CicdAppTests/*.csproj -l:"trx;LogFileName=results.trx" /p:CollectCoverage=true /p:CoverletOutput=TestResults/ /p:CoverletOutputFormat=opencover
dotnet sonarscanner end /d:sonar.login="$(AZUREQUBETOKEN)"