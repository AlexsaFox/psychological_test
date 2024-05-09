using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practic_2.core
{
    public class TTest
    {
        public string title;
        public string description;
        public List<TQuestion> questions;
        public List<TPredisposition> predispositions;
        public Dictionary<TAnswer, TPredisposition> mapper;
        public TIntensity intensity; 

        public TTest(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.questions = new List<TQuestion>();
            this.predispositions = new List<TPredisposition>();
            this.mapper = new Dictionary<TAnswer, TPredisposition>();
            this.intensity = new TIntensity();
        }

        //добавление вопросов в тест
        public TQuestion AddQuestion(string text) 
        {
            for (int i = 0; i < questions.Count; i++) 
            {
                if (questions[i].text == text)
                {
                    throw new Exception(String.Format("This question - \"{0}\" has already been added.", text));
                }
            }
            TQuestion question = new TQuestion(text);
            this.questions.Add(question);
            return question;
        }

        // добавление предрасположенностей в тест
        public TPredisposition AddPredisposition(string title, string details) 
        {
            for(int i = 0; i < predispositions.Count;i++)
            {
                if (predispositions[i].title == title)
                {
                    throw new Exception(String.Format("This predisposition - \"{0}\" has already been added.", title));
                }
            }
            
            TPredisposition predisposition = new TPredisposition(title, details);
            this.predispositions.Add(predisposition);
            return predisposition;
        }

        // добавление связи ответа на вопрос с предрасположенностью
        public void AddMapperItem(TAnswer answer, TPredisposition predisposition)
        {
            this.mapper[answer] = predisposition;
        }

        // получение предрасположенности по ответу
        public TPredisposition GetPredispositionByAnswer(TAnswer answer)
        {
            return this.mapper[answer];
        }
    }
}
