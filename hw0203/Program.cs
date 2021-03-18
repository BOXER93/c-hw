using System;

namespace hw0203
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[101];
            for(int i = 2; i <= 100; i++)
            {
                if (num[i]==0)
                {
                    for(int j = i * i; j <= 100; j = j + i)
                    {
                        num[j] = 1;
                    }
                }
            }
            for (int i = 2; i <= 100; i++)
            {
                if (num[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
