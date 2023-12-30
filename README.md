**Кокорев Роман Максимович**
===============================
Группа: ИП-20-7К
-------------------------------
Тема: Web Api-Автозаправки
-------------------------------
![image](https://github.com/darkchaine/AZS/assets/48962624/b5b713bf-e23e-4540-8e11-aba599fe5806)
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
