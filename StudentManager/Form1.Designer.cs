namespace StudentManager
{
    partial class Form1
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
            dataGridViewStudent = new DataGridView();
            labelID = new Label();
            labelNume = new Label();
            labelMedie = new Label();
            textBox1 = new TextBox();
            textBoxNume = new TextBox();
            textBoxMedie = new TextBox();
            btnADD = new Button();
            btnUPDATE = new Button();
            btnDELETE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewStudent.Location = new Point(20, 12);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 62;
            dataGridViewStudent.RowTemplate.Height = 33;
            dataGridViewStudent.Size = new Size(519, 433);
            dataGridViewStudent.TabIndex = 0;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(12, 475);
            labelID.Name = "labelID";
            labelID.Size = new Size(34, 25);
            labelID.TabIndex = 1;
            labelID.Text = "ID:";
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(12, 538);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(64, 25);
            labelNume.TabIndex = 2;
            labelNume.Text = "Nume:";
            // 
            // labelMedie
            // 
            labelMedie.AutoSize = true;
            labelMedie.Location = new Point(12, 598);
            labelMedie.Name = "labelMedie";
            labelMedie.Size = new Size(65, 25);
            labelMedie.TabIndex = 3;
            labelMedie.Text = "Medie:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 472);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(90, 535);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(150, 31);
            textBoxNume.TabIndex = 5;
            // 
            // textBoxMedie
            // 
            textBoxMedie.Location = new Point(90, 598);
            textBoxMedie.Name = "textBoxMedie";
            textBoxMedie.Size = new Size(150, 31);
            textBoxMedie.TabIndex = 6;
            // 
            // btnADD
            // 
            btnADD.Location = new Point(412, 472);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(112, 34);
            btnADD.TabIndex = 7;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(412, 535);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(112, 34);
            btnUPDATE.TabIndex = 8;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.Location = new Point(412, 598);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(112, 34);
            btnDELETE.TabIndex = 9;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 696);
            Controls.Add(btnDELETE);
            Controls.Add(btnUPDATE);
            Controls.Add(btnADD);
            Controls.Add(textBoxMedie);
            Controls.Add(textBoxNume);
            Controls.Add(textBox1);
            Controls.Add(labelMedie);
            Controls.Add(labelNume);
            Controls.Add(labelID);
            Controls.Add(dataGridViewStudent);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudent;
        private Label labelID;
        private Label labelNume;
        private Label labelMedie;
        private TextBox textBox1;
        private TextBox textBoxNume;
        private TextBox textBoxMedie;
        private Button btnADD;
        private Button btnUPDATE;
        private Button btnDELETE;
    }
}