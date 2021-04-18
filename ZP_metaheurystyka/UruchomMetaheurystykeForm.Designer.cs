
namespace ZP_metaheurystyka
{
    partial class UruchomMetaheurystykeForm
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
            this.InstancjaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JakoscInstancjiTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JakoscDopasowaniaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DopasowanieTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JakoscInstancjiTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.InstancjaTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 589);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instancja";
            // 
            // InstancjaTextBox
            // 
            this.InstancjaTextBox.Enabled = false;
            this.InstancjaTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstancjaTextBox.Location = new System.Drawing.Point(25, 40);
            this.InstancjaTextBox.Multiline = true;
            this.InstancjaTextBox.Name = "InstancjaTextBox";
            this.InstancjaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InstancjaTextBox.Size = new System.Drawing.Size(852, 450);
            this.InstancjaTextBox.TabIndex = 0;
            this.InstancjaTextBox.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(266, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jakość instancji:";
            // 
            // JakoscInstancjiTextBox
            // 
            this.JakoscInstancjiTextBox.Enabled = false;
            this.JakoscInstancjiTextBox.Location = new System.Drawing.Point(410, 530);
            this.JakoscInstancjiTextBox.Name = "JakoscInstancjiTextBox";
            this.JakoscInstancjiTextBox.Size = new System.Drawing.Size(139, 26);
            this.JakoscInstancjiTextBox.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JakoscDopasowaniaTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DopasowanieTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(971, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 589);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uzyskane dopasowanie";
            // 
            // JakoscDopasowaniaTextBox
            // 
            this.JakoscDopasowaniaTextBox.Enabled = false;
            this.JakoscDopasowaniaTextBox.Location = new System.Drawing.Point(490, 533);
            this.JakoscDopasowaniaTextBox.Name = "JakoscDopasowaniaTextBox";
            this.JakoscDopasowaniaTextBox.Size = new System.Drawing.Size(139, 26);
            this.JakoscDopasowaniaTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(312, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Jakość dopasowania:";
            // 
            // DopasowanieTextBox
            // 
            this.DopasowanieTextBox.Enabled = false;
            this.DopasowanieTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DopasowanieTextBox.Location = new System.Drawing.Point(25, 40);
            this.DopasowanieTextBox.Multiline = true;
            this.DopasowanieTextBox.Name = "DopasowanieTextBox";
            this.DopasowanieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DopasowanieTextBox.Size = new System.Drawing.Size(852, 450);
            this.DopasowanieTextBox.TabIndex = 0;
            this.DopasowanieTextBox.WordWrap = false;
            // 
            // UruchomMetaheurystykeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UruchomMetaheurystykeForm";
            this.Text = "Uruchom Metaheurystyke";
            this.Load += new System.EventHandler(this.UruchomMetaheurystykeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InstancjaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JakoscInstancjiTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox JakoscDopasowaniaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DopasowanieTextBox;
    }
}