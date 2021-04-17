
namespace ZP_metaheurystyka
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneratorInstancjiButton = new System.Windows.Forms.Button();
            this.WlasneDaneButton = new System.Windows.Forms.Button();
            this.UruchomMetaheurystykeButton = new System.Windows.Forms.Button();
            this.ParamatryHeurystykiBuuton = new System.Windows.Forms.Button();
            this.ParametryGroupBox = new System.Windows.Forms.GroupBox();
            this.MainMutacjeTextBox = new System.Windows.Forms.TextBox();
            this.MainKrzyzowanieTextBox = new System.Windows.Forms.TextBox();
            this.MainPopulacjaTextBox = new System.Windows.Forms.TextBox();
            this.MainIteracjeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SekwencjeGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MainMutacjeNaSekwencjeTextBox = new System.Windows.Forms.TextBox();
            this.MainPrzerwyTextBox = new System.Windows.Forms.TextBox();
            this.MainAlfabetTextBox = new System.Windows.Forms.TextBox();
            this.MainDlugoscSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.MainLiczbaSekwencjiTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MainJakoscDopasowaniaTextBox = new System.Windows.Forms.TextBox();
            this.ParametryGroupBox.SuspendLayout();
            this.SekwencjeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneratorInstancjiButton
            // 
            this.GeneratorInstancjiButton.BackColor = System.Drawing.SystemColors.Window;
            this.GeneratorInstancjiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratorInstancjiButton.Location = new System.Drawing.Point(76, 81);
            this.GeneratorInstancjiButton.Name = "GeneratorInstancjiButton";
            this.GeneratorInstancjiButton.Size = new System.Drawing.Size(250, 85);
            this.GeneratorInstancjiButton.TabIndex = 0;
            this.GeneratorInstancjiButton.Text = "Generator instancji";
            this.GeneratorInstancjiButton.UseVisualStyleBackColor = false;
            this.GeneratorInstancjiButton.Click += new System.EventHandler(this.GeneratorInstancjiButton_Click);
            // 
            // WlasneDaneButton
            // 
            this.WlasneDaneButton.BackColor = System.Drawing.SystemColors.Window;
            this.WlasneDaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WlasneDaneButton.Location = new System.Drawing.Point(76, 252);
            this.WlasneDaneButton.Name = "WlasneDaneButton";
            this.WlasneDaneButton.Size = new System.Drawing.Size(250, 85);
            this.WlasneDaneButton.TabIndex = 1;
            this.WlasneDaneButton.Text = "Chcę wprowadzić swoje sekwencje";
            this.WlasneDaneButton.UseVisualStyleBackColor = false;
            this.WlasneDaneButton.Click += new System.EventHandler(this.WlasneDaneButton_Click);
            // 
            // UruchomMetaheurystykeButton
            // 
            this.UruchomMetaheurystykeButton.BackColor = System.Drawing.SystemColors.Window;
            this.UruchomMetaheurystykeButton.Enabled = false;
            this.UruchomMetaheurystykeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UruchomMetaheurystykeButton.Location = new System.Drawing.Point(633, 613);
            this.UruchomMetaheurystykeButton.Name = "UruchomMetaheurystykeButton";
            this.UruchomMetaheurystykeButton.Size = new System.Drawing.Size(250, 85);
            this.UruchomMetaheurystykeButton.TabIndex = 2;
            this.UruchomMetaheurystykeButton.Text = "Uruchom metaheurystykę";
            this.UruchomMetaheurystykeButton.UseVisualStyleBackColor = false;
            // 
            // ParamatryHeurystykiBuuton
            // 
            this.ParamatryHeurystykiBuuton.BackColor = System.Drawing.SystemColors.Window;
            this.ParamatryHeurystykiBuuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParamatryHeurystykiBuuton.Location = new System.Drawing.Point(76, 431);
            this.ParamatryHeurystykiBuuton.Name = "ParamatryHeurystykiBuuton";
            this.ParamatryHeurystykiBuuton.Size = new System.Drawing.Size(250, 85);
            this.ParamatryHeurystykiBuuton.TabIndex = 3;
            this.ParamatryHeurystykiBuuton.Text = "Parametry metaheurystyki";
            this.ParamatryHeurystykiBuuton.UseVisualStyleBackColor = false;
            this.ParamatryHeurystykiBuuton.Click += new System.EventHandler(this.ParamatryHeurystykiButton_Click);
            // 
            // ParametryGroupBox
            // 
            this.ParametryGroupBox.Controls.Add(this.MainMutacjeTextBox);
            this.ParametryGroupBox.Controls.Add(this.MainKrzyzowanieTextBox);
            this.ParametryGroupBox.Controls.Add(this.MainPopulacjaTextBox);
            this.ParametryGroupBox.Controls.Add(this.MainIteracjeTextBox);
            this.ParametryGroupBox.Controls.Add(this.label4);
            this.ParametryGroupBox.Controls.Add(this.label3);
            this.ParametryGroupBox.Controls.Add(this.label2);
            this.ParametryGroupBox.Controls.Add(this.label1);
            this.ParametryGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ParametryGroupBox.Location = new System.Drawing.Point(558, 352);
            this.ParametryGroupBox.Name = "ParametryGroupBox";
            this.ParametryGroupBox.Size = new System.Drawing.Size(411, 203);
            this.ParametryGroupBox.TabIndex = 4;
            this.ParametryGroupBox.TabStop = false;
            this.ParametryGroupBox.Text = "Obecne parametry metaheurystyki";
            // 
            // MainMutacjeTextBox
            // 
            this.MainMutacjeTextBox.Enabled = false;
            this.MainMutacjeTextBox.Location = new System.Drawing.Point(281, 146);
            this.MainMutacjeTextBox.Name = "MainMutacjeTextBox";
            this.MainMutacjeTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainMutacjeTextBox.TabIndex = 13;
            // 
            // MainKrzyzowanieTextBox
            // 
            this.MainKrzyzowanieTextBox.Enabled = false;
            this.MainKrzyzowanieTextBox.Location = new System.Drawing.Point(281, 111);
            this.MainKrzyzowanieTextBox.Name = "MainKrzyzowanieTextBox";
            this.MainKrzyzowanieTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainKrzyzowanieTextBox.TabIndex = 12;
            // 
            // MainPopulacjaTextBox
            // 
            this.MainPopulacjaTextBox.Enabled = false;
            this.MainPopulacjaTextBox.Location = new System.Drawing.Point(281, 79);
            this.MainPopulacjaTextBox.Name = "MainPopulacjaTextBox";
            this.MainPopulacjaTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainPopulacjaTextBox.TabIndex = 11;
            // 
            // MainIteracjeTextBox
            // 
            this.MainIteracjeTextBox.Enabled = false;
            this.MainIteracjeTextBox.Location = new System.Drawing.Point(281, 40);
            this.MainIteracjeTextBox.Name = "MainIteracjeTextBox";
            this.MainIteracjeTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainIteracjeTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Częstotliwość mutacji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Procent krzyżowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wielkość populacji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liczba iteracji metaheurystyki";
            // 
            // SekwencjeGroupBox
            // 
            this.SekwencjeGroupBox.Controls.Add(this.MainJakoscDopasowaniaTextBox);
            this.SekwencjeGroupBox.Controls.Add(this.label10);
            this.SekwencjeGroupBox.Controls.Add(this.label6);
            this.SekwencjeGroupBox.Controls.Add(this.label9);
            this.SekwencjeGroupBox.Controls.Add(this.label8);
            this.SekwencjeGroupBox.Controls.Add(this.label7);
            this.SekwencjeGroupBox.Controls.Add(this.label5);
            this.SekwencjeGroupBox.Controls.Add(this.MainMutacjeNaSekwencjeTextBox);
            this.SekwencjeGroupBox.Controls.Add(this.MainPrzerwyTextBox);
            this.SekwencjeGroupBox.Controls.Add(this.MainAlfabetTextBox);
            this.SekwencjeGroupBox.Controls.Add(this.MainDlugoscSekwencjiTextBox);
            this.SekwencjeGroupBox.Controls.Add(this.MainLiczbaSekwencjiTextBox);
            this.SekwencjeGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SekwencjeGroupBox.Location = new System.Drawing.Point(558, 32);
            this.SekwencjeGroupBox.Name = "SekwencjeGroupBox";
            this.SekwencjeGroupBox.Size = new System.Drawing.Size(411, 300);
            this.SekwencjeGroupBox.TabIndex = 5;
            this.SekwencjeGroupBox.TabStop = false;
            this.SekwencjeGroupBox.Text = "Obecne parametry sekwencji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(15, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Długość sekwencji";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(15, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Liczba mutacji w jednej sekwencji";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(15, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Procent przerw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(15, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Alfabet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(15, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Liczba sekwencji";
            // 
            // MainMutacjeNaSekwencjeTextBox
            // 
            this.MainMutacjeNaSekwencjeTextBox.Enabled = false;
            this.MainMutacjeNaSekwencjeTextBox.Location = new System.Drawing.Point(281, 209);
            this.MainMutacjeNaSekwencjeTextBox.Name = "MainMutacjeNaSekwencjeTextBox";
            this.MainMutacjeNaSekwencjeTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainMutacjeNaSekwencjeTextBox.TabIndex = 18;
            // 
            // MainPrzerwyTextBox
            // 
            this.MainPrzerwyTextBox.Enabled = false;
            this.MainPrzerwyTextBox.Location = new System.Drawing.Point(281, 167);
            this.MainPrzerwyTextBox.Name = "MainPrzerwyTextBox";
            this.MainPrzerwyTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainPrzerwyTextBox.TabIndex = 17;
            // 
            // MainAlfabetTextBox
            // 
            this.MainAlfabetTextBox.Enabled = false;
            this.MainAlfabetTextBox.Location = new System.Drawing.Point(281, 123);
            this.MainAlfabetTextBox.Name = "MainAlfabetTextBox";
            this.MainAlfabetTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainAlfabetTextBox.TabIndex = 16;
            // 
            // MainDlugoscSekwencjiTextBox
            // 
            this.MainDlugoscSekwencjiTextBox.Enabled = false;
            this.MainDlugoscSekwencjiTextBox.Location = new System.Drawing.Point(281, 78);
            this.MainDlugoscSekwencjiTextBox.Name = "MainDlugoscSekwencjiTextBox";
            this.MainDlugoscSekwencjiTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainDlugoscSekwencjiTextBox.TabIndex = 15;
            // 
            // MainLiczbaSekwencjiTextBox
            // 
            this.MainLiczbaSekwencjiTextBox.Enabled = false;
            this.MainLiczbaSekwencjiTextBox.Location = new System.Drawing.Point(281, 36);
            this.MainLiczbaSekwencjiTextBox.Name = "MainLiczbaSekwencjiTextBox";
            this.MainLiczbaSekwencjiTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainLiczbaSekwencjiTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(15, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Jakość dopasowania";
            // 
            // MainJakoscDopasowaniaTextBox
            // 
            this.MainJakoscDopasowaniaTextBox.Enabled = false;
            this.MainJakoscDopasowaniaTextBox.Location = new System.Drawing.Point(281, 249);
            this.MainJakoscDopasowaniaTextBox.Name = "MainJakoscDopasowaniaTextBox";
            this.MainJakoscDopasowaniaTextBox.Size = new System.Drawing.Size(100, 26);
            this.MainJakoscDopasowaniaTextBox.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1058, 744);
            this.Controls.Add(this.SekwencjeGroupBox);
            this.Controls.Add(this.ParametryGroupBox);
            this.Controls.Add(this.ParamatryHeurystykiBuuton);
            this.Controls.Add(this.UruchomMetaheurystykeButton);
            this.Controls.Add(this.WlasneDaneButton);
            this.Controls.Add(this.GeneratorInstancjiButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metaheurystyka";
            this.Load += new System.EventHandler(this.MinForm_Load);
            this.ParametryGroupBox.ResumeLayout(false);
            this.ParametryGroupBox.PerformLayout();
            this.SekwencjeGroupBox.ResumeLayout(false);
            this.SekwencjeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GeneratorInstancjiButton;
        private System.Windows.Forms.Button WlasneDaneButton;
        private System.Windows.Forms.Button UruchomMetaheurystykeButton;
        private System.Windows.Forms.Button ParamatryHeurystykiBuuton;
        private System.Windows.Forms.GroupBox ParametryGroupBox;
        private System.Windows.Forms.GroupBox SekwencjeGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MainMutacjeTextBox;
        private System.Windows.Forms.TextBox MainKrzyzowanieTextBox;
        private System.Windows.Forms.TextBox MainPopulacjaTextBox;
        private System.Windows.Forms.TextBox MainIteracjeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MainMutacjeNaSekwencjeTextBox;
        private System.Windows.Forms.TextBox MainPrzerwyTextBox;
        private System.Windows.Forms.TextBox MainAlfabetTextBox;
        private System.Windows.Forms.TextBox MainDlugoscSekwencjiTextBox;
        private System.Windows.Forms.TextBox MainLiczbaSekwencjiTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MainJakoscDopasowaniaTextBox;
    }
}

