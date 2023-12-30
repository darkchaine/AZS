**Кокорев Роман Максимович**
===============================
Группа: ИП-20-7К
-------------------------------
Тема: Web Api-Автозаправки
-------------------------------
![image](https://github.com/dr4matic/AvtoMasterskaya/assets/104574470/5d04d587-85ff-426c-9c6a-be3e79b87db9)
-------------------------------
```mermaid
erDiagram
    Clients ||--o{ Nakladnaya : places
    Clients {
        int id
        string Name
        int Number
        string Address
        int Index
        string Email
    }
  
    Nakladnaya {
        int id
        string Name
        string Description
    }
  Fuel ||--o{ Nakladnaya: is
    Fuel {
        int id
        string Name
        string Edizmer
        int Value
    }
 Postavshik ||--o{ Nakladnaya: is
  Postavshik {
    int id
    string Email
    string name
    string Address
    int Index
    int RS   
   }
```
