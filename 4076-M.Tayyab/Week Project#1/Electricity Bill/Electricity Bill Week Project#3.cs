using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    public class ElectricBill
    {
        protected double units;

        public ElectricBill()
        {
            units = 30;
        }

        public ElectricBill(double unit)
        {
            units = unit;
        }

        public double getUnits()
        {
            return units;
        }

        public void CalculateBill()
        {
            Console.WriteLine("The Bill(only for meter) is: " + units * 5);
            return;
        }

    }

    class Residential : ElectricBill
    {

        public Residential(double unit)
        {
            units = unit;
        }

        public new void CalculateBill()
        {
            double bill;
            if (units < 0)
            {
                Console.WriteLine("The units are not readable");
                return;
            }
            if (units > 0 & units <= 100)
            {
                bill = units * 5;
            }
            else if (units > 100 & units <= 200)
            {
                bill = units * 17;
            }
            else if (units > 200 & units <= 500)
            {
                bill = units * 23;
            }
            else
            {
                bill = units * 69;
            }
            bill = bill + bill * 0.13;
            Console.WriteLine("The (residential)Bill for electricity is: " + bill);
            return;
        }
    }

    class Commercial : ElectricBill
    {
        public Commercial(double unit)
        {
            units = unit;
        }
        public new void CalculateBill()
        {
            double bill;
            if (units < 0)
            {
                Console.WriteLine("The Units are not readable");
                return;
            }
            else if (units > 0 & units <= 100)
            {
                bill = units * 8;
            }
            else if (units > 100 & units <= 200)
            {
                bill = units * 21;
            }
            else if (units > 200 & units <= 500)
            {
                bill = units * 23;
            }
            else
            {
                bill = units * 79;
            }

            bill = bill + bill * 0.17;
            Console.WriteLine("The (commercial)Bill for electricity is: " + bill);
            return;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Residential R1 = new Residential(50);
            R1.CalculateBill();
            Commercial C1 = new Commercial(50);
            C1.CalculateBill();
        }
    }
}