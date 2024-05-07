var person = new Person("John", "Doe");
var person2 = new Person("John", "Doe", DateTime.Now);

var personService = new PersonService(new PersonRepository());

public class Person(string firstName, string lastName)
{
    public Person(string firstName, string lastName, DateTime birthday) : this(firstName, lastName)
    {
        
    }
    
    public string FirstName { get; } = string.IsNullOrWhiteSpace(firstName)
        ? throw new ArgumentException("First name cannot be empty")
        : firstName;
    public string LastName { get; } = string.IsNullOrWhiteSpace(lastName)
        ? throw new ArgumentException("Last name cannot be empty")
        : lastName;
}

public class PersonService(IPersonRepository personRepository)
{
    public Person GetPerson() => personRepository.GetPerson();
}

public interface IPersonRepository
{
    Person GetPerson();
}

public class PersonRepository : IPersonRepository
{
    public Person GetPerson() => new Person("John", "Doe");
}