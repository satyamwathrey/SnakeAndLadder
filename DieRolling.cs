using System;

namespace Snake_and_Ladder
{
    class PlayerPostionZero
    {
        static void Main(string[] args)
        {
            int Position = 0;
            int rolls = 0;
            Console.WriteLine("Player Is at Position: "+Position);

            Random random = new Random();
            while (true)
            {
                rolls = random.Next(7);
                if (rolls != 0)
                    break;
            }
            Console.WriteLine("die count: " + rolls);
            Console.ReadLine();
        }
       
    } 
}
