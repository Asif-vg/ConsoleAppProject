using System;

namespace ConsoleProject
{
    class Program
    {
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
                        break;
                }
            } while (true);
        }

        static void ShowListDepartament()
        {

        }

        static void CreateDepartament()
        {

        }

        static void EditDepartament()
        {

        }
    }
}
