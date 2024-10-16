// 1. Empty
var emptyNumbers = Enumerable.Empty<int>();

if (!emptyNumbers.Any())
{
    Console.WriteLine("A sequência está vazia");
}

// 2. Range
var rangeNumbers = Enumerable.Range(1, 10);

foreach (var number in rangeNumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();

// 3. Repeat
var repeatNumbers = Enumerable.Repeat(2, 5);

foreach (var number in repeatNumbers)
{
    Console.Write(number + " ");
}