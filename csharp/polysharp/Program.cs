using System;
using IsMember = bool;

namespace PolySharpSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("foo", "bar");

            var person = new Person("John", "Doe");

            int[] array = [1, 2, 3];

            var IncrementBy = (int source, int increment = 1) => source + increment;

            IsMember isMember = true;
        }
    }

    public record Address(string Street, string City);

    public class Person(string firstName, string lastName)
    {
        public string FirstName { get; } = string.IsNullOrWhiteSpace(firstName)
            ? throw new ArgumentException("First name cannot be empty")
            : firstName;
        public string LastName { get; } = string.IsNullOrWhiteSpace(lastName)
            ? throw new ArgumentException("Last name cannot be empty")
            : lastName;
    }
}
