using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string x = Console.ReadLine();
            int height = System.Convert.ToInt32(x);
            for(int i = 1; i <= height; i++)
            {
                string asterisk = "".PadLeft(i, '*');
                Console.WriteLine(asterisk);
            }
            int starCnt = 1;
            for (int i = 1; i <= height; i++)
            {
                int spaces = height - i;
                string asterisk = "".PadLeft(starCnt, '*');
                asterisk = asterisk.PadLeft(spaces + starCnt,' ');
                Console.WriteLine(asterisk);
                starCnt += 2;
            }
            
        }
    }
}
