using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz1
{
    internal class Ex3
    {
        public void Exercise()
        {
            int N = 10 + 6;
            int[] X = new int[N];

            Random random = new Random();

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                X[i] = random.Next() % 51;
                Console.WriteLine(X[i]);

                if (X[i] < min)
                    min = X[i];

                else if (X[i] > max)
                    max = X[i];
            }
           Console.WriteLine($"Minimum = {min}");
           Console.WriteLine($"Max = {max}");
        }
    }
}
