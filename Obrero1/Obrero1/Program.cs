using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrero1
{
    class Program
    {
        static void Main(string[] args)
        {
          
       
            Console.WriteLine(" Ingrese numero de horas ");
            string ht = Console.ReadLine();
            int totalhoras = int.Parse(ht);


            if(totalhoras <= 40)
            {

                 int salario = (totalhoras * 16);
                Console.WriteLine(" Salario =" + salario);
            }
            else
            {

                int extra = (totalhoras - 40);
                int i = 40;
                int salario = (i * 16) + (extra * 20);

                Console.WriteLine("Salario =" + salario);
          
            }

            Console.ReadKey();

        }
    }
}
