namespace Practic_2
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
            group_start = new GroupBox();
            button_next = new Button();
            edit_grade = new NumericUpDown();
            edit_age = new NumericUpDown();
            edit_surname = new TextBox();
            edit_name = new TextBox();
            label_grade = new Label();
            label_age = new Label();
            label_surname = new Label();
            label_name = new Label();
            group_description = new GroupBox();
            button_start = new Button();
            label_count_questions = new Label();
            label_description = new Label();
            label_test_title = new Label();
            group_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edit_grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edit_age).BeginInit();
            group_description.SuspendLayout();
            SuspendLayout();
            // 
            // group_start
            // 
            group_start.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            group_start.Controls.Add(button_next);
            group_start.Controls.Add(edit_grade);
            group_start.Controls.Add(edit_age);
            group_start.Controls.Add(edit_surname);
            group_start.Controls.Add(edit_name);
            group_start.Controls.Add(label_grade);
            group_start.Controls.Add(label_age);
            group_start.Controls.Add(label_surname);
            group_start.Controls.Add(label_name);
            group_start.Location = new Point(202, 58);
            group_start.Name = "group_start";
            group_start.Size = new Size(884, 452);
            group_start.TabIndex = 0;
            group_start.TabStop = false;
            // 
            // button_next
            // 
            button_next.Location = new Point(275, 302);
            button_next.Name = "button_next";
            button_next.Size = new Size(343, 57);
            button_next.TabIndex = 11;
            button_next.Text = "NEXT";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // edit_grade
            // 
            edit_grade.Location = new Point(420, 223);
            edit_grade.Name = "edit_grade";
            edit_grade.Size = new Size(149, 27);
            edit_grade.TabIndex = 10;
            // 
            // edit_age
            // 
            edit_age.Location = new Point(420, 190);
            edit_age.Name = "edit_age";
            edit_age.Size = new Size(149, 27);
            edit_age.TabIndex = 9;
            // 
            // edit_surname
            // 
            edit_surname.Location = new Point(420, 154);
            edit_surname.Name = "edit_surname";
            edit_surname.Size = new Size(149, 27);
            edit_surname.TabIndex = 6;
            // 
            // edit_name
            // 
            edit_name.Location = new Point(420, 121);
            edit_name.Name = "edit_name";
            edit_name.Size = new Size(149, 27);
            edit_name.TabIndex = 5;
            // 
            // label_grade
            // 
            label_grade.AutoSize = true;
            label_grade.Location = new Point(299, 227);
            label_grade.Name = "label_grade";
            label_grade.Size = new Size(48, 20);
            label_grade.TabIndex = 4;
            label_grade.Text = "grade";
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.Location = new Point(299, 190);
            label_age.Name = "label_age";
            label_age.Size = new Size(34, 20);
            label_age.TabIndex = 3;
            label_age.Text = "age";
            // 
            // label_surname
            // 
            label_surname.AutoSize = true;
            label_surname.Location = new Point(299, 157);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(65, 20);
            label_surname.TabIndex = 2;
            label_surname.Text = "surname";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(299, 126);
            label_name.Name = "label_name";
            label_name.Size = new Size(46, 20);
            label_name.TabIndex = 1;
            label_name.Text = "name";
            // 
            // group_description
            // 
            group_description.Controls.Add(button_start);
            group_description.Controls.Add(label_count_questions);
            group_description.Controls.Add(label_description);
            group_description.Location = new Point(1, 71);
            group_description.Name = "group_description";
            group_description.Size = new Size(850, 382);
            group_description.TabIndex = 1;
            group_description.TabStop = false;
            group_description.Visible = false;
            // 
            // button_start
            // 
            button_start.Location = new Point(201, 264);
            button_start.Name = "button_start";
            button_start.Size = new Size(474, 59);
            button_start.TabIndex = 2;
            button_start.Text = "START TEST";
            button_start.UseVisualStyleBackColor = true;
            // 
            // label_count_questions
            // 
            label_count_questions.Location = new Point(184, 181);
            label_count_questions.Name = "label_count_questions";
            label_count_questions.Size = new Size(552, 46);
            label_count_questions.TabIndex = 1;
            label_count_questions.Text = "*count questions* QUESTIONS";
            // 
            // label_description
            // 
            label_description.Location = new Point(192, 36);
            label_description.Name = "label_description";
            label_description.Size = new Size(523, 116);
            label_description.TabIndex = 0;
            label_description.Text = "desc";
            // 
            // label_test_title
            // 
            label_test_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_test_title.Font = new Font("Segoe UI", 20F);
            label_test_title.Location = new Point(1, 9);
            label_test_title.Name = "label_test_title";
            label_test_title.Size = new Size(878, 46);
            label_test_title.TabIndex = 2;
            label_test_title.Text = "TEST_NAME";
            label_test_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(group_start);
            Controls.Add(label_test_title);
            Controls.Add(group_description);
            Name = "FormMain";
            Text = "Form1";
            group_start.ResumeLayout(false);
            group_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edit_grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)edit_age).EndInit();
            group_description.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox group_start;
        private Label label_grade;
        private Label label_age;
        private Label label_surname;
        private Label label_name;
        private TextBox edit_surname;
        private TextBox edit_name;
        private Button button_next;
        private NumericUpDown edit_grade;
        private NumericUpDown edit_age;
        private GroupBox group_description;
        private Label label_description;
        private Label label_test_title;
        private Button button_start;
        private Label label_count_questions;
    }
}
