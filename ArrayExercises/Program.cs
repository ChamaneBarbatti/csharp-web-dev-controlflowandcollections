using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array  = new int[6];
            int[] array1  = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in array1) 
            {
                Console.WriteLine(num);

            }
        }
    }
}