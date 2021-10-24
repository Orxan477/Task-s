using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Tək ədədlərin cəminin tapılması
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
            //Console.WriteLine("--------------" );
            //Console.WriteLine("Cem=" + odd);
            #endregion

            #region 2. Düzbucaqlı şkafın qapıdan keçirilməsi
            //Console.Write("Qapinin enini daxil edin");
            //double q_e = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Qapinin uzunlugunu daxil edin");
            //double q_u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Skafin enini daxil edin");
            //double s_e = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Skafin uzunlugunu daxil edin");
            //double s_u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Skafin hundurluyunu daxil edin");
            //double s_h = Convert.ToDouble(Console.ReadLine());
            //if ((q_e > s_e && q_u > s_u) || (q_e > s_u && q_u > s_e) || (q_u > s_h && q_e > s_e) || (q_u > s_e && q_e > s_h))
            //{
            //    Console.WriteLine("Kecir");
            //}
            //else
            //{
            //    Console.WriteLine("Kecmir");
            //}
            #endregion

            #region 3. Sadə və ya mürəkkəb ədəd
            //Console.Write("Ededi daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //n = Math.Abs(n);
            //int i;
            //if (n < 2)
            //{
            //    Console.WriteLine("Ne Sadedir, ne de murekkeb");
            //}
            //if (n == 2)
            //{
            //    Console.WriteLine(n + " sade ededdir");
            //}
            //for (i = 2; i * i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {

            //        Console.WriteLine(n + " murekkeb ededdir");
            //        break;
            //    }
            //}
            //if (n % i != 0)
            //{
            //    Console.WriteLine(n + " sade ededdir");

            //}
            #endregion

            #region  4. Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. 
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n != 0)
            //    {
            //        n = n / 10;
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum + " mertebelidir");

            #endregion

            #region 5. String array və string qəbul edən bir algoritm yazın, əgər string array-də varsa true, yoxdusa false yazdırsın.
            //int i;
            //bool axtaris = false;
            //Console.Write("Massivin uzunlugunu daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------------");
            //string[] arr = new string[n];
            //Console.WriteLine("Massivii daxil edin: ");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToString(Console.ReadLine());
            //}
            //Console.WriteLine("-----------------");
            //Console.Write("Axtarilan sozu daxil edidin: ");
            //string search = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("-----------------");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == search)
            //    {
            //        axtaris = true;
            //        break;                   
            //    }      
            //}
            //if (axtaris)
            //{
            //    Console.WriteLine("true");
            //}
            //else     
            //Console.WriteLine("false");
            #endregion

            #region 6. Number array-in ən böyük elementini tapın. 
            //Console.Write("Number arrayinin uzunlugunu teyin edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[n];
            //int max = number[0];
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Arrayi daxil edin");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = Convert.ToInt32(Console.ReadLine());
            //    if (number[i] > max)
            //    {
            //        max = number[i];
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Boyuk element=" + max);
            #endregion

            #region 7. Number array-ini kiçikdən böyüyə doğru düzün.
            //int temp = 0;
            //Console.Write("Number arrayinin uzunlugunu teyin edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[n];
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Arrayi daxil edin");
            //for (int i = 0; i <= number.Length - 1; i++)
            //{
            //    number[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Daxil olunmus massiv:");
            //foreach (int item in number)
            //    Console.Write(item + " ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Baloncuq alqoritimi ile nizamlama");
            //Console.WriteLine();
            //for (int i = 0; i <= number.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= number.Length - 1; j++)
            //    {
            //        if (number[i] > number[j])
            //        {
            //            temp = number[i];
            //            number[i] = number[j];
            //            number[j] = temp;
            //            foreach (int item in number)
            //                Console.Write(item + " ");
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Nizamlanmis massiv:");
            //foreach (int item in number)
            //    Console.Write(item + " ");
            //Console.WriteLine();
            #endregion

            #region 8. Daxil olunmus eded 7-ye qaliqsiz bolunurse ozunu, bolunmurse hemin edede yaxin ve 7-ye boluneni capa ver.
            //int k, c;
            //Console.Write("Ededi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //k = n % 7;  
            //c = n / 7;
            //if (n >= 0 || n <= -14)
            //{
            //    if (n % 7 != 0)
            //    {
            //        if (k > 3)
            //        {
            //            n = (c * 7) + 7;
            //            Console.WriteLine("7-ye qaliqsiz bolunen yaxin eded: " + n);
            //        }
            //        else
            //        {
            //            n = c * 7;
            //            Console.WriteLine("7-ye qaliqsiz bolunen yaxin eded: " + n);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(n + " ededi 7-ye qaliqsiz bolunur");
            //    }
            //}
            //else if ((n>-14)&&(n<=-11))
            //{
            //    n = (c * 7) - 7;
            //    Console.WriteLine("7-ye qaliqsiz bolunen yaxin eded: " + n);
            //}
            //else
            //{
            //    n =-7;
            //    Console.WriteLine("7-ye qaliqsiz bolunen yaxin eded: " + n);
            //}
            #endregion

            #region 9.Verilmis indeksdeki eded oz indeksinin quvvetiirmi?
            //int count = 0;
            //int temp = 1;
            //int i;
            //Console.Write("Massivin uzunlugunu daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Massivin elementlerini daxil edin");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //if (arr[0] == 0 && arr[1] == 1)
            //    count = 2;
            //else if (arr[0] == 0 || arr[1] == 1)
            //    count = 1;
            //else
            //    count = 0;
            //for (i = 2; i < arr.Length; i++)
            //{
            //    while (arr[i] % i == 0)
            //    {
            //        arr[i] = arr[i] / i;
            //        if (arr[i] == 1)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine("Quvveti olan " + count + " element var");
            #endregion

            #region 10. Verilmis ededin musbet ve ya menfi oldugunu tapin
            //Console.Write("Ededi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("--------------");
            //if (n>0)
            //{
            //    Console.WriteLine(n+" ededi musbetdir");
            //}
            //else
            //{
            //    Console.WriteLine(n + " ededi menfidir");
            //}
            #endregion

            #region 11. Ededin 3 ve 7-ye bolunduyunu yoxlayin
            //Console.Write("Ededi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------");
            //if (n % 21 == 0)
            //{
            //    Console.WriteLine(n + " ededi 3 ve 7-ye bolunur");
            //}
            //else
            //{
            //    Console.WriteLine(n + " ededi 3 ve 7-ye bolunmur");
            //}
            #endregion

            #region 12. 3 ededden en boyuyunu tapin
            //Console.WriteLine("Ededleri daxil edin: ");
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c=");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("------------------");
            //if ((a > b) && (a > c))
            //{
            //    Console.WriteLine(a + " ededi boyukdur");
            //}
            //else if ((b > a) && (b > c))
            //{
            //    Console.WriteLine(b + " ededi boyukdur");
            //}
            //else if ((c > a) && (c > b))
            //{
            //    Console.WriteLine(c + " ededi boyukdur");
            //}
            //else if ((a == b) && (b > c))
            //{
            //    Console.WriteLine("a ededi b ededine beraberdir ve "+c+" ededinden boyukdur");
                
            //}
            //else if (a == b && b < c)
            //{
            //    Console.WriteLine(c + " ededi boyukdur");
            //}
            //else if (b == c && a > b)
            //{
            //    Console.WriteLine(a + " ededi boyukdur");
            //}
            //else if (b == c && a < b)
            //{
            //    Console.WriteLine("b ededi c ededine beraberdir ve " + a + " ededinden boyukdur");
               
            //}
            //else if (a == c && a < b)
            //{
            //    Console.WriteLine(b + " ededi boyukdur");
            //}
            //else if (a == c && a > b)
            //{
            //    Console.WriteLine("a ededi c ededine beraberdir ve " + b + " ededinden boyukdur");
            //}
            //else if ((a == b) && (a == c) && (b == c))
            //{
            //    Console.WriteLine("Ededler beraberdir");
            //}
            #endregion
        }
    }
}
