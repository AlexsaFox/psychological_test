using Practic_2.core;

namespace Practic_2
{
    public partial class FormMain : Form
    {
        public TTest test;
        public TPupil pupil;
        public List<GroupBox> views;
        public TTestFact testFact;

        public FormMain()
        {
            // Á‡„ÛÁÍË Ù‡ÈÎÓ‚
            TTestLoader loader = new TTestLoader("test.json");
            test = loader.Load();

            InitializeComponent();

            label_test_title.Text = test.title;
            views = new List<GroupBox>();
            views.Add(group_start);
            views.Add(group_description);
            views.Add(group_question);
            views.Add(group_result);
            init_progressBar();
            init_views();

            
        }

        private void init_views()
        {
            for (int i = 0; i < views.Count; i++)
            {
                views[i].Location = new Point(0, label_test_title.Height);
                views[i].Width = this.Size.Width;
                views[i].Height = this.Size.Height - label_test_title.Height;
                views[i].Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            }
        }

        private void init_progressBar()
        {
            progressBar_questions.Maximum = test.questions.Count;
            progressBar_questions.Width = Width;
            progressBar_questions.Height = 40;
            progressBar_questions.MaximumSize = new Size(2160, 40);
            progressBar_questions.Location = new Point(0, group_question.Height - progressBar_questions.Height);
            progressBar_questions.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            string name = edit_name.Text;
            string surname = edit_surname.Text;
            int age = ((int)edit_age.Value);
            int grade = ((int)edit_grade.Value);
            if ((name == "") || (surname == "") || (age == 0) || (grade == 0))
            {
                MessageBox.Show("Wrong data");
            }
            else
            {
                pupil = new TPupil(name, surname, age, grade);
                label_description.Text = test.description;
                label_count_questions.Text = $"{test.questions.Count} ‚ÓÔÓÒ‡";
                group_start.Visible = false;
                group_description.Visible = true;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            testFact = new TTestFact(pupil, test);
            TQuestion question = test.questions[0];
            show_question(question);
            group_description.Visible = false;
            group_question.Visible = true;
        }

        public void show_question(TQuestion question)
        {
            List<TAnswer> answers = question.answers;
            label_question_text.Text = question.text;
            label_answer_1.Text = answers[0].text;
            label_answer_2.Text = answers[1].text;
            label_answer_3.Text = answers[2].text;
            if (testFact.chosen_answers.Count + 1 == test.questions.Count)
            {
                button_answer.Text = "«¿¬≈–ÿ»“‹";
            }
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            if (label_answer_1.Checked == true || label_answer_2.Checked == true || label_answer_3.Checked == true)
            {
                find_and_add_checked(test.questions[testFact.chosen_answers.Count].answers);
                progressBar_questions.Value++;
            }
            else
            {
                MessageBox.Show("Õ”∆ÕŒ ¬€¡–¿“‹ ¬¿–»¿Õ“ Œ“¬≈“¿");
            }
            if (testFact.chosen_answers.Count < test.questions.Count)
            {
                TQuestion question = test.questions[testFact.chosen_answers.Count];
                show_question(question);
            }
            else
            {
                // ÎÓ„ËÍ‡ Á‡‚Â¯ÂÌËˇ
                MessageBox.Show("FINISH");
                group_question.Visible = false;
                group_result.Visible = true;

                TTestSave testSave = new TTestSave(testFact);
                MessageBox.Show(testSave.Save());
                

            }

        }

        public void find_and_add_checked(List<TAnswer> answers)
        {
            if (label_answer_1.Checked)
            {
                testFact.AddChosenAnswer(answers[0]);
                label_answer_1.Checked = false;
            }
            else if (label_answer_2.Checked)
            {
                testFact.AddChosenAnswer(answers[1]);
                label_answer_2.Checked = false;
            }
            else if (label_answer_3.Checked)
            {
                testFact.AddChosenAnswer(answers[2]);
                label_answer_3.Checked = false;
            }
        }

        private void debug_Click(object sender, EventArgs e)
        {
            group_question.Visible = false;
            group_result.Visible = true;
        }
    }
}
