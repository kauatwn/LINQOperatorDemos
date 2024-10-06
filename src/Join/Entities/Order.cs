namespace Join.Entities;

internal class Order(int id, int customerId, string product)
{
    public int Id { get; set; } = id;
    public int CustomerId { get; set; } = customerId;
    public string Product { get; set; } = product;
}