﻿namespace ConsoleApp
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
                    Console.WriteLine("No puede ingresar");
                }
            }
            else
            {
                Console.WriteLine("No podemos continuar si no ingresa un nombre.");
            }            
        }
    }
}
