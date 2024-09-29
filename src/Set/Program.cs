using Set.Entities;
using Set.Enums;

var employees = new List<Employee>
{
    new("John", 4000.0, Department.IT),
    new("Jane", 5000.0, Department.Finance),
    new("Alice", 3000.0, Department.HR),
    new("Bob", 4500.0, Department.IT)
};

var projects = new List<Project>
{
    new("Campanha de Lançamento de Produto", Department.Marketing),
    new("Aprimoramento de CRM", Department.Sales),
    new("Desenvolvimento de Aplicativos", Department.IT)
};

// To union, the lists must be equal
// Union requires Equals and GetHashCode for duplicate comparison or the use of Select to extract the desired properties
var employeeDepartments = employees.Select(e => e.Department).ToList();
var projectDepartments = projects.Select(p => p.Department).ToList();

// 1. Union
var allDepartments = employeeDepartments.Union(projectDepartments);
Console.WriteLine("Unindo os departamentos de empregados e projetos:");

foreach (var department in allDepartments)
{
    Console.WriteLine(department);
}

// 2. Intersect
var departmentsWithProjects = employeeDepartments.Intersect(projectDepartments);
Console.WriteLine("\nDepartamentos que se intersectam entre empregados e projetos:");

foreach (var department in departmentsWithProjects)
{
    Console.WriteLine(department);
}

// 3. Except
var departmentsWithoutProjects = employeeDepartments.Except(projectDepartments);
Console.WriteLine("\nDepartamentos com empregados, exceto os que têm projetos:");

foreach (var department in departmentsWithoutProjects)
{
    Console.WriteLine(department);
}

// 4. Distinct
var departments = employeeDepartments.Distinct();
Console.WriteLine("\nDepartamentos de empregados:");

foreach (var department in departments)
{
    Console.WriteLine(department);
}