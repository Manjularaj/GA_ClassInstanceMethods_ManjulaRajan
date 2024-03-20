namespace GA_ClassInstanceMethods_ManjulaRajan
{//Manjula
    //3/20/2024
    internal class Program
    {
        static void Main(string[] args)
        {
             // Create a list of 5 grades ranging between 0 and 100
        List<int> manjulaGrades = new List<int> { 85, 92, 78, 90, 88 };

        // Create a new instance of the Student class with the name "Manjula" and the grades list
        Student manjulaStudent = new Student("Manjula", manjulaGrades);

            manjulaStudent.AddGrade(78);
            manjulaStudent.AddGrade(200);
            manjulaStudent.AddGrade(-130);

            manjulaStudent.GetGrade();

           manjulaStudent.DisplayStudentInfo();

            List<Student> randomStudents = GenerateRandomStudents();

            // Add your student to this list
            randomStudents.Add(manjulaStudent);

            // Loop and display all the info
            foreach (Student student in randomStudents)
            {
                student.DisplayStudentInfo();
            }
        }

        static List<Student> GenerateRandomStudents()
        {
            List<Student> students = new List<Student>();
            Random random = new Random(); // Random object created here

            for (int i = 1; i <= 5; i++)
            {
                Student student = new Student($"Student{i}");

                for (int j = 0; j < 5; j++)
                {
                    student.ExamScores.Add(random.Next(0, 101));
                }

                students.Add(student);
            }

            return students;


        }




    }//class
}//namespace