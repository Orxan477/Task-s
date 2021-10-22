using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tək ədədlərin cəminin tapılması
            //int a, b, c, d;
            //int odd = 0;
            //Console.Write("a=");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c=");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("d=");
            //d = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 != 0)
            //{
            //    odd += a;
            //}
            //if (b % 2 != 0)
            //{
            //    odd += b;
            //}
            //if (c % 2 != 0)
            //{
            //    odd += c;
            //}
            //if (d % 2 != 0)
            //{
            //    odd += d;
            //}
            //Console.WriteLine("Cem=" + odd);
            #endregion
            #region  Düzbucaqlı şkafın qapıdan keçirilməsi

            #endregion
            #region Sadə və ya mürəkkəb ədəd
            Console.Write("Ededi daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            n = Math.Abs(n);
            if (n<2)
            {
                Console.WriteLine("Ne Sadedir, ne de murekkeb");
            }
            if (n==2)
            {
                Console.WriteLine("sade ededdir");
            }
            for (int i = 2; i*i <=n ; i++)
            {
                if (n % i == 0)
                {
                    
                    Console.WriteLine("i=" + i + "   Murekkeb");
                    break;
                }
                Console.WriteLine("Sade");
            }
            
            #endregion
        }
    }
}
