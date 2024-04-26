using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    internal class TIntensity
    {
        public List<TIntensityItem> data;

        // добавление интенсивности
        public void AddItem(int minimal, string description)
        {
            if (data.Count == 0)
            {
                if (minimal != 0)
                {
                    throw new Exception(String.Format("This intensivity - \"{0}\" must start at zero", description));
                }
            }
            else
            {
                for (int i = 0; i < this.data.Count; i++)
                {
                    if (this.data[i].minimal == minimal)
                    {
                        throw new Exception(String.Format("This intensivity - \"{0}\" has already been added.", description));
                    }
                }

                if (data.Last().minimal > minimal)
                {
                    throw new Exception(String.Format("This intensivity - \"{0}\" is lover than previous one", description));
                }
            }
            TIntensityItem item = new TIntensityItem(minimal, description);
            this.data.Add(item);
        }

        // получение интенсивности по счету
        public TIntensityItem get_item_by_score (int score) 
        {
            if (score < 0)
            {
                throw new Exception(String.Format("This score - \"{0}\" is invalid", score));
            }
            for (int i = 0; i < data.Count; i++)
            {
                if (score == data[i].minimal)
                {
                    return data[i];
                }
                else if (score < data[i].minimal)
                {
                    return data[i - 1];
                }
            }
            throw new Exception(String.Format("This score - \"{0}\" was not found", score));
        }
    }
}
