cd "C:\Keyhouse-SaaS-WebApp\Keyhouse-SaaS-WebApp\Keyhouse-WebApi"
\\DSRCDEVOPS\SonarScannerCommon\SonarScanner.MSBuild.exe begin /k:Keyhouse_WebApi /n:Keyhouse_WebApi /v:1.1 /d:sonar.login=a8f6c044d66c976d9fbb25efafecbc9c4d4fe7b7 /d:sonar.host.url=http://dsrcdevops:9000  /d:sonar.branch.name=Testing_For_Improvements
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" "C:\Keyhouse-SaaS-WebApp\Keyhouse-SaaS-WebApp\Keyhouse-WebApi\Keyhouse365.WebApi.sln" /t:Rebuild 
\\DSRCDEVOPS\SonarScannerCommon\SonarScanner.MSBuild.exe end  /d:sonar.login=a8f6c044d66c976d9fbb25efafecbc9c4d4fe7b7

