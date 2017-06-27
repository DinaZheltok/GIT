using System;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String output;
            int i = 0;
            while ( i <= 100 )
            {
                if (i % 3 == 0)
                {
                    output = "3*" + (i / 3).ToString();
                }
                else
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);
             i++;
            }
            Console.ReadKey();
        }
    }
}