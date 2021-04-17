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
        public int JakoscDopasowania { get; set; }
        public List<string> TMPSekwencje { get; set; }

        public GeneratorInstancjiClass(int liczba_sewkencji, int dlugosc_sekwencji, string alfabet, int procent_przerw, int liczba_mutacji, int jakosc_dopasowania)
        {
            this.LiczbaSekwencji = liczba_sewkencji;
            this.DlugoscSekwencji = dlugosc_sekwencji;
            this.Alfabet = new List<char>();
            this.Alfabet.AddRange(alfabet);
            this.ProcentPrzerw = procent_przerw;
            this.LiczbaMutacji = liczba_mutacji;
            this.JakoscDopasowania = jakosc_dopasowania;
            this.TMPSekwencje = new List<string>();
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
        
        public void WprowadzMutacje()
        {
            List<int> pozycje_mutacji = new List<int>();
            var losowa_nowa_zasada = new Random();
            var losowy_index = new Random();

            while (pozycje_mutacji.Count() != this.LiczbaMutacji * this.LiczbaSekwencji)
            {
                for(int i = 0; i < this.Sekwencje.Count(); i++)
                {
                    int index = 0;
                    while (true)
                    {
                        index = losowy_index.Next(this.Sekwencje[i].Count());
                        if (!pozycje_mutacji.Contains(index) && this.Sekwencje[i][index] != '_')
                        {
                            break;
                        }
                    }

                    List<char> tmp_sekwencja = new List<char>(this.Sekwencje[i]);
                    tmp_sekwencja[index] = this.Alfabet[losowa_nowa_zasada.Next(this.Alfabet.Count)];
                    this.Sekwencje[i] = new string(tmp_sekwencja.ToArray());
                    pozycje_mutacji.Add(index);
                }
            }
        }

        public void PoprawBledy()
        {
            for(int pos = 0; pos < this.Sekwencje[0].Count(); pos++)
            {
                Dictionary<char, int> wystapienia_zasad = new Dictionary<char, int>();

                for (int index_sekwencji = 0; index_sekwencji < this.Sekwencje.Count(); index_sekwencji++)
                {
                    try
                    {
                        wystapienia_zasad[Sekwencje[index_sekwencji][pos]] += 1;
                    }
                    catch (KeyNotFoundException)
                    {
                        wystapienia_zasad.Add(Sekwencje[index_sekwencji][pos], 1);
                    }
                }

                wystapienia_zasad.Remove('_');
                if(wystapienia_zasad.Count <= 1)
                {
                    continue;
                }

                char bledna_zasada = wystapienia_zasad.OrderBy(kvp => kvp.Value).First().Key;

                for (int index_sekwencji = 0; index_sekwencji < this.Sekwencje.Count(); index_sekwencji++)
                {
                    List<char> tmp_sekwencja = new List<char>(this.Sekwencje[index_sekwencji]);
                    
                    if(tmp_sekwencja[pos] == bledna_zasada)
                    {
                        if (pos < tmp_sekwencja.Count())
                        {
                            tmp_sekwencja.Insert(pos + 1, '_');
                        }
                        else
                        {
                            tmp_sekwencja.Add('_');
                        }
                    }

                    if (tmp_sekwencja[pos] != bledna_zasada)
                    {
                        tmp_sekwencja.Insert(pos, '_');
                    }
                    this.Sekwencje[index_sekwencji] = new string(tmp_sekwencja.ToArray());
                }

                wystapienia_zasad.Clear();
            }

            this.JakoscDopasowania = ObliczJakoscDopasowania();
        }

        public int ObliczJakoscDopasowania()
        {
            int obecna_jakosc = 0;

            for(int i = 0; i < this.Sekwencje.Count(); i++)
            {
                obecna_jakosc += Sekwencje[i].Count(f => f == '_');
            }

            return obecna_jakosc;
        }

        public bool sprawdzDlugoscSekwencji()
        {
            HashSet<int> dlugosci_sekwencji = new HashSet<int>();
            bool poprawna_dlugosc = true;

            for (int i = 0; i < this.TMPSekwencje.Count; i++)
            {
                dlugosci_sekwencji.Add(TMPSekwencje[i].Count() - Sekwencje[i].Count(f => f == '_'));
            }

            if(dlugosci_sekwencji.Count() != 1)
            {
                poprawna_dlugosc = false;
            }

            return poprawna_dlugosc;
        }

        public bool sprawdzZasadySekwencji()
        {
            bool poprawne_zasady = true;
            HashSet<char> zasady_sekwencji = new HashSet<char>();
            HashSet<char>  alfabet = new HashSet<char>(this.Alfabet);
            int poczatkowy_rozmiar_alfabetu = alfabet.Count();

            for (int i = 0; i < this.TMPSekwencje.Count; i++)
            {
                zasady_sekwencji = new HashSet<char>(this.TMPSekwencje[i]);
                if (zasady_sekwencji.Contains('_'))
                {
                    zasady_sekwencji.Remove('_');
                }

                alfabet.UnionWith(zasady_sekwencji);
                if(alfabet.Count() > poczatkowy_rozmiar_alfabetu)
                {
                    poprawne_zasady = false;
                    break;
                }
            }

            return poprawne_zasady;
        }

        public bool SprawdzPoprawnoscInstancji()
        {
            List<string> BledyFormatu = new List<string>();
            bool poprawnosc_danych = true;

            if (!sprawdzDlugoscSekwencji())
            {
                poprawnosc_danych = false;
                BledyFormatu.Add("Sekwencje nie są równej długości");
            }

            if (!sprawdzZasadySekwencji())
            {
                poprawnosc_danych = false;
                BledyFormatu.Add("W sekwencjach znajduje się inny znak niż w dozwolonym alfabecie");
            }

            if (!poprawnosc_danych)
            {
                System.Windows.Forms.MessageBox.Show("Dane nie zostały zapisane ze względu na następujące błędy: \n -" + String.Join("\n - ", BledyFormatu.ToArray()), "Uwaga - błędy!");
            }

            return poprawnosc_danych;
        }

        public void WygenerujInstancje()
        {
            var macierz = WygenerujMacierz();
            var losowa_sekwencja = WygenerujSekwencje();
            WygenerujDopasowanie(macierz, losowa_sekwencja);
            WprowadzMutacje();
            PoprawBledy();
        }
    }
}
