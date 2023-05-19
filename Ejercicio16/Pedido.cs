
public class Pedido
{
    public int Table { get; set; }
    public List<string> Meals { get; set; }
    public List<string> Drinks { get; set; }
    public string Waiter { get; set; }

    public static List<Pedido> AddOrders()
    {
        var pedidos = new List<Pedido>();

        // Agregar algunos pedidos simulados
        var pedido1 = new Pedido
        {
            Table = 1,
            Meals = new List<string> { "Tacos", "Quesadillas" },
            Drinks = new List<string> { "Pepsi", "Lemonade" },
            Waiter = "Juan Pablo"
        };
        pedidos.Add(pedido1);

        var pedido2 = new Pedido
        {
            Table = 2,
            Meals = new List<string> { "Pozole", "Gorditas" },
            Drinks = new List<string> { "Root Beer", "Mountain Dew" },
            Waiter = "Vlad Enrique"
        };
        pedidos.Add(pedido2);

        var pedido3 = new Pedido
        {
            Table = 3,
            Meals = new List<string> { "Burritos", "Chilaquiles" },
            Drinks = new List<string> { "Berry Punch", "Mango Boing Juice" },
            Waiter = "Diana Mercado"
        };
        pedidos.Add(pedido3);

        return pedidos;
    } 
}