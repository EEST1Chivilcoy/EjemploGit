using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola, a todo el mundo! (mayor de 18 años)");
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine($"Hola, {nombre}");
                Console.WriteLine("Necesitamos verificar si es mayor de edad");
                Console.WriteLine("Por favor, Ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    Console.WriteLine("Bienvenido!");
                }
                else
                {
                    for (int i = 0; i < 50; i++)
                        Console.WriteLine("¡NO PUEDE INGRESAR!");
                }
            }
            else
            {
                Console.WriteLine("No podemos continuar si no ingresa un nombre.");
            }
        }
    }
}
