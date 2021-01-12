using System;

namespace Matrices_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square matrix size: ");
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                
                for(int ii = 0; ii < size; ii++)
                {
                    matrix[i, ii] = int.Parse(line[ii]);
                }
                
            }


        }
    }
}
