using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace ZP_metaheurystyka
{
    public partial class ZapiszInstancjeDoPlikuForm : Form
    {
        public GeneratorInstancjiClass generator = new GeneratorInstancjiClass(0, 0, "ACGT", 0, 0, 0);
        public ZapiszInstancjeDoPlikuForm(GeneratorInstancjiClass Generator)
        {
            InitializeComponent();
            generator = Generator;
        }

        private void ZapiszInstancjeDoPlikuForm_Load(object sender, EventArgs e)
        {

        }

        private void ZapiszDoPlikuButton_Click(object sender, EventArgs e)
        {
            if(this.NazwaPlikuTextBox.Text.Length != 0)
            {
                string sekwencje = string.Empty;
                for (int i = 0; i < generator.Sekwencje.Count(); i++)
                {
                    sekwencje += String.Join("", generator.Sekwencje[i].Split('_')) + Environment.NewLine;
                }
                
                File.WriteAllText(this.NazwaPlikuTextBox.Text, sekwencje);
                System.Windows.Forms.MessageBox.Show("Zapisano!", "Informacja!");
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nazwa pliku nie może być pusta!", "Uwaga!");
            }
        }
    }
}
