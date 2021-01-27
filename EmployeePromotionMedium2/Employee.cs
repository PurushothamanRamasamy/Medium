using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePromotionMedium2
{
    class Employee:IComparable<Employee>
    {
        int id, age;
        string name;
        double salary;

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }


        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age +
           "\nSalary : " + salary;
        }
        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            else if (this.Salary < other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
