namespace Ejercicio5;
static class Program
{
    static void Main(string[] args)
    {
        SmallApartment apartment = new SmallApartment();
        Person person = new Person("Jesús");
        apartment.door = new House.Door("Gris");
        person.house = apartment;
        person.ShowData();
    }
}

public class House
{
    public int Area { get; set; }
    public Door door;

    public House(int area = 200)
    {
        Area = area;
    }

    public void ShowData()
    {
        Console.WriteLine("Clase casa, la cuál tiene un área de: {0} m2",Area);
    }

    public Door GetDoor()
    {
        return door;
    }

    public class Door
    {
        public string Color { get; set; }

        public Door(string color = "Gris")
        {
            Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine("Clase puerta, la cuál es de color: {0}", Color);
        }
    }
}

public class SmallApartment : House
{
    public SmallApartment(int area = 50) : base(area)
    {
    }
}

public class Person
{
    private string name;
    public House house { get; set; }

    public  Person(string name)
    {
        this.name = name;
    }

    public void ShowData()
    {
        Console.WriteLine("Una persona de nombre: {0}",name);
        Console.WriteLine("Valores de la casa");
        house.ShowData();
        Console.WriteLine("Valores de la puerta");
        house.GetDoor().ShowData();
    }
}