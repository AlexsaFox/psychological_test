using Practic_2.core;
using System.Diagnostics;
using System.IO;

namespace PsychologicalTestPracic
{
    public partial class FormMain : Form
    {
        public TTest test;
        public TPupil pupil;
        public List<GroupBox> views;
        public List<RadioButton> answersVariants;
        public TTestFact testFact;
        public TTestSave testSave;
        public TResult result;

        public FormMain()
        {

            TTestLoader loader = new TTestLoader("test.json");
            test = loader.Load();

            InitializeComponent();
            Width = 900;
            Height = 700;
            label_Title.Text = test.title;
            views = new List<GroupBox>();
            views.Add(groupBox_Start);
            views.Add(groupBox_Description);
            views.Add(groupBox_Question);
            views.Add(groupBox_Result);
            views.Add(groupBox_ResultMore);
            init_progressBar();
            answersVariants = [radioButton_AnswerText1, radioButton_AnswerText2, radioButton_AnswerText3];
            init_views();
        }

        private void init_views()
        {
            for (int i = 0; i < views.Count; i++)
            {
                views[i].Location = new Point(0, label_Title.Height);
                views[i].Width = this.Size.Width;
                views[i].Height = this.Size.Height - label_Title.Height - 45;
                views[i].Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            }
        }

        private void init_progressBar()
        {
            progressBar_Questions.Maximum = test.questions.Count;
            progressBar_Questions.Width = groupBox_Question.Width;
            progressBar_Questions.Height = 40;
            progressBar_Questions.Location = new Point(0, groupBox_Question.Height);
            progressBar_Questions.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            string name = edit_Name.Text;
            string surname = edit_Surname.Text;
            int age = ((int)edit_Age.Value);
            int grade = ((int)edit_Grade.Value);
            if ((name == "") || (surname == "") || (age == 0) || (grade == 0))
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                pupil = new TPupil(name, surname, age, grade);
                label_Description.Text = test.description;
                label_QuestCount.Text = $"{test.questions.Count} вопроса";
                groupBox_Start.Visible = false;
                groupBox_Description.Visible = true;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            testFact = new TTestFact(pupil, test);
            TQuestion question = test.questions[0];
            show_question(question);
            groupBox_Description.Visible = false;
            groupBox_Question.Visible = true;
        }

        public void show_question(TQuestion question)
        {
            List<TAnswer> answers = question.answers;
            label_QuestionText.Text = question.text;
            for (int i = 0; i < answersVariants.Count; i++)
            {
                answersVariants[i].Text = answers[i].text;
            }
            if (testFact.chosen_answers.Count + 1 == test.questions.Count)
            {
                button_Answer.Text = "ЗАВЕРШИТЬ";
            }
        }

        private void button_Answer_Click(object sender, EventArgs e)
        {
            bool flagIsEveryone = true;
            for (int i = 0; i < answersVariants.Count; i++)
            {
                if (answersVariants[i].Checked)
                {
                    flagIsEveryone = false;
                }
            }

            if (!flagIsEveryone)
            {
                find_and_add_checked(test.questions[testFact.chosen_answers.Count].answers);
                progressBar_Questions.Value++;
            }
            else
            {
                MessageBox.Show("Нужно выбрать вариант ответа");
            }

            if (testFact.chosen_answers.Count < test.questions.Count)
            {
                TQuestion question = test.questions[testFact.chosen_answers.Count];
                show_question(question);
            }
            else
            {

                //MessageBox.Show("FINISH");
                result = testFact.GetResult();

                testSave = new TTestSave(testFact);

                string path = testSave.Save();

                label_PredispositionName.Text = result.data[0].predisposition.title;
                label_PredispositionDescription.Text = result.data[0].description + "\n" + result.data[0].predisposition.details;
                label_PredispositionScore.Text = result.data[0].score.ToString();

                label_filepath.Text = path;

                if (result.data[0].score == result.data[1].score)
                {
                    button_MoreResult.Text = "Есть ещё результат(-ы) с такими же баллами";
                    button_MoreResult.Font = new Font("Segoe UI", 10.0F);
                }


                groupBox_Question.Visible = false;
                groupBox_Result.Visible = true;
            }
        }

        public void find_and_add_checked(List<TAnswer> answers)
        {
            for (int i = 0; i < answersVariants.Count; i++)
            {
                if (answersVariants[i].Checked)
                {
                    testFact.AddChosenAnswer(answers[i]);
                    answersVariants[i].Checked = false;
                }
            }
        }

        private void button_MoreResult_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < result.data.Count; i++)
            {
                TResultItem item = result.data[i];
                this.dataGridView.Rows.Add(item.predisposition.title, item.score.ToString(), item.description, item.predisposition.details);
            }

            groupBox_Result.Visible = false;
            groupBox_ResultMore.Visible = true;
        }
    }
}
