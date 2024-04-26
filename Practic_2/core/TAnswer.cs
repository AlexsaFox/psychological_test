using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    internal class TAnswer
    {
        public string text;
        public TQuestion question;
    
        public TAnswer (string text, TQuestion question)
        {
            this.text = text;
            this.question = question;
        }
    }
}
