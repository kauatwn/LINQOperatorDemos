namespace Projection.Entities;

internal class Category(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public List<Product> Products { get; set; } = [];
}