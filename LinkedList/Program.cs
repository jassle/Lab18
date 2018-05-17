using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Numbers = new int [] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            int x = Numbers.Max()+1;
            int[] countInt = new int[x];
            Console.WriteLine(x);
            //TheMostAwesomeList Mal_Ever = new TheMostAwesomeList();
            //Mal_Ever.Add("James");
            //Mal_Ever.Add("Jackson");
            //Mal_Ever.Add("Jason");
            //Console.WriteLine(Mal_Ever.Count);
            //Console.WriteLine(Mal_Ever.GetNode(2).Data);

            //for (int i = 0; i < Mal_Ever.Count; i++)
            //{
            //    Console.WriteLine(Mal_Ever.GetNode(i).Data);
            //}
            for (int i = 0; i < Numbers.Length; i++)
            {
                countInt[Numbers[i]]++; //Thank you Mike

                //for (int j = 0; j <= Numbers.Max(); j++)
                //{
                //if(Numbers[i] == j)
                //    {
                //        countInt[j]++;
                //    }
                //}
            }
            for (int i = 0; i <= Numbers.Max(); i++)
            {
                Console.WriteLine($"{i}. {countInt[i]}");
            }
        }
       
    }
}
