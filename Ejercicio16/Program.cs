var pedidos = Pedido.AddOrders();
pedidos.Sort((p1, p2) => p1.Table.CompareTo(p2.Table));

// Mostrar los pedidos en la consola
foreach (var pedido in pedidos)
{
    Console.WriteLine($"Table: {pedido.Table}");
    Console.WriteLine($"Meals: {string.Join(", ", pedido.Meals)}");
    Console.WriteLine($"Drinks: {string.Join(", ", pedido.Drinks)}");
    Console.WriteLine($"Waiter: {pedido.Waiter}");
    Console.WriteLine();
}
    