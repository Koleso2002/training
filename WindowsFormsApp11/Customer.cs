using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Customer
    {
        private readonly string _name;
        public string Name { get => _name; }

        public Customer(string name)
        {
            _name = name;
        }

    }
}
