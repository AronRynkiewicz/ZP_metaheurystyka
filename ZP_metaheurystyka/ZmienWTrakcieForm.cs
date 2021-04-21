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
    public partial class ZmienWTrakcieForm : Form
    {
        public ParametryMetaheurystykiClass parametry = new ParametryMetaheurystykiClass(0, 0, 0, 0);
        int minimumIteracji = 0;
        public ZmienWTrakcieForm(ParametryMetaheurystykiClass Parametry, int minimumIteracji)
        {
            InitializeComponent();
            parametry = Parametry;
            this.LiczbaIteracjiTextBox.Text = parametry.LiczbaIteracji.ToString();
            this.CzestotliwoscMutacjiTextBox.Text = parametry.CzestotliwoscMutacji.ToString();
            this.ProcentKrzyzowaniaTextBox.Text = parametry.ProcentKrzyzowania.ToString();
            this.minimumIteracji = minimumIteracji;
        }

        private void ZmienWTrakcieForm_Load(object sender, EventArgs e)
        {

        }

        private void UaktualnijParametryButton_Click(object sender, EventArgs e)
        {
            List<string> BledyFormatu = new List<string>();
            List<string> Ostrzezenia = new List<string>();

            int TMPLiczbaIteracji = 0;
            double TMPProcentKrzyzowania = 0;
            double TMPCzestotliwoscMutacji = 0;

            try
            {
                TMPLiczbaIteracji = Int32.Parse(this.LiczbaIteracjiTextBox.Text);
                if (TMPLiczbaIteracji <= 0 || TMPLiczbaIteracji <= this.minimumIteracji + 10)
                {
                    Ostrzezenia.Add("Liczba iteracji, nowa liczba iteracji musi być większa, niż: " + (this.minimumIteracji + 10).ToString());
                }
            }
            catch
            {
                BledyFormatu.Add("Liczba iteracji");
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
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na błędne wartości w następujących polach: \n -" + String.Join("\n - ", Ostrzezenia.ToArray()), "Uwaga!");
            }
            else
            {
                parametry.LiczbaIteracji = TMPLiczbaIteracji;
                parametry.ProcentKrzyzowania = TMPProcentKrzyzowania;
                parametry.CzestotliwoscMutacji = TMPCzestotliwoscMutacji;

                parametry.PoprawneParametry = true;
                System.Windows.Forms.MessageBox.Show("Dane zostały uaktualnione!");
                this.Close();
            }
        }
    }
}
