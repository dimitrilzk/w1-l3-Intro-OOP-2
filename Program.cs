using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_l3_Intro_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente();
            //conto.StartMenu();
            conto.NomeCliente = "mario";
            Console.WriteLine(conto.NomeCliente);
        }
    }
}
