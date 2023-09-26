namespace StudentsDB
{
    partial class TableTamplate
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit_button = new System.Windows.Forms.Button();
            this.studentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.view_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(11, 10);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(96, 37);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "В меню";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 59);
            this.panel1.TabIndex = 2;
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(682, 10);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(146, 36);
            this.view_button.TabIndex = 3;
            this.view_button.Text = "Обозреватель записей";
            this.view_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(555, 10);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(121, 37);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Добавить запись";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // TableTamplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableTamplate";
            this.Text = "TableTamplate";
            this.Load += new System.EventHandler(this.TableTamplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentsDataSetBindingSource;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button view_button;
    }
}