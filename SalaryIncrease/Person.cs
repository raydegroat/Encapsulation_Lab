
namespace SalaryIncrease
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
            get { return this.firstName; }
        }

        public string LastName => lastName;

        public int Age => age;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if(this.Age > 30)
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
