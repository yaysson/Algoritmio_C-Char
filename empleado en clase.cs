using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleadoporcomision EPObjeto = new Empleadoporcomision("juan", "Ramirez", 200000, 1.00);


            EPObjeto.sumarVentas(5);

            Console.WriteLine("Nombre" +" "+ EPObjeto.getNombre());
            Console.WriteLine("Apellido"+" " + EPObjeto.getApellido());
            Console.WriteLine("Pago Base"+" " + EPObjeto.getSalario());
            Console.WriteLine("Pago total"+" " + EPObjeto.calsularpago());

            Empleado Nuevo = new Empleado("Rojelio", "Camin", 500000);
            Console.WriteLine("Nombre" +" "+ Nuevo.getNombre());
            Console.WriteLine("Apellido" +" "+ Nuevo.getApellido());
            Console.WriteLine("Salario" +" "+ Nuevo.getSalario());

            Console.ReadKey();
       
        }
    }
}
