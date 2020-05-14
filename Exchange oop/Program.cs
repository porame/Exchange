using System;

namespace oop_change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sale Amount :");
            var saleamount = Console.ReadLine();
            Console.WriteLine("Pay Amount :");
            var payamount = Console.ReadLine();

            cal_change cal = new cal_change();
            cal.calchange(saleamount, payamount);
            Console.WriteLine("Pay Amount :"+ cal.calchange(saleamount, payamount));
            cal.change_thai();
        }
    }
}
