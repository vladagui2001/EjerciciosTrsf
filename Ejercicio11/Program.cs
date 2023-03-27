public class Program
{
    static void Main(string[] args)
    {
        double radio = 5.0; 
        double cir = CalculoCircumf(radio);
        Console.WriteLine($"La circumferencia de un circulo con radio: {radio} es de {cir}");
    }

    static double CalculoCircumf(double radio)
    {
        double cir = 2 * Math.PI * radio;
        return cir;
    }
}