using Filtering.Entities;

var items = new List<object>
{
    new Product { Id = 1, Name = "Apple", Price = 1.20 },
    new Product { Id = 2, Name = "Banana", Price = 2.40 },
    new Product { Id = 3, Name = "Carrot", Price = 0.80 },
    new Product { Id = 4, Name = "Lettuce", Price = 1.00 },
    new Category { Id = 1, Name = "Fruit" },
    new Category { Id = 2, Name = "Vegetable" }
};

// Filtering
var products = items.OfType<Product>();
Console.WriteLine("Lista de produtos:");

foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}

// Filtering with condition
var expensiveProducts = items.OfType<Product>().Where(p => p.Price > 1.00);
Console.WriteLine("\nProdutos com preço maior que R$ 1,00:");

foreach (var product in expensiveProducts)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}