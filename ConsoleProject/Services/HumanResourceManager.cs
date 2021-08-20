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

        public void EditDepartaments(Departament name, string Newname)
        {
            throw new NotImplementedException();
        }

        public void EditEmploye(Employee nomre, Employee fullname, Employee salary, Employee position)
        {
            throw new NotImplementedException();
        }

        public List<Departament> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(Employee nomre, Departament name)
        {
            throw new NotImplementedException();
        }
    }
}
