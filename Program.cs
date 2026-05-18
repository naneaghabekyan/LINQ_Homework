using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ_Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Զույգ թվեր: LINQ - ով գտնել բոլոր զույգ թվերը։
            List<int> listEven = new List<int>() { 1, 4, 6, 7, 8 };
            var arrEven = listEven.Where(i => i % 2 == 0).Select(i => i);

            foreach (int i in arrEven) 
                Console.WriteLine(i);


            /* Անունների ֆիլտր
               List → անուններ։
               Գտնել բոլոր անունները, որոնք սկսվում են “A”-ով։
            */
            List<string> names = new List<string>() { "Aren", "Lia", "Jhon", "Kira", "Anahit" };
            var Anames = names.Where(i => i[0] == 'A').Select(i => i);

            foreach (string i in Anames)
                Console.WriteLine(i);




            /* Գնային ֆիլտր
               List (Name, Price)։
               Գտնել բոլոր ապրանքները, որոնց գինը < 1000։            
             */
            List<(string Name, int Price)> products = new List<(string, int)>
            {
                ("Laptop",1500),
                ("Mouse",1000),
                ("Pen",750),
                ("Desktop", 1200)
            };

            var newProducts = from i in products
                              where i.Price < 1000
                              select i; 

            foreach ((string, int) i in newProducts)
                Console.WriteLine(i);





            /*    Գրիր ծրագիր, որը List-ից գտնում է․
                  Ամենամեծ թիվը (Max)
                  Ամենափոքր թիվը (Min)
                  Գումարը (Sum)
                  Միջինը (Average)
             */
            List<int> listNumbers = new List<int>() { 1, 4, 6, 7, 8 };
            Console.WriteLine("Max: {0}", listNumbers.Max(i => i));
            Console.WriteLine("Min: {0}", listNumbers.Min(i => i));
            Console.WriteLine("Sum: {0}", listNumbers.Sum(i => i));
            Console.WriteLine("Average: {0}", listNumbers.Average(i => i));



            
            // Գրիր ծրագիր, որը List-ից գտնում է բոլոր բառերը, որոնց երկարությունը > 5։
            List<string> words = new List<string>() { "Aren", "Lia", "Jhon", "Kira", "Anahit" };
            var newWords = words.Where(i => i.Length > 5);
            foreach (string word in newWords)
            {
                Console.WriteLine(word);
            }



        }
    }
}
