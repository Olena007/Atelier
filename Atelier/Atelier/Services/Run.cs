using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Services
{
    internal class Run : Services.Info, Interfaces.ICount, Interfaces.ICut
    {
        public void Count(Models.Client client, string[] array)
        {
            int price = 0;

            string[] measure = array[2].Split(' ');
            string[] features = array[3].Split(' ');

            if (client.Request.ToString() == "Штаны")
            {
                price = Convert.ToInt32(measure[0]) * Convert.ToInt32(measure[1]) * Convert.ToInt32(features[2]);
            }
            else if (client.Request.ToString() == "Платье")
            {
                price = (Convert.ToInt32(measure[0]) + 50) * 70 * Convert.ToInt32(features[2]);
            }
            else if (client.Request.ToString() == "Юбка")
            {
                price = Convert.ToInt32(measure[0]) * 50 * Convert.ToInt32(features[2]);
            }
            else if (client.Request.ToString() == "Рубашка")
            {
                price = ((Convert.ToInt32(measure[0]) * 80) + (Convert.ToInt32(measure[1]) * 8)) * Convert.ToInt32(features[2]);
            }

            Console.WriteLine(price);
        }

        public void Cut()
        {
            Console.WriteLine("Замеры сделаны и ткань подготовлена");
        }

        public override void General()
        {
            Console.WriteLine("Пошив закончен");
        }
    }
}
