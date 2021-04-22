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
    public partial class ZapiszWynikDoPliku : Form
    {
        public MetaheurystykaClass wynik = new MetaheurystykaClass(new List<string>(), new List<char>(), 0, 0, 0, 0);
        public ZapiszWynikDoPliku(MetaheurystykaClass Wynik)
        {
            InitializeComponent();
            this.wynik = Wynik;
        }

        private void ZapiszDoPlikuButton_Click(object sender, EventArgs e)
        {
            if (this.NazwaPlikuTextBox.Text.Length != 0)
            {
                string sekwencje = string.Empty;
                for (int i = 0; i < this.wynik.NajlepszeDopasowanie.Count(); i++)
                {
                    sekwencje += this.wynik.NajlepszeDopasowanie[i] + Environment.NewLine;
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
