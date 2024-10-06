using Join.Entities;

var customers = new List<Customer>
{
    new(1, "Alice"),
    new(2, "Bob"),
    new(3, "Charlie")
};

var orders = new List<Order>
{
    new(1, 1, "Laptop"),
    new(2, 2, "Tablet"),
    new(3, 1, "Smartphone")
};

// 1. Join
var customerOrders = customers.Join(
    orders,
    customer => customer.Id,
    order => order.CustomerId,
    (customer, order) => new
    {
        CustomerName = customer.Name,
        OrderProduct = order.Product
    });

// Join returns only customers with orders.
// If a customer doesn't have any orders, it is not included in the result.
Console.WriteLine("Join result:");
foreach (var customerOrder in customerOrders)
{
    Console.WriteLine($"Customer: {customerOrder.CustomerName}, Product: {customerOrder.OrderProduct}");
}

Console.WriteLine();

// 2. GroupJoin
var groupedCustomerOrders = customers.GroupJoin(
    orders,
    customer => customer.Id,
    order => order.CustomerId,
    (customer, ordersGroup) => new
    {
        CustomerName = customer.Name,
        Orders = ordersGroup.Select(order => order.Product)
    }).Where(customerOrder => customerOrder.Orders.Any());

// GroupJoin returns all customers, even if they don't have any orders.
// To filter only customers with orders, it is necessary to use the Where method.
// Otherwise, customers without orders would be included in the result with an empty list of orders.
Console.WriteLine("GroupJoin result:");
foreach (var customerOrder in groupedCustomerOrders)
{
    Console.WriteLine($"Customer: {customerOrder.CustomerName}, Products: {string.Join(", ", customerOrder.Orders)}");
}