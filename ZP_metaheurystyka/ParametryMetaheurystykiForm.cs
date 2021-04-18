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
    public partial class ParametryMetaheurystykiForm : Form
    {
        public ParametryMetaheurystykiClass parametry = new ParametryMetaheurystykiClass(0, 0, 0, 0);
        public ParametryMetaheurystykiForm(ParametryMetaheurystykiClass Parametry)
        {
            InitializeComponent();
            parametry = Parametry;
            this.LiczbaIteracjiTextBox.Text = parametry.LiczbaIteracji.ToString();
            this.WielkoscPopulacjiTextBox.Text = parametry.WielkoscPopulacji.ToString();
            this.CzestotliwoscMutacjiTextBox.Text = parametry.CzestotliwoscMutacji.ToString();
            this.ProcentKrzyzowaniaTextBox.Text = parametry.ProcentKrzyzowania.ToString();
        }

        private void ParametryMetaheurystykiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ZapiszParametryButton_Click(object sender, EventArgs e)
        {
            List<string> BledyFormatu = new List<string>();
            List<string> Ostrzezenia = new List<string>();

            int TMPLiczbaIteracji = 0;
            int TMPWielkoscPopulacji = 0;
            double TMPProcentKrzyzowania = 0;
            double TMPCzestotliwoscMutacji = 0;

            try
            {
                TMPLiczbaIteracji = Int32.Parse(this.LiczbaIteracjiTextBox.Text);
                if (TMPLiczbaIteracji <= 0)
                {
                    Ostrzezenia.Add("Liczba iteracji");
                }
            }
            catch
            {
                BledyFormatu.Add("Liczba iteracji");
            }

            try
            {
                TMPWielkoscPopulacji = Int32.Parse(this.WielkoscPopulacjiTextBox.Text);
                if (TMPWielkoscPopulacji <= 0)
                {
                    Ostrzezenia.Add("Wielkość populacji");
                }
            }
            catch
            {
                BledyFormatu.Add("Wielkość populacji");
            }

            try
            {
                TMPProcentKrzyzowania = Convert.ToDouble(this.ProcentKrzyzowaniaTextBox.Text);
                if (TMPProcentKrzyzowania <= 0)
                {
                    Ostrzezenia.Add("Procent krzyżowania");
                }
            }
            catch
            {
                BledyFormatu.Add("Procent krzyżowania");
            }

            try
            {
                TMPCzestotliwoscMutacji = Convert.ToDouble(this.CzestotliwoscMutacjiTextBox.Text);
                if (TMPCzestotliwoscMutacji <= 0)
                {
                    Ostrzezenia.Add("Częstotliwość mutacji");
                }
            }
            catch
            {
                BledyFormatu.Add("Częstotliwość mutacji [poprawny separator w tym polu: ,]");
            }


            if (BledyFormatu.Count() != 0)
            {
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na błędy w następujących polach: \n -" + String.Join("\n - ", BledyFormatu.ToArray()), "Uwaga - błędy!");
            }
            else if (Ostrzezenia.Count != 0)
            {
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na ujemne lub równe 0 wartości w następujących polach: \n -" + String.Join("\n - ", Ostrzezenia.ToArray()), "Uwaga!");
            }
            else
            {
                parametry.LiczbaIteracji = TMPLiczbaIteracji;
                parametry.WielkoscPopulacji = TMPWielkoscPopulacji;
                parametry.ProcentKrzyzowania = TMPProcentKrzyzowania;
                parametry.CzestotliwoscMutacji = TMPCzestotliwoscMutacji;

                parametry.PoprawneParametry = true;
                System.Windows.Forms.MessageBox.Show("Dane zostały zapisane!");
                this.Close();
            } 
        }
    }
}
