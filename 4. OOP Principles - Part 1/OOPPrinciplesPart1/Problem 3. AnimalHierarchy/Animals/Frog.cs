namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy.Enumerations;
    using AnimalHierarchy.Interfaces;

    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("KWAK");
        }
    }
}
