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

        public GeneratorInstancjiClass Generator = new GeneratorInstancjiClass(0, 0, "ACGT", 0, 0, 0);

        public void OdswiezParametryMeta()
        {
            this.MainIteracjeTextBox.Text = Parametry.LiczbaIteracji.ToString();
            this.MainPopulacjaTextBox.Text = Parametry.WielkoscPopulacji.ToString();
            this.MainMutacjeTextBox.Text = Parametry.CzestotliwoscMutacji.ToString();
            this.MainKrzyzowanieTextBox.Text = Parametry.ProcentKrzyzowania.ToString();
        }

        public void OdswiezParametryInstancji()
        {
            this.MainLiczbaSekwencjiTextBox.Text = Generator.LiczbaSekwencji.ToString();
            this.MainDlugoscSekwencjiTextBox.Text = Generator.DlugoscSekwencji.ToString();
            this.MainAlfabetTextBox.Text = new string(Generator.Alfabet.ToArray());
            this.MainPrzerwyTextBox.Text = Generator.ProcentPrzerw.ToString();
            this.MainMutacjeNaSekwencjeTextBox.Text = Generator.LiczbaMutacji.ToString();
            this.MainJakoscDopasowaniaTextBox.Text = Generator.JakoscDopasowania.ToString();
        }

        public MainForm()
        {
            InitializeComponent();

            OdswiezParametryMeta();

            OdswiezParametryInstancji();
        }

        private void MinForm_Load(object sender, EventArgs e)
        {
            
        }

        private void GeneratorInstancjiButton_Click(object sender, EventArgs e)
        {
            GeneratorInstancjiForm GeneratorForm = new GeneratorInstancjiForm(Generator);
            GeneratorForm.FormClosed += new FormClosedEventHandler(GeneratorForm_FormClosed);
            GeneratorForm.Show();
        }

        void GeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OdswiezParametryInstancji();

            if(Generator.PoprawnaInstancja && Parametry.PoprawneParametry)
            {
                this.UruchomMetaheurystykeButton.Enabled = true;
            }
        }

        private void WlasneDaneButton_Click(object sender, EventArgs e)
        {
            WlasneDaneForm WlasneForm = new WlasneDaneForm(Generator);
            WlasneForm.FormClosed += new FormClosedEventHandler(GeneratorForm_FormClosed);
            WlasneForm.Show();
        }

        private void ParamatryHeurystykiButton_Click(object sender, EventArgs e)
        {
            ParametryMetaheurystykiForm ParametryForm = new ParametryMetaheurystykiForm(Parametry);
            ParametryForm.FormClosed += new FormClosedEventHandler(ParametryForm_FormClosed);
            ParametryForm.Show();
        }

        void ParametryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OdswiezParametryMeta();
            if (Generator.PoprawnaInstancja && Parametry.PoprawneParametry)
            {
                this.UruchomMetaheurystykeButton.Enabled = true;
            }
        }

        private void UruchomMetaheurystykeButton_Click(object sender, EventArgs e)
        {
            UruchomMetaheurystykeForm MetaheurystykaForm = new UruchomMetaheurystykeForm();
            MetaheurystykaForm.Show();
        }
    }
}
