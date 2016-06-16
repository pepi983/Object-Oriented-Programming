namespace Problem3FirstBeforeLast.Student
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 150;
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string phoneNumber;
        private List<double> marks;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            marks = new List<double>();
        }

        public Student(string firstName, string lastName, int age, int faculcyNumber, string email, int groupNumber, string phoneNumber)
            : this(firstName, lastName, age)
        {
            this.FaculcyNumber = faculcyNumber;
            this.Email = email;
            this.GroupNumber = groupNumber;   
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                CheckIfStrIsNullOrEmpty(value, "First Name");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                CheckIfStrIsNullOrEmpty(value, "Last Name");
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The age cannot be less than {0} or more than {1}", MIN_AGE, MAX_AGE));
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public int FaculcyNumber { get; private set; }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                CheckIfStrIsNullOrEmpty(value, "Email");
                this.email = value;
            }
        }

        public int GroupNumber { get; private set; }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                CheckIfStrIsNullOrEmpty(value, "Phone Number");
                this.phoneNumber = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return new List<double>(this.marks);
            }
            set
            {
                this.marks = new List<double>(value);
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}", this.FirstName, this.LastName);
        }

        public void AddMark(double mark)
        {
            marks.Add(mark);
        }

        public void RemoveMark(double mark)
        {
            marks.Remove(mark);
        }

        private void CheckIfStrIsNullOrEmpty(string strToCheck, string message)
        {
            if (string.IsNullOrEmpty(strToCheck))
            {
                throw new ArgumentNullException(string.Format("The {0} cannot be empty!", message));
            }
        }
    }
}
