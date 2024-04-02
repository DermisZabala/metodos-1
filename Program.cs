using System;
using System.Security.Cryptography.X509Certificates;

namespace metodo_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            presentacion();

            Console.WriteLine("\nLa suma de varias operaciones");
            Console.WriteLine("Ingrese el primer numero");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine(suma(numero1, numero2));


        }

        static void presentacion()
        {
            string nombre = "Hamel Zabala";
            int edad = 19;
            string provincia = "San Cristóbal";
            string barrio = "LavaPies";
            string nombreCalle = "Luis Alberti";
            int numCalle = 5;

            Console.WriteLine($"Hola soy {nombre} \nTengo {edad} años y vivo en {provincia}, " +
                $"barrio {barrio}, calle {nombreCalle} #{numCalle}");
        }

        static double suma(double num1, double num2)
        {
            double suma = num1 + num2;

            double mul = num1 * num2;

            double div = num1 / num2;
            
            double resta = num1 - num2;

            double resi = num1 % num2;

            double resultado = suma + mul + div + resta + resi;

            if (num2 == 0)
            {
                
                if (resta >= 0)
                {
                    Console.WriteLine($"Suma: {num1} + {num2} = {suma}");

                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {mul}");

                    Console.WriteLine($"Resta: {num1} - {num2} = {resta}");

                    resultado = suma + mul + resta;
                    Console.Write($"{suma} + {mul} + {resta} = ");
                }
                else
                {

                    Console.Write($"{suma} + {mul} + ({resta}) = ");
                }
            }
            else
            {

                if(resta >= 0)
                {
                    Console.WriteLine($"Suma: {num1} + {num2} = {suma}");

                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {mul}");

                    Console.WriteLine($"Division: {num1} / {num2} = {div}");

                    Console.WriteLine($"Resta: {num1} - {num2} = {resta}");

                    Console.WriteLine($"Residuo: {num1} % {num2} = {resi}");

                    Console.Write($"{suma} + {mul} + {div} + {resta} + {resi} = ");

                }
                else
                {
                    Console.WriteLine($"Suma: {num1} + {num2} = {suma}");

                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {mul}");

                    Console.WriteLine($"Division: {num1} / {num2} = {div}");

                    Console.WriteLine($"Resta: {num1} - {num2} = {resta}");

                    Console.WriteLine($"Residuo: {num1} % {num2} = {resi}");

                    Console.Write($"{suma} + {mul} + {div} + ({resta}) + {resi} = ");
                }

            }

            return resultado;
        }
    }
}
