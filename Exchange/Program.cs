using System;

namespace change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sale Amount :");
            var saleamount = Console.ReadLine();
            Console.WriteLine("Pay Amount :");
            var payamount = Console.ReadLine();

            var sale = Convert.ToDouble(saleamount);
            var pay = Convert.ToDouble(payamount);
            var change = pay - sale;

            Console.WriteLine("Change Amount :"+change);

            var c1000 = change / 1000;
            var r1000 = change % 1000;

            var c500 = r1000 / 500;
            var r500 = r1000 % 500;

            var c100 = r500 / 100;
            var r100 = change % 100;

            var c50 = r100 / 50;
            var r50 = r100 % 50;

            var c20 = r50 / 20;
            var r20 = r50 % 20;

            var c10 = r20 / 10;
            var r10 = r20 % 10;

            var c5 = r10 / 5;
            var r5 = r10 % 5;


            Console.WriteLine("1000 * " + (int)c1000);
            Console.WriteLine("500 * " + (int)c500);
            Console.WriteLine("100 * " + (int)c100);
            Console.WriteLine("50 * " + (int)c50);
            Console.WriteLine("20 * " + (int)c20);
            Console.WriteLine("10 * " + (int)c10);
            Console.WriteLine("5 * " + (int)c5);
            Console.WriteLine(r5);

            cal_change cal = new cal_change();
            cal.calchange(saleamount,payamount);
        }
    }
}
