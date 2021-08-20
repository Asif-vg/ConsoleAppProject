using System;
using System.Collections.Generic;
using System.Text;
using ConsoleProject.Interfaces;
using ConsoleProject.Models;

namespace ConsoleProject.Services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public List<Departament> Departament => throw new NotImplementedException();

        public void AddDepartment(Departament departament)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee, string DepartamentName)
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments(string name, string Newname)
        {
            throw new NotImplementedException();
        }

        public void EditEmploye(int number, string fullName, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public List<Departament> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int number, string departamentName)
        {
            throw new NotImplementedException();
        }
    }
}
