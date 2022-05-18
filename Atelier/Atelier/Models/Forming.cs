using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Forming 
    {
        Measurements measurements = new Measurements();

        Features features = new Features();

        public void Add(Client client, Measurements measurements, Features features, string[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    array[i] = $"{client.Surname}";
                }
                else if (i == 1)
                {
                    array[i] = $"{client.Request}";
                }
                else if (i == 2)
                {
                    if (client.Request.ToString() == "Штаны")
                    {
                        array[i] = $"{measurements.Hips} {measurements.LegLength}";
                    }
                    else if (client.Request.ToString() == "Платье")
                    {
                        array[i] = $"{measurements.TorsoLength}";
                    }
                    else if (client.Request.ToString() == "Юбка")
                    {
                        array[i] = $"{measurements.Hips}";
                    }
                    else if (client.Request.ToString() == "Рубашка")
                    {
                        array[i] = $"{measurements.TorsoLength} {measurements.ArmLength}";
                    }
                }
                else if (i == 3)
                {
                    array[i] = $"{features.Color} {features.Material} {features.Price}";
                }
            }
        }
    }
}
