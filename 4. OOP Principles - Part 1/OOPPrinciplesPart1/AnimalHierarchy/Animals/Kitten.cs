namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy.Enumerations;
    using AnimalHierarchy.Interfaces;

    public class Kitten : Animal, ISound
    {
        public Kitten(int age, string name) : base(age, name, Gender.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I Am a Kitten and i say Miaooo");
        }
    }
}
