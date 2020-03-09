using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //this line iterates horizontally 
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");

            for(int i = 1; i <= 9; i++)
            {
                //we want numbers to appear in the same row
                Console.Write(i);

                for (int j = 1; j <= 9; j++)
                {
                    //for every number iterated in j, multiply that number
                    //by the list of items iterated in the outer loop
                    // 1 * 1, 1 * 2, 1 * 3 etc.
                    // 2 * 1, 2 * 2, 2 * 3, 2 * 4, 
                    Console.Write("\t{0}", i * j);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
