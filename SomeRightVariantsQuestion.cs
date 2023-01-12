using System;
using System.Collections.Generic;

namespace project
{
    class SomeRightVariantsQuestion : IQuestion
    {
        private string questionText = "";
        private int mark;
        private List<String> variantAsnwerArr = new List<String>();
        private List<String> rightVariantsAnswer = new List<String>();
        private List<String> userAnswer = new List<String>();

        public List<String> VariantAnswerArr
        {
            get
            {
                return this.variantAsnwerArr;
            }
            set
            {
                this.variantAsnwerArr = value;
            }
        }

        public List<String> RightVariantsAnswer
        {
            get
            {
                return this.rightVariantsAnswer;
            }
            set
            {
                this.rightVariantsAnswer = value;
            }
        }

        public List<String> UserAnswer
        {
            get
            {
                return this.userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }

        public string QuestionText
        {
            get
            {
                return this.questionText;
            }

            set
            {
                this.questionText = value;
            }
        }

        public int Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                this.mark = value;
            }
        }

        public void MarkOfQuestion()
        {
            for (int i = 0; i < userAnswer.Count; i++)
            {
                if (!rightVariantsAnswer.Contains(userAnswer[i]))
                {
                    Mark--;
                }
            }
        }

        public void ShowVariants()
        {
            for (int i = 0; i < variantAsnwerArr.Count; i++)
            {
                System.Console.WriteLine((i + 1) + ". " + variantAsnwerArr[i]);
            }
        }

        public void GetUserAnswer(string answer)
        {
            for (int i = 0; i < VariantAnswerArr.Count; i++)
            {
                UserAnswer.Add(answer);
            }
        }
    }
}