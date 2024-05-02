using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TResultItem
    {
        public int score;
        public TPredisposition predisposition;
        public string description;

        public TResultItem(int score, TPredisposition predisposition, string description)
        {
            this.score = score;
            this.predisposition = predisposition;
            this.description = description;
        }
    }
}
