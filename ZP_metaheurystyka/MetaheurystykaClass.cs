using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace ZP_metaheurystyka
{
    public class MetaheurystykaClass
    {
        public List<string> OryginalneSekwencje { get; set; }
        public List<char> Alfabet { get; set; }
        public int LiczbaIteracji { get; set; }
        public int WielkoscPopulacji { get; set; }
        public double ProcentKrzyzowania { get; set; }
        public double CzestotliwoscMutacji { get; set; }
        public List<List<string>> Populacja { get; set; }
        public List<string> NajlepszeDopasowanie { get; set; }
        public int NajlepszaJakosc { get; set; }

        public MetaheurystykaClass(List<string> sekwencje, List<char> alfabet, int iteracje, int populacja, double krzyzowanie, double mutacje)
        {
            this.OryginalneSekwencje = new List<string>();
            for(int i = 0; i < sekwencje.Count(); i++)
            {
                this.OryginalneSekwencje.Add(String.Join("", sekwencje[i].Split('_')));
            }

            this.LiczbaIteracji = iteracje;
            this.WielkoscPopulacji = populacja;
            this.ProcentKrzyzowania = krzyzowanie;
            this.CzestotliwoscMutacji = mutacje;
            this.Alfabet = alfabet;
        }

        public string WygenerujLosowaSekwencje()
        {
            Random losowyIndex = new Random();
            string losowaSekwencja = string.Empty;

            for(int i = 0; i < this.OryginalneSekwencje[0].Count() * 10; i++)
            {
                losowaSekwencja += Alfabet[losowyIndex.Next(Alfabet.Count)];
            }

            return losowaSekwencja;
        }

        public List<List<char>> PoprawDlugosc(List<List<char>> dopasowanie)
        {
            int maksymalnaDlugosc = 0;
            for(int i = 0; i < dopasowanie.Count; i++)
            {
                if(dopasowanie[i].Count() > maksymalnaDlugosc)
                {
                    maksymalnaDlugosc = dopasowanie[i].Count();
                }
            }

            for(int i = 0; i < dopasowanie.Count; i++)
            {
                if(dopasowanie[i].Count() != maksymalnaDlugosc)
                {
                    for(int j = 0; j < maksymalnaDlugosc - dopasowanie[i].Count(); j++)
                    {
                        dopasowanie[i].Add('_');
                    }
                }
            }

            return dopasowanie;
        }

        public List<List<char>> PoprawDopasowanie(List<List<char>> dopasowanie)
        {
            List<List<char>> noweDopasowanie = new List<List<char>>();
            dopasowanie = PoprawDlugosc(dopasowanie);

            for (int i = 0; i < dopasowanie.Count(); i++)
            {
                noweDopasowanie.Add(new List<char>());
            }

            for (int pos = 0; pos < dopasowanie[0].Count; pos++)
            {
                int licznik = 0;
                for (int index = 0; index < dopasowanie.Count(); index++)
                {
                    if (dopasowanie[index][pos] == '_')
                    {
                        licznik += 1;
                    }
                }

                if(licznik == dopasowanie.Count())
                {
                    continue;
                }

                for(int index = 0; index < dopasowanie.Count(); index++)
                {
                    noweDopasowanie[index].Add(dopasowanie[index][pos]);
                }
            }

            return noweDopasowanie;
        }

        public List<string> DopasujSekwencje(string losowaSekwencja)
        {
            List<string> WlasciweDopasowanie = new List<string>();
            List<List<char>> TMPDopasowanie = new List<List<char>>();

            for(int i = 0; i < this.OryginalneSekwencje.Count(); i++)
            {
                TMPDopasowanie.Add(new List<char>());
                TMPDopasowanie[i].AddRange(OryginalneSekwencje[i]);
            }

            for(int pos = 0; pos < losowaSekwencja.Length; pos++)
            {
                for(int index = 0; index < TMPDopasowanie.Count(); index++)
                {
                    if(pos >= TMPDopasowanie[index].Count())
                    {
                        TMPDopasowanie[index].Add('_');
                        continue;
                    }

                    if(TMPDopasowanie[index][pos] == losowaSekwencja[pos])
                    {
                        continue;
                    }
                    else
                    {
                        TMPDopasowanie[index].Insert(pos, '_');
                    }
                }
            }

            TMPDopasowanie = PoprawDopasowanie(TMPDopasowanie);

            for(int i = 0; i < TMPDopasowanie.Count; i++)
            {
                WlasciweDopasowanie.Add(new string(TMPDopasowanie[i].ToArray()));
            }

            return WlasciweDopasowanie;
        }

        public void StworzPopulacje()
        {
            Populacja = new List<List<string>>();

            for(int i = 0; i < this.WielkoscPopulacji; i++)
            {
                string losowaSekwencja = WygenerujLosowaSekwencje();

                var osobnik = DopasujSekwencje(losowaSekwencja);
                Populacja.Add(osobnik);
            }
        }
        public int ObliczJakoscDopasowania(List<string> dopasowanie)
        {
            int obecna_jakosc = 0;

            for (int i = 0; i < dopasowanie.Count(); i++)
            {
                obecna_jakosc += dopasowanie[i].Count(f => f == '_');
            }

            return obecna_jakosc;
        }

        public int WybierzNajlepsze()
        {
            int index = 0;
            int najlepszaJakosc = this.NajlepszaJakosc;
            List<int> Jakosci = new List<int>();

            for(int i = 0; i < Populacja.Count; i++)
            {
                int obliczonaJakosc = ObliczJakoscDopasowania(Populacja[i]);
                Jakosci.Add(obliczonaJakosc);

                if (obliczonaJakosc < najlepszaJakosc || najlepszaJakosc == 0)
                {
                    najlepszaJakosc = obliczonaJakosc;
                    index = i;
                }
            }

            this.NajlepszeDopasowanie = Populacja[index];
            this.NajlepszaJakosc = najlepszaJakosc;

            return (int)Jakosci.Average();
        }

        public List<int> UzyskajJakoscDlaPopulacji()
        {
            List<int> listaJakosci = new List<int>();
            int mnoznik = (100 * this.Populacja[0][0].Count());
            for (int i = 0; i < Populacja.Count(); i++)
            {
                double tmp = 1.0 / ObliczJakoscDopasowania(Populacja[i]) * mnoznik;

                if(tmp < 1)
                {
                    tmp = 1;
                }

                listaJakosci.Add((int)tmp);
            }

            return listaJakosci;
        }
        public List<int> Ruletka()
        {
            HashSet<int> wybrane = new HashSet<int>();
            List<int> listaDoLosowania = new List<int>();
            List<int> listaWybranych = new List<int>();
            int wielkoscRuletki = (int)((this.Populacja.Count() * this.ProcentKrzyzowania) / 100);
            var listaJakosci = UzyskajJakoscDlaPopulacji();

            if(wielkoscRuletki < 2)
            {
                wielkoscRuletki = 2;
            }

            if(wielkoscRuletki % 2 == 1)
            {
                wielkoscRuletki += 1;
            }

            if (wielkoscRuletki >= listaJakosci.Count)
            {
                int tmp = 0;
                if(listaJakosci.Count % 2 == 1)
                {
                    tmp = 1;
                }

                for(int i = 0; i < (listaJakosci.Count - tmp); i++)
                {
                    listaWybranych.Add(i);
                }
                return listaWybranych;
            }

            for (int i = 0; i < listaJakosci.Count; i++)
            {
                for(int j = 0; j < listaJakosci[i]; j++)
                {
                    listaDoLosowania.Add(i);
                }
            }

            Random losowyIndex = new Random();
            while (wybrane.Count() != wielkoscRuletki)
            {
                wybrane.Add(listaDoLosowania[losowyIndex.Next(listaDoLosowania.Count())]);
            }
            listaWybranych.AddRange(wybrane);

            return listaWybranych;
        }

        public List<string> PoprawDlugoscOsobnika(List<string> osobnik)
        {
            int maksymalnaDlugosc = 0;
            for (int i = 0; i < osobnik.Count; i++)
            {
                if (osobnik[i].Count() > maksymalnaDlugosc)
                {
                    maksymalnaDlugosc = osobnik[i].Count();
                }
            }

            for (int i = 0; i < osobnik.Count; i++)
            {
                if (osobnik[i].Count() != maksymalnaDlugosc)
                {
                    int dlugosc = maksymalnaDlugosc - osobnik[i].Count();
                    for (int j = 0; j < dlugosc; j++)
                    {
                        osobnik[i] += '_';
                    }
                }
            }

            return osobnik;
        }

        public List<string> PoprawBledy(List<string> osobnik)
        {
            osobnik = PoprawDlugoscOsobnika(osobnik);

            for (int pos = 0; pos < osobnik[0].Count(); pos++)
            {
                Dictionary<char, int> wystapienia_zasad = new Dictionary<char, int>();

                for (int index_sekwencji = 0; index_sekwencji < osobnik.Count(); index_sekwencji++)
                {
                    try
                    {
                        wystapienia_zasad[osobnik[index_sekwencji][pos]] += 1;
                    }
                    catch (KeyNotFoundException)
                    {
                        wystapienia_zasad.Add(osobnik[index_sekwencji][pos], 1);
                    }
                }

                wystapienia_zasad.Remove('_');
                if (wystapienia_zasad.Count <= 1)
                {
                    continue;
                }

                char bledna_zasada = wystapienia_zasad.OrderBy(kvp => kvp.Value).First().Key;

                for (int index_sekwencji = 0; index_sekwencji < osobnik.Count(); index_sekwencji++)
                {
                    List<char> tmp_sekwencja = new List<char>(osobnik[index_sekwencji]);

                    if (tmp_sekwencja[pos] == bledna_zasada)
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
                    osobnik[index_sekwencji] = new string(tmp_sekwencja.ToArray());
                }

                wystapienia_zasad.Clear();
            }

            return osobnik;
        }

        public List<string> UsunPusteKolumny(List<string> osobnik)
        {
            List<string> noweSekwencje = new List<string>();

            for (int i = 0; i < osobnik.Count(); i++)
            {
                noweSekwencje.Add(string.Empty);
            }

            for (int pos = 0; pos < osobnik[0].Count(); pos++)
            {
                int licznik = 0;
                for (int index = 0; index < osobnik.Count(); index++)
                {
                    if (osobnik[index][pos] == '_')
                    {
                        licznik++;
                    }
                }

                if (licznik == osobnik.Count())
                {
                    continue;
                }

                for (int index = 0; index < osobnik.Count(); index++)
                {
                    noweSekwencje[index] += osobnik[index][pos];
                }
            }

            return noweSekwencje;
        }

        public void PierwszeKrzyzowanie(List<int> listaWybranych)
        {
            int pierwszyIndex = 0;
            int drugiIndex = 0;
            Random r = new Random();

            while (listaWybranych.Count() != 0)
            {
                pierwszyIndex = listaWybranych[0];
                drugiIndex = listaWybranych[1];

                int indexZamiany = r.Next(2);

                for(int i = 0; i < this.Populacja[pierwszyIndex].Count(); i++)
                {
                    if (i % 2 == indexZamiany)
                    {
                        string tmpPierwszyString = this.Populacja[pierwszyIndex][i];
                        string tmpDrugiString = this.Populacja[drugiIndex][i];

                        this.Populacja[pierwszyIndex][i] = tmpDrugiString;
                        this.Populacja[drugiIndex][i] = tmpPierwszyString;
                    }
                }

                this.Populacja[pierwszyIndex] = PoprawBledy(this.Populacja[pierwszyIndex]);
                this.Populacja[pierwszyIndex] = UsunPusteKolumny(this.Populacja[pierwszyIndex]);

                this.Populacja[drugiIndex] = PoprawBledy(this.Populacja[drugiIndex]);
                this.Populacja[drugiIndex] = UsunPusteKolumny(this.Populacja[drugiIndex]);


                listaWybranych.RemoveAt(0);
                listaWybranych.RemoveAt(0);
            }
        }

        public void DrugieKrzyzowanie(List<int> listaWybranych)
        {
            int pierwszyIndex = 0;
            int drugiIndex = 0;
            Random r = new Random();

            while (listaWybranych.Count() != 0)
            {
                pierwszyIndex = listaWybranych[0];
                drugiIndex = listaWybranych[1];

                int indexZamiany = r.Next((this.OryginalneSekwencje[0].Count() - 2));
                List<string> CzescPierwszejSekwencji = new List<string>();
                List<string> CzescDrugiejSekwencji = new List<string>();


                for (int i = 0; i < this.Populacja[pierwszyIndex].Count(); i++)
                {
                    string PierwszaCzesc = "";
                    string DrugaCzesc = "";
                    int counter = 0;
                    for(int j = 0; j < this.Populacja[pierwszyIndex][i].Count(); j++)
                    {
                        char tmp = this.Populacja[pierwszyIndex][i][j];
                        if (counter >= indexZamiany)
                        {
                            DrugaCzesc += tmp;
                        }
                        else
                        {
                            PierwszaCzesc += tmp;
                        }

                        if (tmp != '_')
                        {
                            counter += 1;
                        }
                    }
                    CzescPierwszejSekwencji.Add(PierwszaCzesc);
                    this.Populacja[pierwszyIndex][i] = DrugaCzesc;


                    PierwszaCzesc = "";
                    DrugaCzesc = "";
                    counter = 0;
                    for (int j = 0; j < this.Populacja[drugiIndex][i].Count(); j++)
                    {
                        char tmp = this.Populacja[drugiIndex][i][j];
                        if (counter >= indexZamiany)
                        {
                            DrugaCzesc += tmp;
                        }
                        else
                        {
                            PierwszaCzesc += tmp;
                        }

                        if (tmp != '_')
                        {
                            counter += 1;
                        }
                    }
                    CzescDrugiejSekwencji.Add(PierwszaCzesc);
                    this.Populacja[drugiIndex][i] = DrugaCzesc;
                }

                for(int i = 0; i < CzescPierwszejSekwencji.Count(); i++)
                {
                    this.Populacja[pierwszyIndex][i] = CzescDrugiejSekwencji[i] + this.Populacja[pierwszyIndex][i];
                    this.Populacja[drugiIndex][i] = CzescPierwszejSekwencji[i] + this.Populacja[drugiIndex][i];
                }

                this.Populacja[pierwszyIndex] = PoprawBledy(this.Populacja[pierwszyIndex]);
                this.Populacja[pierwszyIndex] = UsunPusteKolumny(this.Populacja[pierwszyIndex]);

                this.Populacja[drugiIndex] = PoprawBledy(this.Populacja[drugiIndex]);
                this.Populacja[drugiIndex] = UsunPusteKolumny(this.Populacja[drugiIndex]);


                listaWybranych.RemoveAt(0);
                listaWybranych.RemoveAt(0);
            }
        }

        public void Krzyzowanie(List<int> listaWybranych)
        {
            PierwszeKrzyzowanie(listaWybranych);
            DrugieKrzyzowanie(listaWybranych);
        }

        public void StartMeta(BackgroundWorker worker, DoWorkEventArgs e, ManualResetEvent wstrzymajMeta)
        {
            Queue<int> SredniaJakosc = new Queue<int>();
            int obecnaSredniaJakosc = 0;

            StworzPopulacje();
            WybierzNajlepsze();
            for (int i = 0; i < this.LiczbaIteracji; i++)
            {
                wstrzymajMeta.WaitOne(Timeout.Infinite);
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                var listaWybranych = Ruletka();
                if(listaWybranych.Count() % 2 != 0)
                {
                    listaWybranych.RemoveAt(0);
                }
                Krzyzowanie(listaWybranych);
                obecnaSredniaJakosc = WybierzNajlepsze();

                if(SredniaJakosc.Count == 10)
                {
                    SredniaJakosc.Dequeue();
                }
                SredniaJakosc.Enqueue(obecnaSredniaJakosc);
                worker.ReportProgress(i, new List<int>(SredniaJakosc));
            }
        }
    }
}
