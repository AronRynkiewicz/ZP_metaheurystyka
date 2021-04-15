
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
            this.SuspendLayout();
            // 
            // GeneratorInstancjiButton
            // 
            this.GeneratorInstancjiButton.BackColor = System.Drawing.SystemColors.Window;
            this.GeneratorInstancjiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratorInstancjiButton.Location = new System.Drawing.Point(134, 182);
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
            this.WlasneDaneButton.Location = new System.Drawing.Point(646, 182);
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
            this.UruchomMetaheurystykeButton.Location = new System.Drawing.Point(646, 403);
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
            this.ParamatryHeurystykiBuuton.Location = new System.Drawing.Point(134, 403);
            this.ParamatryHeurystykiBuuton.Name = "ParamatryHeurystykiBuuton";
            this.ParamatryHeurystykiBuuton.Size = new System.Drawing.Size(250, 85);
            this.ParamatryHeurystykiBuuton.TabIndex = 3;
            this.ParamatryHeurystykiBuuton.Text = "Parametry metaheurystyki";
            this.ParamatryHeurystykiBuuton.UseVisualStyleBackColor = false;
            this.ParamatryHeurystykiBuuton.Click += new System.EventHandler(this.ParamatryHeurystykiButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1058, 664);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GeneratorInstancjiButton;
        private System.Windows.Forms.Button WlasneDaneButton;
        private System.Windows.Forms.Button UruchomMetaheurystykeButton;
        private System.Windows.Forms.Button ParamatryHeurystykiBuuton;
    }
}

