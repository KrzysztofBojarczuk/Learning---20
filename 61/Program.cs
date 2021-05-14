using System;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odgadywanie liczby losowej!");
            Random rand = new Random();
            int num = rand.Next(1, 100);

            bool gameover = false;
            Console.WriteLine("Odganij liczbę od 1 do 100.");
            int guess = 0;
            while (gameover == false)
            {
                guess++;

                int user = int.Parse(Console.ReadLine());

                if (user == num)
                {
                    Console.WriteLine("Odgadłeś prawidłową liczbę.");
                }
                else if (user > num)
                {
                    Console.WriteLine("Liczba zbyt duża spróbuj ponownie.");
                }
                else if (user < num)
                {
                    Console.WriteLine("Liczba zbyt mała spróbuj ponownie.");
                }
                Console.WriteLine($"Potrzebowałeś {guess} prób.");
            }
            
        }
    }
}
