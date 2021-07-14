# CodeFirstExample
Application console use Code first .Net Core 3.1. We can learn file migration, generate script sql from file migration, update database, relationship model code first and insert show data. Download File [PPT Code First](https://drive.google.com/file/d/1V4zfItX-hgqjU3HwjF9U8wwXQ9cD83b9/view?usp=sharing) .
## Installation
Use the NuGet Package Manager to project (example : add-migration <title>, update-database, etc). Information all about [tools](https://docs.microsoft.com/en-us/ef/core/cli/powershell)
```bash
Install-Package Microsoft.EntityFrameworkCore.Tools
```
Use the Console **dotnet ef** can be installed as either a global or local tool. Information all about [dotnet ef](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) 
```bash
dotnet tool install --global dotnet-ef
```

## Usage
- Project
  - Add new file migration in project
  ```bash
     Add-migration <Title>
  ```
  - Direct update database in project
  ```bash
     Update-database
  ```
  - Remove file migration in project
  ```bash
     Remove-migration
  ```
- Global
  - Generate file migration project to script SQL
   ```bash
      dotnet ef migrations script -o <Location file generate script> <Filename.sql> -i ( Example: dotnet ef migrations script -o d:\script.sql -i ) 
  ```
## References
- [Entity Framework Core for Code First](https://entityframeworkcore.com/model-relationships)
- [Entity Framework Core Tutorial](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)


