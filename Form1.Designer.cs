namespace rating
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rad1Neg = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad0 = new System.Windows.Forms.RadioButton();
            this.rad4Neg = new System.Windows.Forms.RadioButton();
            this.rad3Neg = new System.Windows.Forms.RadioButton();
            this.rad2Neg = new System.Windows.Forms.RadioButton();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoriser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word -";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(130, 23);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(359, 23);
            this.txtWord.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExample);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMeaning);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WORD";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(130, 135);
            this.txtExample.Multiline = true;
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(359, 72);
            this.txtExample.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Example -";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(130, 55);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(359, 68);
            this.txtMeaning.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meaning -";
            // 
            // rad1Neg
            // 
            this.rad1Neg.AutoSize = true;
            this.rad1Neg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(25)))));
            this.rad1Neg.Location = new System.Drawing.Point(307, 46);
            this.rad1Neg.Name = "rad1Neg";
            this.rad1Neg.Size = new System.Drawing.Size(208, 24);
            this.rad1Neg.TabIndex = 4;
            this.rad1Neg.TabStop = true;
            this.rad1Neg.Text = "-1 (Slightly Negative)";
            this.rad1Neg.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad4);
            this.groupBox2.Controls.Add(this.rad3);
            this.groupBox2.Controls.Add(this.rad2);
            this.groupBox2.Controls.Add(this.rad1);
            this.groupBox2.Controls.Add(this.rad0);
            this.groupBox2.Controls.Add(this.rad4Neg);
            this.groupBox2.Controls.Add(this.rad3Neg);
            this.groupBox2.Controls.Add(this.rad2Neg);
            this.groupBox2.Controls.Add(this.rad1Neg);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(0)))));
            this.rad4.Location = new System.Drawing.Point(307, 127);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(216, 24);
            this.rad4.TabIndex = 13;
            this.rad4.TabStop = true;
            this.rad4.Text = "4 (Extremely Positive)";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.ForeColor = System.Drawing.Color.DarkGreen;
            this.rad3.Location = new System.Drawing.Point(53, 127);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(171, 24);
            this.rad3.TabIndex = 12;
            this.rad3.TabStop = true;
            this.rad3.Text = "3 (Very Positive)";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(122)))), ((int)(((byte)(33)))));
            this.rad2.Location = new System.Drawing.Point(307, 100);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(225, 24);
            this.rad2.TabIndex = 11;
            this.rad2.TabStop = true;
            this.rad2.Text = "2 (Moderately Positive)";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(142)))), ((int)(((byte)(67)))));
            this.rad1.Location = new System.Drawing.Point(53, 100);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(195, 24);
            this.rad1.TabIndex = 10;
            this.rad1.TabStop = true;
            this.rad1.Text = "1 (Slightly Positive)";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad0
            // 
            this.rad0.AutoSize = true;
            this.rad0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.rad0.Location = new System.Drawing.Point(183, 73);
            this.rad0.Name = "rad0";
            this.rad0.Size = new System.Drawing.Size(200, 24);
            this.rad0.TabIndex = 8;
            this.rad0.TabStop = true;
            this.rad0.Text = "0 (Neutral / Neither)";
            this.rad0.UseVisualStyleBackColor = true;
            // 
            // rad4Neg
            // 
            this.rad4Neg.AutoSize = true;
            this.rad4Neg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rad4Neg.Location = new System.Drawing.Point(53, 19);
            this.rad4Neg.Name = "rad4Neg";
            this.rad4Neg.Size = new System.Drawing.Size(229, 24);
            this.rad4Neg.TabIndex = 7;
            this.rad4Neg.TabStop = true;
            this.rad4Neg.Text = "-4 (Extremely Negative)";
            this.rad4Neg.UseVisualStyleBackColor = true;
            // 
            // rad3Neg
            // 
            this.rad3Neg.AutoSize = true;
            this.rad3Neg.ForeColor = System.Drawing.Color.Red;
            this.rad3Neg.Location = new System.Drawing.Point(307, 19);
            this.rad3Neg.Name = "rad3Neg";
            this.rad3Neg.Size = new System.Drawing.Size(184, 24);
            this.rad3Neg.TabIndex = 6;
            this.rad3Neg.TabStop = true;
            this.rad3Neg.Text = "-3 (Very Negative)";
            this.rad3Neg.UseVisualStyleBackColor = true;
            // 
            // rad2Neg
            // 
            this.rad2Neg.AutoSize = true;
            this.rad2Neg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.rad2Neg.Location = new System.Drawing.Point(53, 46);
            this.rad2Neg.Name = "rad2Neg";
            this.rad2Neg.Size = new System.Drawing.Size(238, 24);
            this.rad2Neg.TabIndex = 5;
            this.rad2Neg.TabStop = true;
            this.rad2Neg.Text = "-2 (Moderately Negative)";
            this.rad2Neg.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(161, 448);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(124, 34);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(328, 448);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 34);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(612, 494);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rad1Neg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad0;
        private System.Windows.Forms.RadioButton rad4Neg;
        private System.Windows.Forms.RadioButton rad3Neg;
        private System.Windows.Forms.RadioButton rad2Neg;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

