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
        public GeneratorInstancjiClass generator = new GeneratorInstancjiClass(0, 0, "ACGT", 0, 0);
        public GeneratorInstancjiForm(GeneratorInstancjiClass Generator)
        {
            InitializeComponent();
            generator = Generator;

            this.LiczbaSekwencjiTextBox.Text = Generator.LiczbaSekwencji.ToString();
            this.DlugoscSekwencjiTextBox.Text = Generator.DlugoscSekwencji.ToString();
            this.AlfabetTextBox.Text = new string(Generator.Alfabet.ToArray());
            this.PrzerwyTextBox.Text = Generator.ProcentPrzerw.ToString();
            this.MutacjeTextBox.Text = Generator.LiczbaMutacji.ToString();
        }

        public bool SprawdzParametry()
        {
            List<string> BledyFormatu = new List<string>();
            List<string> Ostrzezenia = new List<string>();

            bool PoprawneDane = true;
            char[] array = new[] { 'A', 'C', 'G', 'T'};
            HashSet<char> ZbiorZasad = new HashSet<char>(array);

            int TMPLiczbaSekwencji = 0;
            int TMPDlugoscSekwencji = 0;
            HashSet<char> TMPAlfabet;
            int TMPProcentPrzerw;
            int TMPLiczbaMutacji;

            try
            {
                TMPLiczbaSekwencji = Int32.Parse(this.LiczbaSekwencjiTextBox.Text);
                
                if(TMPLiczbaSekwencji <= 3)
                {
                    Ostrzezenia.Add("Liczba sekwencji nie moze byc mniejsza od 3!");
                    PoprawneDane = false;
                }
            }
            catch
            {
                BledyFormatu.Add("Liczba sekwencji");
                PoprawneDane = false;
            }

            try
            {
                TMPDlugoscSekwencji = Int32.Parse(this.DlugoscSekwencjiTextBox.Text);

                if (TMPDlugoscSekwencji <= 0)
                {
                    Ostrzezenia.Add("Długość sekwencji nie moze byc mniejsza od 1!");
                    PoprawneDane = false;
                }
            }
            catch
            {
                BledyFormatu.Add("Długość sekwencji");
                PoprawneDane = false;
            }

            List<char> tmp_alfabet = new List<char>();
            tmp_alfabet.AddRange(this.AlfabetTextBox.Text);
            TMPAlfabet = new HashSet<char>(tmp_alfabet);
            TMPAlfabet.UnionWith(ZbiorZasad);

            if (TMPAlfabet.Count != 4)
            {
                BledyFormatu.Add("Alfabet");
                PoprawneDane = false;
            }

            try
            {
                TMPProcentPrzerw = Int32.Parse(this.PrzerwyTextBox.Text);

                if (TMPProcentPrzerw < 0)
                {
                    Ostrzezenia.Add("Procent przerw nie moze byc mniejszy od 0!");
                    PoprawneDane = false;
                }
            }
            catch
            {
                BledyFormatu.Add("Procent przerw");
                PoprawneDane = false;
            }

            try
            {
                TMPLiczbaMutacji = Int32.Parse(this.MutacjeTextBox.Text);

                if (TMPLiczbaMutacji < 0)
                {
                    Ostrzezenia.Add("Liczba mutacji nie moze byc mniejsza od 0!");
                    PoprawneDane = false;
                }

                if (TMPLiczbaSekwencji != 0)
                {
                    if (TMPLiczbaMutacji > (int)(TMPDlugoscSekwencji / TMPLiczbaSekwencji))
                    {
                        Ostrzezenia.Add("W danej kolumnie może być zmutowany tylko jeden nukleotyd, maksymalna wartość liczby mutacji na sekwencję dla podanych parametrów: " + ((int)(TMPDlugoscSekwencji / TMPLiczbaSekwencji)).ToString());
                        PoprawneDane = false;
                    }
                }
            }
            catch
            {
                BledyFormatu.Add("Liczba mutacji");
                PoprawneDane = false;
            }

            if (BledyFormatu.Count != 0)
            {
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na błędy w następujących polach: \n -" + String.Join("\n - ", BledyFormatu.ToArray()), "Uwaga - błędy!");
            }

            if(Ostrzezenia.Count != 0)
            {
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na ostrzeżenia w następujących polach: \n -" + String.Join("\n - ", Ostrzezenia.ToArray()), "Uwaga!");
            }


            return PoprawneDane;
        }

        private void WygenerujInstancjeButton_Click(object sender, EventArgs e)
        {
            var PoprawneDane = SprawdzParametry();

            if (PoprawneDane)
            {
                generator.LiczbaSekwencji = Int32.Parse(this.LiczbaSekwencjiTextBox.Text);
                generator.DlugoscSekwencji = Int32.Parse(this.DlugoscSekwencjiTextBox.Text);
                generator.Alfabet = new List<char>();
                generator.Alfabet.AddRange(this.AlfabetTextBox.Text);
                generator.ProcentPrzerw = Int32.Parse(this.PrzerwyTextBox.Text);
                generator.LiczbaMutacji = Int32.Parse(this.MutacjeTextBox.Text);

                generator.WygenerujInstancje();
                this.SekwencjeTextBox.Text = "";
                for (int i = 0; i < generator.Sekwencje.Count(); i++)
                {
                    this.SekwencjeTextBox.Text += generator.Sekwencje[i] + System.Environment.NewLine;
                }
            }
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Dane zostały zapisane!");
            this.Close();
        }
    }
}
