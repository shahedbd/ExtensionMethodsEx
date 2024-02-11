using ExtensionMethodsEx;

string input = "hello, world! sudo apt install dotnet-sdk-8.0";
string titleCase = input.ToTitleCaseNew();
Console.WriteLine(titleCase);  // Output: Hello, World! Sudo Apt Install Dotnet-Sdk-8.0


List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "John" },
                new Person { Id = 2, Name = "Jane" },
                new Person { Id = 1, Name = "John" }, // Duplicate Id
                new Person { Id = 3, Name = "Alice" }
            };

IEnumerable<Person> distinctPeople = people.DistinctByCustom(p => p.Id);
foreach (Person person in distinctPeople)
{
    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
}



