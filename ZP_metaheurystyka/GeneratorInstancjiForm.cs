using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZP_metaheurystyka
{
    public partial class GeneratorInstancjiForm : Form
    {
        public GeneratorInstancjiForm()
        {
            InitializeComponent();
        }

        private void WygenerujInstancjeButton_Click(object sender, EventArgs e)
        {
            GeneratorInstancjiClass generator = new GeneratorInstancjiClass(4, 10, "ACGT", 10, 0);
            generator.WygenerujInstancje();
            for(int i = 0; i < generator.Sekwencje.Count(); i++)
            {
                this.SekwencjeTextBox.Text += generator.Sekwencje[i] + System.Environment.NewLine;
            }
        }
    }
}
