class Program
{
    static void Main(string[] args)
    {
        List<string> stringList = new List<string> {"Piedras", "Agua", "Tierra", "Tormenta", "Fuego"};

        Console.WriteLine($"El numero de palabras con la letra 'a' es de {ContadorCaracteres(stringList, 'a')} caracteres");
    }

    static int ContadorCaracteres(List<string> strings, char letra)
    {
        int i = 0;

        foreach (string str in strings)
        {
            if (str.Contains(letra))
            {
                i++;
            }
        }

        return i;
    }
}