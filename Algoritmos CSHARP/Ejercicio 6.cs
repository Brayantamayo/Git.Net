using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite elvalor de la compra Total :");
            double Total =Convert.ToDouble(Console.ReadLine());

            double IVA = Total * 0.19;
            double valor = Total + IVA;

            if (valor >= 100000)
            {
                double descuento = valor * 0.20;
                double totaldescueto = valor - descuento;
                Console.WriteLine("EXITO , tuviste un descuento el 20%  esta es la informacion de tu Compra" + "\n" +
                                   
                                   "TOTAL : " + Total.ToString("C") +"\n"+
                                   
                                   "IVA : " + IVA.ToString("C")+ "\n"+
                                   
                                   "TOTAL CON IVA : "+ valor.ToString("C") + "\n"+

                                   "DESCUENTO :" +descuento.ToString("C") + "\n"+
                            
                                   "TOTAL A PAGAR :"+ totaldescueto.ToString("C") + "\n"
                    );
            }
            else
            {
                
                Console.WriteLine("TOTAL A PAGAR : " + valor.ToString("C")); ///////////////tostring es para colocar el valor en moneda
            }

            


        }
    }
}
