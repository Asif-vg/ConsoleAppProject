using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    class Employee
    {
        private static int _counter = 1000;
        public Employee()
        {
            _counter++;
            No = _counter;
        }
        public int No;
        public string no;
        private string _position;
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value.Length>2)
                {
                    _position = value;
                }
                else
                {
                    Console.WriteLine("vezife min 2 herfden ibaret olmalidir");
                }
            }
        }
        
        public string Fullname;
        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("ayliq mebleg min 250 olmalidir");
                }
            }
        }
        public string DepartmentName;
    }


}

