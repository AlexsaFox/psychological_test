using Practic_2.core;

namespace Practic_2
{
    public partial class FormMain : Form
    {
        public TTest test;
        public TPupil pupil;
        public List<GroupBox> views;
        public FormMain()
        {
            // загрузки файлов
            TTestLoader loader = new TTestLoader("test.json");
            test = loader.Load();

            InitializeComponent();

            label_test_title.Text = test.title;
            views = new List<GroupBox>();
            views.Add(group_start);
            views.Add(group_description);

            init_views();
        }

        private void init_views()
        {
            for (int i = 0; i < views.Count; i++)
            {
                views[i].Location = new Point(0, 70);
                views[i].Width = this.Width;    
            }
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
                
                group_start.Visible = false;
                group_description.Visible = true;
            }
            
        }

       
    }
}
