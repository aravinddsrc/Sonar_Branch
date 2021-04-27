node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def msbuildHome = tool 'MS19'
    def scannerHome = tool 'SONAR SCANNER MS'
    withSonarQubeEnv() {
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" begin /k:\"aravinddsrc_Sonar_Branch\" /d:sonar.login=d37f7b8be381afc0e2100252e2e293dcdaecdbdb /d:sonar.branch.name=$BRANCH_NAME /d:sonar.pullrequest.provider=GitHub /d:sonar.pullrequest.github.repository=$org/$repo /d:sonar.pullrequest.key=$env.CHANGE_ID /d:sonar.pullrequest.branch=$env.CHANGE_BRANCH"  
      bat "\"${msbuildHome}\\MSBuild.exe\" /t:Rebuild"
      bat "\"${scannerHome}\\SonarScanner.MSBuild.exe\" end /d:sonar.login=d37f7b8be381afc0e2100252e2e293dcdaecdbdb"
    }
  }
}
