using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_porcentaje
{
    class Program
    {
        static void Main(string[] args)
        {

            /* tres personas desean invertir en una empresa con capitales diferentes, que porcentaje
             * tiene cada persona*/

            Console.WriteLine(" Ingrese capital 1 ");
            string capita1 = Console.ReadLine();
            float num1 = float.Parse(capita1);

            Console.WriteLine(" Ingrese capital 2 ");
            string capita2 = Console.ReadLine();
            float num2 = float.Parse(capita2);

            Console.WriteLine(" Ingrese capital 3 ");
            string capita3 = Console.ReadLine();
            float num3 = float.Parse(capita3);


            float total = num1 + num2 + num3;
            Console.WriteLine(" Total Capital " + total);

            float porcentaje1 = (num1 / total * 100);
            float porcentaje2 = (num2 / total * 100);
            float porcentaje3 = (num3 / total * 100);

            Console.WriteLine(" Porcentaje de capital 1" + porcentaje1);
            Console.WriteLine(" Porcentaje de capital 2" + porcentaje2);
            Console.WriteLine(" Porcentaje de capital 3" + porcentaje3);


            Console.ReadKey();



        }
    }
}
