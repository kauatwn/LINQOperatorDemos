using Quantifier.Entities;

var products = new List<Product>
{
    new("Apple iPhone 15", 7599.00, 20),
    new("Samsung Galaxy S23", 5999.00, 10),
    new("PlayStation 5", 4199.00, 5),
    new("Xbox Series X", 4999.00, 0)
};

// 1. Any
bool anyInStock = products.Any(p => p.Stock > 0);
Console.WriteLine($"Existe algum produto em estoque? {anyInStock}");

// 2. All
bool allInStock = products.All(p => p.Stock > 0);
Console.WriteLine($"Todos os produtos estão em estoque? {allInStock}");

// 3. Contains
const string productToCheck = "Apple iPhone 15";
bool containsProduct = products.Select(p => p.Name).Contains(productToCheck);
Console.WriteLine($"O produto '{productToCheck}' está na lista? {containsProduct}");