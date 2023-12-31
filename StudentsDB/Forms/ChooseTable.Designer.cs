﻿namespace StudentsDB
{
    partial class ChooseTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonSpecialities = new System.Windows.Forms.Button();
            this.buttonEstimates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите таблицу";
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(221, 95);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(154, 35);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Таблица \"Студенты\"";
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // buttonSubject
            // 
            this.buttonSubject.Location = new System.Drawing.Point(221, 154);
            this.buttonSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(154, 35);
            this.buttonSubject.TabIndex = 2;
            this.buttonSubject.Text = "Таблица \"Предметы\"";
            this.buttonSubject.UseVisualStyleBackColor = true;
            // 
            // buttonSpecialities
            // 
            this.buttonSpecialities.Location = new System.Drawing.Point(221, 206);
            this.buttonSpecialities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpecialities.Name = "buttonSpecialities";
            this.buttonSpecialities.Size = new System.Drawing.Size(154, 35);
            this.buttonSpecialities.TabIndex = 3;
            this.buttonSpecialities.Text = "Таблица \"Специальности\"";
            this.buttonSpecialities.UseVisualStyleBackColor = true;
            // 
            // buttonEstimates
            // 
            this.buttonEstimates.Location = new System.Drawing.Point(221, 262);
            this.buttonEstimates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEstimates.Name = "buttonEstimates";
            this.buttonEstimates.Size = new System.Drawing.Size(154, 35);
            this.buttonEstimates.TabIndex = 4;
            this.buttonEstimates.Text = "Таблица \"Оценки\"";
            this.buttonEstimates.UseVisualStyleBackColor = true;
            // 
            // ChooseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonEstimates);
            this.Controls.Add(this.buttonSpecialities);
            this.Controls.Add(this.buttonSubject);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChooseTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберете таблицу";
            this.Load += new System.EventHandler(this.ChooseTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Button buttonSpecialities;
        private System.Windows.Forms.Button buttonEstimates;
    }
}