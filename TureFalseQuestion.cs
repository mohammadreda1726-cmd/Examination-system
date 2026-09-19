using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class TureFalseQuestion : Question
    {
        public TureFalseQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {

        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}:{Body}");

            foreach(Answer answer in AnswerList)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
