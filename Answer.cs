using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class Answer : IComparable<Answer>,ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int ComPareTo(Answer? other)
        {
            if (other == null)
                return 1;

            return AnswerId.CompareTo(other.AnswerId);
        }

        public object Clone()
        {
            return  new Answer(AnswerId, AnswerText);
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
