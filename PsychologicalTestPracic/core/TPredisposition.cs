﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TPredisposition
    {
        private static int prepositionsCount = 0;
        public int id;
        public string title;
        public string details;

        public TPredisposition(string title, string details)
        {
            prepositionsCount++;
            this.id = prepositionsCount;
            this.title = title;
            this.details = details;
        }
    }
}
