using System.Runtime.InteropServices;
using Intro.Business;
using Intro.Entities;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Krediler";
            int term = 12;
            double amount = 10000.5;

            // variables --> camelCase
            bool isAuthenticated = false;
            Console.WriteLine(message);

            //condition
            if (isAuthenticated)
            {
                Console.WriteLine("Kullanıcı giriş yaptı");
            }
            else
            {
                Console.WriteLine("Kullanıcı giriş yapmadı");
            }


            string[] loans = { "Konut Kredisi", "Taşıt Kredisi", "İhtiyaç Kredisi" }; //dbden gelen veri
 /*         string[] loans2 = new string[6];
            loans2[0] = "Konut Kredisi"; */

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

            // kendi classımızı oluşturduk ve newledik 
            // (Constructor'a taşıdık courseManager class'ına)
/*          Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = "C# Dersi";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java Dersi";
            course2.Price = 0;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python Dersi";
            course3.Price = 0; */


            CourseManager courseManager = new();
            Course[] courses = courseManager.GetAll();
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].Name);
            }

        }
    }
}