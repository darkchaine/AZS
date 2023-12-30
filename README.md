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
        string Name
        int Number
        string Inn
        string Kpp
    }
  
    Nakladnaya {
        int PlatelshikId
        string Name
        string Summa
    }
  Car ||--o{ Nakladnaya: is
    Car {
        string Marka
        string Model
        string Gos_Number
        string ViN
        int Probeg
    }
 Postavshik ||--o{ Nakladnaya: is
  Postavshik {
    string Name
    int Kpp
    string Adres
    int Number
    int Inn   
    string DoverenoeL
   }
```
