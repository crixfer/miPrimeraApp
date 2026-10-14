namespace miPrimeraApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gracias por utilizar miPrimeraApp!");
        
        Console.WriteLine("1.Cuál es tu nombre?");
        string fName = Console.ReadLine(); //introducir nombre
        
        Console.WriteLine("\n2.Qué estudias o cuál es tu carrera?");
        string occupation = Console.ReadLine(); //introducir ocupacion
        
        Console.WriteLine("\nMuy bien!");
        
        Console.WriteLine("\n3.Por qué decidiste estudiar programación?");
        string decision = Console.ReadLine(); //indroducir desicion
        
        Console.WriteLine("\nExcelente! Nunca es tarde para aprender.");
        
        Console.WriteLine($"\nBienvenido/a a miPrimeraApp {fName}.");
        
        Console.WriteLine("\nEsta es tu tarjeta de información:\n");
        
        Console.WriteLine("\t Tarjeta Personal \n");
        Console.WriteLine($"Nombre: {fName}");
        Console.WriteLine($"Ocupación: {occupation}");
        Console.WriteLine($"\nDecisión: \n{decision}");
        
        
        
        
        






    }
}