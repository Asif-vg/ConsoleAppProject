using System;
using ConsoleProject.Models;
using ConsoleProject.Services;
namespace ConsoleProject
{
    class Program
    {
        private static HumanResourceManager humanResource = new HumanResourceManager();
        public Program()
        {
             humanResource = new HumanResourceManager();
        }
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
                        Console.WriteLine("Duzgun secim daxil edin");
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
                        ShowListDepartament(humanResource);
                        break;
                    case 2:
                        CreateDepartament(humanResource);
                        break;
                    case 3:
                        EditDepartament(humanResource);
                        break;
                    default:
                        Console.WriteLine("Secimi duzgun edin");
                        break;
                }
            } while (true); //bu hisse yaddan cixmasin
        }

        static void ShowListDepartament(HumanResourceManager humanResource) //show departaments in departament  list
        {
            if (humanResource.Departament.Count > 0)
            {
                Console.WriteLine("\n=============Departaments==================");
                foreach (var item in humanResource.Departament)
                {
                    Console.WriteLine($"Name: {item.Name} - WorkerLimit: {item.WorkerLimit}- SalaryLimit :{item.SalaryLimit}");
                }
                Console.WriteLine("===============================\n");
            }
            else
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine("Sistemde hec bir departament yoxdur!");
                Console.WriteLine("===============================\n");
            }
        }

        static void CreateDepartament(HumanResourceManager humanResource)  //
        {
            Departament departament = new Departament();

            Console.WriteLine("Departamentin adini daxil edin");
            string departamentName = Console.ReadLine();
            departament.Name = departamentName;

            Console.WriteLine("Isci sayini max daxil edin");
            string workerLimit = Console.ReadLine();
            int WorkerLimit;
            while (!int.TryParse(workerLimit, out WorkerLimit))
            {
                Console.WriteLine("Reqem daxil etmelisiz");
                workerLimit = Console.ReadLine();
            }
            departament.WorkerLimit = WorkerLimit;

            Console.WriteLine("Iscelere ayliq cemi verilecek maximum mebleg");
            string salaryLimit = Console.ReadLine();
            int SalaryLimit;
            while (!int.TryParse(salaryLimit, out SalaryLimit))
            {
                Console.WriteLine("Reqem daxil etmelisiz");
               
            }
            departament.SalaryLimit = SalaryLimit;

            humanResource.AddDepartment(departament);

        }

        static void EditDepartament(HumanResourceManager humanResource) //edit new departament to departament list
        {
            Departament departament = new Departament();
            Console.WriteLine("Departament-in adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine();

            //Console.WriteLine("WorkerLimiti daxil edin");
            //int workerLimit = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine("SalaryLimit-i daxil edin");
            double salaryLimit = Convert.ToDouble(Console.ReadLine());

            if (name.ToLower() == departament.Name.ToLower());
            {
                Console.WriteLine("Departament-in yeni adini daxil edin");
                string newName = Console.ReadLine();
                departament.Name = newName;

                //Console.WriteLine("Yeni WorkerLimiti daxil edin");
                //string newWorkerLimit = Console.ReadLine();
                //int newworkerLimit;
                //while (!int.TryParse(newWorkerLimit, out newworkerLimit))
                //{
                //    Console.WriteLine("Reqem daxil etmelisiz");
                //    newWorkerLimit = Console.ReadLine();
                //    int.TryParse(newWorkerLimit, out newworkerLimit);
                //}

                //Console.Write("Yeni SalaryLimit-i daxil edin");
                //string newsalaryLimit = Console.ReadLine();
                //double newSalaryLimit;
                //while (!double.TryParse(newsalaryLimit, out newSalaryLimit))
                //{
                //    Console.WriteLine("Reqem daxil etmelisiz");
                //    newsalaryLimit = Console.ReadLine();
                //    double.TryParse(newsalaryLimit, out newSalaryLimit);
                //}
                //departament.Name = newName;
                //departament.SalaryLimit = newSalaryLimit;
                //departament.WorkerLimit = newworkerLimit;

                humanResource.EditDepartaments(name, newName);
            }
        }
        static void EmployeeOperation()
        {
            do
            {
                Console.WriteLine("Seciminizi Edin");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1 - Iscilerin siyahisini gostermek");
                Console.WriteLine("2 - Departamentdeki iscilerin siyahisini gostermek");
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
                      ShowListEmployee(humanResource);
                        break;
                    case 2:
                        ShowListEmployeeinDepartament(humanResource);
                        break;
                    case 3:
                        AddEmployee(humanResource);
                        break;
                    case 4:
                        EditEmployee(humanResource);
                        break;
                    case 5:
                        RemoveEmployee(humanResource);
                        break;
                    default:
                        Console.WriteLine("Secimi duzgun edin");
                        break;
                }
            } while (true); //bu hisse yaddan cixmasin!!!!!!!!!:(
        }
        static void ShowListEmployee(HumanResourceManager humanResource)              // show employee in list
        {
            if (humanResource.Employee.Count > 0)
            {
                Console.WriteLine("\n=============Isciler==================");
                foreach (var item in humanResource.Employee)
                {
                    Console.WriteLine($"Fullname: {item.Fullname} - No: {item.No}- DepartamentName :{item.DepartmentName} - Position: {item.Position} -  Salary: {item.Salary}");
                }
                Console.WriteLine("===============================\n");
            }
            else
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine("Sistemde hec bir isci yoxdur!");
                Console.WriteLine("===============================\n");
            }
        }
        static void ShowListEmployeeinDepartament(HumanResourceManager human) //show employee list in departament
        {
            Console.WriteLine("Departament-in adini daxil edin");
            string departamentName = Console.ReadLine();

            foreach (Employee employee in humanResource.Employee)
            {
                if (departamentName.ToLower()==employee.DepartmentName)
                {
                    Console.WriteLine(employee.Fullname);
                    Console.WriteLine(employee.no);
                    Console.WriteLine(employee.Position);
                    Console.WriteLine(employee.Salary);
                }
            }
        }
        static void AddEmployee(HumanResourceManager humanResource) //add employee to employee list
        {
           
            Console.WriteLine("Isci elave edin");
            Employee employee = new Employee();
            

            Console.WriteLine("Iscinin fullname-ni daxil edin");
            string fullName = Console.ReadLine();
            employee.Fullname = fullName;
            Console.WriteLine();
            
            Console.WriteLine("Iscinin position-nu daxil edin");
            string position = Console.ReadLine();
            employee.Position = position;
            Console.WriteLine();

            Console.WriteLine("Iscinin elave olundugu departmentin adini daxil edin");
            string departamentname = Console.ReadLine();
            employee.DepartmentName = departamentname;
            Console.WriteLine();

            Console.WriteLine("Iscinin maasini daxil edin");
            string salary = Console.ReadLine();
            double salaryEmployee;
            while (!double.TryParse(salary, out salaryEmployee))
            {
                Console.WriteLine("Reqem daxil etmelisiz");
                salary = Console.ReadLine();
                
            }

            employee.Salary = salaryEmployee;
            
            employee.no = employee.DepartmentName.Substring(0, 2).ToUpper() + employee.No;


            humanResource.AddEmployee(employee);
        }
        static void EditEmployee(HumanResourceManager humanResource) //edit new employee 
        {
            Employee employee = new Employee();
            Console.WriteLine("Istediyiniz iscinin nomresini daxil edin");
            string no = Console.ReadLine();

            Console.WriteLine("Iscinin adini daxil edin");
            string fullname = Console.ReadLine();

            Console.WriteLine("Iscinin position-nu daxil edin");
            string position = Console.ReadLine();

            Console.WriteLine("Iscinin salary-ni daxil edin");
            double salary =Convert.ToDouble(Console.ReadLine());

            if (no.ToLower() == employee.no.ToLower() && fullname.ToLower() == employee.Fullname.ToLower() && position.ToLower() == employee.Position.ToLower() && salary == employee.Salary);
            {
                Console.WriteLine("İşçinin yeni adını daxil edin");
                string newFullName = Console.ReadLine();
                Console.WriteLine( );

                Console.WriteLine("İşçinin yeni vəzifəsini daxil edin");
                string newPosition = Console.ReadLine();
                Console.WriteLine();
                
                Console.Write("İşçinin yeni maaşını daxil edin");
                string newsalary = Console.ReadLine();
                double newSalary;
                Console.WriteLine();
                while (!double.TryParse(newsalary,out newSalary))
                {
                    Console.WriteLine("Reqem daxil etmelisiz");
                    newsalary = Console.ReadLine();
                    Console.WriteLine();
                }

                Console.WriteLine("Iscinin yeni departament yerini daxil edin");
                string DepartamentName = Console.ReadLine();

                employee.no = DepartamentName.Substring(0, 2).ToUpper() + employee.No;
                employee.DepartmentName = DepartamentName;
                employee.Position = newPosition;
                employee.Salary = newSalary;
                employee.Fullname = newFullName;

                Console.WriteLine("Proses tamamlandi");
            }
        }
        static void RemoveEmployee(HumanResourceManager humanResource) //delete employee from list employee
        {
            Employee employee = new Employee();
            Console.WriteLine("Isci silinmesi");
            Console.WriteLine("Iscinin nomresini daxil edin");
            string no = Console.ReadLine();
            Console.WriteLine("Iscinin departamentName-ni daxil edin");
            string departamentName = Console.ReadLine();
            humanResource.RemoveEmployee(no, departamentName);
        }

    }
}
