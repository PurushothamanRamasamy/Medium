using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeePromotionMedium4
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static Employee employee = new Employee();
        static void Main()
        {
            int menu;
            int getEmployeeId;
            do
            {
                Employee employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();
                employees.Add(employee);
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
        public static void PrintEmployee(int empID)
        {
            var enteredEmployeeIdsAge = from e in employees where e.Id.Equals(empID) select e.Age;
            /*var searchedEmployees = from emp in employees  where emp.Age> enteredEmployeeIdsAge select emp;*/
            var searchedEmployees = employees.Where(emp => emp.Age > employees.Single(e=>e.Id ==empID).Age);
            foreach (var emp in searchedEmployees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
