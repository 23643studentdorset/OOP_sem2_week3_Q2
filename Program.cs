using System;
using System.Collections.Generic;

namespace OOP_sem2_week3_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Write a program that allows a teacher to enter in a N-number of students. 
             *  For each student ask the teacher to enter in their name and final score for the class. 
             *  When the teacher is done entering the data, print the highest grade in the class, and the average grade for the class.
             */
            
            Console.WriteLine("How many students you have?");
            string numberOfStudents = Console.ReadLine();

            string[] students = new string [int.Parse(numberOfStudents)];
            double[] grades = new double[int.Parse(numberOfStudents)];
           
           

            for (int i=0; i < students.Length; i++ )
            {
                Console.WriteLine("Enter the name of the student");
                string name = Console.ReadLine();
                students[i] = name;

                Console.WriteLine("Enter the grade of that student");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
            }

            Console.WriteLine(students[0]);
            
            
        }
    }
}
