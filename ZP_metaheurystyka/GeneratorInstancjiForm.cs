﻿using System;
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

        public bool SprawdzParametry()
        {
            List<string> BledyFormatu = new List<string>();
            bool PoprawneDane = true;
            char[] array = new[] { 'A', 'C', 'G', 'T'};
            HashSet<char> ZbiorZasad = new HashSet<char>(array);

            int TMPLiczbaSekwencji;
            int TMPDlugoscSekwencji;
            HashSet<char> TMPAlfabet;
            int TMPProcentPrzerw;
            int TMPLiczbaMutacji;

            try
            {
                TMPLiczbaSekwencji = Int32.Parse(this.LiczbaSekwencjiTextBox.Text);
            }
            catch
            {
                BledyFormatu.Add("Liczba sekwencji");
                PoprawneDane = false;
            }

            try
            {
                TMPDlugoscSekwencji = Int32.Parse(this.DlugoscSekwencjiTextBox.Text);
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
            }
            catch
            {
                BledyFormatu.Add("Procent przerw");
                PoprawneDane = false;
            }

            try
            {
                TMPLiczbaMutacji = Int32.Parse(this.MutacjeTextBox.Text);
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


            return PoprawneDane;
        }

        private void WygenerujInstancjeButton_Click(object sender, EventArgs e)
        {
            var PoprawneDane = SprawdzParametry();

            if (PoprawneDane)
            {
                GeneratorInstancjiClass generator = new GeneratorInstancjiClass(
                    Int32.Parse(this.LiczbaSekwencjiTextBox.Text),
                    Int32.Parse(this.DlugoscSekwencjiTextBox.Text),
                    this.AlfabetTextBox.Text,
                    Int32.Parse(this.PrzerwyTextBox.Text),
                    Int32.Parse(this.MutacjeTextBox.Text));

                generator.WygenerujInstancje();
                this.SekwencjeTextBox.Text = "";
                for (int i = 0; i < generator.Sekwencje.Count(); i++)
                {
                    this.SekwencjeTextBox.Text += generator.Sekwencje[i] + System.Environment.NewLine;
                }
            }
        }
    }
}
