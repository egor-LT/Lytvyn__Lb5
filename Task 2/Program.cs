using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MathOperations
    {
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

      
        public static int[] Add(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Arrays must have the same length.");
            }

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }

       
        public static int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }



        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int[] Subtract(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Arrays must have the same length.");
            }

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] - arr2[i];
            }
            return result;
        }

       

        
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           
            int result1 = MathOperations.Add(5, 3);
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] result2 = MathOperations.Add(array1, array2);

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] result3 = MathOperations.Add(matrix1, matrix2);

            
            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: [" + string.Join(", ", result2) + "]");
            Console.WriteLine("Result 3:");
            for (int i = 0; i < result3.GetLength(0); i++)
            {
                for (int j = 0; j < result3.GetLength(1); j++)
                {
                    Console.Write(result3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}