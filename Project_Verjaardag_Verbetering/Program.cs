using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Verjaardag_Verbetering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens
            // 29/11/2023
            // Project Verjaardag
            
            // Velden 
            DateTime _geboortedatum = DateTime.Now,_verjaardag = DateTime.Now, _vandaag = DateTime.Now;
            TimeSpan _tussenperiode = TimeSpan.Zero;
            int _geboortejaar = 0, _huidigjaar = 0, _verschil = 0, _aantalDagen = 0;
            

            // Programma

            //Stap 1: Intro
            Console.WriteLine("Welkom op dit programma.");
            Console.WriteLine("Druk op een toets op verder te gaan");
            Console.ReadKey();

            // Scherm leegmaken 
            Console.Clear();
            try
            {
                //Stap 2: Vraag geboorte datum
                Console.Write("Geef uw geboorte datum (dd/mm/jjjj): ");
                _geboortedatum = DateTime.Parse(Console.ReadLine());
                //Stap 3: bereken de aantal dagen volgende verjaardag
                // neem het verschil van de jaren tussen de geboorte datum en vandaag.
                _geboortejaar = _geboortedatum.Year;
                _huidigjaar = _vandaag.Year;
                _verschil = _huidigjaar - _geboortejaar;

                // tel het verschil erbij op zodat de datum in dit jaar valt
                _verjaardag = _geboortedatum.AddYears(_verschil);
                 
                //Vergelijk de datums, 
                // Als de geboorte datum vroeger valt dan vandaag, tel ik er 1 bij op
                if(_verjaardag < _vandaag)
                {
                    _verjaardag = _verjaardag.AddYears(1);
                }

                // neem het verschil tussen de toekomstige verjaardag en vandaag
                _tussenperiode = _verjaardag - _vandaag;

                // Neem het aantal dagen
                _aantalDagen = (int)_tussenperiode.TotalDays;
                
                // Scherm leegmaken 
                Console.Clear();

                //Stap 4: Geef het antwoord
                Console.WriteLine($"Je geboortedatum was {_geboortedatum.ToShortDateString()}.");
                Console.WriteLine($"Je volgende verjaardag vindt plaats op {_verjaardag.ToLongDateString()}");
                Console.WriteLine($"Je moet nog {_aantalDagen.ToString()} dagen wachten op je komende verjaardag");
                Console.ReadKey();

            }
            catch
            {
                // Scherm leegmaken 
                Console.Clear();

                // Foutmelding
                Console.WriteLine("U gaf geen juiste datum in.\nDruk op een toets om af te sluiten");
                Console.ReadKey();

            }
            

        }
    }
}
