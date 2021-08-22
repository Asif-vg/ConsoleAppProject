using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Models;


namespace ConsoleProject.Interfaces
{
    interface IHumanResourceManager
    {
        public List<Departament> Departament { get;}
        public void AddDepartment(Departament departament);
        public List<Departament> GetAllDepartments();
        public List<Departament> EditDepartaments(string name,string Newname );
        public void AddEmployee(Employee employee, string DepartamentName);
        public void RemoveEmployee(string number, string departamentName);  
        public List<Employee> EditEmploye(string number, string fullName, double salary, string position);
    }
}
