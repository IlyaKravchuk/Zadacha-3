using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,m;
            Console.WriteLine("Введите количество элементов в массиве");
            Int32 M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массив");
            Single[] array = new Single[M];
            Single[] Newarray = new Single[M];

            for (i = 0; i < M; i++)
            {
                array[i] = Convert.ToSingle(Console.ReadLine());
            }

            
            Int32 j = M-1;
            Int32 minin = 0;
            Single X = -100000;
            n = 0;
            m = j;

            for (i=0; i < M; i++ )
            {
                Single min = 100000;
                Int32 I = 0;
                for (I = 0; I < M; I++ )
                {
                    if ((array[I] < min) & (array[I] > X))
                    {
                        min = array[I];
                        minin = I;
                    }
                }
                if (Math.IEEERemainder(i, 2) == 0)
                {
                    Single Z = array[n];
                    array[n] = min;
                    array[minin] = Z;
                    n++;
                }
                else
                {
                    Single Z = array[m];
                    array[m] = min;
                    array[minin] = Z;
                    m--;
                }
                X = min;
            }

            Console.WriteLine("Обновленный массив: ");

            
            for ( i = 0; i < M; i++)
            Console.WriteLine(array[i]);
            Console.ReadLine();
        }
    }
}
