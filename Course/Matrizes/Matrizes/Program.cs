using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] values = Console.ReadLine().Split(" ");
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values1 = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values1[j]);
                }

            }

            int numberSelect = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {               
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j]  == numberSelect)
                    {
                        Console.WriteLine("Position"+i+","+j);
                        
                        if(j != 0)
                        Console.WriteLine("Left: " + mat[i , j-1]);
                        if(j !=  n-1 )
                        Console.WriteLine("Right: " + mat[i , j+1]);
                        if (i != 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (i != m-1)
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }

            }



            /*int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Main Diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i]+" ");
            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        count++;
                }

            }
            Console.WriteLine("Negative numbers: "+ count );*/


            /*double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));*/

        }
    }
}
