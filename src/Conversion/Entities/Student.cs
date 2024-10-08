namespace Conversion.Entities;

internal class Student(int id, string name, double grade)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public double Grade { get; set; } = grade;
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
    }
}