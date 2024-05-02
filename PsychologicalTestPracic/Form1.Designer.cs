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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label_Title = new Label();
            groupBox_Start = new GroupBox();
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
            label_Title.Font = new Font("Segoe UI", 30F);
            label_Title.Location = new Point(-7, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1524, 85);
            label_Title.TabIndex = 0;
            label_Title.Text = "*Test_name*";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Start
            // 
            groupBox_Start.Controls.Add(edit_Grade);
            groupBox_Start.Controls.Add(edit_Age);
            groupBox_Start.Controls.Add(edit_Surname);
            groupBox_Start.Controls.Add(edit_Name);
            groupBox_Start.Controls.Add(button_Next);
            groupBox_Start.Font = new Font("Segoe UI", 20F);
            groupBox_Start.Location = new Point(31, 229);
            groupBox_Start.Name = "groupBox_Start";
            groupBox_Start.Padding = new Padding(40, 50, 40, 3);
            groupBox_Start.Size = new Size(450, 438);
            groupBox_Start.TabIndex = 1;
            groupBox_Start.TabStop = false;
            // 
            // edit_Grade
            // 
            edit_Grade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Grade.BorderStyle = BorderStyle.None;
            edit_Grade.Font = new Font("Segoe UI", 15F);
            edit_Grade.Location = new Point(86, 223);
            edit_Grade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            edit_Grade.Name = "edit_Grade";
            edit_Grade.Size = new Size(271, 37);
            edit_Grade.TabIndex = 4;
            edit_Grade.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // edit_Age
            // 
            edit_Age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Age.BorderStyle = BorderStyle.None;
            edit_Age.Font = new Font("Segoe UI", 15F);
            edit_Age.Location = new Point(86, 171);
            edit_Age.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            edit_Age.Name = "edit_Age";
            edit_Age.Size = new Size(271, 37);
            edit_Age.TabIndex = 3;
            edit_Age.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // edit_Surname
            // 
            edit_Surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Surname.BorderStyle = BorderStyle.None;
            edit_Surname.Font = new Font("Segoe UI", 15F);
            edit_Surname.Location = new Point(86, 120);
            edit_Surname.Name = "edit_Surname";
            edit_Surname.PlaceholderText = "фамилия";
            edit_Surname.Size = new Size(271, 34);
            edit_Surname.TabIndex = 2;
            edit_Surname.Text = "fox";
            // 
            // edit_Name
            // 
            edit_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_Name.BorderStyle = BorderStyle.None;
            edit_Name.Font = new Font("Segoe UI", 15F);
            edit_Name.Location = new Point(86, 70);
            edit_Name.Name = "edit_Name";
            edit_Name.PlaceholderText = "имя";
            edit_Name.Size = new Size(271, 34);
            edit_Name.TabIndex = 1;
            edit_Name.Text = "alex";
            // 
            // button_Next
            // 
            button_Next.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Next.BackColor = SystemColors.ButtonHighlight;
            button_Next.Font = new Font("Segoe UI", 20F);
            button_Next.Location = new Point(60, 323);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(321, 59);
            button_Next.TabIndex = 0;
            button_Next.Text = "ДАЛЬШЕ";
            button_Next.UseVisualStyleBackColor = false;
            button_Next.Click += button_Next_Click;
            // 
            // groupBox_Description
            // 
            groupBox_Description.Controls.Add(label_Description);
            groupBox_Description.Controls.Add(label_QuestCount);
            groupBox_Description.Controls.Add(button_Start);
            groupBox_Description.Font = new Font("Segoe UI", 20F);
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
            label_Description.Font = new Font("Segoe UI", 15F);
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
            label_QuestCount.Font = new Font("Segoe UI", 15F);
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
            button_Start.BackColor = SystemColors.ButtonHighlight;
            button_Start.Font = new Font("Segoe UI", 20F);
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
            groupBox_Question.Controls.Add(progressBar_Questions);
            groupBox_Question.Controls.Add(button_Answer);
            groupBox_Question.Controls.Add(radioButton_AnswerText3);
            groupBox_Question.Controls.Add(radioButton_AnswerText2);
            groupBox_Question.Controls.Add(radioButton_AnswerText1);
            groupBox_Question.Controls.Add(label_QuestionText);
            groupBox_Question.Font = new Font("Segoe UI", 20F);
            groupBox_Question.Location = new Point(31, 692);
            groupBox_Question.Name = "groupBox_Question";
            groupBox_Question.Padding = new Padding(40, 50, 40, 0);
            groupBox_Question.Size = new Size(450, 438);
            groupBox_Question.TabIndex = 6;
            groupBox_Question.TabStop = false;
            groupBox_Question.Visible = false;
            // 
            // progressBar_Questions
            // 
            progressBar_Questions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar_Questions.Location = new Point(0, 397);
            progressBar_Questions.Name = "progressBar_Questions";
            progressBar_Questions.Size = new Size(450, 41);
            progressBar_Questions.TabIndex = 7;
            // 
            // button_Answer
            // 
            button_Answer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Answer.BackColor = SystemColors.ButtonHighlight;
            button_Answer.Font = new Font("Segoe UI", 20F);
            button_Answer.Location = new Point(60, 326);
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
            radioButton_AnswerText3.Font = new Font("Segoe UI", 15F);
            radioButton_AnswerText3.Location = new Point(27, 261);
            radioButton_AnswerText3.Name = "radioButton_AnswerText3";
            radioButton_AnswerText3.Size = new Size(380, 44);
            radioButton_AnswerText3.TabIndex = 9;
            radioButton_AnswerText3.TabStop = true;
            radioButton_AnswerText3.Text = "*answer_text*";
            radioButton_AnswerText3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText3.UseVisualStyleBackColor = true;
            // 
            // radioButton_AnswerText2
            // 
            radioButton_AnswerText2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_AnswerText2.Font = new Font("Segoe UI", 15F);
            radioButton_AnswerText2.Location = new Point(27, 211);
            radioButton_AnswerText2.Name = "radioButton_AnswerText2";
            radioButton_AnswerText2.Size = new Size(380, 44);
            radioButton_AnswerText2.TabIndex = 8;
            radioButton_AnswerText2.TabStop = true;
            radioButton_AnswerText2.Text = "*answer_text*";
            radioButton_AnswerText2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText2.UseVisualStyleBackColor = true;
            // 
            // radioButton_AnswerText1
            // 
            radioButton_AnswerText1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_AnswerText1.Font = new Font("Segoe UI", 15F);
            radioButton_AnswerText1.Location = new Point(27, 161);
            radioButton_AnswerText1.Name = "radioButton_AnswerText1";
            radioButton_AnswerText1.Size = new Size(380, 44);
            radioButton_AnswerText1.TabIndex = 7;
            radioButton_AnswerText1.TabStop = true;
            radioButton_AnswerText1.Text = "*answer_text*";
            radioButton_AnswerText1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton_AnswerText1.UseVisualStyleBackColor = true;
            // 
            // label_QuestionText
            // 
            label_QuestionText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_QuestionText.Location = new Point(27, 50);
            label_QuestionText.Name = "label_QuestionText";
            label_QuestionText.Size = new Size(380, 108);
            label_QuestionText.TabIndex = 0;
            label_QuestionText.Text = "*quest_text*";
            label_QuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Result
            // 
            groupBox_Result.Controls.Add(label_filepath);
            groupBox_Result.Controls.Add(label_PredispositionDescription);
            groupBox_Result.Controls.Add(label_PredispositionScore);
            groupBox_Result.Controls.Add(label_PredispositionName);
            groupBox_Result.Controls.Add(button_MoreResult);
            groupBox_Result.Controls.Add(label_ResultTitle);
            groupBox_Result.Font = new Font("Segoe UI", 20F);
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
            label_filepath.BorderStyle = BorderStyle.None;
            label_filepath.Font = new Font("Segoe UI", 10F);
            label_filepath.Location = new Point(3, 388);
            label_filepath.Name = "label_filepath";
            label_filepath.ReadOnly = true;
            label_filepath.Size = new Size(444, 23);
            label_filepath.TabIndex = 5;
            // 
            // label_PredispositionDescription
            // 
            label_PredispositionDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionDescription.Font = new Font("Segoe UI", 15F);
            label_PredispositionDescription.Location = new Point(95, 211);
            label_PredispositionDescription.Name = "label_PredispositionDescription";
            label_PredispositionDescription.Size = new Size(296, 94);
            label_PredispositionDescription.TabIndex = 4;
            label_PredispositionDescription.Text = "*pred_desc_1*";
            label_PredispositionDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PredispositionScore
            // 
            label_PredispositionScore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionScore.Font = new Font("Segoe UI", 10F);
            label_PredispositionScore.Location = new Point(95, 182);
            label_PredispositionScore.Name = "label_PredispositionScore";
            label_PredispositionScore.Size = new Size(296, 29);
            label_PredispositionScore.TabIndex = 3;
            label_PredispositionScore.Text = "*pred_score_1*";
            label_PredispositionScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_PredispositionName
            // 
            label_PredispositionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_PredispositionName.Font = new Font("Segoe UI", 15F);
            label_PredispositionName.Location = new Point(95, 116);
            label_PredispositionName.Name = "label_PredispositionName";
            label_PredispositionName.Size = new Size(296, 52);
            label_PredispositionName.TabIndex = 2;
            label_PredispositionName.Text = "*pred_name_1*";
            label_PredispositionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_MoreResult
            // 
            button_MoreResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_MoreResult.BackColor = SystemColors.ButtonHighlight;
            button_MoreResult.Font = new Font("Segoe UI", 20F);
            button_MoreResult.Location = new Point(60, 323);
            button_MoreResult.Name = "button_MoreResult";
            button_MoreResult.Size = new Size(361, 59);
            button_MoreResult.TabIndex = 1;
            button_MoreResult.Text = "ЕЩЁ";
            button_MoreResult.UseVisualStyleBackColor = false;
            button_MoreResult.Click += button_MoreResult_Click;
            // 
            // label_ResultTitle
            // 
            label_ResultTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ResultTitle.Location = new Point(3, 26);
            label_ResultTitle.Name = "label_ResultTitle";
            label_ResultTitle.Size = new Size(444, 63);
            label_ResultTitle.TabIndex = 0;
            label_ResultTitle.Text = "РЕЗУЛЬТАТ";
            label_ResultTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_ResultMore
            // 
            groupBox_ResultMore.Controls.Add(dataGridView);
            groupBox_ResultMore.Controls.Add(label_ResultTitle_more);
            groupBox_ResultMore.Font = new Font("Segoe UI", 20F);
            groupBox_ResultMore.Location = new Point(1012, 692);
            groupBox_ResultMore.Name = "groupBox_ResultMore";
            groupBox_ResultMore.Padding = new Padding(0);
            groupBox_ResultMore.Size = new Size(450, 438);
            groupBox_ResultMore.TabIndex = 7;
            groupBox_ResultMore.TabStop = false;
            groupBox_ResultMore.Visible = false;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { CollumnName, Score, ScoreDescription, Description });
            dataGridView.Location = new Point(3, 116);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(447, 260);
            dataGridView.TabIndex = 10;
            // 
            // label_ResultTitle_more
            // 
            label_ResultTitle_more.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_ResultTitle_more.Location = new Point(3, 50);
            label_ResultTitle_more.Name = "label_ResultTitle_more";
            label_ResultTitle_more.Size = new Size(444, 63);
            label_ResultTitle_more.TabIndex = 0;
            label_ResultTitle_more.Text = "РЕЗУЛЬТАТ";
            label_ResultTitle_more.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CollumnName
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CollumnName.DefaultCellStyle = dataGridViewCellStyle2;
            CollumnName.HeaderText = "Предрасположенность";
            CollumnName.MinimumWidth = 6;
            CollumnName.Name = "CollumnName";
            // 
            // Score
            // 
            Score.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F);
            Score.DefaultCellStyle = dataGridViewCellStyle3;
            Score.HeaderText = "Результат";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            Score.Width = 153;
            // 
            // ScoreDescription
            // 
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ScoreDescription.DefaultCellStyle = dataGridViewCellStyle4;
            ScoreDescription.HeaderText = "Расшифровка результата";
            ScoreDescription.MinimumWidth = 6;
            ScoreDescription.Name = "ScoreDescription";
            // 
            // Description
            // 
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Description.DefaultCellStyle = dataGridViewCellStyle5;
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
        public ProgressBar progressBar_Questions;
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
        private Button button1;
        private Label label_ResultTitle_more;
        private DataGridView dataGridView;
        private TextBox label_filepath;
        private DataGridViewTextBoxColumn CollumnName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn ScoreDescription;
        private DataGridViewTextBoxColumn Description;
    }
}
