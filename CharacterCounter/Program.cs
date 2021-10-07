using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            // programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Length omadust kasutamata

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}";
            int charCounter = 0;
            foreach(char c in fullName)
            {
                charCounter++;
            }
            Console.WriteLine($"Su nimes {fullName} on {charCounter} tähte");
        }
    }
}
