namespace Lift
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
            trackBar1 = new TrackBar();
            labelEtaj3 = new Label();
            labelEtaj2 = new Label();
            labelEtaj1 = new Label();
            labelParter = new Label();
            checkBoxEtaj3 = new CheckBox();
            checkBoxEtaj2 = new CheckBox();
            checkBoxEtaj1 = new CheckBox();
            checkBoxParter = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(324, 165);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(69, 289);
            trackBar1.TabIndex = 0;
            // 
            // labelEtaj3
            // 
            labelEtaj3.AutoSize = true;
            labelEtaj3.Location = new Point(227, 179);
            labelEtaj3.Name = "labelEtaj3";
            labelEtaj3.Size = new Size(55, 25);
            labelEtaj3.TabIndex = 1;
            labelEtaj3.Text = "etaj 3";
            // 
            // labelEtaj2
            // 
            labelEtaj2.AutoSize = true;
            labelEtaj2.Location = new Point(227, 256);
            labelEtaj2.Name = "labelEtaj2";
            labelEtaj2.Size = new Size(55, 25);
            labelEtaj2.TabIndex = 2;
            labelEtaj2.Text = "etaj 2";
            // 
            // labelEtaj1
            // 
            labelEtaj1.AutoSize = true;
            labelEtaj1.Location = new Point(227, 338);
            labelEtaj1.Name = "labelEtaj1";
            labelEtaj1.Size = new Size(55, 25);
            labelEtaj1.TabIndex = 3;
            labelEtaj1.Text = "etaj 1";
            // 
            // labelParter
            // 
            labelParter.AutoSize = true;
            labelParter.Location = new Point(227, 420);
            labelParter.Name = "labelParter";
            labelParter.Size = new Size(59, 25);
            labelParter.TabIndex = 4;
            labelParter.Text = "parter";
            // 
            // checkBoxEtaj3
            // 
            checkBoxEtaj3.AutoSize = true;
            checkBoxEtaj3.Location = new Point(415, 175);
            checkBoxEtaj3.Name = "checkBoxEtaj3";
            checkBoxEtaj3.Size = new Size(81, 29);
            checkBoxEtaj3.TabIndex = 5;
            checkBoxEtaj3.Text = "etaj 3";
            checkBoxEtaj3.UseVisualStyleBackColor = true;
            checkBoxEtaj3.CheckedChanged += checkBoxEtaj3_CheckedChanged;
            // 
            // checkBoxEtaj2
            // 
            checkBoxEtaj2.AutoSize = true;
            checkBoxEtaj2.Location = new Point(415, 252);
            checkBoxEtaj2.Name = "checkBoxEtaj2";
            checkBoxEtaj2.Size = new Size(81, 29);
            checkBoxEtaj2.TabIndex = 6;
            checkBoxEtaj2.Text = "etaj 2";
            checkBoxEtaj2.UseVisualStyleBackColor = true;
            checkBoxEtaj2.CheckedChanged += checkBoxEtaj2_CheckedChanged;
            // 
            // checkBoxEtaj1
            // 
            checkBoxEtaj1.AutoSize = true;
            checkBoxEtaj1.Location = new Point(415, 334);
            checkBoxEtaj1.Name = "checkBoxEtaj1";
            checkBoxEtaj1.Size = new Size(81, 29);
            checkBoxEtaj1.TabIndex = 7;
            checkBoxEtaj1.Text = "etaj 1";
            checkBoxEtaj1.UseVisualStyleBackColor = true;
            checkBoxEtaj1.CheckedChanged += checkBoxEtaj1_CheckedChanged;
            // 
            // checkBoxParter
            // 
            checkBoxParter.AutoSize = true;
            checkBoxParter.Location = new Point(415, 420);
            checkBoxParter.Name = "checkBoxParter";
            checkBoxParter.Size = new Size(83, 29);
            checkBoxParter.TabIndex = 8;
            checkBoxParter.Text = "Parter";
            checkBoxParter.UseVisualStyleBackColor = true;
            checkBoxParter.CheckedChanged += checkBoxParter_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 655);
            Controls.Add(checkBoxParter);
            Controls.Add(checkBoxEtaj1);
            Controls.Add(checkBoxEtaj2);
            Controls.Add(checkBoxEtaj3);
            Controls.Add(labelParter);
            Controls.Add(labelEtaj1);
            Controls.Add(labelEtaj2);
            Controls.Add(labelEtaj3);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label labelEtaj3;
        private Label labelEtaj2;
        private Label labelEtaj1;
        private Label labelParter;
        private CheckBox checkBoxEtaj3;
        private CheckBox checkBoxEtaj2;
        private CheckBox checkBoxEtaj1;
        private CheckBox checkBoxParter;
    }
}