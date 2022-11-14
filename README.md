# Fung
Fung is a fuel accounting system. Its goal is to accumulate information from fuel stations in one place, instead of an impressive number of report files, which makes it faster and easier to get the information you need. The data are statistics of fuel residues and indicators of level gauges in real-time.

The system consists of three parts:
- Server (for storing information)
- Front (to access information)
- WPF Application (for transmitting data from the station)

## Applications

- [Backend](./backend) — [.NET 6](https://www.c-sharpcorner.com/article/what-is-new-in-net-6-0/), [PostgreSQL](https://www.postgresql.org).

- [Frontend](./frontend) — [Angular 14](https://angular.io/).

### DB Schema
[dbdiagram.io](https://dbdiagram.io/d/62fe6a1cc2d9cf52fad335c9)

```mermaid
erDiagram
User ||--o{ Station : Id_UserId
User ||--o{ Token : Id_UserId
User ||--|| Settings : Id_UserId
User {
  Id int PK
  Email string
  Password string
  Salt string
  IsEmailConfirmed boolean
  CreatedAt datetime
}

Station ||--o{ FuelTank : Id_StationId
Station {
  Id int PK
  Name string
  Token sting
  UserId int FK
}

FuelTank ||--o{ LevelIndicator_Transactions : Id_FuelTankId
FuelTank ||--o{ Remaining_Transactions : Id_FuelTankId
FuelTank {
  Id int PK
  Name string
  Number int
  Capacity numeric
  CurrentAmount numeric
  StationId int FK
  UpdatedAt datetime
}

LevelIndicator_Transactions {
  Id int PK
  Height numeric
  Temperature numeric
  Volume numeric
  Density numeric
  TransactionTime datetime
  CreatedAt datetime
  FuelTankId int FK
}

Remaining_Transactions {
  Id int PK
  Volume numeric
  TransactionTime datetime
  CreatedAt datetime
  FuelTankId int FK
}

Token {
  Id int PK
  Value string
  Expires datetime
  UserId int FK
  Type int
}

Settings {
  Id int PK
  HeightUnits int
  VolumeUnits int
  UserId int FK
}
```