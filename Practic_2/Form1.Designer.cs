﻿using System.Drawing.Printing;

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
            group_input_objects = new GroupBox();
            label_name = new Label();
            edit_name = new TextBox();
            label_surname = new Label();
            label_grade = new Label();
            edit_surname = new TextBox();
            edit_grade = new NumericUpDown();
            edit_age = new NumericUpDown();
            label_age = new Label();
            button_next = new Button();
            group_description = new GroupBox();
            button_start = new Button();
            label_count_questions = new Label();
            label_description = new Label();
            label_test_title = new Label();
            group_question = new GroupBox();
            button_answer = new Button();
            label_answer_3 = new RadioButton();
            label_answer_2 = new RadioButton();
            label_answer_1 = new RadioButton();
            label_question_text = new Label();
            group_start.SuspendLayout();
            group_input_objects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edit_grade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edit_age).BeginInit();
            group_description.SuspendLayout();
            group_question.SuspendLayout();
            SuspendLayout();
            // 
            // group_start
            // 
            group_start.Controls.Add(group_input_objects);
            group_start.Controls.Add(button_next);
            group_start.Location = new Point(942, 9);
            group_start.Margin = new Padding(0);
            group_start.Name = "group_start";
            group_start.Padding = new Padding(150, 10, 150, 70);
            group_start.Size = new Size(716, 466);
            group_start.TabIndex = 0;
            group_start.TabStop = false;
            // 
            // group_input_objects
            // 
            group_input_objects.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            group_input_objects.Controls.Add(label_name);
            group_input_objects.Controls.Add(edit_name);
            group_input_objects.Controls.Add(label_surname);
            group_input_objects.Controls.Add(label_grade);
            group_input_objects.Controls.Add(edit_surname);
            group_input_objects.Controls.Add(edit_grade);
            group_input_objects.Controls.Add(edit_age);
            group_input_objects.Controls.Add(label_age);
            group_input_objects.Location = new Point(146, 48);
            group_input_objects.Margin = new Padding(0);
            group_input_objects.MaximumSize = new Size(900, 300);
            group_input_objects.Name = "group_input_objects";
            group_input_objects.Padding = new Padding(0);
            group_input_objects.Size = new Size(420, 250);
            group_input_objects.TabIndex = 12;
            group_input_objects.TabStop = false;
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 20F);
            label_name.Location = new Point(80, 23);
            label_name.Name = "label_name";
            label_name.Size = new Size(81, 46);
            label_name.TabIndex = 1;
            label_name.Text = "имя";
            // 
            // edit_name
            // 
            edit_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_name.Font = new Font("Segoe UI", 20F);
            edit_name.Location = new Point(170, 20);
            edit_name.Name = "edit_name";
            edit_name.Size = new Size(223, 52);
            edit_name.TabIndex = 5;
            edit_name.Text = "alex";
            // 
            // label_surname
            // 
            label_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_surname.AutoSize = true;
            label_surname.Font = new Font("Segoe UI", 20F);
            label_surname.Location = new Point(2, 81);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(159, 46);
            label_surname.TabIndex = 2;
            label_surname.Text = "фамилия";
            // 
            // label_grade
            // 
            label_grade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_grade.AutoSize = true;
            label_grade.Font = new Font("Segoe UI", 20F);
            label_grade.Location = new Point(57, 194);
            label_grade.Name = "label_grade";
            label_grade.Size = new Size(104, 46);
            label_grade.TabIndex = 4;
            label_grade.Text = "класс";
            // 
            // edit_surname
            // 
            edit_surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_surname.Font = new Font("Segoe UI", 20F);
            edit_surname.Location = new Point(170, 78);
            edit_surname.Name = "edit_surname";
            edit_surname.Size = new Size(223, 52);
            edit_surname.TabIndex = 6;
            edit_surname.Text = "fox";
            // 
            // edit_grade
            // 
            edit_grade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_grade.Font = new Font("Segoe UI", 20F);
            edit_grade.Location = new Point(170, 194);
            edit_grade.Name = "edit_grade";
            edit_grade.Size = new Size(223, 52);
            edit_grade.TabIndex = 10;
            edit_grade.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // edit_age
            // 
            edit_age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_age.Font = new Font("Segoe UI", 20F);
            edit_age.Location = new Point(171, 136);
            edit_age.Name = "edit_age";
            edit_age.Size = new Size(222, 52);
            edit_age.TabIndex = 9;
            edit_age.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label_age
            // 
            label_age.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_age.AutoSize = true;
            label_age.Font = new Font("Segoe UI", 20F);
            label_age.Location = new Point(21, 138);
            label_age.Name = "label_age";
            label_age.Size = new Size(140, 46);
            label_age.TabIndex = 3;
            label_age.Text = "возраст";
            // 
            // button_next
            // 
            button_next.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_next.Font = new Font("Segoe UI", 20F);
            button_next.Location = new Point(197, 348);
            button_next.Margin = new Padding(0, 50, 0, 0);
            button_next.MaximumSize = new Size(0, 80);
            button_next.Name = "button_next";
            button_next.Size = new Size(300, 60);
            button_next.TabIndex = 11;
            button_next.Text = "ДАЛЕЕ";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // group_description
            // 
            group_description.Controls.Add(button_start);
            group_description.Controls.Add(label_count_questions);
            group_description.Controls.Add(label_description);
            group_description.Location = new Point(942, 508);
            group_description.Name = "group_description";
            group_description.Padding = new Padding(150, 10, 150, 70);
            group_description.Size = new Size(878, 474);
            group_description.TabIndex = 1;
            group_description.TabStop = false;
            group_description.Visible = false;
            // 
            // button_start
            // 
            button_start.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_start.Font = new Font("Segoe UI", 20F);
            button_start.Location = new Point(280, 394);
            button_start.Margin = new Padding(0);
            button_start.Name = "button_start";
            button_start.Size = new Size(300, 60);
            button_start.TabIndex = 2;
            button_start.Text = "НАЧАТЬ ТЕСТ";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // label_count_questions
            // 
            label_count_questions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_count_questions.Font = new Font("Segoe UI", 15F);
            label_count_questions.Location = new Point(120, 336);
            label_count_questions.Name = "label_count_questions";
            label_count_questions.Size = new Size(600, 46);
            label_count_questions.TabIndex = 1;
            label_count_questions.Text = "*count questions* QUESTIONS";
            label_count_questions.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_description
            // 
            label_description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_description.Font = new Font("Segoe UI", 20F);
            label_description.Location = new Point(120, 22);
            label_description.Name = "label_description";
            label_description.Size = new Size(600, 280);
            label_description.TabIndex = 0;
            label_description.Text = "desc";
            label_description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_test_title
            // 
            label_test_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_test_title.Font = new Font("Segoe UI", 30F);
            label_test_title.Location = new Point(12, -1);
            label_test_title.Name = "label_test_title";
            label_test_title.Size = new Size(967, 80);
            label_test_title.TabIndex = 2;
            label_test_title.Text = "TEST_NAME";
            label_test_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // group_question
            // 
            group_question.Controls.Add(button_answer);
            group_question.Controls.Add(label_answer_3);
            group_question.Controls.Add(label_answer_2);
            group_question.Controls.Add(label_answer_1);
            group_question.Controls.Add(label_question_text);
            group_question.Font = new Font("Segoe UI", 20F);
            group_question.Location = new Point(8, 82);
            group_question.Name = "group_question";
            group_question.Padding = new Padding(50, 10, 50, 30);
            group_question.Size = new Size(928, 521);
            group_question.TabIndex = 3;
            group_question.TabStop = false;
            group_question.Visible = false;
            // 
            // button_answer
            // 
            button_answer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_answer.Location = new Point(226, 431);
            button_answer.Name = "button_answer";
            button_answer.Size = new Size(468, 57);
            button_answer.TabIndex = 4;
            button_answer.Text = "ОТВЕТИТЬ";
            button_answer.UseVisualStyleBackColor = true;
            button_answer.Click += button_answer_Click;
            // 
            // label_answer_3
            // 
            label_answer_3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_answer_3.Font = new Font("Segoe UI", 15F);
            label_answer_3.Location = new Point(44, 328);
            label_answer_3.Name = "label_answer_3";
            label_answer_3.Size = new Size(827, 80);
            label_answer_3.TabIndex = 3;
            label_answer_3.TabStop = true;
            label_answer_3.Text = "*answer_text*";
            label_answer_3.UseVisualStyleBackColor = true;
            // 
            // label_answer_2
            // 
            label_answer_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_answer_2.Font = new Font("Segoe UI", 15F);
            label_answer_2.Location = new Point(44, 242);
            label_answer_2.Name = "label_answer_2";
            label_answer_2.Size = new Size(827, 80);
            label_answer_2.TabIndex = 2;
            label_answer_2.TabStop = true;
            label_answer_2.Text = "*answer_text*";
            label_answer_2.UseVisualStyleBackColor = true;
            // 
            // label_answer_1
            // 
            label_answer_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_answer_1.Font = new Font("Segoe UI", 15F);
            label_answer_1.Location = new Point(44, 156);
            label_answer_1.Name = "label_answer_1";
            label_answer_1.Size = new Size(827, 80);
            label_answer_1.TabIndex = 1;
            label_answer_1.TabStop = true;
            label_answer_1.Text = "*answer_text*";
            label_answer_1.UseVisualStyleBackColor = true;
            // 
            // label_question_text
            // 
            label_question_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_question_text.Location = new Point(44, 35);
            label_question_text.Name = "label_question_text";
            label_question_text.Size = new Size(831, 95);
            label_question_text.TabIndex = 0;
            label_question_text.Text = "*question_text*";
            label_question_text.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 633);
            Controls.Add(group_start);
            Controls.Add(group_description);
            Controls.Add(group_question);
            Controls.Add(label_test_title);
            Name = "FormMain";
            Text = "Form1";
            group_start.ResumeLayout(false);
            group_input_objects.ResumeLayout(false);
            group_input_objects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edit_grade).EndInit();
            ((System.ComponentModel.ISupportInitialize)edit_age).EndInit();
            group_description.ResumeLayout(false);
            group_question.ResumeLayout(false);
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
        private GroupBox group_input_objects;
        private GroupBox group_question;
        private Button button_answer;
        private RadioButton label_answer_3;
        private RadioButton label_answer_2;
        private RadioButton label_answer_1;
        private Label label_question_text;
    }
}
