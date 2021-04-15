
namespace ZP_metaheurystyka
{
    partial class ParametryMetaheurystykiForm
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
            this.ZapiszParametryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LiczbaIteracjiTextBox = new System.Windows.Forms.TextBox();
            this.WielkoscPopulacjiTextBox = new System.Windows.Forms.TextBox();
            this.ProcentKrzyzowaniaTextBox = new System.Windows.Forms.TextBox();
            this.CzestotliwoscMutacjiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZapiszParametryButton
            // 
            this.ZapiszParametryButton.BackColor = System.Drawing.SystemColors.Window;
            this.ZapiszParametryButton.Enabled = false;
            this.ZapiszParametryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZapiszParametryButton.Location = new System.Drawing.Point(338, 385);
            this.ZapiszParametryButton.Name = "ZapiszParametryButton";
            this.ZapiszParametryButton.Size = new System.Drawing.Size(98, 42);
            this.ZapiszParametryButton.TabIndex = 0;
            this.ZapiszParametryButton.Text = "Zapisz";
            this.ZapiszParametryButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba iteracji metaheurystyki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wielkość populacji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(54, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Procent krzyżowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(54, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Częstotliwość mutacji";
            // 
            // LiczbaIteracjiTextBox
            // 
            this.LiczbaIteracjiTextBox.Location = new System.Drawing.Point(355, 55);
            this.LiczbaIteracjiTextBox.Name = "LiczbaIteracjiTextBox";
            this.LiczbaIteracjiTextBox.Size = new System.Drawing.Size(211, 26);
            this.LiczbaIteracjiTextBox.TabIndex = 5;
            // 
            // WielkoscPopulacjiTextBox
            // 
            this.WielkoscPopulacjiTextBox.Location = new System.Drawing.Point(355, 120);
            this.WielkoscPopulacjiTextBox.Name = "WielkoscPopulacjiTextBox";
            this.WielkoscPopulacjiTextBox.Size = new System.Drawing.Size(211, 26);
            this.WielkoscPopulacjiTextBox.TabIndex = 6;
            // 
            // ProcentKrzyzowaniaTextBox
            // 
            this.ProcentKrzyzowaniaTextBox.Location = new System.Drawing.Point(355, 172);
            this.ProcentKrzyzowaniaTextBox.Name = "ProcentKrzyzowaniaTextBox";
            this.ProcentKrzyzowaniaTextBox.Size = new System.Drawing.Size(211, 26);
            this.ProcentKrzyzowaniaTextBox.TabIndex = 7;
            // 
            // CzestotliwoscMutacjiTextBox
            // 
            this.CzestotliwoscMutacjiTextBox.Location = new System.Drawing.Point(355, 229);
            this.CzestotliwoscMutacjiTextBox.Name = "CzestotliwoscMutacjiTextBox";
            this.CzestotliwoscMutacjiTextBox.Size = new System.Drawing.Size(211, 26);
            this.CzestotliwoscMutacjiTextBox.TabIndex = 8;
            // 
            // ParametryMetaheurystykiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CzestotliwoscMutacjiTextBox);
            this.Controls.Add(this.ProcentKrzyzowaniaTextBox);
            this.Controls.Add(this.WielkoscPopulacjiTextBox);
            this.Controls.Add(this.LiczbaIteracjiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZapiszParametryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ParametryMetaheurystykiForm";
            this.Text = "Parametry Metaheurystyki";
            this.Load += new System.EventHandler(this.ParametryMetaheurystykiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZapiszParametryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LiczbaIteracjiTextBox;
        private System.Windows.Forms.TextBox WielkoscPopulacjiTextBox;
        private System.Windows.Forms.TextBox ProcentKrzyzowaniaTextBox;
        private System.Windows.Forms.TextBox CzestotliwoscMutacjiTextBox;
    }
}