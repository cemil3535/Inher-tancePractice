using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherıtancePractice
{
    public abstract class BaseKisi
    {
        // property to identify
        public string Name {  get; set; }
        public string Surname {  get; set; }

        // name and surnamae metod to identify
        public void DisplayNameSurname(string name, string surname)
        {
            Console.Write($"Ad ve Soyad: {name} {surname}");
        }

        // derived student class.
        public class Student : BaseKisi
        {
            public string StudentNumber {  get; set; }

            // teacher show information metod
            public  void DisplayStudentInfo(string studentName, string studentSurname, string studentNumber)
            {
                DisplayNameSurname(studentName, studentSurname);

                Console.WriteLine($" Ogrencinin Numarasi: {studentNumber}");
            } 

        }

        // derived reacher class
        public class Teacher : BaseKisi
        {
            public decimal Salary { get; set; }

            // teacher show information metod
            public void DisplayTeacherInfo(string teacherName, string teacherSurname, decimal salary)
            {
                DisplayNameSurname(teacherName, teacherSurname);
                salary = Convert.ToDecimal(salary);
                Console.WriteLine($" Ogretmen maasi {salary} TL.dir.");
            }

        }

        
    }
}
