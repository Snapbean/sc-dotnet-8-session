using System.Diagnostics.CodeAnalysis;

var p = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Country = "Switzerland"
};

var e = new Employee("John", "Doe", "Developer"); // what about Country?

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
    public required string Country { get; set; }
}

public class Employee : Person
{
    public required string Function { get; set; }

    [SetsRequiredMembers]
    public Employee(string firstName, string lastName, string function)
    {
        FirstName = firstName;
        LastName = lastName;
        Function = function;
    }
}

