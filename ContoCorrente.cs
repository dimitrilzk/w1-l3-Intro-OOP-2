﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                CreaNuovoConto();
            }
            if(scelta == 2)
            {
                //Versamento();
            }
            if(scelta == 3)
            {
                //Prelievo();
            }
            if(scelta == 4)
            {
                Console.WriteLine("Chiusura del programma...");
            }
            else
            {
                Console.WriteLine("Hai selezionato una voce non valida");
                StartMenu();
            }
        }
        private void CreaNuovoConto()
        {
            Console.WriteLine("Nome cliente: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Cognome cliente: ");
            string Cognome = Console.ReadLine();

            Console.WriteLine("Eseguire un versamento (minimo 1000 euro): ");
            int Versamento = int.Parse((string)Console.ReadLine());

            ContoCorrente conto1 = new ContoCorrente();
            _nomeCliente = Nome;
            _cognomeCliente = Cognome;
            _saldo += Versamento;
            _contoAperto = true;
            Console.WriteLine($"Conto corrente numero 51434 intestato a: {_nomeCliente} {_cognomeCliente} con saldo: {_saldo} euro è stato aperto con successo");
            StartMenu();


        }
    }
}
