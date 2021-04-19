
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JakoscInstancjiTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InstancjaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JakoscDopasowaniaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DopasowanieTextBox = new System.Windows.Forms.TextBox();
            this.MetaProgressBar = new System.Windows.Forms.ProgressBar();
            this.UruchomMetaheurystykeButton = new System.Windows.Forms.Button();
            this.PauzaButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wykresJakosci = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wykresJakosci)).BeginInit();
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
            // JakoscInstancjiTextBox
            // 
            this.JakoscInstancjiTextBox.Enabled = false;
            this.JakoscInstancjiTextBox.Location = new System.Drawing.Point(410, 530);
            this.JakoscInstancjiTextBox.Name = "JakoscInstancjiTextBox";
            this.JakoscInstancjiTextBox.Size = new System.Drawing.Size(139, 26);
            this.JakoscInstancjiTextBox.TabIndex = 16;
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
            // InstancjaTextBox
            // 
            this.InstancjaTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstancjaTextBox.Location = new System.Drawing.Point(25, 40);
            this.InstancjaTextBox.Multiline = true;
            this.InstancjaTextBox.Name = "InstancjaTextBox";
            this.InstancjaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InstancjaTextBox.Size = new System.Drawing.Size(852, 450);
            this.InstancjaTextBox.TabIndex = 0;
            this.InstancjaTextBox.WordWrap = false;
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
            this.DopasowanieTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DopasowanieTextBox.Location = new System.Drawing.Point(25, 40);
            this.DopasowanieTextBox.Multiline = true;
            this.DopasowanieTextBox.Name = "DopasowanieTextBox";
            this.DopasowanieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DopasowanieTextBox.Size = new System.Drawing.Size(852, 450);
            this.DopasowanieTextBox.TabIndex = 0;
            this.DopasowanieTextBox.WordWrap = false;
            // 
            // MetaProgressBar
            // 
            this.MetaProgressBar.Location = new System.Drawing.Point(12, 626);
            this.MetaProgressBar.Name = "MetaProgressBar";
            this.MetaProgressBar.Size = new System.Drawing.Size(1874, 37);
            this.MetaProgressBar.TabIndex = 18;
            // 
            // UruchomMetaheurystykeButton
            // 
            this.UruchomMetaheurystykeButton.BackColor = System.Drawing.SystemColors.Window;
            this.UruchomMetaheurystykeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UruchomMetaheurystykeButton.Location = new System.Drawing.Point(1287, 902);
            this.UruchomMetaheurystykeButton.Name = "UruchomMetaheurystykeButton";
            this.UruchomMetaheurystykeButton.Size = new System.Drawing.Size(250, 85);
            this.UruchomMetaheurystykeButton.TabIndex = 19;
            this.UruchomMetaheurystykeButton.Text = "Uruchom metaheurystykę";
            this.UruchomMetaheurystykeButton.UseVisualStyleBackColor = false;
            this.UruchomMetaheurystykeButton.Click += new System.EventHandler(this.UruchomMetaheurystykeButton_Click);
            // 
            // PauzaButton
            // 
            this.PauzaButton.BackColor = System.Drawing.SystemColors.Window;
            this.PauzaButton.Enabled = false;
            this.PauzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauzaButton.Location = new System.Drawing.Point(1598, 902);
            this.PauzaButton.Name = "PauzaButton";
            this.PauzaButton.Size = new System.Drawing.Size(85, 85);
            this.PauzaButton.TabIndex = 20;
            this.PauzaButton.Text = "Pauza";
            this.PauzaButton.UseVisualStyleBackColor = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.Window;
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(1727, 902);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(85, 85);
            this.StopButton.TabIndex = 21;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // wykresJakosci
            // 
            chartArea1.Name = "ChartArea1";
            this.wykresJakosci.ChartAreas.Add(chartArea1);
            legend1.Name = "Średnia Jakość";
            this.wykresJakosci.Legends.Add(legend1);
            this.wykresJakosci.Location = new System.Drawing.Point(37, 687);
            this.wykresJakosci.Name = "wykresJakosci";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Średnia Jakość";
            series1.Name = "Series1";
            this.wykresJakosci.Series.Add(series1);
            this.wykresJakosci.Size = new System.Drawing.Size(1058, 300);
            this.wykresJakosci.TabIndex = 22;
            this.wykresJakosci.Text = "chart1";
            // 
            // UruchomMetaheurystykeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.wykresJakosci);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauzaButton);
            this.Controls.Add(this.UruchomMetaheurystykeButton);
            this.Controls.Add(this.MetaProgressBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.wykresJakosci)).EndInit();
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
        private System.Windows.Forms.ProgressBar MetaProgressBar;
        private System.Windows.Forms.Button UruchomMetaheurystykeButton;
        private System.Windows.Forms.Button PauzaButton;
        private System.Windows.Forms.Button StopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykresJakosci;
    }
}