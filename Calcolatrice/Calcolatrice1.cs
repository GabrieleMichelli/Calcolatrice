
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    public class Calcolatrice1
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }
        public Operazione operazione { get; set; }


        public void ChiediOperazioneNumeri()

        {
            Console.WriteLine("CHE OPERAZIONE VUOI FARE:\n 1)ADDIZIONE;\n 2)SOTTRAZIONE\n 3)MOLTIPLICAZIONE;\n 4)DIVISONE");
            operazione = (Operazione)Enum.Parse(typeof(Operazione), Console.ReadLine());



            Console.WriteLine("Inserisci il primo numero");
            try
            {
                Num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                Num2 = Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Eccezione {e.GetType()}");
                throw e;
            }

        }
        public void Calcola()
        {
            switch (operazione)
            {
                case Operazione.Somma:
                    this.Somma();
                    break;
                case Operazione.Sottrazione:
                    this.Sottrazione();
                    break;
                case Operazione.Prodotto:
                    this.Prodotto();
                    break;
                case Operazione.Divisione:
                    this.Dividi();
                    break;
            }
        }

        public void Somma()
        {

            Result = Num1 + Num2;
            Console.WriteLine($"Il risultato dell'addizione è {Result}");
        }

        public void Sottrazione()
        {

            Result = Num1 - Num2;
            Console.WriteLine($"Il risultato della sottrazione è {Result}");
        }

        public void Prodotto()
        {

            Result = Num1 * Num2;
            Console.WriteLine($"Il risultato della moltiplicazione è {Result}");
        }
        public void Dividi()
        {
            if (Num2 == 0)
            {
                Console.WriteLine("NON PUOI DIVIDERE PER ZERO");
            }
            else
            {
                Result = Num1 / Num2;
                Console.WriteLine($"Il risultato della divisione è {Result}");
            }


        }
    }
}