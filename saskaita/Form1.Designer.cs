namespace saskaita
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.prvard = new System.Windows.Forms.TextBox();
            this.logpass = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.regpass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registruotis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Išeiti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(494, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "NEŽYMĖTI";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // prvard
            // 
            this.prvard.Location = new System.Drawing.Point(159, 141);
            this.prvard.Name = "prvard";
            this.prvard.Size = new System.Drawing.Size(155, 23);
            this.prvard.TabIndex = 4;
            // 
            // logpass
            // 
            this.logpass.Location = new System.Drawing.Point(159, 239);
            this.logpass.Name = "logpass";
            this.logpass.Size = new System.Drawing.Size(155, 23);
            this.logpass.TabIndex = 5;
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(464, 92);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(155, 23);
            this.nam.TabIndex = 6;
            // 
            // regpass
            // 
            this.regpass.Location = new System.Drawing.Point(464, 163);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(155, 23);
            this.regpass.TabIndex = 7;
            // 
            // regpass2
            // 
            this.regpass2.Location = new System.Drawing.Point(464, 239);
            this.regpass2.Name = "regpass2";
            this.regpass2.Size = new System.Drawing.Size(155, 23);
            this.regpass2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prisijungimo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Slaptažodis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prisijungimo vardas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Slaptažodis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pakartoti slaptažodį";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(159, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prisijungimas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(468, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registracija";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regpass2);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.prvard);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private TextBox prvard;
        private TextBox logpass;
        private TextBox nam;
        private TextBox regpass;
        private TextBox regpass2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}