using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Models;


namespace ConsoleProject.Interfaces
{
    interface IHumanResourceManager
    {
        public List<Departament> Departament { get;}
        public void AddDepartment(Departament departament);  //Add Departament to departament list
        public List<Departament> GetAllDepartments();  //Return all departament
        public List<Departament> EditDepartaments(string name,string Newname );  //Change in departament
        public void AddEmployee(Employee employee, string DepartamentName);  //Add Employee to employee list
        public void RemoveEmployee(string number, string departamentName);  //Delete employee from employee list
        public List<Employee> EditEmploye(string number, string fullName, double salary, string position); //Change in Employee
    }
}
