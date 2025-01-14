COMANDOS LINUX

CRIAR DIRETÓRIOS:
mkdir -p 01-consoleapp/scripts

CRIAR ARQUIVOS
touch devel-workfile.sh

Mostrar as dependencias
tree

Tutorial consoleapp
dotnet --help

.Net comandos
dotnet --info
dotnet new list (lista possibilidades de projetos)

dotnet new solution --name consoleapp (cria a solução do projeto)
dotnet new console --name consoleapp (cria um projeto console)

dotnet sln  consoleapp.sln add consoleapp/ (adiciona um projeto a uma solução)

dotnet clean
dotnet restore
dotnet build

# Create test project (xUnit)
dotnet new list | grep -i test
dotnet new xunit --name consoleapptst

dotnet sln consoleapp.sln add consoleapptst/

# Add reference project to another project
cd consoleapptst/
dotnet add reference ../consoleapp/consoleapp.csproj



