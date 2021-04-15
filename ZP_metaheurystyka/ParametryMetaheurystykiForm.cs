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
            parametry.LiczbaIteracji = 100;
            parametry.CzestotliwoscMutacji = 0.001;
            parametry.WielkoscPopulacji = 100;
            parametry.ProcentKrzyzowania = 100;
        }
    }
}
