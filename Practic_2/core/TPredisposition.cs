using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    internal class TPredisposition
    {
        private static int prepositions_count = 0;
        public int id;
        public string title;
        public string details;

        public TPredisposition(string title, string details)
        {
            prepositions_count++;
            this.id = prepositions_count;
            this.title = title;
            this.details = details;
        }
    }
}
