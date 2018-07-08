using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.Program;

namespace Delegates
{
    class Program
    {
        public static List<Person> People { get; set; } = new List<Person> {
            new Person
            {
                ID=1,
                Name="Aydin",
                Age=10
            },
            new Person
            {
                ID=2,
                Name="Aysel",
                Age=40,
            },
            new Person{
            ID=3,
            Name="Elshan",
            Age=23
            }
            
        };

        public static List<Computer> Computers = new List<Computer>
        {
            new Computer
            {
                Name="ASUS",
                Price=1000
            },
            new Computer
            {
                Name="MacbookAir",
                Price=2000
            },
            new Computer
            {
                Name="Acer",
                Price=1500
            }

        };
        public delegate bool SearchHandler<T>(T item);

        
        static void Main(string[] args)
        {
            
            //IEnumerable<Person> people = Search(People, new SearchHandler<Person>(
            //    Intermediate1));
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //}
            //IEnumerable<Computer> computers = Search(Computers, new SearchHandler<Computer>(Intermediate2));
            //foreach (Computer computer in computers)
            //{
            //    Console.WriteLine(computer);
            //}


            bool response1 = Computers.MyAll<Computer>(x=> x.Price>=1000);
            Console.WriteLine("response 1 is "+response1);

           
            Computer computer2 = Computers.MyFirstOrDefault();
            Console.WriteLine(computer2);

            Computer computer1 = Computers.MyFirst();
            Console.WriteLine(computer1);

            IEnumerable<Computer> reversedComputers = Computers.MyReverse();
            foreach (Computer item in reversedComputers)
            {
                Console.WriteLine(item);
            }
        }

        private static bool Intermediate2(Computer computer)
        {
            if (computer.Price > 1000)
            {
                return true;
            }
            return false;
        }

        public static bool Intermediate1(Person person)
        {
            if (person.Age > 12)
            {
                return true;
            }
            return false;
        }

        public static IEnumerable<T> Search<T>(IEnumerable<T> items, SearchHandler<T> searchHandler)
        {
            List<T> returnList = new List<T>();
            foreach (T item in items)
            {
                if (searchHandler(item))
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }
    }
}
