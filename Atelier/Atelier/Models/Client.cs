using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Client
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public string Request { get; set; }

        public Client() { }

        public Client(string name, string surname, string gender, string request)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Request = request;
        }
    }
}
