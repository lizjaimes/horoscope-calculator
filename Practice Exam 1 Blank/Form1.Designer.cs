namespace Practice_Exam_1_Blank
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
            this.txtBirthMonth = new System.Windows.Forms.TextBox();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBirthDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOutputSentence = new System.Windows.Forms.Label();
            this.lblZodiacChinese = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.lblZodiacSign = new System.Windows.Forms.Label();
            this.lblLeapYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstZodiacChinese = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBirthMonth
            // 
            this.txtBirthMonth.Location = new System.Drawing.Point(6, 25);
            this.txtBirthMonth.Name = "txtBirthMonth";
            this.txtBirthMonth.Size = new System.Drawing.Size(100, 26);
            this.txtBirthMonth.TabIndex = 0;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(220, 24);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(100, 26);
            this.txtBirthYear.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(113, 24);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 26);
            this.txtBirthDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBirthDate);
            this.groupBox1.Controls.Add(this.txtBirthMonth);
            this.groupBox1.Controls.Add(this.txtBirthYear);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Your Birthdate (M/D/Y)";
            // 
            // btnBirthDate
            // 
            this.btnBirthDate.AutoSize = true;
            this.btnBirthDate.Location = new System.Drawing.Point(7, 58);
            this.btnBirthDate.Name = "btnBirthDate";
            this.btnBirthDate.Size = new System.Drawing.Size(313, 30);
            this.btnBirthDate.TabIndex = 3;
            this.btnBirthDate.Text = "GO!";
            this.btnBirthDate.UseVisualStyleBackColor = true;
            this.btnBirthDate.Click += new System.EventHandler(this.btnBirthDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutputSentence);
            this.groupBox2.Controls.Add(this.lblZodiacChinese);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblZodiac);
            this.groupBox2.Controls.Add(this.lblZodiacSign);
            this.groupBox2.Controls.Add(this.lblLeapYear);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 291);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stuff You Should Know";
            // 
            // lblOutputSentence
            // 
            this.lblOutputSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputSentence.Location = new System.Drawing.Point(6, 130);
            this.lblOutputSentence.Name = "lblOutputSentence";
            this.lblOutputSentence.Size = new System.Drawing.Size(314, 158);
            this.lblOutputSentence.TabIndex = 6;
            // 
            // lblZodiacChinese
            // 
            this.lblZodiacChinese.AutoSize = true;
            this.lblZodiacChinese.Location = new System.Drawing.Point(237, 87);
            this.lblZodiacChinese.Name = "lblZodiacChinese";
            this.lblZodiacChinese.Size = new System.Drawing.Size(0, 20);
            this.lblZodiacChinese.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chinese zodiac?";
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.CausesValidation = false;
            this.lblZodiac.Location = new System.Drawing.Point(237, 55);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(0, 20);
            this.lblZodiac.TabIndex = 3;
            // 
            // lblZodiacSign
            // 
            this.lblZodiacSign.AutoSize = true;
            this.lblZodiacSign.Location = new System.Drawing.Point(7, 55);
            this.lblZodiacSign.Name = "lblZodiacSign";
            this.lblZodiacSign.Size = new System.Drawing.Size(188, 20);
            this.lblZodiacSign.TabIndex = 2;
            this.lblZodiacSign.Text = "What is your zodiac sign?";
            // 
            // lblLeapYear
            // 
            this.lblLeapYear.Location = new System.Drawing.Point(237, 26);
            this.lblLeapYear.Name = "lblLeapYear";
            this.lblLeapYear.Size = new System.Drawing.Size(51, 20);
            this.lblLeapYear.TabIndex = 1;
            this.lblLeapYear.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is Your Birthday A Leap Year?";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(169, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(5, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstZodiacChinese
            // 
            this.lstZodiacChinese.ForeColor = System.Drawing.Color.Black;
            this.lstZodiacChinese.FormattingEnabled = true;
            this.lstZodiacChinese.ItemHeight = 20;
            this.lstZodiacChinese.Items.AddRange(new object[] {
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat",
            "Monkey",
            "Rooster",
            "Dog",
            "Pig"});
            this.lstZodiacChinese.Location = new System.Drawing.Point(348, 22);
            this.lstZodiacChinese.Name = "lstZodiacChinese";
            this.lstZodiacChinese.Size = new System.Drawing.Size(147, 244);
            this.lstZodiacChinese.TabIndex = 10;
            this.lstZodiacChinese.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstZodiacChinese);
            this.Name = "Form1";
            this.Text = "Horoscope Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirthMonth;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBirthDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOutputSentence;
        private System.Windows.Forms.Label lblZodiacChinese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.Label lblZodiacSign;
        private System.Windows.Forms.Label lblLeapYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstZodiacChinese;
    }
}

