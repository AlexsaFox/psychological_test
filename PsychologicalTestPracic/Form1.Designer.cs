namespace PsychologicalTestPracic
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label_Title = new Label();
            groupBox_Start = new GroupBox();
            label_Grade = new Label();
            label_Age = new Label();
            label_Surname = new Label();
            label_Name = new Label();
            edit_Grade = new NumericUpDown();
            edit_Age = new NumericUpDown();
            edit_Surname = new TextBox();
            edit_Name = new TextBox();
            button_Next = new Button();
            groupBox_Description = new GroupBox();
            label_Description = new Label();
            label_QuestCount = new Label();
            button_Start = new Button();
            groupBox_Question = new GroupBox();
            progressBar_Questions = new ProgressBar();
            button_Answer = new Button();
            radioButton_AnswerText3 = new RadioButton();
            radioButton_AnswerText2 = new RadioButton();
            radioButton_AnswerText1 = new RadioButton();
            label_QuestionText = new Label();
            groupBox_Result = new GroupBox();
            label_filepath = new TextBox();
            label_PredispositionDescription = new Label();
            label_PredispositionScore = new Label();
            label_PredispositionName = new Label();
            button_MoreResult = new Button();
            label_ResultTitle = new Label();
            groupBox_ResultMore = new GroupBox();
            dataGridView = new DataGridView();
            label_ResultTitle_more = new Label();
            CollumnName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            ScoreDescription = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            groupBox_Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edit_Grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edit_Age).BeginInit();
            groupBox_Description.SuspendLayout();
            groupBox_Question.SuspendLayout();
            groupBox_Result.SuspendLayout();
            groupBox_ResultMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Title.Font = new Font("Montserrat Alternates", 30F);
            label_Title.ForeColor = Color.FromArgb(92, 76, 71);
            label_Title.Location = new Point(-7, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1524, 85);
            label_Title.TabIndex = 0;
            label_Title.Text = "*Test_name*";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Start
            // 
            groupBox_Start.BackColor = Color.Transparent;
            groupBox_Start.Controls.Add(label_Grade);
            groupBox_Start.Controls.Add(label_Age);
            groupBox_Start.Controls.Add(label_Surname);
            groupBox_Start.Controls.Add(label_Name);
            groupBox_Start.Controls.Add(edit_Grade);
            groupBox_Start.Controls.Add(edit_Age);
            groupBox_Start.Controls.Add(edit_Surname);
            groupBox_Start.Controls.Add(edit_Name);
            groupBox_Start.Controls.Add(button_Next);
            groupBox_Start.Font = new Font("Montserrat Alternates", 20F);
            groupBox_Start.ForeColor = Color.FromArgb(92, 76, 71);
            groupBox_Start.Location = new Point(31, 229);
            groupBox_Start.Name = "groupBox_Start";
            groupBox_Start.Padding = new Padding(60, 80, 60, 3);
            groupBox_Start.Size = new Size(450, 438);
            groupBox_Start.TabIndex = 1;
            groupBox_Start.TabStop = false;
            // 
            // label_Grade
            // 
            label_Grade.Font = new Font("Montserrat Alternates", 15F);
            label_Grade.Location = new Point(106, 254);
            label_Grade.Name = "label_Grade";
            label_Grade.Size = new Size(142, 34);
            label_Grade.TabIndex = 8;
            label_Grade.Text = "Класс";
            label_Grade.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_Age
            // 
            label_Age.Font = new Font("Montserrat Alternates", 15F);
            label_Age.Location = new Point(106, 202);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(142, 34);
            label_Age.TabIndex = 7;
            label_Age.Text = "Возраст";
            label_Age.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_Surname
            // 
            label_Surname.Font = new Font("Montserrat Alternates", 15F);
            label_Surname.Location = new Point(106, 148);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(142, 34);
            label_Surname.TabIndex = 6;
            label_Surname.Text = "Фамилия";
            label_Surname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            label_Name.Font = new Font("Montserrat Alternates", 15F);
            label_Name.Location = new Point(106, 98);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(142, 34);
            label_Name.TabIndex = 5;
            label_Name.Text = "Имя";
            label_Name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // edit_Grade
            // 
            edit_Grade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Grade.BackColor = Color.FromArgb(174, 165, 156);
            edit_Grade.BorderStyle = BorderStyle.FixedSingle;
            edit_Grade.Font = new Font("Montserrat Alternates", 15F);
            edit_Grade.ForeColor = Color.FromArgb(92, 76, 71);
            edit_Grade.Location = new Point(254, 253);
            edit_Grade.Name = "edit_Grade";
            edit_Grade.Size = new Size(83, 38);
            edit_Grade.TabIndex = 4;
            // 
            // edit_Age
            // 
            edit_Age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Age.BackColor = Color.FromArgb(174, 165, 156);
            edit_Age.BorderStyle = BorderStyle.FixedSingle;
            edit_Age.Font = new Font("Montserrat Alternates", 15F);
            edit_Age.ForeColor = Color.FromArgb(92, 76, 71);
            edit_Age.Location = new Point(254, 201);
            edit_Age.Name = "edit_Age";
            edit_Age.Size = new Size(83, 38);
            edit_Age.TabIndex = 3;
            // 
            // edit_Surname
            // 
            edit_Surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Surname.BackColor = Color.FromArgb(174, 165, 156);
            edit_Surname.BorderStyle = BorderStyle.FixedSingle;
            edit_Surname.Font = new Font("Montserrat Alternates", 15F);
            edit_Surname.ForeColor = Color.FromArgb(92, 76, 71);
            edit_Surname.Location = new Point(254, 150);
            edit_Surname.Name = "edit_Surname";
            edit_Surname.Size = new Size(83, 38);
            edit_Surname.TabIndex = 2;
            // 
            // edit_Name
            // 
            edit_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Name.BackColor = Color.FromArgb(174, 165, 156);
            edit_Name.BorderStyle = BorderStyle.FixedSingle;
            edit_Name.Font = new Font("Montserrat Alternates", 15F);
            edit_Name.ForeColor = Color.FromArgb(92, 76, 71);
            edit_Name.Location = new Point(254, 100);
            edit_Name.Name = "edit_Name";
            edit_Name.RightToLeft = RightToLeft.No;
            edit_Name.Size = new Size(83, 38);
            edit_Name.TabIndex = 1;
            // 
            // button_Next
            // 
            button_Next.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Next.BackColor = Color.FromArgb(131, 213, 132);
            button_Next.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button_Next.FlatAppearance.BorderSize = 0;
            button_Next.FlatStyle = FlatStyle.Flat;
            button_Next.Font = new Font("Montserrat Alternates Medium", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_Next.Location = new Point(80, 323);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(281, 59);
            button_Next.TabIndex = 0;
            button_Next.Text = "ДАЛЬШЕ";
            button_Next.UseVisualStyleBackColor = false;
            button_Next.Click += button_Next_Click;
            // 
            // groupBox_Description
            // 
            groupBox_Description.BackColor = Color.Transparent;
            groupBox_Description.Controls.Add(label_Description);
            groupBox_Description.Controls.Add(label_QuestCount);
            groupBox_Description.Controls.Add(button_Start);
            groupBox_Description.Font = new Font("Segoe UI", 20F);
            groupBox_Description.ForeColor = Color.FromArgb(92, 76, 71);
            groupBox_Description.Location = new Point(520, 229);
            groupBox_Description.Name = "groupBox_Description";
            groupBox_Description.Padding = new Padding(40, 50, 40, 3);
            groupBox_Description.Size = new Size(450, 438);
            groupBox_Description.TabIndex = 5;
            groupBox_Description.TabStop = false;
            groupBox_Description.Visible = false;
            // 
            // label_Description
            // 
            label_Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Description.Font = new Font("Montserrat Alternates", 15F);
            label_Description.ForeColor = Color.FromArgb(92, 76, 71);
            label_Description.Location = new Point(55, 70);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(352, 190);
            label_Description.TabIndex = 4;
            label_Description.Text = "*desc*";
            label_Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_QuestCount
            // 
            label_QuestCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_QuestCount.Font = new Font("Montserrat Alternates", 15F);
            label_QuestCount.ForeColor = Color.FromArgb(92, 76, 71);
            label_QuestCount.Location = new Point(70, 272);
            label_QuestCount.Name = "label_QuestCount";
            label_QuestCount.Size = new Size(321, 38);
            label_QuestCount.TabIndex = 3;
            label_QuestCount.Text = "*question count*";
            label_QuestCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            button_Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Start.BackColor = Color.FromArgb(131, 213, 132);
            button_Start.FlatAppearance.BorderSize = 0;
            button_Start.FlatStyle = FlatStyle.Flat;
            button_Start.Font = new Font("Montserrat Alternates Medium", 19.7999973F, FontStyle.Bold);
            button_Start.Location = new Point(60, 323);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(321, 59);
            button_Start.TabIndex = 2;
            button_Start.Text = "НАЧАТЬ";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // groupBox_Question
            // 
            groupBox_Question.BackColor = Color.Transparent;
            groupBox_Question.Controls.Add(progressBar_Questions);
            groupBox_Question.Controls.Add(button_Answer);
            groupBox_Question.Controls.Add(radioButton_AnswerText3);
            groupBox_Question.Controls.Add(radioButton_AnswerText2);
            groupBox_Question.Controls.Add(radioButton_AnswerText1);
            groupBox_Question.Controls.Add(label_QuestionText);
            groupBox_Question.Font = new Font("Segoe UI", 20F);
            groupBox_Question.ForeColor = Color.FromArgb(92, 76, 71);
            groupBox_Question.Location = new Point(1012, 229);
            groupBox_Question.Name = "groupBox_Question";
            groupBox_Question.Padding = new Padding(40, 50, 40, 0);
            groupBox_Question.Size = new Size(450, 552);
            groupBox_Question.TabIndex = 6;
            groupBox_Question.TabStop = false;
            groupBox_Question.Visible = false;
            // 
            // progressBar_Questions
            // 
            progressBar_Questions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar_Questions.BackColor = Color.FromArgb(131, 213, 132);
            progressBar_Questions.Location = new Point(0, 511);
            progressBar_Questions.Name = "progressBar_Questions";
            progressBar_Questions.Size = new Size(450, 41);
            progressBar_Questions.TabIndex = 7;
            // 
            // button_Answer
            // 
            button_Answer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Answer.BackColor = Color.FromArgb(131, 213, 132);
            button_Answer.FlatAppearance.BorderSize = 0;
            button_Answer.FlatStyle = FlatStyle.Flat;
            button_Answer.Font = new Font("Montserrat Alternates Medium", 19.7999973F, FontStyle.Bold);
            button_Answer.Location = new Point(60, 440);
            button_Answer.Name = "button_Answer";
            button_Answer.Size = new Size(321, 59);
            button_Answer.TabIndex = 10;
            button_Answer.Text = "ОТВЕТИТЬ";
            button_Answer.UseVisualStyleBackColor = false;
            button_Answer.Click += button_Answer_Click;
            // 
            // radioButton_AnswerText3
            // 
            radioButton_AnswerText3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_AnswerText3.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            radioButton_AnswerText3.FlatAppearance.BorderSize = 0;
            radioButton_AnswerText3.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 192, 0);
            radioButton_AnswerText3.Font = new Font("Montserrat Alternates", 14.999999F);
            radioButton_AnswerText3.Location = new Point(27, 333);
            radioButton_AnswerText3.Name = "radioButton_AnswerText3";
            radioButton_AnswerText3.Padding = new Padding(10, 0, 0, 0);
            radioButton_AnswerText3.Size = new Size(380, 80);
            radioButton_AnswerText3.TabIndex = 9;
            radioButton_AnswerText3.TabStop = true;
            radioButton_AnswerText3.Text = "*answer_text*";
            radioButton_AnswerText3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText3.UseVisualStyleBackColor = true;
            // 
            // radioButton_AnswerText2
            // 
            radioButton_AnswerText2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_AnswerText2.Font = new Font("Montserrat Alternates", 14.999999F);
            radioButton_AnswerText2.Location = new Point(27, 247);
            radioButton_AnswerText2.Name = "radioButton_AnswerText2";
            radioButton_AnswerText2.Padding = new Padding(10, 0, 0, 0);
            radioButton_AnswerText2.Size = new Size(380, 80);
            radioButton_AnswerText2.TabIndex = 8;
            radioButton_AnswerText2.TabStop = true;
            radioButton_AnswerText2.Text = "*answer_text*";
            radioButton_AnswerText2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText2.UseVisualStyleBackColor = true;
            // 
            // radioButton_AnswerText1
            // 
            radioButton_AnswerText1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_AnswerText1.BackColor = Color.Transparent;
            radioButton_AnswerText1.Font = new Font("Montserrat Alternates", 14.999999F);
            radioButton_AnswerText1.Location = new Point(27, 161);
            radioButton_AnswerText1.Name = "radioButton_AnswerText1";
            radioButton_AnswerText1.Padding = new Padding(10, 0, 0, 0);
            radioButton_AnswerText1.Size = new Size(380, 80);
            radioButton_AnswerText1.TabIndex = 7;
            radioButton_AnswerText1.TabStop = true;
            radioButton_AnswerText1.Text = "*answer_text*";
            radioButton_AnswerText1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText1.UseVisualStyleBackColor = false;
            // 
            // label_QuestionText
            // 
            label_QuestionText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_QuestionText.Font = new Font("Montserrat Alternates", 19.7999973F);
            label_QuestionText.Location = new Point(27, 50);
            label_QuestionText.Name = "label_QuestionText";
            label_QuestionText.Size = new Size(380, 108);
            label_QuestionText.TabIndex = 0;
            label_QuestionText.Text = "*quest_text*";
            label_QuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Result
            // 
            groupBox_Result.BackColor = Color.Transparent;
            groupBox_Result.Controls.Add(label_filepath);
            groupBox_Result.Controls.Add(label_PredispositionDescription);
            groupBox_Result.Controls.Add(label_PredispositionScore);
            groupBox_Result.Controls.Add(label_PredispositionName);
            groupBox_Result.Controls.Add(button_MoreResult);
            groupBox_Result.Controls.Add(label_ResultTitle);
            groupBox_Result.Font = new Font("Segoe UI", 20F);
            groupBox_Result.ForeColor = Color.FromArgb(92, 76, 71);
            groupBox_Result.Location = new Point(520, 692);
            groupBox_Result.Name = "groupBox_Result";
            groupBox_Result.Padding = new Padding(0);
            groupBox_Result.Size = new Size(450, 438);
            groupBox_Result.TabIndex = 6;
            groupBox_Result.TabStop = false;
            groupBox_Result.Visible = false;
            // 
            // label_filepath
            // 
            label_filepath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_filepath.BackColor = Color.FromArgb(255, 253, 241);
            label_filepath.BorderStyle = BorderStyle.None;
            label_filepath.Font = new Font("Montserrat Alternates", 10F);
            label_filepath.Location = new Point(3, 388);
            label_filepath.Name = "label_filepath";
            label_filepath.ReadOnly = true;
            label_filepath.Size = new Size(444, 21);
            label_filepath.TabIndex = 5;
            // 
            // label_PredispositionDescription
            // 
            label_PredispositionDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionDescription.Font = new Font("Montserrat Alternates", 12F);
            label_PredispositionDescription.Location = new Point(60, 211);
            label_PredispositionDescription.Name = "label_PredispositionDescription";
            label_PredispositionDescription.Size = new Size(321, 94);
            label_PredispositionDescription.TabIndex = 4;
            label_PredispositionDescription.Text = "*pred_desc_1*";
            label_PredispositionDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PredispositionScore
            // 
            label_PredispositionScore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionScore.Font = new Font("Montserrat Alternates", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_PredispositionScore.Location = new Point(60, 168);
            label_PredispositionScore.Name = "label_PredispositionScore";
            label_PredispositionScore.Size = new Size(321, 29);
            label_PredispositionScore.TabIndex = 3;
            label_PredispositionScore.Text = "*pred_score_1*";
            label_PredispositionScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PredispositionName
            // 
            label_PredispositionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionName.Font = new Font("Montserrat Alternates", 14.999999F);
            label_PredispositionName.Location = new Point(60, 116);
            label_PredispositionName.Name = "label_PredispositionName";
            label_PredispositionName.Size = new Size(321, 52);
            label_PredispositionName.TabIndex = 2;
            label_PredispositionName.Text = "*pred_name_1*";
            label_PredispositionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_MoreResult
            // 
            button_MoreResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_MoreResult.BackColor = Color.FromArgb(131, 213, 132);
            button_MoreResult.FlatAppearance.BorderSize = 0;
            button_MoreResult.FlatStyle = FlatStyle.Flat;
            button_MoreResult.Font = new Font("Montserrat Alternates Medium", 19.7999973F, FontStyle.Bold);
            button_MoreResult.Location = new Point(60, 323);
            button_MoreResult.Name = "button_MoreResult";
            button_MoreResult.Size = new Size(321, 59);
            button_MoreResult.TabIndex = 1;
            button_MoreResult.Text = "ЕЩЁ";
            button_MoreResult.UseVisualStyleBackColor = false;
            button_MoreResult.Click += button_MoreResult_Click;
            // 
            // label_ResultTitle
            // 
            label_ResultTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ResultTitle.Font = new Font("Montserrat Alternates", 19.7999973F);
            label_ResultTitle.Location = new Point(3, 26);
            label_ResultTitle.Name = "label_ResultTitle";
            label_ResultTitle.Size = new Size(444, 63);
            label_ResultTitle.TabIndex = 0;
            label_ResultTitle.Text = "РЕЗУЛЬТАТ";
            label_ResultTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_ResultMore
            // 
            groupBox_ResultMore.BackColor = Color.Transparent;
            groupBox_ResultMore.Controls.Add(dataGridView);
            groupBox_ResultMore.Controls.Add(label_ResultTitle_more);
            groupBox_ResultMore.Font = new Font("Segoe UI", 20F);
            groupBox_ResultMore.ForeColor = Color.FromArgb(92, 76, 71);
            groupBox_ResultMore.Location = new Point(31, 718);
            groupBox_ResultMore.Name = "groupBox_ResultMore";
            groupBox_ResultMore.Padding = new Padding(5, 0, 5, 0);
            groupBox_ResultMore.Size = new Size(450, 412);
            groupBox_ResultMore.TabIndex = 7;
            groupBox_ResultMore.TabStop = false;
            groupBox_ResultMore.Visible = false;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 253, 241);
            dataGridViewCellStyle1.Font = new Font("Montserrat Alternates", 10F);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(131, 213, 132);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(174, 165, 156);
            dataGridViewCellStyle2.Font = new Font("Montserrat Alternates", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(131, 213, 132);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { CollumnName, Score, ScoreDescription, Description });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 253, 241);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(92, 76, 71);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(131, 213, 132);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(92, 76, 71);
            dataGridView.Location = new Point(8, 116);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(174, 165, 156);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(131, 213, 132);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.RowHeadersWidth = 50;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 253, 241);
            dataGridViewCellStyle9.Font = new Font("Montserrat Alternates", 10F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(92, 76, 71);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(131, 213, 132);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.Size = new Size(434, 234);
            dataGridView.TabIndex = 10;
            // 
            // label_ResultTitle_more
            // 
            label_ResultTitle_more.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ResultTitle_more.Font = new Font("Montserrat Alternates", 20F);
            label_ResultTitle_more.Location = new Point(8, 50);
            label_ResultTitle_more.Name = "label_ResultTitle_more";
            label_ResultTitle_more.Size = new Size(434, 63);
            label_ResultTitle_more.TabIndex = 0;
            label_ResultTitle_more.Text = "РЕЗУЛЬТАТ";
            label_ResultTitle_more.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CollumnName
            // 
            CollumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Montserrat Alternates", 10F);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CollumnName.DefaultCellStyle = dataGridViewCellStyle3;
            CollumnName.HeaderText = "Предрасположенность";
            CollumnName.MinimumWidth = 6;
            CollumnName.Name = "CollumnName";
            // 
            // Score
            // 
            Score.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Font = new Font("Montserrat Alternates", 10F);
            Score.DefaultCellStyle = dataGridViewCellStyle4;
            Score.HeaderText = "Баллы";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            Score.Width = 130;
            // 
            // ScoreDescription
            // 
            ScoreDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Montserrat Alternates", 10F);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ScoreDescription.DefaultCellStyle = dataGridViewCellStyle5;
            ScoreDescription.HeaderText = "Расшифровка результата";
            ScoreDescription.MinimumWidth = 6;
            ScoreDescription.Name = "ScoreDescription";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new Font("Montserrat Alternates", 10F);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            Description.DefaultCellStyle = dataGridViewCellStyle6;
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 253, 241);
            ClientSize = new Size(1506, 1175);
            Controls.Add(groupBox_ResultMore);
            Controls.Add(groupBox_Result);
            Controls.Add(groupBox_Question);
            Controls.Add(groupBox_Description);
            Controls.Add(groupBox_Start);
            Controls.Add(label_Title);
            MinimumSize = new Size(1000, 700);
            Name = "FormMain";
            Text = "Психологический тест";
            groupBox_Start.ResumeLayout(false);
            groupBox_Start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edit_Grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)edit_Age).EndInit();
            groupBox_Description.ResumeLayout(false);
            groupBox_Question.ResumeLayout(false);
            groupBox_Result.ResumeLayout(false);
            groupBox_Result.PerformLayout();
            groupBox_ResultMore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Title;
        private GroupBox groupBox_Start;
        private TextBox edit_Name;
        private Button button_Next;
        private NumericUpDown edit_Grade;
        private NumericUpDown edit_Age;
        private TextBox edit_Surname;
        private GroupBox groupBox_Description;
        private Label label_QuestCount;
        private Button button_Start;
        private GroupBox groupBox_Question;
        private Label label_Description;
        private Label label_QuestionText;
        private Button button_Answer;
        private RadioButton radioButton_AnswerText3;
        private RadioButton radioButton_AnswerText2;
        private RadioButton radioButton_AnswerText1;
        private ProgressBar progressBar1;
        private GroupBox groupBox_Result;
        private Label label_ResultTitle;
        private Label label_PredispositionDescription;
        private Label label_PredispositionScore;
        private Label label_PredispositionName;
        private Button button_MoreResult;
        private GroupBox groupBox_ResultMore;
        private Label label2;
        private Label label3;
        private Label label_ResultTitle_more;
        private DataGridView dataGridView;
        private TextBox label_filepath;
        private Label label_Name;
        private Label label_Age;
        private Label label_Surname;
        private Label label_Grade;
        private ProgressBar progressBar_Questions;
        private DataGridViewTextBoxColumn CollumnName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn ScoreDescription;
        private DataGridViewTextBoxColumn Description;
    }
}
