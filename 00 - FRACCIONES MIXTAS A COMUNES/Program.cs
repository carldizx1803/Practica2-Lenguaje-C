using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Fracciones_mixtas_a_comunes
{
    class Program
    {
        static void Main(string[] args)
        {

            int entero, numerador, denominador, resultado;

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write(" CONVERSOR DE FRACCIÓN MIXTA A FRACCIÓN IMPROPIA \n ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write(" Porfavor, ingrese el numero entero que acompaña a la fracción: "); 
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write(" Porfavor, ingrese el numerador de la fracción que acompaña al entero: ");
            numerador = int.Parse(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write(" Porfavor, ingrese el denominador de la fracción que acompaña al entero: ");
            denominador = int.Parse(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.Write(" La fracción mixta ingresada es: ");
            Console.Write(entero+" {0} / {1}", numerador, denominador);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Thread.Sleep(1500);

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            resultado = (entero * numerador + denominador);
            Thread.Sleep(1500);
            Console.Write("El resultado al convertir a fracción impropia es: {0} / {1}", resultado, numerador);
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.ReadKey();

        }
    }
}
