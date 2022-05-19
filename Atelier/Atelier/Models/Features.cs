using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Features
    {
        public string Type { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }

        public int Price { get; set; }

        public Features() { }

        public Features(string type, string color, string material, int price)
        {
            this.Type = type;
            this.Color = color;
            this.Material = material;
            this.Price = price;
        }
    }
}
