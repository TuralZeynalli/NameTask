using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> namesList = new List<string> 
            {"Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Henry", "Ivy", "Jack",
            "Katherine", "Leo", "Mia", "Nathan", "Olivia", "Peter", "Quinn", "Rachel", "Samuel", "Tara",
            "Uma", "Victor", "Wendy", "Xavier", "Yara", "Zachary", "Abigail", "Benjamin", "Chloe", "Daniel",
            "Emily", "Finn", "Gabriella", "Harry", "Isabella", "Jacob", "Kylie", "Liam", "Madison", "Noah",
            "Sophia", "Ethan", "Ava", "Lucas", "Ella", "Mason", "Avery", "Logan", "Scarlett", "Elijah",
            "Luna", "James", "Hannah", "Alexander", "Mila", "Michael", "Natalie", "Owen", "Victoria", "William",
            "Penelope", "Ryan", "Aria", "Jayden", "Zoe", "Matthew", "Grace", "David", "Leah", "Nathan",
            "Brooklyn", "Jackson", "Addison", "Evan", "Layla", "Benjamin", "Riley", "Dylan", "Nora", "Gabriel",
            "Samantha", "Andrew", "Audrey", "Nicholas", "Claire", "Isaac", "Lily", "Luke", "Maya", "Connor",
            "Evelyn", "Henry", "Anna", "Isaiah", "Ellie"};


            //    * "A" hərfi ilə başlayanları qaytarın.

            List<string> findStartWithA = namesList.Where(m => m.StartsWith("A".ToLower().ToUpper())) 
                .ToList();

            int queue = 1;
            foreach (var item in findStartWithA)
            {
                Console.WriteLine($"{queue}. {item}");
                queue++;
            }



            //    *  Əlifbaya görə sıralayın edin.

            List<string> ABC = namesList.OrderBy(m => m).ToList();

            foreach (var item in ABC)
            {
                Console.WriteLine(item);
            }



            //    *  5 hərfdən çox olanları qaytarın.

            List<string> find5LengthNames = namesList.Where(m => m.Length > 5).
                ToList();

            foreach (var item in find5LengthNames)
            {
                Console.WriteLine(item);
            }



            //    *  "M" hərfi ilə başlayanların sayını qaytarın.

            int returnCountOfStartWithM = namesList.Count(m => m.StartsWith("M"));

            Console.WriteLine("Count of names starting with 'M': " + returnCountOfStartWithM);


            Console.WriteLine(".........");
            //    *  "John"  adının olub olmamasını yoxlayın.

            bool findJohn = namesList.Contains("John".ToLower().ToUpper());
            
            Console.WriteLine(findJohn);
            Console.WriteLine("/////");


            //    *   İlk 3 adı götürün.

            List<string> take3Names = namesList.Take(3).ToList();

            int queue2 = 1;
            foreach (var item in take3Names)
            {
                Console.WriteLine($"{queue2}. {item}");

                queue2++;
            }



            //    *   Son 3 adı götürün.

            namesList.Reverse();

            List<string> takeLast3Names = namesList.Take(3).ToList();

            foreach (var item in takeLast3Names)
            {
                Console.WriteLine(item); //sual?
            }

            namesList.Reverse();



            //    *   Ən uzun adı tapın.????


            //    *   Uzunluğu 4 - 6 arasında olan adları çıxarın.

            List<string> find4Length6Length = namesList.OrderBy(m => m.Length >= 4 && m.Length >= 6).ToList();

            foreach (var item in find4Length6Length)
            {
                Console.WriteLine(item);
            }



            //    *   Bütün adların "A"  hərfi ilə başlayıb-başlamadığını yoxlayın.

            bool searchAllNamesStartWithA = namesList.All(m => m.StartsWith("A".ToLower().ToUpper()));

            Console.WriteLine(searchAllNamesStartWithA);



            //    *   İçərisində "an" olan adların sayını qaytarın.

            int findCountOfContainAn = namesList.Count(m => m.ToLower().Contains("an"));

            Console.WriteLine(findCountOfContainAn);



            //    *   Uzunluğu tək ədəd olan adları əlifbaya görə sıralayıb duplikat olmayanlarının 10 dənəsini götürün.

            List<string> Take10 = namesList.OrderBy(m => m.Length % 2 == 1).
                OrderBy(m => m).
                Distinct().
                Take(10).
                ToList();

            foreach (var item in Take10)
            {
                Console.WriteLine(item);
            }



            //    *   Adların ortalama uzunluğunu çıxarın.

            double AvarageOfNames = namesList.Average(m => m.Length);
            
            Console.WriteLine(AvarageOfNames);



            //    *   İçərisində "e" olan adları götürüb ölçüsünə görə sıralayıb ən uzun ilk 5 dənəsini götürün.

            List<string> containsETake5 = namesList.Where(m => m.Contains("e")).
               OrderByDescending(m => m.Length).
               Take(5).
               ToList();

            foreach (var item in containsETake5)
            {
                Console.WriteLine(item);
            }      

        }

    }
}
