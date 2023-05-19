var students = new Dictionary<string, string>();

students.Add("2323", "Eduardo López");
students.Add("3282", "Diego Montez");
students.Add("9012", "Vlad Enrique");

Console.WriteLine("Ingrese el número de Identificación del estudiante:");
string idstudents = Console.ReadLine();

if (students.ContainsKey(idstudents))
{
    string studentname = students[idstudents];
        Console.WriteLine($"La identificación {idstudents} corresponde a: {studentname}");
    }
    else
    {
        Console.WriteLine($"No se encontró ningún estudiante con la identificación {idstudents} en la colección.");
    }