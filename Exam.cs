using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuesthion { get; set; }
        public Question[] Questions { get; set; }
        public Subject Subject { get; set; }

        public Exam( int time, int numberOfQuestion, Question[] questions , Subject subject)
        {
            Time = time;
            NumberOfQuesthion = numberOfQuestion;
            Questions = questions;
            Subject = subject;
        }
        public abstract void ShowExam();

        public override string ToString()
        {
            return $" Subject:{Subject.SubjectName} ,  Time: {Time} minutes , Questions: {NumberOfQuesthion}";

        }
    }
}
