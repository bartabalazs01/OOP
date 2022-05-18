using System;

namespace MyPersons
{
    namespace Test
    {

    }

}

namespace MyPersons.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person child1 = new("nev2", 9);
            Person adult1 = new("nev3", 32);
            Person person0 = PersonReader();
            Console.WriteLine(person0.GetType());
        }

        static Person PersonReader()    //szemely beolvaso fv.
        {
            Console.Write("Add the person's name: ");
            string name = Console.ReadLine();
            Console.Write("Add the person's age: ");
            int age;
            bool ok;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out age);
            } while (!ok);
            if (age < 18)
            {
                Console.Write("Add the child's school: ");
                string school = Console.ReadLine();
                return new Child(name, age, school);
            }
            else
            {
                Console.Write("Add the adult's workplace: ");
                string workplace = Console.ReadLine();
                return new Adult(name, age, workplace);
            }
        }
    }

}
