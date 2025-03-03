using Sorting.Entities;

var people = new List<Person>
{
    new("John", "Doe", 25),
    new("Alice", "Johnson", 22),
    new("Michael", "Brown", 30),
    new("Emily", "Smith", 27),
    new("Bob", "Williams", 22)
};

// 1. OrderBy
// It orders by name in ascending order.
IOrderedEnumerable<Person> sortedByName = people.OrderBy(p => p.FirstName);
Console.WriteLine("Pessoas ordenadas pelo nome em ordem crescente:");

foreach (Person person in sortedByName)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 2. OrderByDescending
// It orders by name in descending order.
IOrderedEnumerable<Person> sortedByNameDesc = people.OrderByDescending(p => p.FirstName);
Console.WriteLine($"{Environment.NewLine}Pessoas ordenadas pelo nome em ordem decrescente:");

foreach (Person person in sortedByNameDesc)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 3. ThenBy
// It orders by name in ascending order after ordering by age in ascending order.
IOrderedEnumerable<Person> sortedByAgeAndName = people.OrderBy(p => p.Age).ThenBy(p => p.FirstName);
Console.WriteLine($"{Environment.NewLine}Pessoas ordenadas pela idade e depois pelo nome em ordem crescente:");

foreach (Person person in sortedByAgeAndName)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 4. ThenByDescending
// It orders by name in descending order after ordering by age in descending order.
IOrderedEnumerable<Person> sortedByAgeAndNameDesc = people.OrderByDescending(p => p.Age).ThenByDescending(p => p.FirstName);
Console.WriteLine($"{Environment.NewLine}Pessoas ordenadas pela idade e depois pelo nome em ordem decrescente:");

foreach (Person person in sortedByAgeAndNameDesc)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 5. Reverse
// It reverses the list after ordering by age in ascending order (equivalent to sort by age in descending order
// directly)
IEnumerable<Person> reversedList = people.OrderBy(p => p.Age).Reverse();

Console.WriteLine($"{Environment.NewLine}Reverte a ordem da lista após ordenar pela idade:");
foreach (Person person in reversedList)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// It is not recommended to use the Reverse method after the OrderBy or OrderByDescending methods. It can be
// confusing and make the code less readable. It is better to use the OrderBy or OrderByDescending methods directly.