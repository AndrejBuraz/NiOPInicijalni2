using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova: ");
            string znakovi = Console.ReadLine();
            Console.WriteLine("Niz u kojem su razmaci zamijenjeni sa _: " + znakovi.Replace(" ", "_"));
            Console.ReadKey();
        }
    }
}
