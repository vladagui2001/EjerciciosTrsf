namespace Ejercicio4;
public class Person
{
    public int Age{get;set;}
    public string Name{get;set;}
    public void SetAge(int n){
        Age=n;
    }
    public void SetName(string n){
        Name=n;
    }
    public void SayHello(){
        Console.WriteLine("Hola, me llamo: {0}",Name);
    }
}
public class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("Estoy llendo a clase.");
    }
    public void ShowAge()
    {
        Console.WriteLine("Mi edad es de: {0} años.", Age);
    }
}
public class Teacher : Person
{
    private string Subject{get;set;}
    public void Explain()
    {
        Console.WriteLine("La explicación está por empezar.");
    }
}