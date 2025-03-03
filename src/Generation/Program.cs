// 1. Empty
IEnumerable<int> emptyNumbers = Enumerable.Empty<int>();

if (!emptyNumbers.Any())
{
    Console.WriteLine("A sequência está vazia");
}

// 2. Range
IEnumerable<int> rangeNumbers = Enumerable.Range(1, 10);

foreach (int number in rangeNumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();

// 3. Repeat
IEnumerable<int> repeatNumbers = Enumerable.Repeat(2, 5);

foreach (int number in repeatNumbers)
{
    Console.Write(number + " ");
}