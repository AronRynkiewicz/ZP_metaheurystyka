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
    public partial class MainForm : Form
    {
        public ParametryMetaheurystykiClass Parametry = new ParametryMetaheurystykiClass(0, 0, 0, 0);
        public MainForm()
        {
            InitializeComponent();
            this.MainIteracjeTextBox.Text = Parametry.LiczbaIteracji.ToString();
            this.MainPopulacjaTextBox.Text = Parametry.WielkoscPopulacji.ToString();
            this.MainMutacjeTextBox.Text = Parametry.CzestotliwoscMutacji.ToString();
            this.MainKrzyzowanieTextBox.Text = Parametry.ProcentKrzyzowania.ToString();
        }

        private void MinForm_Load(object sender, EventArgs e)
        {

        }

        private void GeneratorInstancjiButton_Click(object sender, EventArgs e)
        {
            GeneratorInstancjiForm GeneratorForm = new GeneratorInstancjiForm();

            GeneratorForm.Show();
        }

        private void WlasneDaneButton_Click(object sender, EventArgs e)
        {
            new WlasneDaneForm().Show();
        }

        private void ParamatryHeurystykiButton_Click(object sender, EventArgs e)
        {
            ParametryMetaheurystykiForm ParametryForm = new ParametryMetaheurystykiForm(Parametry);
            ParametryForm.FormClosed += new FormClosedEventHandler(ParametryForm_FormClosed);
            ParametryForm.Show();
        }

        void ParametryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainIteracjeTextBox.Text = Parametry.LiczbaIteracji.ToString();
            this.MainPopulacjaTextBox.Text = Parametry.WielkoscPopulacji.ToString();
            this.MainMutacjeTextBox.Text = Parametry.CzestotliwoscMutacji.ToString();
            this.MainKrzyzowanieTextBox.Text = Parametry.ProcentKrzyzowania.ToString();
        }
    }
}
