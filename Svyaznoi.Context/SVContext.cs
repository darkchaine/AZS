using Svyaznoi.Context.Contracts.Models;
using System.Xml.Linq;

namespace Svyaznoi.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Client> clients;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Fuel> fuels;

        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            clients = new HashSet<Client>();
            postavshiks = new HashSet<Postavshik>();
            fuels = new HashSet<Fuel>();
            Seed();
        }

        public ICollection<Client> Clients => clients;

        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Fuel> Fuels => fuels;

        public ICollection<Postavshik> Postavshiks => postavshiks;


      

        void IContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "ilya@mail.ru",
                Name = "Илья",
                Adres = "Санкт-Петербург, ул. Тореза 47",
                Index = 147318,
                Inn = 1234567812,
                RS = 43434234
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "goloand@mail.ru",
                Name = "Голанд",
                Adres = "Санкт-Петербург, ул. Ленина 28",
                Index = 112334,
                Inn = 1235675,
                RS = 4575674
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Паша",
                Number = 799102950,
                Address = "Бугры, ул. Победы 23",
                Index = 8757874,
                Email = "chekjopa@mail.ru"
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Эндрю",
                Number = 793202950,
                Address = "СПБ, ул. Коменданского 78",
                Index = 87433874,
                Email = "polovnik@mail.ru"
            });
            Clients.Add(new Client
            {
                Id = Guid.NewGuid(),
                Name = "Тимурка",
                Number = 799454950,
                Address = "СПБ, пр. Тореза 43",
                Index = 813134,
                Email = "kukold@mail.ru"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ИП ЖОПА",
                Description = "Накладная № 124234121376 от «18» Ноября 2023г.\r\nПродавец: ООО Павленко, ИНН 12121213124\r\nАдрес продавца: Тореза 40\r\nПокупатель: ИП Логинов, ИНН 12121213124, КПП 342423\r\nАдрес покупателя: Науки"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ОАО ШВЕЕЕЕЕПС",
                Description = "Накладная № 124234123232 от «19» Ноября 2023г.\r\nПродавец: ООО Павленко, ИНН 123313433124\r\nАдрес продавца: Ленина 43\r\nПокупатель: ООО Криуленко, ИНН 123313433124, КПП 342332\r\nАдрес покупателя: Лакшери"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ООО БЕЛГОРОДСКОЕ БРЕВНО",
                Description = "Накладная № 124231233232 от «20» Ноября 2023г.\nПродавец: ООО Рукенглаз, ИНН 14434566324\nАдрес продавца: Лисичанск 10\nПокупатель: ИП РИКОН, ИНН 14434566324, КПП 3423232\nАдрес покупателя: Болотная"
            });
            Fuels.Add(new Fuel
            {
                Id = Guid.NewGuid(),
                Name = "95",
                Edizmer = "Литр",
                Value = 55
            });
            Fuels.Add(new Fuel
            {
                Id = Guid.NewGuid(),
                Name = "92",
                Edizmer = "Литр",
                Value = 50
            });
            Fuels.Add(new Fuel
            {
                Id = Guid.NewGuid(),
                Name = "ДТ",
                Edizmer = "Литр",
                Value = 65
            });
            Fuels.Add(new Fuel
            {
                Id = Guid.NewGuid(),
                Name = "100",
                Edizmer = "Литр",
                Value = 60
            });
        }
    }
}
