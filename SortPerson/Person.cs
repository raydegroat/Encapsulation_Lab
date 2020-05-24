
namespace Sort
{
    public class Person
    {
        private string firstName;  
        private string lastName;   
        private int age;

        public Person(string firstName, string lastName, int age) 
        {

            this.firstName = firstName; // Arguments passed to the Person contructor are copied into the local private class variables.
            this.lastName = lastName;   // The dot notation must be used here to diferentiate them from the args to Person().
            this.age = age;
        }

        public string FirstName  // By convetion, public members begin with a capital letter
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName => lastName;   // No setter is used. Using a function body. => means "return"

        // public int Age { get; set; }           Using an "auto setter". Will it work? I want _age to be returned. Nope. It won't work"

        public int Age => age;

        public override string ToString()
        {
            return $"{FirstName}, {LastName} is {Age} years old"; // Note!: Returning public properties assigned by the accesor
        }                                                         // NOT the backing store variable! 
    }
}
