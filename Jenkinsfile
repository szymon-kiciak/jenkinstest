	
pipeline {
agent any
environment {
dotnet = 'C:/Program Files/dotnet/dotnet.exe'
}
stages {
stage ('Checkout') {
steps {
git credentialsId: 'szymon-kiciak', url: 'https://github.com/szymon-kiciak/jenkinstest',branch: 'master'
}
}
stage('Clean') {
steps {
bat 'dotnet clean'
}
}
stage('Build') {
steps {
bat 'dotnet build --configuration Release'
}
}
stage('Pack') {
steps {
bat 'dotnet pack --no-build --output nupkgs'
}
}
}
}
