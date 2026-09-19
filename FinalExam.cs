using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class FinalExam: Exam
    {
        public FinalExam(int time, int numberOfQuestion, Question[] questions, Subject subject) : base(time, numberOfQuestion, questions,subject )
        {
        }
        public override void ShowExam()
        {
            int grade = 0;
            Console.WriteLine("------ Final Exam -----");
            Console.WriteLine($"Subject: {Subject.SubjectName}");
            Console.WriteLine($"Time:{Time} minutes");

            foreach(Question question in Questions)
            {
                Console.WriteLine(question);

                question.ShowQuestion();

                Console.WriteLine($"Right Answer: {question.RightAnswer}");
                
                grade += question.Mark;
            }
            Console.WriteLine($"Grade: {grade}");

        }
    }
}
