using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    class Departament
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                
            }
        }
        public int WorkerLimit;
        public double SalaryLimit;
        public List<Employee> Employee { get; set; }
        public double CalcSalaryAverage()
        {
            
            return 0;
        }
    }
}
