﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.Design.AxImporter;

namespace Practic_2.core
{
    public class TTestLoader
    {
        public string fileName;
        public string data;
        public List<TAnswer> answersId;
        public List<TPredisposition> predispositionsId;

        public TTestLoader(string fileName)
        {
            this.fileName = fileName;
            answersId = new List<TAnswer>();
            predispositionsId = new List<TPredisposition>();
        }

        public TTest Load()
        {
            answersId.Clear();
            predispositionsId.Clear();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                JsonDocument document = JsonDocument.Parse(json);
                JsonElement root = document.RootElement;
                TTest test = GetTest(root);
                FillQuestions(root, test);
                FillPredispositions(root, test);
                FillMapper(root, test);
                FillIntesity(root, test);
                return test;
            }
        }

        public TTest GetTest(JsonElement root)
        {
            string title = root.GetProperty("title").GetString();
            string description = root.GetProperty("description").GetString();
            TTest test = new TTest(title, description);
            return test;
        }


        public void FillAnswersForQuestion(JsonElement question, TQuestion questionItem)
        {
            JsonElement.ArrayEnumerator answers = question.GetProperty("answers").EnumerateArray();
            foreach (JsonElement answer in answers)
            {
                string textA = answer.GetProperty("text").GetString();
                TAnswer answerItem = questionItem.AddAnswer(textA);
                // ПРОВЕРКА ID
                if (answer.GetProperty("id").GetInt32() != answersId.Count + 1)
                {
                    throw new Exception(String.Format("Mistake in answer id"));
                }
                answersId.Add(answerItem);
            }
        }

        public void FillQuestions(JsonElement root, TTest test)
        {
            JsonElement.ArrayEnumerator questions = root.GetProperty("questions").EnumerateArray();
            foreach (JsonElement question in questions)
            {
                string textQ = question.GetProperty("text").GetString();
                TQuestion questionItem = test.AddQuestion(textQ);
                FillAnswersForQuestion(question, questionItem);
            }
        }

        public void FillPredispositions(JsonElement root, TTest test)
        {
            JsonElement.ArrayEnumerator predispositions = root.GetProperty("predispositions").EnumerateArray();
            foreach (JsonElement predisposition in predispositions)
            {
                string titleP = predisposition.GetProperty("title").GetString();
                string details = predisposition.GetProperty("details").GetString();
                TPredisposition predispositionItem = test.AddPredisposition(titleP, details);
                // ПРОВЕРКА ID
                if (predisposition.GetProperty("id").GetInt32() != predispositionsId.Count + 1)
                {
                    throw new Exception(String.Format("Mistake in predisposition id"));
                }
                
                predispositionsId.Add(predispositionItem);
            }
        }

        public void FillMapper(JsonElement root, TTest test)
        {
            JsonElement.ArrayEnumerator mapper = root.GetProperty("mapper").EnumerateArray();
            foreach (JsonElement mapperElement in mapper)
            {
                int answerId = mapperElement.GetProperty("answer").GetInt32();
                int predispositionId = mapperElement.GetProperty("predisposition").GetInt32();
                // ПРОВЕРКА ID - (1, count)

                if (answerId == 0 && answerId == answersId.Count)
                {
                    throw new Exception(String.Format("answerId out of range"));
                }
                if (predispositionId == 0 && predispositionId == predispositionsId.Count)
                {
                    throw new Exception(String.Format("predispositionId out of range"));
                }

                test.AddMapperItem(answersId[answerId - 1], predispositionsId[predispositionId - 1]);
            }
        }

        public void FillIntesity(JsonElement root, TTest test)
        {
            JsonElement.ArrayEnumerator intesity = root.GetProperty("intensity").EnumerateArray();
            foreach (JsonElement intensityItem in intesity)
            {
                int minimal = intensityItem.GetProperty("minimal").GetInt32();
                int maximal = intensityItem.GetProperty("maximal").GetInt32();
                string description = intensityItem.GetProperty("description").GetString();
                test.intensity.AddItem(minimal, maximal, description);
            }
        }
    }
}
