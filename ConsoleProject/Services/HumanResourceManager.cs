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

        public void EditDepartaments(string name, string Newname)
        {
           
        }

        public void EditEmploye(string number, string fullName, double salary, string position)
        {
            Employee employees = FindEmployeeNo(number);

            if (employees==null)
            {
                Console.WriteLine($"{number} nomreli isci yoxdur");
                return;
            }
            employees.No = number;
        }

        public List<Departament> GetAllDepartments()
        {
            return Departament;
        }

        public void RemoveEmployee(string number, string departamentName)
        {
            
            Employee removeEmployee = _empmloyee.Find(e => e.No==number);

            if (removeEmployee==null)
            {
                Console.WriteLine("Daxil edilen nomreli isci tapilmadi");
            }
            removeEmployee.No = number;
            removeEmployee.DepartmentName = departamentName;
        }

        public Employee FindEmployeeNo(string no)
        {
            
            foreach (var item in _empmloyee)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
