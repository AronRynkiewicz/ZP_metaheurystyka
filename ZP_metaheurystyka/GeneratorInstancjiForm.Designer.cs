
namespace ZP_metaheurystyka
{
    partial class GeneratorInstancjiForm
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
            this.WygenerujInstancjeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LiczbaSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.DlugoscSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.AlfabetTextBox = new System.Windows.Forms.TextBox();
            this.PrzerwyTextBox = new System.Windows.Forms.TextBox();
            this.MutacjeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SekwencjeTextBox = new System.Windows.Forms.TextBox();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.OdswiezButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.JakoscTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WygenerujInstancjeButton
            // 
            this.WygenerujInstancjeButton.Location = new System.Drawing.Point(382, 258);
            this.WygenerujInstancjeButton.Name = "WygenerujInstancjeButton";
            this.WygenerujInstancjeButton.Size = new System.Drawing.Size(192, 51);
            this.WygenerujInstancjeButton.TabIndex = 0;
            this.WygenerujInstancjeButton.Text = "Wygeneruj instancję";
            this.WygenerujInstancjeButton.UseVisualStyleBackColor = true;
            this.WygenerujInstancjeButton.Click += new System.EventHandler(this.WygenerujInstancjeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba sekwencji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(83, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Długość sekwencji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(626, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alfabet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(571, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Procent przerw";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(444, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Liczba mutacji w jednej sekwencji";
            // 
            // LiczbaSekwencjiTextBox
            // 
            this.LiczbaSekwencjiTextBox.Location = new System.Drawing.Point(284, 59);
            this.LiczbaSekwencjiTextBox.Name = "LiczbaSekwencjiTextBox";
            this.LiczbaSekwencjiTextBox.Size = new System.Drawing.Size(143, 26);
            this.LiczbaSekwencjiTextBox.TabIndex = 6;
            // 
            // DlugoscSekwencjiTextBox
            // 
            this.DlugoscSekwencjiTextBox.Location = new System.Drawing.Point(284, 114);
            this.DlugoscSekwencjiTextBox.Name = "DlugoscSekwencjiTextBox";
            this.DlugoscSekwencjiTextBox.Size = new System.Drawing.Size(143, 26);
            this.DlugoscSekwencjiTextBox.TabIndex = 7;
            // 
            // AlfabetTextBox
            // 
            this.AlfabetTextBox.Location = new System.Drawing.Point(692, 61);
            this.AlfabetTextBox.Name = "AlfabetTextBox";
            this.AlfabetTextBox.Size = new System.Drawing.Size(143, 26);
            this.AlfabetTextBox.TabIndex = 8;
            this.AlfabetTextBox.Text = "ACGT";
            // 
            // PrzerwyTextBox
            // 
            this.PrzerwyTextBox.Location = new System.Drawing.Point(692, 114);
            this.PrzerwyTextBox.Name = "PrzerwyTextBox";
            this.PrzerwyTextBox.Size = new System.Drawing.Size(143, 26);
            this.PrzerwyTextBox.TabIndex = 9;
            // 
            // MutacjeTextBox
            // 
            this.MutacjeTextBox.Location = new System.Drawing.Point(692, 178);
            this.MutacjeTextBox.Name = "MutacjeTextBox";
            this.MutacjeTextBox.Size = new System.Drawing.Size(143, 26);
            this.MutacjeTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SekwencjeTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(64, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 410);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wygenerowana instancja";
            // 
            // SekwencjeTextBox
            // 
            this.SekwencjeTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SekwencjeTextBox.Location = new System.Drawing.Point(25, 40);
            this.SekwencjeTextBox.Multiline = true;
            this.SekwencjeTextBox.Name = "SekwencjeTextBox";
            this.SekwencjeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SekwencjeTextBox.Size = new System.Drawing.Size(787, 343);
            this.SekwencjeTextBox.TabIndex = 0;
            this.SekwencjeTextBox.WordWrap = false;
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.Location = new System.Drawing.Point(708, 770);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(192, 51);
            this.ZapiszButton.TabIndex = 12;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // OdswiezButton
            // 
            this.OdswiezButton.Location = new System.Drawing.Point(494, 770);
            this.OdswiezButton.Name = "OdswiezButton";
            this.OdswiezButton.Size = new System.Drawing.Size(192, 51);
            this.OdswiezButton.TabIndex = 13;
            this.OdswiezButton.Text = "Sprawdź";
            this.OdswiezButton.UseVisualStyleBackColor = true;
            this.OdswiezButton.Click += new System.EventHandler(this.OdswiezButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(64, 781);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Obecna jakość dopasowania:";
            // 
            // JakoscTextBox
            // 
            this.JakoscTextBox.Enabled = false;
            this.JakoscTextBox.Location = new System.Drawing.Point(288, 775);
            this.JakoscTextBox.Name = "JakoscTextBox";
            this.JakoscTextBox.Size = new System.Drawing.Size(139, 26);
            this.JakoscTextBox.TabIndex = 15;
            // 
            // GeneratorInstancjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(978, 844);
            this.Controls.Add(this.JakoscTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OdswiezButton);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MutacjeTextBox);
            this.Controls.Add(this.PrzerwyTextBox);
            this.Controls.Add(this.AlfabetTextBox);
            this.Controls.Add(this.DlugoscSekwencjiTextBox);
            this.Controls.Add(this.LiczbaSekwencjiTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WygenerujInstancjeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GeneratorInstancjiForm";
            this.Text = "Generator Instancji";
            this.Load += new System.EventHandler(this.GeneratorInstancjiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WygenerujInstancjeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LiczbaSekwencjiTextBox;
        private System.Windows.Forms.TextBox DlugoscSekwencjiTextBox;
        private System.Windows.Forms.TextBox AlfabetTextBox;
        private System.Windows.Forms.TextBox PrzerwyTextBox;
        private System.Windows.Forms.TextBox MutacjeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SekwencjeTextBox;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Button OdswiezButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JakoscTextBox;
    }
}