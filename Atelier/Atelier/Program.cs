using System;

namespace Atelier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Models.Client();
            var measurements = new Models.Measurements();
            var features = new Models.Features();
            var info = new Services.Info();
            var run = new Services.Run();

            Console.WriteLine("Информация о клиенте:");

            Console.Write("Имя: ");
            string name = Console.ReadLine();
            client.Name = name;

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            client.Surname = surname;

            Console.Write("Пол: ");
            string gender = Console.ReadLine();
            client.Gender = gender;

            Console.Write("Запрос одежды: ");
            string request = Console.ReadLine();
            client.Request = request;

            string[] array = new string[4];

            var clientt = new Models.Client(name, surname, gender, request);

            var measure = new Models.Measurements();

            Console.WriteLine("Параметры: ");

            if (client.Request.ToString() == "Штаны")
            {
                Console.Write("Бедра (см): ");
                int hips = Convert.ToInt32(Console.ReadLine());
                measurements.Hips = hips;

                Console.Write("Длина ног (см): ");
                int legs = Convert.ToInt32(Console.ReadLine());
                measurements.LegLength = legs;

                measure = new Models.Measurements(hips, legs, false);
            }
            else if (client.Request.ToString() == "Платье")
            {
                Console.Write("Длина туловища (см): ");
                int torso = Convert.ToInt32(Console.ReadLine());
                measurements.TorsoLength = torso;

                measure = new Models.Measurements(torso, false);
            }
            else if (client.Request.ToString() == "Юбка")
            {
                Console.Write("Бедра (см): ");
                int hips = Convert.ToInt32(Console.ReadLine());
                measurements.Hips = hips;

                measure = new Models.Measurements(hips, true);
            }
            else if (client.Request.ToString() == "Рубашка")
            {
                Console.Write("Длина туловища (см): ");
                int torso = Convert.ToInt32(Console.ReadLine());
                measurements.TorsoLength = torso;

                Console.Write("Длина рукава (см): ");
                int arm = Convert.ToInt32(Console.ReadLine());
                measurements.ArmLength = arm;

                measure = new Models.Measurements(torso, arm, true);
            }

            Console.WriteLine("Характеристики:");

            Console.Write("Тип: ");
            string type = Console.ReadLine();
            features.Type = type;

            Console.Write("Цвет: ");
            string color = Console.ReadLine();
            features.Color = color;

            Console.Write("Метериал: ");
            string material = Console.ReadLine();
            features.Material = material;

            Console.Write("Цена: ");
            int price = Convert.ToInt32(Console.ReadLine());
            features.Price = price;

            var forming = new Models.Forming();
            forming.Add(client, measure, features, array);

            Console.WriteLine("Введите строку для поиска");

            string line = Console.ReadLine();
            Services.SearchExtension.Search(array, line);

            run.Cut();
            info.General();
            run.Count(client, array);
            run.General();
        }
    }
}
