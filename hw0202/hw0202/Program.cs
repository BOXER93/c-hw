using System;

namespace hw0202
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 13, 89, 10, 28, 14 };
            int max=a[0], min=a[0];
            double ave, sum = a[0];
            Console.WriteLine("数组元素：");
            Console.Write(a[0] + "  ");
            for (int i = 1; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + "  ");
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min> a[i])
                {
                    max = a[i];
                }
                sum = sum + a[i];
            }
            ave =sum / a.Length;
            Console.WriteLine("");
            Console.WriteLine("最大值："+max);
            Console.WriteLine("最小值："+min);
            Console.WriteLine("总和："+sum);
            Console.WriteLine("平均值："+ave);
        }
    }
}
