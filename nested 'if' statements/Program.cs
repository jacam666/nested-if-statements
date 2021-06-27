using System;

namespace nested__if__statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = Convert.ToInt32(Console.ReadLine());
           
            if (points > 80)
            {
                Console.WriteLine("Level completed");
            }
            else
            {
                Console.WriteLine("You lost");
            }
            if (points > 90)
            {
                Console.WriteLine("Extra gift");
            }
        }
    }
}
