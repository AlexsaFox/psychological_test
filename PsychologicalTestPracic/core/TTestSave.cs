using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TTestSave
    {
        public TTestFact testFact;
        public TResult result;

        public TTestSave(TTestFact testFact)
        {
            this.testFact = testFact;
            result = testFact.GetResult();
        }
        public string Save()
        {
            // Название теста/фио/дата прохождения
            string path = GetCorrectFilePath();
            StreamWriter file = new StreamWriter(path);

            
            for (int i = 0; i < testFact.chosenAnswers.Count; i++)
            {
                file.WriteLine($"{i + 1} - {testFact.chosenAnswers[i].text}");
            }
            file.WriteLine("___результат___");
            for (int i = 0; i < result.data.Count; i++)
            {
                TResultItem item = result.data[i];
                file.WriteLine($"{item.predisposition.title} - {item.score}");
            }
            file.Close();
            return path;
        }

        public string GetCorrectFilePath()
        {
            string test_name = testFact.test.title;
            string pupil_name_surname = testFact.pupil.name + testFact.pupil.surname;
            string timestamp = testFact.datetime.ToString();
            string dir_path = @$"{test_name}\{pupil_name_surname}";

            string fileName = timestamp.Replace(" ", "");
            fileName = fileName.Replace(".", "");
            fileName = fileName.Replace(":", "");
            Directory.CreateDirectory(dir_path);

            return Directory.GetCurrentDirectory() + @$"\{dir_path}\{fileName}.txt";
        }
    }
}
