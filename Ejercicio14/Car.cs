public class Car
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Type { get; set; } = string.Empty;
    public double Kilometers { get; set; }
}

public static class CarDataMocker
{
    public static List<Car> GetMockCarData()
    {
        List<Car> cars = new List<Car>();

        // Create and add mock cars to the collection
        cars.Add(new Car
        {
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2022,
            Type = "Standard",
            Kilometers = 15000.5
        });

        cars.Add(new Car
        {
            Brand = "Honda",
            Model = "Civic",
            Year = 2021,
            Type = "Manual",
            Kilometers = 18000.75
        });

        cars.Add(new Car
        {
            Brand = "Ford",
            Model = "Mustang",
            Year = 2020,
            Type = "Standard",
            Kilometers = 25000.2
        });

        foreach (Car car in cars)
    {
        Console.WriteLine($"Brand: {car.Brand}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Year: {car.Year}");
        Console.WriteLine($"Type: {car.Type}");
        Console.WriteLine($"Kilometers: {car.Kilometers}");
        Console.WriteLine();
    }
        // Add more mock cars as needed 

        return cars;
    }
}
