using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on  mängu võitnud; 
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda. 

            Random rnd = new Random();
            int i = 0; //i - iteration
            int myRandomNumber = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Tere tulemast mängu, arva ära mu number 1-10-neni vahemikus :)");
                int arv = Convert.ToInt32(Console.ReadLine());

                if (arv == myRandomNumber)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    //(i = i + 1); == i++
                    i++;
                    Console.WriteLine($"Oled valet numbrit {i} korda sisestanud. Proovi uuesti");
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
