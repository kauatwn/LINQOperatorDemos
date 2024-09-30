namespace Element.Entities;

internal class Customer(int id, string name, int age)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}