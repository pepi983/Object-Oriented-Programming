namespace Schools.People
{
    using System;
    using Schools.Interfaces;
    using Schools.ExceptionVerification;

    public class Student : Person, IName, IComment
    {
        private int classNumber;

        public Student(string name, int classNumber) : base (name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                Verification.CheckIfNumberNegative(value, "The class number cannot be negative number");
                this.classNumber = value;
            }
        }
    }
}
