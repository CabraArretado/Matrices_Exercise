using System;
using System.Linq;
using System.Collections.Generic;

namespace Matrices_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a square matrix (Multidimensional array)
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


            // Printing the main diagonal of the created matrix
            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(matrix[i,i] + " ");
            }
            Console.WriteLine();


            // Display how many negative numbers were used in the matrix
            var lista = new List<int>();
            for(int i = 0; i < size; i++)
            {
                for(int ii = 0; ii < size; ii++)
                {
                    if (matrix[i, ii] < 0) lista.Add(matrix[i, ii]);
                }
            }
            Console.WriteLine("Negative numbers: " + lista.Count);

        }
    }
}
