using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    class TelephoneBook : ITelephoneBook
    {
        

        public TelephoneBook()
        {
            People = new List<IPerson>();

            Person jesse = new Person("Jesse", "Wijnakker");
            Person rens = new Person("Rens", "Wijnakker");
            Person inge = new Person("Inge", "Wijnakker");
            Person rik = new Person("Rik", "Boer");
            Person dirk = new Person("Dirk", "Dribbel");
            Person henk = new Person("Henk", "Haas");
            Person bart = new Person("Bart", "Butser");
            Person bob = new Person("Bob", "Es");
            Person douwe = new Person("Douwe", "Donder");

            
            People.Add(jesse);
            People.Add(rens);
            People.Add(inge);
            People.Add(rik);
            People.Add(dirk);
            People.Add(henk);
            People.Add(bart);
            People.Add(bob);
            People.Add(douwe);
            
        }

        public IList<IPerson> People { get; set; }
        

        public int Count
        {
            get { return People.Count; }
        }

        public List<IPerson> SortByLastName()
        {
            return People.OrderByDescending(p => p.LastName).ToList();
        }

        public List<IPerson> FirstNameStartWith(char firstChar)
        {
            Console.WriteLine("### Sorted by first name starts with " + firstChar + " ###");
            return People.Where(p => p.FirstName.StartsWith(firstChar + "")).ToList();
        }

        public List<IPerson> LastNameLongerThan(int length)
        {
            Console.WriteLine("### Sorted by length of Lastname bigger than " + length + " ###");
            return People.Where(p => p.LastName.Length > length).ToList();
        }

        public List<IPerson> SortByLastNameLength()
        {
            Console.WriteLine("### Order by length of Lastname ###");
            return People.OrderByDescending(p => p.LastName.Length).ToList();
        }

        
        
    }
}
