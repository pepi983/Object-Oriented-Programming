namespace Schools.Disciplines
{
    using System;
    using Schools.Interfaces;
    using Schools.ExceptionVerification;

    public class Discipline : IName, IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Verification.CheckIfNullOrEmpty(value, "The name of the discipline cannot be empty!");
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                Verification.CheckIfNumberNegative(value, "The lectures cannot be less than 0");
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                Verification.CheckIfNumberNegative(value, "The excersises cannot be less than 0");
                this.numberOfExcercises = value;
            }
        }

        public string Comment { get; set; }
    }
}
