using System;

namespace CLassWork
{
    internal class C1
    {
        public static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Enter how many numbers you want to store:");
            b = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[b];

            for (int i = 0; i < b; i++)
            {
                Console.Write("Enter number ");
            }                a[i] = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("You entered:");
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
