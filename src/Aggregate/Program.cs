using Aggregate.Entities;
using Aggregate.Enums;

List<Employee> employees =
[
    new("Alice", 7500.00, Department.IT),
    new("Bob", 5000.00, Department.HR),
    new("Charlie", 6000.00, Department.Finance),
    new("Diana", 8000.00, Department.IT),
    new("Edward", 9000.00, Department.Finance)
];

// 1. Sum
double totalSalaries = employees.Sum(e => e.Salary);
Console.WriteLine($"Salário total de todos os empregados: {totalSalaries:C}");

// 2. Min
double minSalary = employees.Min(e => e.Salary);
Console.WriteLine($"Menor salário de um empregado: {minSalary:C}");

// 3. Max
double maxSalary = employees.Max(e => e.Salary);
Console.WriteLine($"Maior salário de um empregado: {maxSalary:C}");

// 4. Average
double averageSalary = employees.Average(e => e.Salary);
Console.WriteLine($"Salário médio dos empregados: {averageSalary:C}");

// 5. Count
int countOfFinanceEmployees = employees.Count(e => e.Department == Department.Finance);
Console.WriteLine($"Número total de empregados do departamento de finanças: {countOfFinanceEmployees}");

// 6. CountBy
IEnumerable<KeyValuePair<Department, int>> countByDepartment = employees.CountBy(e => e.Department);
foreach ((Department department, int count) in countByDepartment)
{
    Console.WriteLine($"Número total de empregados do departamento {department}: {count}");
}

//// Old way to achieve the same result as CountBy.
//IEnumerable<KeyValuePair<Department, int>> countByDepartment = employees
//    .GroupBy(e => e.Department)
//    .Select(group => new KeyValuePair<Department, int>(group.Key, group.Count()));
//foreach ((Department department, int count) in countByDepartment)
//{
//    Console.WriteLine($"Número total de empregados do departamento {department}: {count}");
//}

// 7. Aggregate
double totalSalariesWithAggregate = employees.Aggregate(0.0, (accumulator, e) => accumulator + e.Salary);
Console.WriteLine($"Salário total de todos os empregados (usando Aggregate): {totalSalariesWithAggregate:C}");

// 8. AggregateBy
IEnumerable<KeyValuePair<Department, double>> totalSalariesByDepartment = employees
    .AggregateBy(e => e.Department, 0.0, (total, e) => total + e.Salary);
foreach ((Department department, double total) in totalSalariesByDepartment)
{
    Console.WriteLine($"Salário total do departamento {department}: {total:C}");
}

//// Old way to achieve the same result as AggregateBy.
//IEnumerable<KeyValuePair<Department, double>> totalSalariesByDepartment = employees
//    .GroupBy(e => e.Department)
//    .Select(group =>
//        new KeyValuePair<Department, double>(group.Key, group.Aggregate(0.0, (total, e) => total + e.Salary)));

//foreach ((Department department, double total) in totalSalariesByDepartment)
//{
//    Console.WriteLine($"Salário total do departamento {department}: {total:C}");
//}