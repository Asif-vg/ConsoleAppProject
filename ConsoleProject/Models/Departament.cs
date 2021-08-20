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
                if (NameCheck(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Departamentin adi min 2 herf olmalidir");
                }
            }
        }

        private bool NameCheck(string name)
        {
            if (name.Length >= 2)
            {
                return false;
            }
            foreach (char item in name)
            {
                if (!Char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;

        }
        private int _workerLimit;
        public int WorkerLimit
        {
            get
            {
                return _workerLimit;
            }
            set
            {
                if (value>1)
                {
                    _workerLimit = value;
                }
                else
                {
                    Console.WriteLine("iscinin sayi min 1 olmalidir");
                }
            }
        }
        private double _salaryLimit;
        public double SalaryLimit
        {
            get
            {
                return _salaryLimit;
            }
            set
            {
                if (value>250)
                {
                    _salaryLimit = value;
                }
                else
                {
                    Console.WriteLine("ayliq mebleg min 250 olmalidir");
                }
            }
        }
        public List<Employee> Employee { get; }
        public double CalcSalaryAverage()
        {
            double Sum = 0;
            double Avarage = 0;
            foreach (var item in Employee)
            {
                Sum += item.Salary;
            }
            if (Employee.Count!=0)
            {
                Avarage = Sum / Employee.Count;
            }
            else
            {
                return 0;
            }
            
            return Avarage;
        }
    }
}
