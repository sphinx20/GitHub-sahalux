using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Numerics;

namespace My_Personal_Projects
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] scores)
            : base(firstName.ToLower(), lastName.ToLower(), identification)
        {
            testScores = scores;
        }

        public char calculate()
        {
            int sum = 0;
            char grade = 't';
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }

            var avg = (double)sum / testScores.Length;

            if (avg < 40)
            {
                grade = 'T';
            }
            else if (avg >= 40 && avg < 55)
            {
                grade = 'D';
            }
            else if (avg >= 55 && avg < 70)
            {
                grade = 'P';
            }
            else if (avg >= 70 && avg < 80)
            {
                grade = 'A';
            }
            else if (avg >= 80 && avg < 90)
            {
                grade = 'E';
            }
            else if (avg >= 90 && avg < 100)
            {
                grade = 'O';
            }

            return grade;

        }

    }



    public class Inheritance
    {
        static void New()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
        }
    }

}
