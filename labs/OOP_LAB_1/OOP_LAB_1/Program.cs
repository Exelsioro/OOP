using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            // задание 1 а
            sbyte sb = 1;
            short sh = 2;
            int i = 3;
            long l = 4;
            byte b = 5;
            ushort ush = 6;
            uint ui = 7;
            ulong ul = 8;
            char ch = 'c';
            bool bo = true;
            float fl = 9;
            double db = 10;
            string str = "ы";
            object OBJ = 11;

            // задание 1 б
            int A = 1;
            uint asd = 12;
            Int32 i32 = 2;

            //неявное
            float q = A;
            double w = A;
            long lng = A;
            Int64 i64 = i32;
            ulong sd = asd;

            //явное
            short sho = (short)A;
            ushort uss = (ushort)A;
            byte bt = (byte)A;
            uint u = (uint)A;
            float B = (float)A;

            // задание 1 в
            int box = 1;
            object obox = box;
            double doub = (double)(int)obox;

            // задание 1 г 
            var a = true;
            Console.WriteLine(a);

            //задание 1 д
            int? x1 = null;
            int? x2 = null;
            Console.WriteLine(x1 == x2);

            //задание 2 а, б
            string st2 = "www";
            string st3 = "qqq.eee rrr";
            string st1 = "qqq";
            Console.WriteLine(st2 == st1);
            Console.WriteLine(st1 + st2);
            Console.WriteLine(String.Copy(st1));
            string st4 = st3.Substring(4, 3);
            Console.WriteLine(st4);
            char[] del = " .".ToCharArray();
            string[] words = st3.Split(del, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                Console.WriteLine(word);
            string st5 = st2.Insert(3, st1);
            Console.WriteLine(st5);
            string st6;
            st6 = st2.Remove(1, 1);
            Console.WriteLine(st6);

            //задание 2 в
            string nll = null;
            Console.WriteLine(nll + st1);
            Console.WriteLine(nll == st1);
            Console.WriteLine(nll != st1);

            //задание 2 г
            StringBuilder strbldr = new StringBuilder("strbldr", 50);
            Console.WriteLine(strbldr);
            strbldr.Append(new char[] { 'Q', 'W', 'E' });
            strbldr.Insert(0, "QQQ");
            strbldr.Remove(4, 3);
            Console.WriteLine(strbldr);

            //задание 3 a
            int[,] mass = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine();
            for (int cnt = 0; cnt < 2; cnt++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int cnt2 = 0; cnt2 < 2; cnt2++)
                {
                    Console.Write(mass[cnt, cnt2] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ////задание 3 б
            //string[] strmss = new string[] { "qwe", "asd", "zxc" };
            //for (int cnt2 = 0; cnt2 < 3; cnt2++)
            //{
            //    Console.Write(strmss[cnt2] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine(strmss.Length);
            //Console.WriteLine("Введите позицию");
            //int pos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите строку");
            //strmss[pos] = Console.ReadLine();
            //for (int cnt2 = 0; cnt2 < 3; cnt2++)
            //{
            //    Console.Write(strmss[cnt2] + "\t");
            //}
            //Console.WriteLine();

            ////задание 3 в
            //int[][] jugo = new int[3][];
            //jugo[0] = new int[2];
            //jugo[1] = new int[3];
            //jugo[2] = new int[4];
            //Console.WriteLine("Введите элементы ступенчатого массива");
            //for (int cnt = 0; cnt < jugo.Length; cnt++)
            //{
            //    for (int cnt2 = 0; cnt2 < jugo[cnt].Length; cnt2++)
            //    {
            //        jugo[cnt][cnt2] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //foreach (int[] eac in jugo)
            //{
            //    foreach (int eac2 in eac)
            //    {
            //        Console.Write(eac2 + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // задание 3 г
            var array = new object[1];
            var strin_g = "qwe";

            // задание 4 а б в г
            (int first, string second, char third, string fourth, ulong fifth) tp = (1, "qwe", 'q', "qwer", 2);
            Console.WriteLine($"{tp}");
            Console.WriteLine($"{tp.first} {tp.third} {tp.fourth}");

            var e1 = tp.first;
            var e2 = tp.second;
            var e3 = tp.third;
            var e4 = tp.fourth;
            var e5 = tp.fifth;

            var t1 = Tuple.Create(123, "Hello");
            var t2 = Tuple.Create(123, "Hello");
            Console.WriteLine(t1 == t2); // False
            Console.WriteLine(t1.Equals(t2)); // True

            //задание 5
            int LocFunc(int[] U, string strng)
            {
                int max = 0, min = 1234567890, sum = 0;
                char first_symb = strng[0];
                for (int M = 0; M < U.Length; M++)
                {
                    if (U[M] > max)
                    {
                        max = U[M];
                    }
                }
                for (int M = 0; M < U.Length; M++)
                {
                    if (U[M] < min)
                    {
                        min = U[M];
                    }
                }
                for (int M = 0; M < U.Length; M++)
                {
                    sum = sum + U[M];
                }

                (int, int, int, char) AAAAAAAAAAAAA = (min, max, sum, first_symb);
                Console.WriteLine($"{AAAAAAAAAAAAA}");
                return 0;
            }
            int[] W = { 1,5, 6, 7, 2, 3 };
            string STR = "qwer";
            LocFunc(W, STR);



        }
    }
}
