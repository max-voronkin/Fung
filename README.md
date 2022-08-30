# Fung
Fung is a Fuel accounting system. It`s purpose to accumulate information in one place.

## Applications

- [Backend](./backend) — [.NET 6](https://www.c-sharpcorner.com/article/what-is-new-in-net-6-0/), [PostgreSQL](https://www.postgresql.org).

- [Frontend](./frontend) — [Angular 14](https://angular.io/).

### DB Schema

```mermaid
erDiagram
User ||--o{ Station : Id_UserId
User ||--o{ RefreshToken : Id_UserId
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
  FuelTankId int FK
}

Remaining_Transactions {
  Id int PK
  Volume numeric
  TransactionTime datetime
  FuelTankId int FK
}

RefreshToken {
  Id int PK
  Token string
  Expires datetime
  UserId int FK
}
```