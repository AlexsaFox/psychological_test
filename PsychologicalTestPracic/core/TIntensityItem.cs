using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TIntensityItem
    {
        public int minimal;
        public int maximal;
        public string description;

        public TIntensityItem(int minimal, int maximal, string description)
        {
            this.minimal = minimal;
            this.maximal = maximal;
            this.description = description;
        }
    }
}
