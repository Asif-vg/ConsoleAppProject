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
        public void EditDepartaments(string name,string Newname );
        public void AddEmployee(Employee employee, string DepartamentName);
        public void RemoveEmployee(string number, string departamentName);  //tipe birde baxmalsisan!!!!!!
        public void EditEmploye(string number, string fullName, double salary, string position);
    }
}
