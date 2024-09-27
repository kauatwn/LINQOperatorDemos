using Projection.Entities;

var products = new List<Product>
{
    new() { Id = 1, Name = "Apple", Price = 1.20 },
    new() { Id = 2, Name = "Banana", Price = 2.40 },
    new() { Id = 3, Name = "Cherry", Price = 3.60 }
};

// Simple projection
var productNames = products.Select(p => p.Name);
Console.WriteLine("Projeção simples dos produtos:");

foreach (var name in productNames)
{
    Console.WriteLine($"Nome: {name}");
}

// Complex projection
var productProjection = products.Select(p => new { p.Id, p.Name, p.Price });
Console.WriteLine("\nProjeção complexa dos produtos:");

foreach (var product in productProjection)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}