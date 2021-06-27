using System;
using System.Collections.Generic;
using System.Linq;

namespace SQL_CodeFirst_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalContext db = new AnimalContext();

            Animal Charmander = new Animal() { Name = "Charmander", EaterType = "Fire", Species = "Dragon", Age = 13 };
            List<Animal> PokeDex = db.Animals.Add(Charmander).ToList();
            
            Animal m1 = db.Animals.Find(1);
            Console.WriteLine(m1.Name);
            Console.WriteLine(m1.Species);
            Console.WriteLine(m1.EaterType);
        }

        public static void PrintFullList(List<Animal> animals, AnimalContext db)
        {
            foreach(Animal m in animals)
            {
                Console.WriteLine(m.Species);
            }

        }
    }
}
