using System;
using System.Collections.Generic;
using System.Text;

namespace _1050Lab3
{
    class Student
    {

        public string studentFullName;
        public int Grade;
        public string Teacher;


        public string Information()
        {

            return "Full Name: " + studentFullName + "\nGrade: " + Grade + "\nProfessor:  " + Teacher;

        }




        public void studentGrade()
        {

            Console.Write("Teacher input student grade: \n");

            Console.Write("Input Student Grade for Jane Werstershire: \n\n");

            int Grade = int.Parse(Console.ReadLine);

            Console.Write("\n");
        }

        public void studentGrade2()
        {
            Console.Write("Teacher input student grade: \n");

            Console.Write("Input Student Grade for Joe Fabric: \n\n");

            int Grade = int.Parse(Console.ReadLine());

            Console.Write("\n");
        }


        public void studentGrade3()
        {
            Console.Write("Teacher input student grade: \n");

            Console.Write("Input Student Grade for Melissa Wisha: \n\n");

            int Grade = int.Parse(Console.ReadLine());

            Console.Write("\n");
        }

        public void studentGrade4()
        {
            Console.Write("Teacher input student grade: \n");

            Console.Write("Input Student Grade for Matt Flatts: \n\n");

            int Grade = int.Parse(Console.ReadLine());

            Console.Write("\n\n\n");


        }



        public static string studentGrade(string studentGrades1)
        {
            return studentGrades1;
        }

        public static string studentGrade2(string studentGrades2)
        {
            return studentGrades2;
        }

        public static string studentGrade3(string studentGrades3)
        {
            return studentGrades3;
        }

        public static string studentGrade4(string studentGrades4)
        {
            return studentGrades4;
        }





    }
}
