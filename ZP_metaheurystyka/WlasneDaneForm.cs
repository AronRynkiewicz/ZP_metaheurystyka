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

namespace ZP_metaheurystyka
{
    public partial class WlasneDaneForm : Form
    {
        public GeneratorInstancjiClass generator = new GeneratorInstancjiClass(0, 0, "ACGT", 0, 0, 0);
        public WlasneDaneForm(GeneratorInstancjiClass Generator)
        {
            InitializeComponent();

            generator = Generator;

            this.LiczbaSekwencjiTextBox.Text = Generator.LiczbaSekwencji.ToString();
            this.DlugoscSekwencjiTextBox.Text = Generator.DlugoscSekwencji.ToString();
            this.AlfabetTextBox.Text = new string(Generator.Alfabet.ToArray());
            if (generator.Sekwencje != null)
            {
                WyswietlSekwencje();
            }
        }

        private void WlasneDaneForm_Load(object sender, EventArgs e)
        {

        }
        private void WczytajSekwencje(string sekwencje)
        {
            HashSet<char> nowy_alfabet = new HashSet<char>();
            var nowe_sekwencje = sekwencje.Split();
            

            for (int i = 0; i < nowe_sekwencje.Count(); i++)
            {
                if (nowe_sekwencje[i].Count() > 0)
                {
                    generator.TMPSekwencje.Add(String.Concat(nowe_sekwencje[i].Where(c => !Char.IsWhiteSpace(c))));
                }
            }
        }

        private void Uaktualnij()
        {
            int licznik = 0;
            HashSet<char> nowy_alfabet = new HashSet<char>();

            for (int i = 0; i < generator.Sekwencje.Count(); i++)
            {
                if (generator.Sekwencje[i].Count() > 0)
                {
                    nowy_alfabet.UnionWith(new HashSet<char>(String.Concat(generator.Sekwencje[i].Where(c => !Char.IsWhiteSpace(c)))));
                    licznik += 1;
                }
            }

            generator.LiczbaSekwencji = generator.Sekwencje.Count();
            generator.DlugoscSekwencji = generator.Sekwencje[0].Count();
            generator.Alfabet = nowy_alfabet.ToList();

            this.LiczbaSekwencjiTextBox.Text = generator.LiczbaSekwencji.ToString();
            this.DlugoscSekwencjiTextBox.Text = generator.DlugoscSekwencji.ToString();
            this.AlfabetTextBox.Text = new string(generator.Alfabet.ToArray());
        }

        private void WczytajInstancjeButton_Click(object sender, EventArgs e)
        {
            var sekwencje = string.Empty;
            var sciezka = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sciezka = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        sekwencje = reader.ReadToEnd();
                    }
                }
            }

            WczytajSekwencje(sekwencje);
            WyswietlWczytaneSekwencje();
        }

        private void WyswietlWczytaneSekwencje()
        {
            this.SekwencjeTextBox.Text = "";
            for (int i = 0; i < generator.TMPSekwencje.Count(); i++)
            {
                this.SekwencjeTextBox.Text += generator.TMPSekwencje[i] + System.Environment.NewLine;
            }
        }
        private void WyswietlSekwencje()
        {
            this.SekwencjeTextBox.Text = "";
            for (int i = 0; i < generator.Sekwencje.Count(); i++)
            {
                this.SekwencjeTextBox.Text += generator.Sekwencje[i] + System.Environment.NewLine;
            }
        }
        private void NadpiszSekwencje()
        {
            generator.TMPSekwencje.Clear();

            for (int i = 0; i < this.SekwencjeTextBox.Lines.Length; i++)
            {
                if (SekwencjeTextBox.Lines[i].Count() > 0)
                {
                    generator.TMPSekwencje.Add(String.Concat(SekwencjeTextBox.Lines[i].Where(c => !Char.IsWhiteSpace(c))));
                }
            }
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            NadpiszSekwencje();
            if (generator.SprawdzPoprawnoscInstancji())
            {
                generator.Sekwencje = generator.TMPSekwencje;

                WyswietlSekwencje();

                generator.PoprawnaInstancja = true;
                System.Windows.Forms.MessageBox.Show("Dane zostały zapisane!");
                this.Close();
            }
        }

        private void OdswiezButton_Click(object sender, EventArgs e)
        {
            NadpiszSekwencje();
            if (generator.SprawdzPoprawnoscInstancji())
            {

                generator.Sekwencje = generator.TMPSekwencje;

                Uaktualnij();
                WyswietlSekwencje();
                System.Windows.Forms.MessageBox.Show("Dane zostały poprawnie wczytane", "Informacja");
            }
        }
    }
}
