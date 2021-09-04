using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class PersonClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public PersonClass()
        {
            Id = 1;
            Name = "DefaultName";
            BirthDate = DateTime.Now;
        }

    }
}
