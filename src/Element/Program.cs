using Element.Entities;

var customers = new List<Customer>
{
    new(1, "John", 42),
    new(2, "Alice", 30),
    new(3, "Carol", 22),
    new(4, "David", 35),
    new(5, "Eve", 28),
    new(6, "Frank", 45),
    new(7, "Grace", 33),
    new(8, "Helen", 40),
};

// 1. FirstOrDefault
Customer? firstCustomer = customers.FirstOrDefault();
Console.WriteLine(firstCustomer);

// 1.1. FirstOrDefault with predicate
Customer? firstCustomerOver40 = customers.FirstOrDefault(c => c.Age < 25);
Console.WriteLine(firstCustomerOver40);

// 2. LastOrDefault
Customer? lastCustomer = customers.LastOrDefault();
Console.WriteLine(lastCustomer);

// 2.1. LastOrDefault with predicate
Customer? lastCustomerUnder30 = customers.LastOrDefault(c => c.Age < 30);
Console.WriteLine(lastCustomerUnder30);

// 3. SingleOrDefault
Customer? singleCustomer = customers.SingleOrDefault(c => c.Id == 2);
Console.WriteLine(singleCustomer);

// 4. ElementAtOrDefault
Customer? customerAt5 = customers.ElementAtOrDefault(5);
Console.WriteLine(customerAt5);

// 5. DefaultIfEmpty
var emptyList = new List<Customer>();
Customer? defaultIfEmptyList = emptyList.DefaultIfEmpty(new Customer(0, "Default", 0)).FirstOrDefault();
Console.WriteLine(defaultIfEmptyList);

// All other element methods without the "OrDefault" suffix throw an exception if the collection is empty or if a
// predicate is not met.

// It is necessary to implement the ToString method in the Customer class to display the object in the console in a
// readable format. Otherwise, the output will be the type name of the object.

// Another way is to use the Select method to select the desired property of the object and display it in the console.
// For example, Console.WriteLine(customers.Select(c => $"Name: {c.Name}, Age: {c.Age}").FirstOrDefault());