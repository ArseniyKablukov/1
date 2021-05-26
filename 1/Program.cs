using System;

namespace _1
{
    class Program
    {
        static class lib1
        {
            //2
            static void stpow()
            {
                string a = Convert.ToString(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < b; i++)
                {
                    Console.Write(a);
                }
            }


            //3
            static void rev()
            {
                string a = Convert.ToString(Console.ReadLine());
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            }


            //5
            static void remov()
            {
                string str = Convert.ToString(Console.ReadLine());
                string s = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        str = str.Replace(Convert.ToString(s[j]), "");
                    }
                }
                Console.WriteLine(str);
            }


            //6
            static void leng()
            {
                string str = Convert.ToString(Console.ReadLine());
                Console.WriteLine(str.Length);
            }
        }

    }
}
