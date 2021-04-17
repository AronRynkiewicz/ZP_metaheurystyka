
namespace ZP_metaheurystyka
{
    partial class WlasneDaneForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SekwencjeTextBox = new System.Windows.Forms.TextBox();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.WczytajInstancjeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DlugoscSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlfabetTextBox = new System.Windows.Forms.TextBox();
            this.LiczbaSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.OdswiezButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SekwencjeTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(65, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 410);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytana instancja";
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
            this.ZapiszButton.Location = new System.Drawing.Point(709, 752);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(192, 51);
            this.ZapiszButton.TabIndex = 13;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // WczytajInstancjeButton
            // 
            this.WczytajInstancjeButton.Location = new System.Drawing.Point(406, 250);
            this.WczytajInstancjeButton.Name = "WczytajInstancjeButton";
            this.WczytajInstancjeButton.Size = new System.Drawing.Size(192, 51);
            this.WczytajInstancjeButton.TabIndex = 14;
            this.WczytajInstancjeButton.Text = "Wczytaj instancję";
            this.WczytajInstancjeButton.UseVisualStyleBackColor = true;
            this.WczytajInstancjeButton.Click += new System.EventHandler(this.WczytajInstancjeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(86, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Liczba sekwencji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(86, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Długość sekwencji";
            // 
            // DlugoscSekwencjiTextBox
            // 
            this.DlugoscSekwencjiTextBox.Location = new System.Drawing.Point(278, 134);
            this.DlugoscSekwencjiTextBox.Name = "DlugoscSekwencjiTextBox";
            this.DlugoscSekwencjiTextBox.Size = new System.Drawing.Size(143, 26);
            this.DlugoscSekwencjiTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(585, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alfabet";
            // 
            // AlfabetTextBox
            // 
            this.AlfabetTextBox.Location = new System.Drawing.Point(674, 59);
            this.AlfabetTextBox.Name = "AlfabetTextBox";
            this.AlfabetTextBox.Size = new System.Drawing.Size(143, 26);
            this.AlfabetTextBox.TabIndex = 20;
            this.AlfabetTextBox.Text = "ACGT";
            // 
            // LiczbaSekwencjiTextBox
            // 
            this.LiczbaSekwencjiTextBox.Location = new System.Drawing.Point(278, 59);
            this.LiczbaSekwencjiTextBox.Name = "LiczbaSekwencjiTextBox";
            this.LiczbaSekwencjiTextBox.Size = new System.Drawing.Size(143, 26);
            this.LiczbaSekwencjiTextBox.TabIndex = 21;
            // 
            // OdswiezButton
            // 
            this.OdswiezButton.Location = new System.Drawing.Point(511, 752);
            this.OdswiezButton.Name = "OdswiezButton";
            this.OdswiezButton.Size = new System.Drawing.Size(192, 51);
            this.OdswiezButton.TabIndex = 22;
            this.OdswiezButton.Text = "Sprawdź";
            this.OdswiezButton.UseVisualStyleBackColor = true;
            this.OdswiezButton.Click += new System.EventHandler(this.OdswiezButton_Click);
            // 
            // WlasneDaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(978, 844);
            this.Controls.Add(this.OdswiezButton);
            this.Controls.Add(this.LiczbaSekwencjiTextBox);
            this.Controls.Add(this.AlfabetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DlugoscSekwencjiTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WczytajInstancjeButton);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WlasneDaneForm";
            this.Text = "Wlasne Dane";
            this.Load += new System.EventHandler(this.WlasneDaneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SekwencjeTextBox;
        private System.Windows.Forms.Button ZapiszButton;
        private System.Windows.Forms.Button WczytajInstancjeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DlugoscSekwencjiTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AlfabetTextBox;
        private System.Windows.Forms.TextBox LiczbaSekwencjiTextBox;
        private System.Windows.Forms.Button OdswiezButton;
    }
}