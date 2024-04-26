using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TResult
    {
        public List<TResultItem> data;
        
        // полчение результата по предрасположенности
        public TResultItem GetResultItemByPredisposition(TPredisposition predisposition) 
        {
            for (int i = 0; i < data.Count; i++) 
            {
                if (data[i].predisposition == predisposition)
                {
                    return data[i];
                }
            }
            throw new Exception(String.Format("This predisposition - \"{0}\" was not found", predisposition));
        }

        public void SortByScore()
        {
            data.Sort(CompareByScore);
        }

        // если булет выводиться в обратном порядке поменять местами 1 и -1
        private static int CompareByScore(TResultItem item1, TResultItem item2) 
        { 
            int score1 = item1.score;
            int score2 = item2.score;

            if (score1 > score2) return 1;
            if (score1 < score2) return -1;
            return 0;
        }
    }
}
