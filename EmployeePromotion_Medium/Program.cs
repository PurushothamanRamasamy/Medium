using System;
using System.Collections.Generic;
namespace EmployeePromotion_Medium
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {
           var employees = new Dictionary<int,Employee>();
            int menu,getEmployeeId;
            bool isTrue = true;

            do
            {
                try
                {
                    getData();
                    isTrue = false;
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("An item with the same key has already been added. "))
                    {
                        Console.WriteLine("\nEmployee Id Already Exists\n Kindly enter different Employee Id\n\n");
                       

                    } else if(e.Message.Contains("Input string was not in a correct format."))
                    {
                        Console.WriteLine("\nKindly enter Correct format of data\n\n");
                    }
                    else
                    {
                        Console.WriteLine("-----------------Error:-----------------\n" + e.Message);
                        Console.WriteLine("\nKindly enter Valid data\n\n");
                    }

                }
            }
            while (isTrue);




             void getData()
            {
                do
                {
                    Employee employee = new Employee();
                    employee.TakeEmployeeDetailsFromUser();
                    employees.Add(employee.Id, employee);
                    Console.WriteLine("\nTo continue entering employee details enter 1, to exit enter 0");
                    menu = Convert.ToInt32(Console.ReadLine());
                } while (menu == 1);
                Console.WriteLine("\nPlease enter the employee ID to view Employee details");

                getEmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(employees[getEmployeeId].ToString());
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Value.ToString());
                }
            } 
        }
       
    }
}
