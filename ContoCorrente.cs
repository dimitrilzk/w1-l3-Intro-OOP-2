using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_l3_Intro_OOP_2
{
    internal class ContoCorrente
    {
        private string _nomeCliente;
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }
        private string _cognomeCliente;
        public string CognomeCliente
        {
            get { return _cognomeCliente; }
            set { _cognomeCliente = value; }
        }
        private float _saldo = 0;
        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        private bool _contoAperto = false;
        public bool ContoAperto
        {
            get { return _contoAperto; }
            set { _contoAperto = value; }
        }
        public void StartMenu()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("WELCOME   TO   YOURE   BANK   ACCOUNT");
            Console.WriteLine("*************************************");

            Console.WriteLine("\nScegli l'operazione da effettuare:");
            Console.WriteLine("1. APRI UN NUOVO CONTO CORRENTE");
            Console.WriteLine("2. EFFETTUA UN VERSAMENTO");
            Console.WriteLine("3. EFFETTUA UN PRELIEVO");
            Console.WriteLine("4. ESCI");
            Console.ReadLine();
           
        }
    }
}
