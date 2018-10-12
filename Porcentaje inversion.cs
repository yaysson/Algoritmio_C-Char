using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_taller_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando un objeto de la clase articulo
            Articulo leche = new Articulo("Lacteo 001", "1 Galon de leche", 2, 2.50);

            //Aplicar Descuento.
            leche.setDescuento(0.15);

            //obtener precio ajustado.
            double precio_leche = leche.getTotalAjustado();

            Console.WriteLine(leche.getDescripcion() + "\n" + precio_leche);

            


            Articulo pan = new Articulo(" Pandemija 002", "1 unidad de pan", 2, 200);

            pan.setDescuento(0.20);

            double precio_pan = pan.getTotalAjustado();

            Console.WriteLine(pan.getDescripcion() + "\n" + precio_pan);




            Console.ReadKey();

        }
    }
}
