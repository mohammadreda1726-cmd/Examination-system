namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create subject
            Subject subject = new Subject(1, "Programing");

            // create MCQ Answers
            Answer[] answers1 =
            {
                new Answer(1, "C#"),
                new Answer(2, "Java"),
                new Answer(3, "Python"),
                new Answer(4, "C++")
            };

            // Create MCQ Question               \\ Polymorphism   
            Question question1 = new MCQQuestion(
                "MCQ",    
                "Which language is developed by Microsoft?",
                5,
                answers1,
                answers1[0]
            );

            // Create Answers T / F
            Answer[] answers2 =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            // Create T/ F Question            \\ Polymorphism
            Question question2 = new TureFalseQuestion(
                "True / False",
                "C# is a programming language.",
                20,
                answers2,
                answers2[0]
            );

            // Create Questions Array
            Question[] questions =
            {
                question1,
                question2
            };

            // Create Final Exam
            Exam finalExam = new FinalExam(
                100,
                questions.Length,
                questions,
                subject
            );

            // Assign Exam to Subject
            subject.CreateExam(finalExam);

            finalExam.ShowExam();

            Console.ReadKey();
        }
    }
}
