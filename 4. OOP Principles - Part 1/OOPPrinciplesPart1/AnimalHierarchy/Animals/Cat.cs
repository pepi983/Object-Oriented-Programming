namespace AnimalHierarchy.Animals 
{
    using System;
    using AnimalHierarchy.Enumerations;
    using AnimalHierarchy.Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("MIAOO");
        }
    }
}
