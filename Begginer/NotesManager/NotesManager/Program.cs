using System;

namespace NotesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "Mathematics", "Geography and History", "Spanish Language and Literature", "Foreign Language", "Physical Education" };
            int isContinue;

            do
            {
                Console.WriteLine("Student name:");
                string studentName = Console.ReadLine();

                double sumSubjects = 0;
                for (int i = 0; i < subjects.Length; i++)
                {
                    double subjectGrade;
                    while (true)
                    {
                        Console.WriteLine($"The grade for {subjects[i]} is:");
                        if (double.TryParse(Console.ReadLine(), out subjectGrade) && subjectGrade >= 0 && subjectGrade <= 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number between 0 and 10.");
                        }
                    }
                    sumSubjects += subjectGrade;
                }

                double average = sumSubjects / subjects.Length;
                string grade = GetGrade(average);

                Console.WriteLine($"Student: {studentName}\n----------------------------\nYour average grade is: {average:F2}\nFinal grade: {grade}");

                Console.WriteLine("Do you want to calculate the average grade for another student? 1 - Yes, 2 - No");
                if (!int.TryParse(Console.ReadLine(), out isContinue) || isContinue < 1 || isContinue > 2)
                {
                    Console.WriteLine("Invalid input. Ending the program.");
                    break;
                }



            } while (isContinue == 1);
        }

        static string GetGrade(double average)
        {
            if (average >= 9)
                return "A";
            else if (average >= 8)
                return "B";
            else if (average >= 7)
                return "C";
            else if (average >= 6)
                return "D";
            else
                return "F";
        }
    }
}
