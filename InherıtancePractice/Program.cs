// See https://aka.ms/new-console-template for more information

using InherıtancePractice;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using static InherıtancePractice.BaseKisi;
public class Program
{
    public static void Main(string[] args)
    {

        // Student create object and  want to information by metod
        Student student = new Student();

        Console.Write("Lutfen adinizi giriniz: ");
        string name = Console.ReadLine();
        Console.Write("lutfen soyadinizi giriniz: ");
        string surname = Console.ReadLine();
        Console.Write("Lutfen Ogreni Numarasini Giriniz: ");
        string number = Console.ReadLine();
        student.DisplayStudentInfo(name, surname, number);


        // Teacher create object and  want to information by metod
        Teacher teacher = new Teacher();
        Console.Write("Lutfen adinizi giriniz: ");
        string teacherName = Console.ReadLine();
        Console.Write("lutfen soyadinizi giriniz: ");
        string teacherSurname = Console.ReadLine();
        Console.Write("Lutfen Aylik Maasinizi Giriniz: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());
        teacher.DisplayTeacherInfo(teacherName,teacherSurname, salary);


    }


}
