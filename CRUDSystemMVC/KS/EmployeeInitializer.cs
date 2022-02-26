using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUDSystemMVC.Models;

namespace CRUDSystemMVC.KS
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var Employees = new List<Employee>
            {
                new Employee {FirstName = "Karam",LastName = "Saad",Salary=9500 },
                new Employee {FirstName = "Ibrahem",LastName = "Saed",Salary=9000 },
                new Employee {FirstName = "Ali",LastName = "Tarek",Salary=8500 },
                new Employee {FirstName = "Mohamed",LastName = "Ali",Salary=10500 },
                new Employee {FirstName = "Esa",LastName = "Ibrahem",Salary=8000 },
                new Employee {FirstName = "Hesham",LastName = "Mohamed",Salary=5000 },
                new Employee {FirstName = "Hussain",LastName = "Sabry",Salary=7500 },
                new Employee {FirstName = "Ibrahem",LastName = "Hossam",Salary=6500 },
                new Employee {FirstName = "Ahmed",LastName = "Mohamed",Salary=8500 },
                new Employee {FirstName = "Omar",LastName = "Magdy",Salary=11000 }
            };

            Employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            
        }




    }
}