using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_metaheurystyka
{
    public class GeneratorInstancjiClass
    {
        public int LiczbaSekwencji { get; set; }
        public int DlugoscSekwencji { get; set; }
        public List<char> Alfabet { get; set; }
        public int ProcentPrzerw { get; set; }
        public int LiczbaMutacji { get; set; }
        public List<string> Sekwencje { get; set; }

        public GeneratorInstancjiClass(int liczba_sewkencji, int dlugosc_sekwencji, string alfabet, int procent_przerw, int liczba_mutacji)
        {
            this.LiczbaSekwencji = liczba_sewkencji;
            this.DlugoscSekwencji = dlugosc_sekwencji;
            this.Alfabet = new List<char>();
            this.Alfabet.AddRange(alfabet);
            this.ProcentPrzerw = procent_przerw;
            this.LiczbaMutacji = liczba_mutacji;
        }

        public List<List<int>> WygenerujMacierz()
        {
            List<List<int>> macierz = new List<List<int>>();
            int liczba_przerw = (int)Math.Round((double)((this.DlugoscSekwencji * this.ProcentPrzerw) / 100));

            for (int i = 0; i < this.LiczbaSekwencji; i++)
            {
                macierz.Add((from number in Enumerable.Range(0, this.DlugoscSekwencji) select 1).ToList());
                macierz[i].AddRange((from number in Enumerable.Range(0, liczba_przerw) select 0).ToList());
                macierz[i] = macierz[i].OrderBy(x => Guid.NewGuid()).ToList();
            }

            return macierz;
        }

        public string WygenerujSekwencje()
        {
            int liczba_przerw = (int)Math.Round((double)((this.DlugoscSekwencji * this.ProcentPrzerw) / 100));
            var random = new Random();

            List<char> losowa_sekwencja = new List<char>();
            losowa_sekwencja.AddRange((
                from number in 
                Enumerable.Range(0, liczba_przerw + this.DlugoscSekwencji)
                select 
                this.Alfabet[random.Next(this.Alfabet.Count)])
                .ToList());

            return new string(losowa_sekwencja.ToArray());
        }

        public void WygenerujDopasowanie(List<List<int>> macierz, string losowa_sekwencja)
        {
            this.Sekwencje = new List<string>();

            for(int i = 0; i < macierz.Count(); i++)
            {
                string sekwencja = "";
                for(int j = 0; j < macierz[i].Count(); j++)
                {
                    if(macierz[i][j] == 1)
                    {
                        sekwencja += losowa_sekwencja[j];
                    }
                    else
                    {
                        sekwencja += '_';
                    }
                }
                this.Sekwencje.Add(sekwencja);
            }
        }
        

        public void WygenerujInstancje()
        {
            var macierz = WygenerujMacierz();
            var losowa_sekwencja = WygenerujSekwencje();
            WygenerujDopasowanie(macierz, losowa_sekwencja);
        }
    }
}
