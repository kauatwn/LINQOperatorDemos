using Element.Entities;

var customers = new List<Customer>
{
    new(1,"John", 42),
    new(2,"Alice", 30),
    new(3,"Carol", 22),
    new(4,"David", 35),
    new(5,"Eve", 28),
    new(6,"Frank", 45),
    new(7,"Grace", 33),
    new(8,"Helen", 40),
};

// 1. FirstOrDefault
var firstCustomer = customers.FirstOrDefault();
Console.WriteLine(firstCustomer);

// 1.1. FirstOrDefault with predicate
var firstCustomerOver40 = customers.FirstOrDefault(c => c.Age < 25);
Console.WriteLine(firstCustomerOver40);

// 2. LastOrDefault
var lastCustomer = customers.LastOrDefault();
Console.WriteLine(lastCustomer);

// 2.1. LastOrDefault with predicate
var lastCustomerUnder30 = customers.LastOrDefault(c => c.Age < 30);
Console.WriteLine(lastCustomerUnder30);

// 3. SingleOrDefault
var singleCustomer = customers.SingleOrDefault(c => c.Id == 2);
Console.WriteLine(singleCustomer);

// 4. ElementAtOrDefault
var customerAt5 = customers.ElementAtOrDefault(5);
Console.WriteLine(customerAt5);

// 5. DefaultIfEmpty
var emptyList = new List<Customer>();
var defaultIfEmptyList = emptyList.DefaultIfEmpty(new Customer(0, "Default", 0)).FirstOrDefault();
Console.WriteLine(defaultIfEmptyList);

// All other element methods without the "OrDefault" suffix throw an exception if the collection is empty
// or if a predicate is not met.