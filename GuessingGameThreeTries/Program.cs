using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on  mängu võitnud; 
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int i = 0; //i - iteration
            int myRandomNumber = rnd.Next(1, 11);

            while (i < 3)
            {
               Console.WriteLine("Tere tulemast mängu, arva ära mu number 1-10vahemikus :)");
                int arv = Convert.ToInt32(Console.ReadLine());

                if(arv == myRandomNumber)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //(i = i + 1); == i++
                    i++; 
                    Console.WriteLine($"Vale number. Alles on jäänud {3 - i} katset.");
                }
                  
            }
            Console.WriteLine("Kena päeva!");
            }
        
    }
}
