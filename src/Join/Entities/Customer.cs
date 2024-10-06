namespace Join.Entities;

internal class Customer(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
}