class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un texto con espacios: ");
        string input = Console.ReadLine();
        int ContEsp = EspCont(input);
        Console.WriteLine($"The input string contains {ContEsp} spaces.");
    }

    static int EspCont(string input)
    {
        int ContEsp = 0;
        foreach (char letra in input)
        {
            if (letra == ' ')
            {
                ContEsp++;
            }
        }
        return ContEsp;
    }
}