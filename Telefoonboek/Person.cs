using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    class Person : IPerson
    {
        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;

        }

        public string FirstName {get; set;}
        public string TelephoneNumber { get; set; }
        public string LastName { get; set; }

        string IPerson.FullName
        {
            get { return FirstName + " " + LastName; }
            
        }
    }
}
