using Conversion.Entities;

// Lista de estudantes
var students = new List<Student>()
{
    new(1, "Alice", 7.5),
    new(2, "Bob", 5.0),
    new(3, "Charlie", 6.0),
    new(4, "Diana", 8.0),
    new(5, "Edward", 9.0)
};

// 1. AsEnumerable
var enumerableStudents = students.AsEnumerable();
Console.WriteLine("Lista convertida para IEnumerable:");
foreach (var student in enumerableStudents)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 2. AsQueryable
var queryableStudents = students.AsQueryable();
var query = queryableStudents.Where(s => s.Grade > 7.0);
Console.WriteLine("Lista convertida para IQueryable:");
foreach (var student in query)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 3. Cast
var castedStudents = students.Cast<Student>();
Console.WriteLine("Lista convertida para IEnumerable<Student> usando Cast:");
foreach (var student in castedStudents)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 4. OfType
var mixedStudents = new List<object>
{
    new Student(1, "Alice", 7.5),
    "Not a student",
    new Student(2, "Bob", 5.0),
    12345
};

var studentsOnly = mixedStudents.OfType<Student>();
Console.WriteLine("Filtrando apenas objetos do tipo Student usando OfType:");
foreach (var student in studentsOnly)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 5. ToArray
var studentArray = students.ToArray();
Console.WriteLine("Lista convertida para array:");
foreach (var student in studentArray)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 6. ToDictionary
var studentDictionary = students.ToDictionary(s => s.Id);
Console.WriteLine("Lista convertida para Dictionary:");
foreach (var kvp in studentDictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

Console.WriteLine();

// 7. ToList
var studentList = students.ToList();
Console.WriteLine("Lista convertida para List:");
foreach (var student in studentList)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 8. ToLookup
var studentLookup = students.ToLookup(s => s.Grade > 7.0 ? "Aprovados" : "Reprovados");
Console.WriteLine("Lista convertida para Lookup:");
foreach (var group in studentLookup)
{
    Console.WriteLine($"{group.Key}:");
    foreach (var student in group)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
    }

    Console.WriteLine();
}