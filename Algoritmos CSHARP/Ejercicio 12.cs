using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de personas del grupo   :");
            double personas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de mujeres del grupo   :");
            double mujeres = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingrese la cantidad de hombres del grupo   :");
            double hombres = Convert.ToDouble(Console.ReadLine());

            


            double porcentajehombre=(hombres/personas)*100;
            double porcentajemujer=(mujeres/personas)*100;

            Console.WriteLine("El porcentaje de hombres es: " +porcentajehombre + "%");
            Console.WriteLine("El porcentaje de mujeres es: " + porcentajemujer+ "%");




        }
    }
}
