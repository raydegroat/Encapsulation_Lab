using System;

namespace ValidationOfData
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary) //Constructor for class Person
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;

        }

        public string FirstName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name must have at least 3 characters");
                }

                this.firstName = value;
            }
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name must have at least 3 characters");
                }

                this.lastName = value;
            }
            get
            {
                return this.lastName;
            }
        }

        public int Age
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
            }
            get
            {
                return this.age;
            }
        }

        public decimal Salary
        {
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than $460!");
                }
                this.salary = value;
            }
            get
            {
                return this.salary;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{FirstName}, receives {Salary} dollars";
        }
    }
}
