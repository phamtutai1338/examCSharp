using Exam;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam
{
    class Program
    {
        List<Exam> exams = new ViewAll().getData();
        private string id;

        static void Main(string[] args)
        {
            Program pro = new Program();
            while (true)
            {

                Menu();
                int c = int.Parse(Console.ReadLine());
                switch (c)

                {
                    case 1:
                        pro.ShowAll();
                        break;
                    case 2:
                        pro.Add();
                        break;
                    case 3:
                        pro.Delete();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();

        }

      

        public static void Menu()
        {
            Console.WriteLine("========== Actions=========");
            Console.WriteLine("1. Show all");
            Console.WriteLine("2. Add Product");
            Console.WriteLine("3. Delete product");
            Console.WriteLine("4. End");
        }
        public void ShowAll()
        {
            var exam = exams.OrderBy(pro => pro.ProductId);
            foreach (var item in exam)
            {

                Console.WriteLine(item.ProductId + "  " + item.ProductName +"  "+ item.Price);
            }
        }
        public void Add()
        {
            Add add = new Add();
            Console.WriteLine("Enter product Id : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Name : ");
            string desc = Console.ReadLine();
            Console.WriteLine("Enter product Price :");
            double price = double.Parse(Console.ReadLine());
            Exam exam = new Exam { ProductId = id, ProductName = name, Price = price };
            add.getData(exam);
        }

       
       
        public void Delete()
        {
            Delete delete = new Delete();
            Console.WriteLine("Enter product id :");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var item in exams)
            {
                if (item.ProductId.Equals(id))
                {
                    delete.DeleteExam(id);
                    count = 1;
                    break;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("ID {0} Not Found !", id);
            }

        }
       
    }
}



