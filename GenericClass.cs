using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class GenericClass
    {
        public GenericClass()
        {
            Buildings<int> empireState = new Buildings<int>();

            empireState.Name = "My Building";
            empireState.City = "Tbilisi";
        }
    }


    class Buildings<T>
    {
        public string Name { get; set; }
        public string City { get; set; }

    }
}
