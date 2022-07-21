using System;
using System.Collections.Generic;
using CS_EmployeeInfo.Models;
using CS_EmployeeInfo.Task1;
using CS_EmployeeInfo.Task2;
using CS_EmployeeInfo.Task3;
using CS_EmployeeInfo.Task4;
using CS_EmployeeInfo.Task5;
using static CS_EmployeeInfo.Models.EmployeeType;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EmployeeInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("INITIATING TASK -1 : CRUD OPERATIONS");
            Console.WriteLine(" ");
            Crud obj = new Crud();
            obj.performCrud();
            Console.Clear();

            Gateway gateway = new Gateway();

            Console.WriteLine("Using Inheritence");
            Manager manager = new Manager(1, "Harsh", 100050, "Pro Dev", 1500, 2000);
            Console.WriteLine($"Salary for Manager = {manager.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(manager);



            Console.ReadLine();
            Engineer engineer = new Engineer(2, "I am engineer ", 576456, "Eng Dept", 3, 4);
            Console.WriteLine($"Salary for Engineer = {engineer.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(engineer);

            Console.ReadLine();
            SalesManager salesManager = new SalesManager(3, "I am sales manager", 1054000, "sales Dept", 1000, 2000, 2000, 1000);
            Console.WriteLine($"Salarr for Sales Manager = {salesManager.GetSalary()}");
            Console.WriteLine("Gateway operation to calculate gross salary as per designation");
            gateway.GrossSalary(salesManager);

            Console.ReadLine();


            /**

            //-----------------------------------------------------------------------------------------------

            
            Console.WriteLine("INITIATING TASK -2 :  GROSS SALARY");
            Console.WriteLine(" ");
            GrossSalary obj1 = new GrossSalary();
            obj1.printGross(obj1.calculateGrossSalary());
            Console.Clear();

            //--------------------------------------------------------------------------------------------------



            Console.WriteLine(" ");
            Console.WriteLine("INITIATING TASK -3 :  GROSS TAX");
            Console.WriteLine(" ");
            Tax obj2 = new Tax();
            obj2.printTax(obj2.taxAssign());
            Console.Clear();

            //---------------------------------------------------------------------------------------------------------

            Console.WriteLine(" ");
            Console.WriteLine("INITIATING TASK -4 :  NET SALARY");
            Console.WriteLine(" ");
            NetSalary obj3 = new NetSalary();
            obj3.printNet(obj3.calculateNet());
            Console.Clear();

            //--------------------------------------------------------------------------------------------------------------


            Console.WriteLine(" ");
            Console.WriteLine("INITIATING TASK -5:  NET SALARY IN WORDS");
            Console.WriteLine(" ");
            NetInWords obj4 = new NetInWords();
            obj4.printNet(obj4.printNetWords());
            **/
        }
    }
}