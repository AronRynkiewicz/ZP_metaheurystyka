
namespace ZP_metaheurystyka
{
    partial class ZapiszWynikDoPliku
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
            this.NazwaPlikuTextBox = new System.Windows.Forms.TextBox();
            this.ZapiszDoPlikuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(90, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa pliku (wraz ze ścieżką)";
            // 
            // NazwaPlikuTextBox
            // 
            this.NazwaPlikuTextBox.Location = new System.Drawing.Point(314, 187);
            this.NazwaPlikuTextBox.Name = "NazwaPlikuTextBox";
            this.NazwaPlikuTextBox.Size = new System.Drawing.Size(222, 26);
            this.NazwaPlikuTextBox.TabIndex = 8;
            // 
            // ZapiszDoPlikuButton
            // 
            this.ZapiszDoPlikuButton.Location = new System.Drawing.Point(326, 257);
            this.ZapiszDoPlikuButton.Name = "ZapiszDoPlikuButton";
            this.ZapiszDoPlikuButton.Size = new System.Drawing.Size(192, 51);
            this.ZapiszDoPlikuButton.TabIndex = 9;
            this.ZapiszDoPlikuButton.Text = "Zapisz do pliku";
            this.ZapiszDoPlikuButton.UseVisualStyleBackColor = true;
            this.ZapiszDoPlikuButton.Click += new System.EventHandler(this.ZapiszDoPlikuButton_Click);
            // 
            // ZapiszWynikDoPliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZapiszDoPlikuButton);
            this.Controls.Add(this.NazwaPlikuTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ZapiszWynikDoPliku";
            this.Text = "ZapiszWynikDoPliku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NazwaPlikuTextBox;
        private System.Windows.Forms.Button ZapiszDoPlikuButton;
    }
}