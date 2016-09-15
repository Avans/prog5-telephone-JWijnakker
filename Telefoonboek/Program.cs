using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{

    class Program
    {
        static void Main(string[] args)
        {

            //Success met de opdracht!
            TelephoneBook book = new TelephoneBook();
            
            List<IPerson> lastNameBook = book.SortByLastName();
            Console.WriteLine("### Sorted by Lastname ###");
            Print(lastNameBook);

            List<IPerson> firstCharBook = book.FirstNameStartWith('B');
            Print(firstCharBook);

            List<IPerson> lengthBook = book.LastNameLongerThan(5);
            Print(lengthBook);

            List<IPerson> orderLastNameBook = book.SortByLastNameLength();
            Print(orderLastNameBook);
            Console.ReadLine();

        }

        static void Print(List<IPerson> list)
        {
            foreach (IPerson p in list) { Console.WriteLine(p.FullName); }
        }
    }
}
