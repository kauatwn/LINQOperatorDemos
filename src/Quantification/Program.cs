using Quantification.Entities;

var products = new List<Product>
{
    new("Apple iPhone 15", 7599.00, 20),
    new("Samsung Galaxy S23", 5999.00, 10),
    new("PlayStation 5", 4199.00, 5),
    new("Xbox Series X", 4999.00, 0)
};

var anyInStock = products.Any(p => p.Stock > 0);
Console.WriteLine($"Existe algum produto em estoque? {anyInStock}");

var allInStock = products.All(p => p.Stock > 0);
Console.WriteLine($"Todos os produtos estão em estoque? {allInStock}");

var expensiveProducts = products.Count(p => p.Price > 5000);
Console.WriteLine($"Número de produtos com preço maior que R$ 5.000,00: {expensiveProducts}");

var totalPrices = products.Sum(p => p.Price);
Console.WriteLine($"Preço total de todos os produtos: {totalPrices:C}");

var averagePrices = products.Average(p => p.Price);
Console.WriteLine($"Preço médio dos produtos: {averagePrices:C}");