using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        Contact (string _name, string _phone)
        {
            Name = _name;
            Phone = _phone;
        }
    }
}
