// See https://aka.ms/new-console-template for more information

// Primer ejercicio 
Console.WriteLine("\nEjercicio 1");

int n1 = 30, n2 = 20;
if (n1 > n2)
{
    int dif = n1 - n2, dob = dif*2;

    Console.WriteLine( "La diferencia entre {0} y {1} es de {2}", n1, n2, dif, dob);
    Console.WriteLine( "Y su doble sería {0}", dob);
}
else
{
    Console.WriteLine("El segundo número es mayor que el primero");
}