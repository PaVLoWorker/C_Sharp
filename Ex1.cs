using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz1
{
    internal class Ex1
    {
        public void Exercise()
        {
            int N = 10 + 6;
            int[] masivchik = {1, 2, 40};

            foreach (int i in masivchik)
            {
                if (compare(N, i))
                   Console.WriteLine($"{i} is in diapazone");
                else
                    Console.WriteLine($"{i} is out of diapazone");
            }
            
                
        }

        private bool compare (int N, int num)
        {
            return (num <= N && N >= 1);

        }
    }
}
