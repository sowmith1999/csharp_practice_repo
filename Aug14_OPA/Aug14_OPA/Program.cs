using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string empName = Console.ReadLine();
                string experience = Console.ReadLine();
                string qualification = Console.ReadLine();
                manager.AddEmployee(empName, experience, qualification);
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            // Enter code for performing 2 tasks
            #region solution1
            if(choice==1)
            {
               List<Employee> Employeelist=manager.ViewEmployees();
                if(Employeelist.Count==0)
                {
                    Console.WriteLine("No employees present");
                }
                else
                {
                    foreach(var k in Employeelist)
                    {
                        int dotlocation = k.Experience.IndexOf('.');
                        int years = int.Parse(k.Experience.Substring(0, dotlocation));
                        int months = int.Parse(k.Experience.Substring(dotlocation + 1));
                        Console.WriteLine(k.Empid+": "+k.EmpName+", experience: "+years+"y "+months+"m, gross = "+k.GrossSalary+", net = "+k.NetSalary);
                    }
                }
            }
            else
            {
                string empName = Console.ReadLine();
                string experience = Console.ReadLine();
                string qualification = Console.ReadLine();
                if(qualification!="Degree" && qualification!="Masters")
                {
                    Console.WriteLine("Qualification invalid!");
                    return;
                }
                if(experience.Length<3)
                {
                    Console.WriteLine("Invalid format!");
                    return;
                }
                Employee hold = manager.AddEmployee(empName, experience, qualification);
                Console.WriteLine("Following employee has been added");
                Console.WriteLine("Name: "+hold.EmpName);
                Console.WriteLine("ID: "+hold.Empid);
                Console.WriteLine("Experience: "+hold.Experience);
                Console.WriteLine("Qualification: "+hold.Qualification);
                Console.WriteLine("Basic Pay: "+hold.BasicSalary);
                Console.WriteLine("Gross Pay: "+hold.GrossSalary);
                Console.WriteLine("PF: "+hold.Pf);
                Console.WriteLine("Tax: "+hold.Tax);
                Console.WriteLine("Net Pay: "+hold.NetSalary);



            }


            #endregion

        }
    }

    // Create class Employee as per given specification
    #region solution2
    class Employee
    {

        private int empid;
        private static int hold = 1001;
        private string empName;
        private string experience;
        private string qualification;
        private double grossSalary;
        private double basicSalary;
        private double pf;
        private double tax;
        private double netSalary;

        public int Empid { get => empid; set => empid = value; }
        public static int Hold { get => hold; set => hold = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public double GrossSalary { get => grossSalary; set => grossSalary = value; }
        public double Pf { get => pf; set => pf = value; }
        public double Tax { get => tax; set => tax = value; }
        public double NetSalary { get => netSalary; set => netSalary = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public Employee(string empName, string experience, string qualification)
        {
            this.Empid = hold;
            this.EmpName = empName;
            this.Experience = experience;
            this.Qualification = qualification;
            this.GrossSalary = 0;
            this.basicSalary = 0;
            this.Pf = 0;
            this.Tax = 0;
            this.NetSalary = 0;
            hold = hold + 1;
        }

    }


    #endregion

    // Create class EmployeeManager as per given specification
    // Write code for methods that would perform operations handled in solution1
    #region solution3
    class EmployeeManager
    {
        public List<Employee> employees = new List<Employee>();
        public double CalculateGross(string experince,string qualification)
        {
            int dotlocation = experince.IndexOf('.');
            int years =int.Parse(experince.Substring(0, dotlocation));
            int months = int.Parse(experince.Substring(dotlocation + 1));
            double grosssalary=0;
            if(years==0)
            {
                grosssalary = 250000;
                if(qualification=="Masters")
                {
                    grosssalary = grosssalary + 50000;
                }
            }
            else if(years>0)
            {
                if(qualification=="Masters")
                {
                    grosssalary = 250000 + 65000 * years;
                }
                else
                {
                    grosssalary = 250000 + 50000 * years;
                }
            }
            return grosssalary;
        }
        public double CalculateTax(double grosssalary)
        {
            double tax = 0;
            if(grosssalary<=300000)
            {
                tax = 0;
            }
            else if(grosssalary>300000 && grosssalary<500001)
            {
                tax = 0.1 * grosssalary;
            }
            else if (grosssalary > 500000 & grosssalary < 800001)
            {
                tax = 0.2 * grosssalary;
            }
            else if(grosssalary>800000)
            {
                tax = 0.3 * grosssalary;
            }
            return tax;
        }
        public List<Employee> ViewEmployees()
        {
            return this.employees;
        }
        public Employee AddEmployee(string empName, string exp, string qualification)
        {
            Employee Hold = new Employee(empName,exp,qualification);
            Hold.GrossSalary = CalculateGross(exp, qualification);
            Hold.Tax = CalculateTax(Hold.GrossSalary);
            Hold.BasicSalary = 0.4 * Hold.GrossSalary;
            Hold.Pf = 0.12 * Hold.BasicSalary;
            Hold.NetSalary = Hold.GrossSalary - (Hold.Pf + Hold.Tax);
            employees.Add(Hold);
            return Hold;
        }
    }


    #endregion

    // Other miscellaneous code, if required
    #region miscellaneous



    #endregion

}