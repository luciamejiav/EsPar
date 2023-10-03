// crear en la terminal dotnet new console
using System;
using Microsoft.VisualBasic;

namespace _01_espar
{ //poner el mismo nombre que en el RootNamespace 
    internal class Par
    {
        static void Main(string[] args)
        {
            string? numero;
            int n;

            Console.Write("Introduce un número: ");
            numero = Console.ReadLine();

            try
            {
                n = Int32.Parse(numero); //pasamos el nº de string a int
                Console.WriteLine(n);
                if (n % 2 == 0) //comprobamos si es par
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }
            }
            catch (FormatException) //si no es entero salta un aviso
            {
                Console.WriteLine($"Unable to parse '{numero}'");
            }


        }
    }
}