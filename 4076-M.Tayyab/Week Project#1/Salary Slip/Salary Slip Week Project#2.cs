using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
public class SalarySlip
{
    string designation;

    public SalarySlip()
    {
        designation = "Employee";
    }

    public void setDesignation()
    {
        Console.WriteLine("Enter the designation of Employee(Engineer, Manager, Analyst): ");
        designation = Console.ReadLine();
    }

    public string getDesignation()
    {
        return designation;
    }

    public void Salary()
    {
        if (designation.ToLower() == "engineer")
        {
            Console.WriteLine("Gross Salary for " + designation + " is: $" + 2100);
        }
        else if (designation.ToLower() == "manager")
        {
            Console.WriteLine("Gross Salary for "+ designation + " is: $" + 2750);
        }
        else if (designation.ToLower() == "analyst")
        {
            Console.WriteLine("Gross Salary for " + designation + " is: $" + 2450);
        }
        else
        {
            Console.WriteLine("The gross salary of employee is : 1500");
        }
        return;
    }
}
class Program
{
    public static void Main(string[] args)
    {

        SalarySlip S1 = new SalarySlip();
        S1.setDesignation();
        S1.Salary();
        SalarySlip S2 = new SalarySlip();
        S2.setDesignation();
        S2.Salary();
        SalarySlip S3 = new SalarySlip();
        S3.setDesignation();
        S3.Salary();
    }
}
}


