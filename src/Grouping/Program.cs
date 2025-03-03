using Grouping.Entities;
using Grouping.Enums;

var employees = new List<Employee>
{
    new("Alice", Department.HR),
    new("Bob", Department.IT),
    new("Charlie", Department.IT),
    new("David", Department.HR),
    new("Eve", Department.Finance),
    new("Frank", Department.Finance),
    new("Grace", Department.Marketing),
    new("Irene", Department.Marketing),
    new("Henry", Department.Sales),
    new("Jack", Department.Sales)
};

// 1. GroupBy
Console.WriteLine("Accessing all groups with the GroupBy method");
IEnumerable<IGrouping<Department, Employee>> groupedEmployees = employees.GroupBy(e => e.Department);

foreach (IGrouping<Department, Employee> group in groupedEmployees)
{
    Console.WriteLine($"Department: {group.Key}");
    foreach (Employee employee in group)
    {
        Console.WriteLine($"- {employee.Name}");
    }

    Console.WriteLine();
}

// 1.1. GroupBy with element selector. Accessing directly the first group with the key
Console.WriteLine("Accessing directly the Marketing group with the GroupBy method");
IGrouping<Department, string>? financeGroup = employees.GroupBy(e => e.Department, e => e.Name)
    .FirstOrDefault(g => g.Key == Department.Marketing);

if (financeGroup is not null)
{
    Console.WriteLine($"Department: {financeGroup.Key}");
    foreach (string employee in financeGroup)
    {
        Console.WriteLine($"- {employee}");
    }

    Console.WriteLine();
}

// 2. ToLookup
Console.WriteLine("Accessing all groups with the ToLookup method");
ILookup<Department, Employee> lookupEmployees = employees.ToLookup(e => e.Department);

foreach (IGrouping<Department, Employee> group in lookupEmployees)
{
    Console.WriteLine($"Department: {group.Key}");
    foreach (Employee employee in group)
    {
        Console.WriteLine($"- {employee.Name}");
    }

    Console.WriteLine();
}

// 2.1. Accessing directly the first group with the key
Console.WriteLine("Accessing directly the Sales group with the ToLookup method");
Console.WriteLine($"Department: {Department.Sales}");
foreach (Employee group in lookupEmployees[Department.Sales])
{
    Console.WriteLine($"- {group.Name}");
}