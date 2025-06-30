using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPI;

namespace MPI_suma_matrice
{
    internal class Program
    {
        static int N = 4;
        static void Main(string[] args)
        {
            using (new MPI.Environment(ref args))
            {
                var comm = Communicator.world;
                int rank = comm.Rank;
                int size = comm.Size;

                int localSolutions = 0;

                for (int i = rank; i < N; i += size)
                {
                    int[] S = new int[N];
                    S[0] = i;
                    QUEENS(1, S, ref localSolutions);
                }

                int totalSolutions = comm.Reduce(localSolutions, Operation<int>.Add, 0);

                if (rank == 0)
                    Console.WriteLine($"Număr total de solutii pentru {N} regine: {totalSolutions}");
            }
        }

        static void QUEENS(int k, int[] S, ref int count)
        {
            for (int i = 0; i < N; i++)
            {
                if (ACCEPT(k, i, S))
                {
                    S[k] = i;
                    if (k == N - 1)
                    {
                        count++;
                    }
                    else
                    {
                        int[] Snew = (int[])S.Clone();
                        QUEENS(k + 1, Snew, ref count);
                    }
                }
            }
        }

        static bool ACCEPT(int k, int i, int[] S)
        {
            for (int j = 0; j < k; j++)
            {
                if (S[j] == i) return false;
                if (Math.Abs(j - k) == Math.Abs(S[j] - i)) return false;
            }
            return true;
        }
    }
}
