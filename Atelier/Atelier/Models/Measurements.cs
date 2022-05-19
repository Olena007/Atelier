using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Measurements
    {
        public int Chest { get; set; }

        public int Waist { get; set; }

        public int Hips { get; set; }

        public int LegLength { get; set; }

        public int ArmLength { get; set; }

        public int TorsoLength { get; set; }

        public Measurements() { }

        public Measurements(int first, int sec, bool fact)
        {
            if (fact == false)
            {
                this.Hips = first;
                this.LegLength = sec;
            }
            else if (fact == true)
            {
                this.TorsoLength = first;
                this.ArmLength = sec;
            }
        }

        public Measurements(int first, bool fact)
        {
            if (fact == false)
            {
                this.TorsoLength = first;
            }
            else if (fact = true)
            {
                this.Hips = first;
            }
        }
    }
}
