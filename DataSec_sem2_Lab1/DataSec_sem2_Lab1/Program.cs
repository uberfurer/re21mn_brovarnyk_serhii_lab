using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataSec_sem2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "";
            string strB = "";
            string strM = "";
            Console.WriteLine("Do you want type your own polynomials or check a preset result?\nType *check* to check or *enter* to type your values...");
            string message = Console.ReadLine();
            if (message == "check")
            {
                strA = "1001101101";
                strB = "11100011";
                strM = "10011";
            }
            else if(message == "enter")
            {
                Console.WriteLine("Type polinomial A:");
                strA = Console.ReadLine();
                Console.WriteLine("Type polinomial B:");
                strB = Console.ReadLine();
                Console.WriteLine("Type polinomial M:");
                strM = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error. Program will be terminated...");
                Environment.Exit(0);
            }
            
            int a = Convert.ToInt32(strA, 2);
            int b = Convert.ToInt32(strB, 2);
            int m = Convert.ToInt32(strM, 2);
            BitArray arrA = new BitArray(BitConverter.GetBytes(a));
            BitArray arrB = new BitArray(BitConverter.GetBytes(b));
            BitArray arrM = new BitArray(BitConverter.GetBytes(m));
            BitArray arrAB = new BitArray(arrA.Count + arrB.Count - 1);
            Console.WriteLine("A * B Operation:");
            byte[] res = new byte[32];
            int resInt = 0;
            string AB = "";
            for (int pos = 0; pos < arrB.Count; pos++)
            {
                for(int pos2 = 0; pos2 < arrA.Count; pos2++)
                {
                    arrAB.Set(pos + pos2, arrAB.Get(pos + pos2) ^ (arrA.Get(pos2) & arrB.Get(pos)));
                }
                arrAB.CopyTo(res, 0);
                resInt = BitConverter.ToInt32(res, 0);
                if(arrB.Get(pos) == true)
                {
                    AB = Convert.ToString(resInt, 2);
                    Console.WriteLine(AB);
                }
            }
            
            BitArray arrABmodM = new BitArray(BitConverter.GetBytes(resInt));
            Console.WriteLine("\nMod M Operation:");
            for (int shift = AB.Length - strM.Length; shift > 0; shift--)
            {
                while ((arrABmodM.Get(shift + strM.Length - 1) == false) && shift > 0) shift--;
                BitArray arrSh = LeftShift(arrM, shift);
                for (int pos = 0; pos < arrA.Count; pos++)
                {
                    arrABmodM.Set(pos, arrABmodM.Get(pos) ^ arrSh.Get(pos));
                }
                arrABmodM.CopyTo(res, 0);
                resInt = BitConverter.ToInt32(res, 0);
                Console.WriteLine(Convert.ToString(resInt, 2));
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static BitArray LeftShift(BitArray arr, int count)
        {
            BitArray arr_t = new BitArray(arr);
            for(int i = arr_t.Count-1; i >= 0; i--)
            {
                if(i + count < arr_t.Count)
                {
                    arr_t.Set(i + count, arr_t.Get(i));
                    arr_t.Set(i, false);
                }
            }
            return arr_t;
        }
    }
}
