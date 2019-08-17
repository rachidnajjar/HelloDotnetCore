# HelloDotnetCore

Hello world application using dotnet core

1. Créer le repository dans github
2. Cloner le repository sur son poste de travail
3. Créer l'application console :
    - dotnet new console
4. Installer le package EF Core :
    - dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    - dotnet add package Microsoft.EntityFrameworkCore.Design
5. Créer les classes models
6. Créer la base de données :
    - dotnet ef migrations add InitialCreate (pour créer la migration initiale)
    - dotnet ef database update
7. Modifier la base de données :
    - dotnet ef migrations add (pour créer une nouvelle migration)
    - dotnet ef database update
