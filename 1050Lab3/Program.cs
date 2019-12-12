using System;

namespace _1050Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor Teacher1 = new Instructor();
            Teacher1.professorName = "John";
            Teacher1.courseName = "English";

            Instructor Teacher2 = new Instructor();
            Teacher2.professorName = "Mike";
            Teacher2.courseName = "Math";

            string print1 = Teacher1.teacherInformation();
            string print2 = Teacher2.teacherInformation();

            string firstTeacher = Teacher1.professorName;
            string firstClass = Teacher1.courseName;
            string teacher1Info = firstTeacher + ", " + firstClass;

            string secondTeacher = Teacher2.professorName;
            string secondClass = Teacher2.courseName;
            string teacher2Info = secondTeacher + ", " + secondClass;

            
            Student student1 = new Student();
            student1.studentFullName = "Jane";
            student1.studentGrade();
            student1.Teacher = teacher1Info;

            Student student2 = new Student();
            student2.studentFullName = "Joe";
            student2.studentGrade2();
            student2.Teacher = teacher1Info;

            Student student3 = new Student();
            student3.studentFullName = "Melissa";
            student3.studentGrade3();
            student3.Teacher = teacher2Info;

            Student student4 = new Student();
            student4.studentFullName = "Matt";
            student4.studentGrade4();
            student4.Teacher = teacher2Info;

            string printed1 = student1.Information();
            string printed2 = student2.Information();
            string printed3 = student3.Information();
            string printed4 = student4.Information();
           
            string studentStart = "Hi student, below you can see the information regarding your classes.";


            
            System.Console.WriteLine(studentStart + "\n");
            System.Console.WriteLine("Input Student Grade: ");
            System.Console.WriteLine(printed1 + "\n\n" + printed2 + "\n\n" + printed3 + "\n\n" + printed4);
        }
    }
}
