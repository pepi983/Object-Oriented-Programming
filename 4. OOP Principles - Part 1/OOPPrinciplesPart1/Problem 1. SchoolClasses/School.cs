namespace Schools
{
    using System;
    using System.Collections.Generic;
    using Schools.Disciplines;
    using Schools.ExceptionVerification;
    using Schools.Interfaces;
    using Schools.People;
    using Schools.SchoolClasses;

    public class School
    {
        List<SchoolClass> classes;

        public School()
        {
            this.classes = new List<SchoolClass>();
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return new List<SchoolClass>(this.classes);
            }
            private set
            {
                this.classes = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.Classes.Add(schoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            this.Classes.Remove(schoolClass);
        }
    }
}
