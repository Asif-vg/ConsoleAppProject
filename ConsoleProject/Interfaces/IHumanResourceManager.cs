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
        public void EditDepartaments(Departament name,string Newname );
        public void RemoveEmployee(Employee nomre, Departament name);
        public void EditEmploye(Employee nomre,Employee fullname,Employee salary,Employee position);
    }
}
