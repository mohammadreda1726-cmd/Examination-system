using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestion, Question[] questions Subject subject) : base(time, numberOfQuestion, questions, subject)
        {
            foreach (Question question in questions)
            {
                if (question is not MCQQuestion)
                {
                    // If the question is not an MCQQuestion, throw an exception
                    throw new ArgumentException("Practical Exam accepts MCQ questions only.");
                }
            }
        }
        public override void ShowExam()
        {
            Console.WriteLine("------ Practical Exam -----");
            Console.WriteLine($"Subject: {Subject.SubjectName}");
            Console.WriteLine($"Time:{Time} minutes");


            foreach (Question question in Questions)
            {
                question.ShowQuestion();

                Console.WriteLine($"Right Answer: {question.RightAnswer}");
                Console.WriteLine();
            }
        }
    }
}
