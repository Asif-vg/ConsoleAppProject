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
            } while (true); //bu hisse yaddan cixmasin
        }

        static void ShowListDepartament()
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

        static void CreateDepartament()
        {
            Console.WriteLine("Departamentin adini daxil edin");
            string departamentName = Console.ReadLine();
            Console.WriteLine("Isci sayini max daxil edin");
            string workerLimit = Console.ReadLine();
            int WorkerLimit;
            while (!int.TryParse(workerLimit, out WorkerLimit))
            {

                Console.WriteLine("Reqem daxil etmelisiz");
                workerLimit = Console.ReadLine();
                int.TryParse(workerLimit, out WorkerLimit);
                break;

            }
            Console.WriteLine("Iscelere ayliq cemi verilecek maximum mebleg");
            string salaryLimit = Console.ReadLine();
            int SalaryLimit;
            while (!int.TryParse(salaryLimit, out SalaryLimit))
            {
                Console.WriteLine("Reqem daxil etmelisiz");
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
                      ShowListEmployee( );
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
            } while (true); //bu hisse yaddan cixmasin!!!!!!!!!:(
        }
        static void ShowListEmployee()              
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
        static void ShowListEmployeeinDepartament()
        {
            Console.WriteLine("Departament adi daxil edin");
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
        static void AddEmployee()
        {
            Console.WriteLine("Isci elave edin");
           Employee employee = new Employee();

            Console.WriteLine("Iscinin fullname-ni daxil edin");
            string fullName = Console.ReadLine();
            
            Console.WriteLine("Iscinin position-nu daxil edin");
            string position = Console.ReadLine();

            Console.WriteLine("Iscinin elave olundugu departmentin adini daxil edin");
            string departamentname = Console.ReadLine();

            Console.WriteLine("Iscinin maasini daxil edin");
            string salary = Console.ReadLine();
            double salaryEmployee;
            while (!double.TryParse(salary, out salaryEmployee))
            {
                Console.WriteLine("Reqem daxil etmelisiz");
                salary = Console.ReadLine();
                double.TryParse(salary, out salaryEmployee);
            }
            employee.Salary = salaryEmployee;
            employee.Fullname = fullName;
            employee.Position = position;
            employee.DepartmentName = departamentname;


        }
        static void EditEmployee()
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
                
                Console.WriteLine("İşçinin yeni vəzifəsini daxil edin");
                string newPosition = Console.ReadLine();
                
                Console.Write("İşçinin yeni maaşını daxil edin");
                string newsalary = Console.ReadLine();
                double newSalary;
                while (!double.TryParse(newsalary,out newSalary))
                {
                    Console.WriteLine("Reqem daxil etmelisiz");
                    newsalary = Console.ReadLine();
                    double.TryParse(newsalary, out newSalary);
                }

                Console.WriteLine("Iscinin yeni departament yerini daxil edin");
                string DepartamentName = Console.ReadLine();
                employee.DepartmentName = DepartamentName;
                employee.Position = position;
                employee.Salary = salary;
                employee.Fullname = fullname;
            }
        }
        static void RemoveEmployee()
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
