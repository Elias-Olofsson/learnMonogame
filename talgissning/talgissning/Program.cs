using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talgissning
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Slump = new Random();
            int Slump1 = Slump.Next(0, 101);
            int antalgissningar = 0;

            Console.Write("skriv ett tal.");
            int gissning = int.Parse(Console.ReadLine());
            antalgissningar++;

            while (gissning != Slump1)
            {
                if (gissning < Slump1)
                {
                    Console.WriteLine("Din gissning var för låg" + gissning);
                    Console.Write("försök igen");
                    antalgissningar++;
                }
                else
                {
                    Console.WriteLine("Din gissning var för hög: + gissning");
                    Console.Write("försök igen:");
                    antalgissningar++;
                }

                gissning = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("din gissning var rätt:");
            Console.WriteLine("Antalgissningar:" + antalgissningar);
        } 
    }
}