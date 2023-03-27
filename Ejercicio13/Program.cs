class Program
{
    static void Main(string[] args)
    {
        int n1 = 5;
        int n2 = 10;
        Console.WriteLine($"Cambio de Números:\nPrimer Numero= {n1},\nSegundo Numero = {n2}\n");
        Cambio(ref n1, ref n2);
        Console.WriteLine($"Numero cambiado:\nEl primer número ahora es = {n1}\nY el segundo es = {n2}");
    }

    static void Cambio(ref int n1, ref int n2)
    {
        int temp = n1;
        n1 = n2;
        n2 = temp;
    }
}