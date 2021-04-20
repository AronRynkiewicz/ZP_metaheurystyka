
namespace ZP_metaheurystyka
{
    partial class ZmienWTrakcieForm
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
            this.UaktualnijParametryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LiczbaIteracjiTextBox = new System.Windows.Forms.TextBox();
            this.ProcentKrzyzowaniaTextBox = new System.Windows.Forms.TextBox();
            this.CzestotliwoscMutacjiTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UaktualnijParametryButton
            // 
            this.UaktualnijParametryButton.BackColor = System.Drawing.SystemColors.Window;
            this.UaktualnijParametryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UaktualnijParametryButton.Location = new System.Drawing.Point(391, 310);
            this.UaktualnijParametryButton.Name = "UaktualnijParametryButton";
            this.UaktualnijParametryButton.Size = new System.Drawing.Size(144, 42);
            this.UaktualnijParametryButton.TabIndex = 1;
            this.UaktualnijParametryButton.Text = "Uaktualnij";
            this.UaktualnijParametryButton.UseVisualStyleBackColor = false;
            this.UaktualnijParametryButton.Click += new System.EventHandler(this.UaktualnijParametryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(81, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liczba iteracji metaheurystyki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(81, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Procent krzyżowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(81, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Częstotliwość mutacji";
            // 
            // LiczbaIteracjiTextBox
            // 
            this.LiczbaIteracjiTextBox.Location = new System.Drawing.Point(324, 67);
            this.LiczbaIteracjiTextBox.Name = "LiczbaIteracjiTextBox";
            this.LiczbaIteracjiTextBox.Size = new System.Drawing.Size(211, 26);
            this.LiczbaIteracjiTextBox.TabIndex = 6;
            // 
            // ProcentKrzyzowaniaTextBox
            // 
            this.ProcentKrzyzowaniaTextBox.Location = new System.Drawing.Point(324, 138);
            this.ProcentKrzyzowaniaTextBox.Name = "ProcentKrzyzowaniaTextBox";
            this.ProcentKrzyzowaniaTextBox.Size = new System.Drawing.Size(211, 26);
            this.ProcentKrzyzowaniaTextBox.TabIndex = 8;
            // 
            // CzestotliwoscMutacjiTextBox
            // 
            this.CzestotliwoscMutacjiTextBox.Location = new System.Drawing.Point(324, 195);
            this.CzestotliwoscMutacjiTextBox.Name = "CzestotliwoscMutacjiTextBox";
            this.CzestotliwoscMutacjiTextBox.Size = new System.Drawing.Size(211, 26);
            this.CzestotliwoscMutacjiTextBox.TabIndex = 9;
            // 
            // ZmienWTrakcieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(606, 408);
            this.Controls.Add(this.CzestotliwoscMutacjiTextBox);
            this.Controls.Add(this.ProcentKrzyzowaniaTextBox);
            this.Controls.Add(this.LiczbaIteracjiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UaktualnijParametryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ZmienWTrakcieForm";
            this.Text = "Zmień Parametry";
            this.Load += new System.EventHandler(this.ZmienWTrakcieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UaktualnijParametryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LiczbaIteracjiTextBox;
        private System.Windows.Forms.TextBox ProcentKrzyzowaniaTextBox;
        private System.Windows.Forms.TextBox CzestotliwoscMutacjiTextBox;
    }
}