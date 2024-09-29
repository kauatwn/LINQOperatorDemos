using Set.Enums;

namespace Set.Entities;

internal class Project(string name, Department department)
{
    public string Name { get; } = name;
    public Department Department { get; } = department;
}