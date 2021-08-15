/*Create a class called EmployeeSalary with attributes as EmployeeId, name, 
Basic salary, HR allowance, Travel Allowant, % of income tax deduction. 
Provide appropriate visibility (private/public/protected/static)  of all the attributes. 
Create a constructor to accept employee salary details.*/

using System;

namespace Dailytask3 
{
    class EmployeeSalary
    {
        public int EmployeeID;
        public string Name;
        double BasicSalary;
        double HRallowance;
        double TravelAllowance;
        public double  Deduction_Percent;
        private double calc_Percent(EmployeeSalary emp) 
        {
            double totsal = BasicSalary + HRallowance + TravelAllowance; 
            double annualsal = totsal * 12;
            double itp;
            if (annualsal < 500000)
            {
                itp = 0;
            }
            else if (annualsal < 1000000)
            {
                itp = 10;
            }
            else if (annualsal < 1500000)
            {
                itp = 20;
            }
            else
            {
                itp = 30;
            }

            return itp;
        }
     
        public EmployeeSalary(int eid, string ename, float ebsal, float ehra, float eta)
        {
            EmployeeID = eid;
            Name = ename;
            BasicSalary = ebsal;
            HRallowance = ehra;
            TravelAllowance = eta;
            Deduction_Percent = calc_Percent(this);
        }


    }
    class employee
    {
        static void Main()
        {
            EmployeeSalary e = new EmployeeSalary(1, "kriti", 50000, 80000, 300000);
            EmployeeSalary e1 = new EmployeeSalary(2, "shikha", 15000, 35000, 65000);
            EmployeeSalary e2 = new EmployeeSalary(3, "ujjwal", 20000, 24000, 15000);
            EmployeeSalary e3 = new EmployeeSalary(4, "rina", 10000, 30000, 15000);
            Console.WriteLine("Employee ID is " + e.EmployeeID + " With Name " + e.Name +
                " Whose IT Slab is " + e.Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e1.EmployeeID + " With Name " + e1.Name +
                " Whose IT Slab is " + e1.Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e2.EmployeeID + " With Name " + e2.Name +
                " Whose IT Slab is " + e2.Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e3.EmployeeID + " With Name " + e3.Name +
                " Whose IT Slab is " + e3.Deduction_Percent + "%");
        }
    }
}
