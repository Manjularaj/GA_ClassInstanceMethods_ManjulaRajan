using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ClassInstanceMethods_ManjulaRajan
{
    public class Student
    {
        // Properties
        public string Name { get; set; }
        public List<int> ExamScores { get; private set; }

        // Constructor to initialize the student with a name and a list of exam scores
        public Student(string name)
        {
            Name = name;
            ExamScores = new List<int>();
        }

        // Constructor that takes a name and a list of grades
        public Student(string name, List<int> examScores)
        {
            Name = name;
            ExamScores = examScores;
        }

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                ExamScores.Add(grade);
                Console.WriteLine($"Added grade {grade} for {Name}");
            }
            else
            {
                Console.WriteLine($"Invalid grade: {grade}. Grade must be between 0 and 100.");
            }
        }

        private char GetLetterGrade(int score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        void DisplayAllGrades()

        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < ExamScores.Count; i++)
            {

                char letterGrade = GetLetterGrade(ExamScores[i]);
                Console.WriteLine($"Exam {i + 1}: {letterGrade} ({ExamScores[i]})");
            }

        }


        public double CalculateAverageScore()
        {
            // 1a. Validation Condition
            if (ExamScores.Count == 0)
            {
                return 0;
            }

            // 1b. Sum all grades
            int totalScore = 0;
            foreach (int score in ExamScores)
            {
                totalScore += score;
            }

            // 1c. Return average grade
            return (double)totalScore / ExamScores.Count;

        }

            public char GetGrade()
            {
                // 1a. Calculate the average score
                double averageScore = CalculateAverageScore();

                // 1b. Convert the average score to the nearest whole number
                int roundedAverageScore = (int)Math.Round(averageScore);

                // 1c. Get the letter grade based on the rounded average score
                return GetLetterGrade(roundedAverageScore);
            }

        public void DisplayStudentInfo()
        {
            // Calculate the average score
            double averageScore = CalculateAverageScore();

            // Get the overall letter grade
            char grade = GetGrade();

            // Display the student's name
            Console.WriteLine($"Student Name: {Name}");

            // Display the average score with two decimal places
            Console.WriteLine($"Average Score: {averageScore:F2}");

            // Display the overall letter grade
            Console.WriteLine($"Grade: {grade}");
        }

    }//class
}//namespace
