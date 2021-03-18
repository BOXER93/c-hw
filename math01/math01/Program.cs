using System;


namespace math01
{
    class Program
    {
        static void Main(string[] args)
        {
     
            /*
             Console.WriteLine("请输入学生姓名：");
             string name = Console.ReadLine();
             Console.WriteLine("请输入所在学校：");
             string school = Console.ReadLine();
             Console.WriteLine("{0}同学在{1}学习", name, school);
            */
            Console.Write("输入第一个数字");
            int a = Convert.ToInt32(Console.ReadLine());//直接用(int)Console.Read()键盘输入似乎会出问题。
                                                        //最上面注释写法键盘输入无问题
            Console.Write("输入四则运算符中的一个");
            char b = char.Parse(Console.ReadLine());
            Console.Write("输入第二个数字");
            int c = Convert.ToInt32(Console.ReadLine());
            if (b == '+')
            {
                Console.WriteLine("运算结果："+(a+c));
            }
            if (b == '-')
            {
                Console.WriteLine("运算结果：" + (a -c));
            }
            if (b == '*')
            {
                Console.WriteLine("运算结果：" + (a * c));
            }
            if (b == '/')
            {
                Console.WriteLine("运算结果：" + (a / c));
            }
            Console.WriteLine("Hello World!");
        }
    }
}

