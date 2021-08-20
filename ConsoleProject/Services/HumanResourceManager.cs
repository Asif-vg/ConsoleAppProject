using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Interfaces;
using ConsoleProject.Models;

namespace ConsoleProject.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        private List<Departament> _departament;
        public List<Departament> Departament
        {
            get
            {
                return _departament;
            }
        }
        public HumanResourceManager()
        {
            _departament = new List<Departament>();
        }

        public void AddDepartment(Departament departament)
        {
            _departament.Add(departament); 
        }

        public void AddEmployee(Employee employee, string DepartamentName)
        {
            Employee employee1 = new Employee();
            employee1.Fullname = employee.Fullname;
            employee1.Salary = employee.Salary;
            employee1.Position = employee.Position;

            foreach (Departament item in Departament)
            {
               
            }
        }

        public void EditDepartaments(string name, string Newname)
        {
           
        }

        public void EditEmploye(int number, string fullName, double salary, string position)
        {
             
        }

        public List<Departament> GetAllDepartments()
        {
            return Departament;
        }

        public void RemoveEmployee(int number, string departamentName)
        {
            
        }
    }
}
