namespace Ejercicio4;
public class Student : Program{
    public double n {get; set;}
    public void GoToClasses(){
        Console.WriteLine("Voy a ir a clase");
    }
    public void ShowAge(){
        Console.WriteLine("Mi edad es de: {0}",n);
    }
}