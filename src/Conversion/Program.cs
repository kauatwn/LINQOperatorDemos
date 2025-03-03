using Conversion.Entities;

// Lista de estudantes
var students = new List<Student>
{
    new(1, "Alice", 7.5),
    new(2, "Bob", 5.0),
    new(3, "Charlie", 6.0),
    new(4, "Diana", 8.0),
    new(5, "Edward", 9.0)
};

// 1. AsEnumerable
IEnumerable<Student> enumerableStudents = students.AsEnumerable();
Console.WriteLine("Lista convertida para IEnumerable:");
foreach (Student student in enumerableStudents)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 2. AsQueryable
IQueryable<Student> queryableStudents = students.AsQueryable();
IQueryable<Student> query = queryableStudents.Where(s => s.Grade > 7.0);
Console.WriteLine("Lista convertida para IQueryable:");
foreach (Student student in query)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 3. Cast
// Casting explícito (redundante)
IEnumerable<Student> castedStudents = students.Cast<Student>();

// // Casting implícito (não redundante)
// IEnumerable<Student> castedStudents = students;
Console.WriteLine("Lista convertida para IEnumerable<Student> usando Cast:");
foreach (Student? student in castedStudents)
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

IEnumerable<Student> studentsOnly = mixedStudents.OfType<Student>();
Console.WriteLine("Filtrando apenas objetos do tipo Student usando OfType:");
foreach (Student student in studentsOnly)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 5. ToArray
Student[] studentArray = students.ToArray();
Console.WriteLine("Lista convertida para array:");
foreach (Student student in studentArray)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 6. ToDictionary
Dictionary<int, Student> studentDictionary = students.ToDictionary(s => s.Id);
Console.WriteLine("Lista convertida para Dictionary:");
foreach (KeyValuePair<int, Student> kvp in studentDictionary)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

Console.WriteLine();

// 7. ToList
List<Student> studentList = students.ToList();
Console.WriteLine("Lista convertida para List:");
foreach (Student student in studentList)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// 8. ToLookup
ILookup<string, Student> studentLookup = students.ToLookup(s => s.Grade > 7.0 ? "Aprovados" : "Reprovados");
Console.WriteLine("Lista convertida para Lookup:");
foreach (IGrouping<string, Student> group in studentLookup)
{
    Console.WriteLine($"{group.Key}:");
    foreach (Student student in group)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
    }

    Console.WriteLine();
}