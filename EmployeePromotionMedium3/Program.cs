using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeePromotionMedium3
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static Employee employee = new Employee();
        static void Main()
        {
            int menu;
            string getEmployeeName;
            do
            {
                Employee employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();
                employees.Add(employee);
                Console.WriteLine("\nTo continue entering employee details enter 1, to exit enter 0");
                menu = Convert.ToInt32(Console.ReadLine());
            } while (menu == 1);
            SortAndPrintEmployees();
            Console.WriteLine("Please enter the employee Name");
            getEmployeeName = Console.ReadLine();
            PrintEmployee(getEmployeeName);
        }

        public static void SortAndPrintEmployees()
        {
            employees.Sort();
            Console.WriteLine("The sorted employee list");
            foreach (var employe in employees)
            {
                Console.WriteLine(employe.ToString());
                Console.WriteLine("-----------------------");
            }
        }
        public static void PrintEmployee(string empName)
        {
            var searchedEmployee = from emp in employees where emp.Name.Equals(empName) select emp;
            foreach (var emp in searchedEmployee)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
