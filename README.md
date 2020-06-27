# NETCore2.2-Udemy-CleanArchitecture

## Course
Udemy Course
https://www.udemy.com/course/getting-started-with-net-core-clean-architecture/

## Objective
Develop a Project with .NetCore using Clean-Architecture and CQRS.

## AutoMapper
https://automapper.org/

## Structure Folder
- Api
  - Configurations
  - Controllers
- Application
  - AutoMapper
  - Interfaces(services)
  - Services
  - ViewModels
- Domain
  - CommandHandlers
  - Commands
  - Interfaces(repositories)
  - Models
- Domain.Core
  - Bus
  - Commands
  - Events
- Infra.Bus
  - * InMemoryBus(class)
- Infra.Data
   - Context
   - Migrations
   - Repository
- Infra.IoC
   - * Dependency Container(class)
- Presentation (MVC)
   - Configurations
   - Controllers
   - Views
   

