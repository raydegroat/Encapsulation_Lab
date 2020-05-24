using System;

public class Person  // For Teams
{
    private string firstName;
    private int age;

    public Person(string firstName, int age)
    {
        this.firstName = firstName;
        this.age = age;
    }

    private string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }

            this.firstName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
    }
}