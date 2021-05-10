using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{



    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Мартин";
            student.middleName = "Ирогевич";
            student.lastName = "Дулин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.grup = "qwer1";

            return student;

        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Номер: {student.id}");
            Console.WriteLine($"Группа: {student.grup}");



        }


        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
            Console.WriteLine("* * * * * * * * * * * * *");
            firstStudent.Print();

            Console.WriteLine("* * * * * * * * * * * * *");

            var secondStudent = new Student();

            secondStudent.firstName = "Noname";
            secondStudent.Print();
            Console.WriteLine("* * * * * * * * * * * * *");
            string fullName = firstStudent.GetFullName();

            //Print(fullName);
        }
    }
}
