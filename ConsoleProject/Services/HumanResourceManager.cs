using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Interfaces;
using ConsoleProject.Models;
using System.Linq;

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
        private List<Employee> _empmloyee;
        public List<Employee> Employee 
        {
            get
            {
                return _empmloyee;
            }
        }
        public HumanResourceManager()
        {
            _empmloyee = new List<Employee>();
            _departament = new List<Departament>();
        }

        public void AddDepartment(Departament departament)
        {

            _departament.Add(departament); 
        }

        public void AddEmployee(Employee employee, string DepartamentName)
        {
            _empmloyee.Add(employee);
        }

        public List<Departament> EditDepartaments(string name, string Newname)
        {
            return _departament.FindAll(d => d.Name == name);
        }

        public List<Employee> EditEmploye(string number, string fullName, double salary, string position)
        {
            return _empmloyee.FindAll(e => e.no.ToLower() == number.ToLower() && e.Fullname.ToLower() == fullName.ToLower() && e.Salary == salary && e.Position.ToLower() == position.ToLower()).ToList();
        }

        public List<Departament> GetAllDepartments()
        {
            return _departament;
        }

        public void RemoveEmployee(string number, string departamentName)
        {
            var EmployeeList = _empmloyee.ToList();
            var RemoveItem = _empmloyee.Find(e => e.no.ToLower() == number.ToLower() && e.DepartmentName.ToLower() == departamentName.ToLower());
            _empmloyee.Remove(RemoveItem);
        }

    }
}
