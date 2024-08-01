namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola, a todo el mundo!");
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine($"Hola, {nombre}");
            }
        }
    }
}
