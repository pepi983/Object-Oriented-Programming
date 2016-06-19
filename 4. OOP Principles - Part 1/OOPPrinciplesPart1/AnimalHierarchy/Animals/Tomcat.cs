namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy.Enumerations;
    using AnimalHierarchy.Interfaces;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name) : base(age, name, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I Am a Tomcat and i say Miaooo");
        }
    }
}
