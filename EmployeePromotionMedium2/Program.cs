using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeePromotionMedium2
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static Employee employee = new Employee();
        static void Main()
        {
            int menu, getEmployeeId;
            do
            {
                Employee employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();
                employees.Add( employee);
                Console.WriteLine("\nTo continue entering employee details enter 1, to exit enter 0");
                menu = Convert.ToInt32(Console.ReadLine());
            } while (menu == 1);
            SortAndPrintEmployees();
            Console.WriteLine("Please enter the employee ID");
            getEmployeeId = Convert.ToInt32(Console.ReadLine());
            PrintEmployee(getEmployeeId);
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
        public static void PrintEmployee(int empId)
        {
            var searchedEmployee = from emp in employees where emp.Id.Equals(empId) select emp;
            foreach (var emp in searchedEmployee)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
