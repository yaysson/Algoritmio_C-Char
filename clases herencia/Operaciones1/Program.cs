using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones1
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumando totalsuma = new Sumando(5, 8);
            totalsuma.getSuma();
            Resta totalresta = new Resta(5, 8);
            totalresta.getResta();
            Multi totalmulti= new Multi(5, 8);
            totalmultu.getMulti();
            Divi totaldivi = new Divi(5, 8);
            totaldivi.getDivi();


            Console.WriteLine("suma" + totalsuma.getSuma());
            Console.WriteLine("Resta" + totalresta.getResta());
            Console.WriteLine("Multiplicacion" + totalmulti.getMulti());
            Console.WriteLine("Divicion" + totaldivi.getDivi());





        }
    }
}
