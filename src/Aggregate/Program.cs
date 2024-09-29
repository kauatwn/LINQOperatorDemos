using Aggregate.Entities;
using Aggregate.Enums;

var employees = new List<Employee>
{
    new("Alice", 7500.00, Department.IT),
    new("Bob", 5000.00, Department.HR),
    new("Charlie", 6000.00, Department.Finance),
    new("Diana", 8000.00, Department.IT),
    new("Edward", 9000.00, Department.Finance)
};

// 1. Sum
var totalSalaries = employees.Sum(e => e.Salary);
Console.WriteLine($"Salário total de todos os empregados: {totalSalaries:C}");

// 2. Min
var minSalary = employees.Min(e => e.Salary);
Console.WriteLine($"Menor salário de um empregado: {minSalary:C}");

// 3. Max
var maxSalary = employees.Max(e => e.Salary);
Console.WriteLine($"Maior salário de um empregado: {maxSalary:C}");

// 4. Average
var averageSalary = employees.Average(e => e.Salary);
Console.WriteLine($"Salário médio dos empregados: {averageSalary:C}");

// 5. Count
var countOfFinanceEmployees = employees.Count(e => e.Department == Department.Finance);
Console.WriteLine($"Número total de empregados do departamento de finanças: {countOfFinanceEmployees}");