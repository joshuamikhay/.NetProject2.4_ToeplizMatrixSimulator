using System;
//2018326660145
//Joshua Mikhay Kusuma
//Toepliz Matrix
namespace _2._4
{
    class Program
    {
        public static int x = 3;
        public static int y = 4;

    
        static bool isToepliz(int[,] matrix) //check if its toepliz matrix or not
        {
            for(int i=0; i<x-1;i++) //check the first row
            {
                for(int j=0;j<y-1;j++)
                {
                    if(matrix[i,j] != matrix[i+1,j+1])
                    {
                        return false;
                    }
                }
            }
            return true; //when all descending diagonals from begining-end are same
        }
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine(" >>Toepliz Matrix Simulation <<" + "\n");
            int[,] matrix = { { 1, 2, 3, 4 },
                              { 5, 1, 2, 3 }, 
                              { 9, 5, 1, 2 } };
            Console.WriteLine("Matix is shown below: ");
            for(int i=0; i<matrix.GetLength(0);i++)
            {
                for(int j=0; j<matrix.GetLength(1);j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    counter++;
                    if(counter%matrix.GetLength(0)==0)
                    {
                        Console.WriteLine(" ");
                    }

                }
            }
            Console.WriteLine("\n");
            if(isToepliz(matrix))
            {
                Console.WriteLine("The Matrix is a Toepliz Matrix !");
            }
            else
            {
                Console.WriteLine("The Matrix is not a Toepliz Matrix !");
            }
                        
        }
    }
}
