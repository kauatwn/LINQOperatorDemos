using Filtering.Entities;

var items = new List<object>
{
    new Product(1, "Apple", 1.20),
    new Product(2, "Banana", 2.40),
    new Product(3, "Carrot", 0.80),
    new Product(4, "Lettuce", 1.00),
    new Category(1, "Fruit"),
    new Category(2, "Vegetable")
};

// Filtering
IEnumerable<Product> products = items.OfType<Product>();
Console.WriteLine("Lista de produtos:");

foreach (Product product in products)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}

// Filtering with condition
IEnumerable<Product> expensiveProducts = items.OfType<Product>().Where(p => p.Price > 1.00);
Console.WriteLine($"{Environment.NewLine}Produtos com preço maior que R$ 1,00:");

foreach (Product product in expensiveProducts)
{
    Console.WriteLine($"Id: {product.Id}, Nome: {product.Name}, Preço: {product.Price:C}");
}