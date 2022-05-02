namespace saskaita
{
    partial class Form3
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
            this.impv = new System.Windows.Forms.TextBox();
            this.imkod = new System.Windows.Forms.TextBox();
            this.adrs = new System.Windows.Forms.TextBox();
            this.bankas = new System.Windows.Forms.TextBox();
            this.snr = new System.Windows.Forms.TextBox();
            this.pvmkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Gridas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gridas)).BeginInit();
            this.SuspendLayout();
            // 
            // impv
            // 
            this.impv.Location = new System.Drawing.Point(37, 32);
            this.impv.Name = "impv";
            this.impv.Size = new System.Drawing.Size(161, 23);
            this.impv.TabIndex = 0;
            // 
            // imkod
            // 
            this.imkod.Location = new System.Drawing.Point(37, 90);
            this.imkod.Name = "imkod";
            this.imkod.Size = new System.Drawing.Size(161, 23);
            this.imkod.TabIndex = 1;
            // 
            // adrs
            // 
            this.adrs.Location = new System.Drawing.Point(37, 148);
            this.adrs.Name = "adrs";
            this.adrs.Size = new System.Drawing.Size(161, 23);
            this.adrs.TabIndex = 2;
            // 
            // bankas
            // 
            this.bankas.Location = new System.Drawing.Point(37, 206);
            this.bankas.Name = "bankas";
            this.bankas.Size = new System.Drawing.Size(161, 23);
            this.bankas.TabIndex = 3;
            // 
            // snr
            // 
            this.snr.Location = new System.Drawing.Point(37, 264);
            this.snr.Name = "snr";
            this.snr.Size = new System.Drawing.Size(161, 23);
            this.snr.TabIndex = 4;
            // 
            // pvmkod
            // 
            this.pvmkod.Location = new System.Drawing.Point(37, 322);
            this.pvmkod.Name = "pvmkod";
            this.pvmkod.Size = new System.Drawing.Size(161, 23);
            this.pvmkod.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Įmonės pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Įmonės kodas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bankas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sąskaitos numeris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "PVM kodas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pridėti įmonę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gridas
            // 
            this.Gridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridas.Location = new System.Drawing.Point(239, 111);
            this.Gridas.Name = "Gridas";
            this.Gridas.RowTemplate.Height = 25;
            this.Gridas.Size = new System.Drawing.Size(522, 282);
            this.Gridas.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rodyti įmonių sąrašą";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Grįžti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(689, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Uždaryti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 426);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gridas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pvmkod);
            this.Controls.Add(this.snr);
            this.Controls.Add(this.bankas);
            this.Controls.Add(this.adrs);
            this.Controls.Add(this.imkod);
            this.Controls.Add(this.impv);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Gridas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox impv;
        private TextBox imkod;
        private TextBox adrs;
        private TextBox bankas;
        private TextBox snr;
        private TextBox pvmkod;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private DataGridView Gridas;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}