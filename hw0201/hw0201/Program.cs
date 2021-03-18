using System;

namespace hw0201
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("输入数字");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("该数素数因子：");
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    int x = 0;int y;
                    for (y = 1; y <= i; y++)
                    {
                        if (i % y == 0)
                        {
                            x++;
                        }
                    }
                    if (x == 2)
                    {
                        Console.Write(i+",");
                    }
                }
            }
        }
    }
}
