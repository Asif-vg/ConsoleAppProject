﻿using System;
using ConsoleProject.Models;
using ConsoleProject.Services;
namespace ConsoleProject
{
    class Program
    {
        HumanResourceManager humanResource = new HumanResourceManager();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Seciminizi edin");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("-1 Departament uzerinde emeliyyat");
                Console.WriteLine("-2 Employee uzerinde emeliyyat");
                Console.WriteLine(Environment.NewLine);

                string choose = Console.ReadLine();
                int choosenum;
                int.TryParse(choose, out choosenum);
                switch (choosenum)
                {
                    case 1:
                        DepartamentOperation();
                        break;
                    case 2:
                        EmployeeOperation();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("duzgun secim daxile edin");
                        break;
                }

            } while (true);

        }

        static void DepartamentOperation()
        {
            do
            {
                Console.WriteLine("Seciminizi Edin");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1 - Departameantlerin siyahisini gostermek");
                Console.WriteLine("2 - Departamenet yaratmaq");
                Console.WriteLine("3 - Departmanetde deyisiklik etmek");
                Console.WriteLine(Environment.NewLine);
                string choose = Console.ReadLine();
                int chooseNumber;
                int.TryParse(choose, out chooseNumber);
                switch (chooseNumber)
                {
                    case 1:
                        ShowListDepartament();
                        break;
                    case 2:
                        CreateDepartament();
                        break;
                    case 3:
                        EditDepartament();
                        break;
                    default:
                        Console.WriteLine("Secimi duzgun edin");
                        break;
                }
            } while (true);
        }

        static void ShowListDepartament()
        {

        }

        static void CreateDepartament()
        {
            Console.WriteLine("Departamentin adini daxil edin");
            string departamentName = Console.ReadLine();
            Console.WriteLine("Isci sayini max daxil edin");
            string workerLimit = Console.ReadLine();
            int WorkerLimit;
            while (int.TryParse(workerLimit, out WorkerLimit))
            {

                Console.WriteLine("Isci sayini duzgun daxil edin");
                workerLimit = Console.ReadLine();
                int.TryParse(workerLimit, out WorkerLimit);
                break;

            }
            Console.WriteLine("Iscelere ayliq cemi verilecek maximum mebleg");
            string salaryLimit = Console.ReadLine();
            int SalaryLimit;
            while (int.TryParse(salaryLimit, out SalaryLimit))
            {
                Console.WriteLine("Meblegi duzgun daxil edin");
                salaryLimit = Console.ReadLine();
                int.TryParse(salaryLimit, out SalaryLimit);
                break;
            }

        }

        static void EditDepartament()
        {

        }
        static void EmployeeOperation()
        {
            do
            {
                Console.WriteLine("Seciminizi Edin");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1 - Iscilerin siyahisini gostermek");
                Console.WriteLine("2 - Departamentdeki iscilerin siyahisini gostermrek");
                Console.WriteLine("3 - Isci elave etmek");
                Console.WriteLine("4 - Isci uzerinde deyisiklik etmek");
                Console.WriteLine("5 - Departamentden isci silinmesi");
                Console.WriteLine(Environment.NewLine);
                string choose = Console.ReadLine();
                int chooseNumber;
                int.TryParse(choose, out chooseNumber);
                switch (chooseNumber)
                {
                    case 1:
                      //  ShowListEmployee( );
                        break;
                    case 2:
                        ShowListEmployeeinDepartament();
                        break;
                    case 3:
                        AddEmployee();
                        break;
                    case 4:
                        EditEmployee();
                        break;
                    case 5:
                        RemoveEmployee();
                        break;
                    default:
                        Console.WriteLine("Secimi duzgun edin");
                        break;
                }
            } while (true);
        }
        #region ShowListEmployee
        //static void ShowListEmployee( ref  HumanResourceManager humanResource)               //BURANIN CASE HISSESINDE ERROR VERIR ONU DUZELDECEM
        //{
        //    if (humanResource.Employee.Count > 0)
        //    {
        //        Console.WriteLine("\n=============Isciler==================");
        //        foreach (var item in humanResource.Employee)
        //        {
        //            Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}- DepartamentName :{item.DepartmentName} - Position: {item.Position} -  Salary: {item.Salary}");
        //        }
        //        Console.WriteLine("===============================\n");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n===============================");
        //        Console.WriteLine("Sistemde hec bir isci yoxdur!");
        //        Console.WriteLine("===============================\n");
        //    }
        //}
        #endregion   //BURANIN CASE HISSESINDE ERROR VERIR ONU DUZELDECEM

        static void ShowListEmployeeinDepartament()
        {

        }
        static void AddEmployee()
        {
            Console.WriteLine("Iscinin fullname-ni daxil edin");
            string fullName = Console.ReadLine();
            Console.WriteLine("Iscinin elave olundugu departmentin adini daxil edin");
            string departament = Console.ReadLine();
            Console.WriteLine("Iscinin maasini daxil edin");
            string salary = Console.ReadLine();
            int salaryEmployee;
            while (!int.TryParse(salary, out salaryEmployee))
            {
                Console.WriteLine("salary 250-den asagi ola bilmez");
                salary = Console.ReadLine();
                int.TryParse(salary, out salaryEmployee);
            }

        }
        static void EditEmployee()
        {
            Console.WriteLine("Deyismek istediyiniz iscinin nomresini daxil edin");

        }
        static void RemoveEmployee()
        {

        }

    }
}
