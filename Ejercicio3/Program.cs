// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ejercicio 1 Sesión 8");

double a, b, p, ar, c;

Console.Write("Escriba el primer valor: ");
a = double.Parse(Console.ReadLine());

Console.Write("Escriba el segundo valor: ");
b = double.Parse(Console.ReadLine());

p = (a*2) + (b*2);
Console.WriteLine("El perímetro es: {0}",p);

ar = a * b; 
Console.WriteLine("El área es: {0}",ar);

c = Math.Sqrt(a * a + b * b);
Console.WriteLine("La Diagonal es: {0}",c);
