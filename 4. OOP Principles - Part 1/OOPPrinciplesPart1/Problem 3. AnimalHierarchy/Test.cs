namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AnimalHierarchy.Animals;
    using AnimalHierarchy.Enumerations;

    class Test
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat(5, "Grry", Gender.Male));
            animals.Add(new Dog(12, "Puhcho", Gender.Male));
            animals.Add(new Frog(2, "Froggy", Gender.Other));
            animals.Add(new Kitten(3, "Grry"));
            animals.Add(new Tomcat(7, "Grry"));

            var avarageAge = animals.Sum(x => x.Age) / (double)animals.Count;
            Console.WriteLine("Avarage age: " + avarageAge);
        }
    }
}
