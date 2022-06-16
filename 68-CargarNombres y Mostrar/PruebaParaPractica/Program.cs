using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaParaPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de nombres:");
            int CantidadDeNombre = Convert.ToInt32(Console.ReadLine());

            string[] NombresIngresados = new string[CantidadDeNombre];

            Console.WriteLine("Ahora ingrese los nombres:");

            for (int i=0; i < CantidadDeNombre; i++)
            {

                NombresIngresados  [i]= Console.ReadLine();
                
            }
            Console.Clear();

            Console.CursorLeft = 30;
            Console.WriteLine("Los nombres ingresados son:");
            for (int i = 0; i < CantidadDeNombre; i++)
            {
                
                Console.WriteLine(NombresIngresados[i]);
            }
            Console.ReadKey();
        }
    }
}
