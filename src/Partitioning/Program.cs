using Partitioning.Entities;

var products = new List<Product>
{
    new(1, "Keyboard", 49.99),
    new(2, "Monitor", 199.99),
    new(3, "Headphones", 299.99),
    new(4, "Tablet", 499.99),
    new(5, "Smartphone", 799.99),
    new(6, "Laptop", 999.99)
};

// 1. Take
// It takes the first 3 products.
IEnumerable<Product> firstThree = products.Take(3);
Console.WriteLine("Take result: ");
foreach (Product product in firstThree)
{
    Console.WriteLine(product);
}
Console.WriteLine();

// 2. Skip
// It skips the first 3 products.
IEnumerable<Product> skipThree = products.Skip(3);
Console.WriteLine("Skip result:");
foreach (Product product in skipThree)
{
    Console.WriteLine(product);
}
Console.WriteLine();

// 3. TakeWhile
// It takes the products while the price is less than 500. It stops taking immediately when an item does not meet the
// condition, returning the items collected up to that point, even if subsequent items in the list meet the condition.
IEnumerable<Product> takeWhile = products.TakeWhile(p => p.Price < 500);
Console.WriteLine("TakeWhile result:");
foreach (Product product in takeWhile)
{
    Console.WriteLine(product);
}
Console.WriteLine();

// 4. SkipWhile
// It skips the products while the price is less than 500. It stops skipping immediately when an item does not meet the
// condition, including all subsequent items in the list regardless of whether they meet the condition or not.
IEnumerable<Product> skipWhile = products.SkipWhile(p => p.Price < 500);
Console.WriteLine("SkipWhile result:");
foreach (Product product in skipWhile)
{
    Console.WriteLine(product);
}