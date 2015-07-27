﻿namespace Exams
{
    using System;

    public class SimpleMathExam : Exam
    {
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("value", "Problems solved must be in range [0..2]");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }

            if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }
    }


}