using System;

namespace MoreStringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racecar" tagurpidi

            string race = "racecar";


            for (int i = race.Length - 1; i >= 0; i--)
            {
                Console.Write(race[i]);
            }

            
        }
    }
}
