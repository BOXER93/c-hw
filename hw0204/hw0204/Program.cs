using System;

namespace hw0204
{
    public interface square     //接口
    {
        double s() ;           //面积
    }
    class chang : square        //长方形
    {
        private int a, b;
        public chang(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public double s ()
        {
            return a * b;
        }
    }
    class zheng : square           //正方形
    {
        private int a;
        public zheng(int a)
        {
            this.a = a;
        }
        public double s()
        {
            return a * a;
        }
    }
    class san : square      //三角形
    {
        private int a, b, c;
        public san(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a + b <= c || a + c <= b)
            {
                Console.WriteLine("不是三角形重新创建对象");
            }
        }
        public double s()
        {
            int p = (a + b + c) / 2;
            return System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

   class test                                   //十个形状对象
    {
        static void Main(String[] args)
        {
            chang a = new chang(2, 1);
            chang b= new chang(1, 1);
            chang c= new chang(1,41);
            zheng d = new zheng(2);
            zheng e = new zheng(3);
            zheng f = new zheng(4);
            zheng g = new zheng(5);
            san x = new san(1, 3, 3);
            san y = new san(3, 4, 5);
            san z = new san(10, 10, 10);
            Console.WriteLine("十个形状的面积和："+(a.s()+b.s()+c.s()+d.s()+e.s()+f.s()+g.s()+x.s()+y.s()+z.s()));

        }
    }
}
