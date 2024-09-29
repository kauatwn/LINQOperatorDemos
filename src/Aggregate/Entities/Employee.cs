using Aggregate.Enums;

namespace Aggregate.Entities;

internal class Employee(string name, double salary, Department department)
{
    public string Name { get; } = name;
    public double Salary { get; } = salary;
    public Department Department { get; } = department;
}