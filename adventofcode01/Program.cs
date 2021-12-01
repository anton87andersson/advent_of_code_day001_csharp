using System;

namespace adventofcode01
{
    class Program
    {
        static void Main(string[] args)
        {
            int prev_num = 0;
            int count_inc = -1;

            foreach (string line in System.IO.File.ReadLines("PATH/TO/FILE"))
            {
                int line_to_int = int.Parse(line);

                if (line_to_int > prev_num)
                {
                    Console.WriteLine("Not bigger");
                    count_inc++;
                } 

                prev_num = line_to_int;
               
            }

            Console.WriteLine(count_inc.ToString());
            Console.ReadLine();
        }
    }
}
