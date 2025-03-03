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

// To union, the lists must be equal. The Union method requires Equals and GetHashCode methods for duplicate comparison
// or the use of Select to extract the desired properties.
List<Department> employeeDepartments = employees.Select(e => e.Department).ToList();
List<Department> projectDepartments = projects.Select(p => p.Department).ToList();

// 1. Union
IEnumerable<Department> allDepartments = employeeDepartments.Union(projectDepartments);
Console.WriteLine("Unindo os departamentos de empregados e projetos:");

foreach (Department department in allDepartments)
{
    Console.WriteLine(department);
}

// 2. Intersect
IEnumerable<Department> departmentsWithProjects = employeeDepartments.Intersect(projectDepartments);
Console.WriteLine($"{Environment.NewLine}Departamentos que se intersectam entre empregados e projetos:");

foreach (Department department in departmentsWithProjects)
{
    Console.WriteLine(department);
}

// 3. Except
IEnumerable<Department> departmentsWithoutProjects = employeeDepartments.Except(projectDepartments);
Console.WriteLine($"{Environment.NewLine}Departamentos com empregados, exceto os que têm projetos:");

foreach (Department department in departmentsWithoutProjects)
{
    Console.WriteLine(department);
}

// 4. Distinct
IEnumerable<Department> departments = employeeDepartments.Distinct();
Console.WriteLine($"{Environment.NewLine}Departamentos de empregados:");

foreach (Department department in departments)
{
    Console.WriteLine(department);
}

// 5. Concat
