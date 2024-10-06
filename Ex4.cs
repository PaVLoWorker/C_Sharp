using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz1
{
    internal class Ex4
    {
        public void Exercise()
        {
            int N = 10 + 6;
            int[] X = new int[N];
            int M = 13;

            int counter = 0;

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                X[i] = random.Next() % 51 - 26;

                if (Math.Abs(X[i]) > M)
                    counter++;
            }
            foreach (int i in X)
                Console.Write(i + "\t");

            int[] Y = new int[counter] ;

            Yfilling(X, Y, N, M);

            Console.WriteLine();

            foreach (int i in Y)   
                Console.Write(i + "\t");
        }
        private void Yfilling(int[] X, int[] Y, int N, int M)
        {
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(X[i]) > M)
                {

                    Y[k] = X[i];
                    k++;
                }
            }
        }
    }   
}
