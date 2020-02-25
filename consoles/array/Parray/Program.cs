using System;

namespace Parray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[9];

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] % 2 == 1)
                {
                    vect[i]++;
                    Console.WriteLine(vect[i]);
                }
            }


        }
    }
}
