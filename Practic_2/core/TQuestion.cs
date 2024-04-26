using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    internal class TQuestion
    {
        public string text;
        public List<TAnswer> answers;

        public TQuestion(string text)
        {
            this.text = text;
            this.answers = new List<TAnswer>();
        }

        public TAnswer AddAnswer(string text)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].text == text)
                {
                    throw new Exception(String.Format("This answer - \"{0}\" has already been added.", text));
                }
            }
            TAnswer answer = new TAnswer(text, this);
            this.answers.Add(answer);
            return answer;
        }
    }
}
