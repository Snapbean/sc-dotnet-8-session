using To = string[];
using Cc = string[];
using Bcc = string[];

using PersonId = System.Guid;
using AddressId = System.Guid;
using Person = (string firstName, string lastName);
using IsMember = bool;

SendMail(["a"], ["b"], ["c"]);

void SendMail(To to, Cc cc, Bcc bcc)
{
    
}

PersonId id = Guid.NewGuid();
DisplayPerson(id, ("John", "Doe"), true);

AddressId addressId = Guid.NewGuid();
DisplayPerson(addressId, ("John", "Doe"), true); // funktioniert auch, keine Discriminated Unions!

void DisplayPersonOldWay(Guid id, (string firstName, string lastName) person, bool isMember)
{
    Console.WriteLine($"{person.firstName} {person.lastName}. Member: {isMember}. Id: {id}");
}

void DisplayPerson(PersonId id, Person person, IsMember isMember)
{
    Console.WriteLine($"{person.firstName} {person.lastName}. Member: {isMember}. Id: {id}");
}


/* Beispiel FSharp Discriminated Unions

type PersonId = PersonId of int
type AddressId = AddressId of int

let getPerson(personId: PersonId) =
   "John Doe"

let personId = PersonId 12345
getPerson personId |> ignore

getPerson 7777 |> ignore // kompiliert nicht

let addressId = AddressId 8888
getPerson addressId |> ignore // kompiliert nicht

*/