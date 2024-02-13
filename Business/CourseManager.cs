using Intro.Entities;

namespace Intro.Business;
public class CourseManager // kurs ile ilgili operasyonları tutar
{
    Course[] courses = new Course[3]; // bu classın içindeki tüm methodlar bu arraya erişebilir
    public CourseManager() // bu class newlendiğinde çalışacak olan blok (constructor)
    {
            Course course1 = new Course();
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
            course3.Price = 0;

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;
    }

 public Course[] GetAll() 
 {      
        //kursları getir veritabanından...
        return courses;
        Console.WriteLine("Kurslar listelendi");
 }
}
