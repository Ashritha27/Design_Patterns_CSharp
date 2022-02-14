using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public interface IEmployee
    {
        public string GetName();
        public void SetSalary(float salary);

        public float GetSalary();
        public string GetRoles();
    }

    public class Developer : IEmployee
    {
        string name; float salary;string[] roles;

       public Developer(string name, float salary, string[] roles = null)
        {
            this.name = name;
            this.salary = salary;
            this.roles = roles;
        }

        public string GetName()
        {
            return this.name.ToString();
        }

        public string GetRoles()
        {
            return string.Join(',', this.roles);
        }

        public float GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }
    }

    public class ProductManager : IEmployee
    {
        string name; float salary; string[] roles;

        public ProductManager(string name, float salary, string[] roles = null)
        {
            this.name = name;
            this.salary = salary;
            this.roles = roles;
        }

        public string GetName()
        {
            return this.name.ToString();
        }

        public string GetRoles()
        {
            return string.Join(',', this.roles);
        }

        public float GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }
    }

    public class Organization
    {
        readonly List<IEmployee> employee = new List<IEmployee>();float netSalary; string allRoles = string.Empty;
        public void AddEmployees(IEmployee employee)
        {
            this.employee.Add(employee);
        }

        public float GetNetSalaries()
        {
            netSalary = 0;
            foreach (var emp in employee)
            {
                netSalary += emp.GetSalary();
            }
            return netSalary;
        }

        public string GetAllOrgRoles()
        {
            
            foreach(var emp in employee)
            {
                allRoles += emp.GetRoles();
            }
            return allRoles;
        }

    }
    class Composite
    {
        static void Main(string[] args)
        {
            
            var dev = new Developer("John Do", 12000,new string[]{ "Dev", "Architect" });
            var pm = new ProductManager("John Deo", 17000, new string[] { "Manager", "Product Manager" });
            
            var org = new Organization();
            org.AddEmployees(dev);
            org.AddEmployees(pm);

            Console.WriteLine(org.GetNetSalaries());
            Console.WriteLine(org.GetAllOrgRoles());



        }
    }
}
