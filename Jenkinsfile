node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def msbuildHome = tool 'MS19'
    def scannerHome = tool 'SONAR SCANNER MS'
    withSonarQubeEnv() {
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" begin /k:\"aravinddsrc_Sonar_Branch\"" /d:sonar.login=\"d37f7b8be381afc0e2100252e2e293dcdaecdbdb\""
      bat "\"${msbuildHome}\\MSBuild.exe\" /t:Rebuild"
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" end"
    }
  }
}
