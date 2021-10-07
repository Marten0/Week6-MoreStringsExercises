using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a'tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);

        }
    }
}
