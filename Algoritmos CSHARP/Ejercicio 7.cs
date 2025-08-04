 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba cuantas horas deasea calcular a minutos y a segundos : ");
            double horas=Convert.ToDouble(Console.ReadLine());

            double minutos = horas * 60;
            double segundos = minutos * 60;

            Console.WriteLine("El numero de minutos es : "+minutos+"\n"+
                               "el numero de segundos es : "+segundos 
                               );
        }
    }
}
