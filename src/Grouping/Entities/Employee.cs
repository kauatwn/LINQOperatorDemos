using Grouping.Enums;

namespace Grouping.Entities;

internal class Employee(string name, Department department)
{
    public string Name { get; set; } = name;
    public Department Department { get; set; } = department;
}