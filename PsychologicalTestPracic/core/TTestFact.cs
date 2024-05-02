using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practic_2.core
{
    public class TTestFact
    {
        public TPupil pupil;
        public DateTime datetime;
        public TTest test;
        public List<TAnswer> chosen_answers;
        
        public TTestFact(TPupil pupil, TTest test)
        {
            this.pupil = pupil;
            this.test = test;
            this.datetime = DateTime.Now;
            this.chosen_answers = new List<TAnswer>();
        }

        // сохранение (добавление) отмеченных ответов
        public void AddChosenAnswer (TAnswer answer) 
        {
            chosen_answers.Add(answer);
        }

        // получение результата
        public TResult GetResult() 
        {
            TResult result = CreateUninitializationResult();

            this.CountPredisposition(result);

            this.AddInterpretationToResult(result);

            result.SortByScore();

            return result;
        }

        // создание пустого результата
        private TResult CreateUninitializationResult()
        {
            List<TPredisposition> predispositions = this.test.predispositions;
            TResult result = new TResult();

            for (int i = 0; i < predispositions.Count; i++)
            {
                TResultItem item = new TResultItem(0, predispositions[i], "");
                result.data.Add(item);
            }
            return result;
        }

        // подсчет счета предрасположенностей
        private void CountPredisposition (TResult result)
        {
            for (int i = 0; i < chosen_answers.Count; i++)
            {
                TAnswer cur_ans = chosen_answers[i];
                TPredisposition cur_predisposition = test.mapper[cur_ans];
                // ПРОВЕРИТЬ ПОТОМ НА СОХРАНЕНИЕ!!!!!!!!
                TResultItem item = result.GetResultItemByPredisposition(cur_predisposition);
                item.score++;
            }
        }

        // добавление интерпритации результата
        private void AddInterpretationToResult(TResult result)
        {
            TIntensity intensity = test.intensity;
            foreach (var result_item in result.data)
            {
                TIntensityItem item = intensity.get_item_by_score(result_item.score);
                result_item.description = item.description;
            }
        }

       
    }
}
