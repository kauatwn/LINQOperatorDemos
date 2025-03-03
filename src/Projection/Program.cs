using Projection.Entities;

var products = new List<Product>
{
    new(1, "Apple", 1.20),
    new(2, "Banana", 2.40),
    new(3, "Cherry", 3.60)
};

// Simple projection
IEnumerable<string> productNames = products.Select(p => p.Name);
Console.WriteLine("Projeção simples dos produtos:");

foreach (string name in productNames)
{
    Console.WriteLine($"Nome: {name}");
}

// Complex projection
var productProjection = products.Select(p => new { p.Id, p.Name, p.Price });
Console.WriteLine($"{Environment.NewLine}Projeção complexa dos produtos:");

foreach (var product in productProjection)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}

var categories = new List<Category>
{
    new(1, "Fruit") { Products = products },
    new(2, "Vegetable")
    {
        Products =
        [
            new Product(4, "Carrot", 0.80),
            new Product(5, "Lettuce", 1.00)
        ]
    }
};

// Nested projection
IEnumerable<Product> allProducts = categories.SelectMany(c => c.Products);
Console.WriteLine($"{Environment.NewLine}Todos os produtos de todas as categorias:");

foreach (Product product in allProducts)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}