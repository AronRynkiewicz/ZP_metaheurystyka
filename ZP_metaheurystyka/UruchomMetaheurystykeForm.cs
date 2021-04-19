using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZP_metaheurystyka
{
    public partial class UruchomMetaheurystykeForm : Form
    {
        public GeneratorInstancjiClass generator = new GeneratorInstancjiClass(0, 0, "ACGT", 0, 0, 0);
        public ParametryMetaheurystykiClass parametry = new ParametryMetaheurystykiClass(0, 0, 0, 0);
        public MetaheurystykaClass heurystyka = new MetaheurystykaClass(new List<string>(), new List<char>(), 0, 0, 0, 0);

        public void Zauktalizuj(TextBox poleTekstowe, TextBox poleJakosci, List<string> dopasowanie, int jakosc)
        {
            poleTekstowe.Text = "";

            for (int i = 0; i < dopasowanie.Count; i++)
            {
                poleTekstowe.Text += dopasowanie[i] + System.Environment.NewLine;
            }

            poleJakosci.Text = jakosc.ToString();
        }
        public UruchomMetaheurystykeForm(GeneratorInstancjiClass Generator, ParametryMetaheurystykiClass Parametry)
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            generator = Generator;
            parametry = Parametry;
            Zauktalizuj(this.InstancjaTextBox, this.JakoscInstancjiTextBox, generator.Sekwencje, generator.JakoscDopasowania);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            heurystyka = new MetaheurystykaClass(generator.Sekwencje, generator.Alfabet, parametry.LiczbaIteracji, parametry.WielkoscPopulacji, parametry.ProcentKrzyzowania, parametry.CzestotliwoscMutacji);
            heurystyka.StartMeta(worker, e);
        }

        private void UruchomMetaheurystykeForm_Load(object sender, EventArgs e)
        {

        }

        private void UruchomMetaheurystykeButton_Click(object sender, EventArgs e)
        {
            this.StopButton.Enabled = true;
            this.PauzaButton.Enabled = true;
            this.UruchomMetaheurystykeButton.Enabled = false;

            MetaProgressBar.Maximum = parametry.LiczbaIteracji;
            MetaProgressBar.Step = 1;
            MetaProgressBar.Value = 0;

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
            this.UruchomMetaheurystykeButton.Enabled = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.wykresJakosci.Series.Clear();

            MetaProgressBar.Value = e.ProgressPercentage;


            List<int> tmp = new List<int>();
            var s = this.wykresJakosci.Series.Add((e.ProgressPercentage).ToString());
            s.ChartType = SeriesChartType.Area;

            tmp = e.UserState as List<int>;
            for(int i = 0; i < tmp.Count; i++)
            {
                s.Points.Add(tmp[i]);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Zauktalizuj(this.DopasowanieTextBox, this.JakoscDopasowaniaTextBox, heurystyka.NajlepszeDopasowanie, heurystyka.NajlepszaJakosc);
            }
            else if (e.Error != null)
            {
                System.Windows.Forms.MessageBox.Show("Metaheurystyka nie zakończyła się poprawnie ze względu na: \n-" + e.Error.Message, "Uwaga!");
            }
            else
            {
                Zauktalizuj(this.DopasowanieTextBox, this.JakoscDopasowaniaTextBox, heurystyka.NajlepszeDopasowanie, heurystyka.NajlepszaJakosc);
            }
        }
    }
}
