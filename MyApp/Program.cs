using System;
using System.Text;

namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(   Gilbert.SumNumbers(12, 12));

            StringBuilder sb = new StringBuilder("Gilbert");

            sb.Append('7');

            sb.ToString();

            Console.WriteLine(sb);
        }
    }

    //public static class Gilbert
    //{
    //    public static int a;

    //    public static int b;

    //    public static int SumNumbers(int a,int b)
    //    {
    //        int total = a + b;

    //        return total;
    //    }
    //}


}
