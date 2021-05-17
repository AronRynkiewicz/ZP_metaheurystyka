using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

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

        public List<int> obecnaListaJakosci { get; set; }

        private static readonly Random getrandom = new Random();

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
            //Random losowyIndex = new Random();
            string losowaSekwencja = string.Empty;

            for(int i = 0; i < this.OryginalneSekwencje[0].Count() * 10; i++)
            {
                losowaSekwencja += Alfabet[getrandom.Next(Alfabet.Count)];
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

                if (licznik == dopasowanie.Count())
                {
                    continue;
                }

                for (int index = 0; index < dopasowanie.Count(); index++)
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

            for (int i = 0; i < this.WielkoscPopulacji; i++)
            {
                string losowaSekwencja = WygenerujLosowaSekwencje();

                var osobnik = DopasujSekwencje(losowaSekwencja);
                Populacja.Add(new List<string>(osobnik));
            }
        }

        public int ObliczJakoscDopasowania(List<string> dopasowanie)
        {
            int obecna_jakosc = 0;

            obecna_jakosc = dopasowanie[0].Count();

            return obecna_jakosc;
        }

        public int WybierzNajlepsze()
        {
            List<int> Jakosci = new List<int>();

            for (int i = 0; i < Populacja.Count; i++)
            {
                int obliczonaJakosc = ObliczJakoscDopasowania(Populacja[i]);
                Jakosci.Add(obliczonaJakosc);

                if (obliczonaJakosc < this.NajlepszaJakosc || this.NajlepszaJakosc == 0)
                {
                    this.NajlepszeDopasowanie = new List<string>(Populacja[i]);
                    this.NajlepszaJakosc = obliczonaJakosc;
                }
            }

            return (int)Jakosci.Average();
        }

        public List<int> UzyskajJakoscDlaPopulacji()
        {
            List<int> listaJakosci = new List<int>();
            for (int i = 0; i < Populacja.Count(); i++)
            {
                double tmp = this.Populacja.Count() / (1.0 / ObliczJakoscDopasowania(Populacja[i]));

                if(tmp > 100)
                {
                    tmp = 100;
                }

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

            this.obecnaListaJakosci = new List<int>(listaJakosci);

            if (wielkoscRuletki < 2)
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
                listaWybranych = listaWybranych.OrderBy(a => Guid.NewGuid()).ToList();
                return listaWybranych;
            }

            for (int i = 0; i < listaJakosci.Count; i++)
            {
                for(int j = 0; j < listaJakosci[i]; j++)
                {
                    listaDoLosowania.Add(i);
                }
            }

            //Random losowyIndex = new Random();
            Random losowyIndex = getrandom;
            while (wybrane.Count() != wielkoscRuletki)
            {
                wybrane.Add(listaDoLosowania[losowyIndex.Next(listaDoLosowania.Count())]);
            }
            listaWybranych.AddRange(wybrane);

            listaWybranych = listaWybranych.OrderBy(a => Guid.NewGuid()).ToList();
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

        public List<List<string>> PierwszeKrzyzowanie(List<int> listaWybranych)
        {
            List<List<string>> nowaPopulacja = new List<List<string>>();
            int pierwszyIndex = 0;
            int drugiIndex = 0;
            bool flaga = false;
            //Random r = new Random();
            Random r = getrandom;

            if ((listaWybranych.Count() / 2) % 1 != 0)
            {
                flaga = true;
            }

            while (listaWybranych.Count() != 0)
            {
                List<string> tmpDopasowanie = new List<string>();
                if (flaga == true)
                {
                    pierwszyIndex = 1;
                    drugiIndex = listaWybranych.Count - 1;

                }
                else
                {
                    pierwszyIndex = listaWybranych[0];
                    drugiIndex = listaWybranych[1];
                }

                int indexZamiany = r.Next(2);

                for (int i = 0; i < this.Populacja[pierwszyIndex].Count(); i++)
                {
                    int wylosowanaLiczba = r.Next(2);
                    if (wylosowanaLiczba == 0)
                    {
                        tmpDopasowanie.Add(this.Populacja[pierwszyIndex][i]);
                    }
                    else
                    {
                        tmpDopasowanie.Add(this.Populacja[drugiIndex][i]);
                    }
                }

                tmpDopasowanie = PoprawBledy(tmpDopasowanie);
                tmpDopasowanie = UsunPusteKolumny(tmpDopasowanie);

                nowaPopulacja.Add(new List<string>(tmpDopasowanie));

                if (flaga == true)
                {
                    flaga = false;
                    continue;
                }

                listaWybranych.RemoveAt(0);
                listaWybranych.RemoveAt(0);
            }

            return nowaPopulacja;
        }

        public List<List<string>> DrugieKrzyzowanie(List<int> listaWybranych)
        {
            //Random r = new Random();
            Random r = getrandom;
            List<List<string>> nowaPopulacja = new List<List<string>>();

            for (int mainCounter = 0; mainCounter < listaWybranych.Count; mainCounter += 2)
            {
                int indexZamiany = r.Next(1, (this.OryginalneSekwencje[0].Count() - 2));
                List<string> CzescPierwszejSekwencji = new List<string>();
                List<string> CzescDrugiejSekwencji = new List<string>();

                for (int i = 0; i < this.Populacja[listaWybranych[mainCounter]].Count(); i++)
                {
                    string PierwszaCzesc = "";
                    int counter = 0;
                    for (int j = 0; j < this.Populacja[listaWybranych[mainCounter]][i].Count(); j++)
                    {
                        char tmp = this.Populacja[listaWybranych[mainCounter]][i][j];
                        if (counter >= indexZamiany)
                        {
                            break;
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

                    counter = 0;
                    for (int j = 0; j < this.Populacja[listaWybranych[mainCounter + 1]][i].Count(); j++)
                    {
                        char tmp = this.Populacja[listaWybranych[mainCounter + 1]][i][j];
                        if (counter >= indexZamiany)
                        {
                            PierwszaCzesc += tmp;
                        }

                        if (tmp != '_')
                        {
                            counter += 1;
                        }
                    }
                    CzescDrugiejSekwencji.Add(PierwszaCzesc);
                }

                List<string> tmp1 = new List<string>();
                for (int i = 0; i < CzescDrugiejSekwencji.Count(); i++)
                {
                    tmp1.Add(CzescDrugiejSekwencji[i]);
                }

                
                nowaPopulacja.Add(new List<string>(tmp1));

                nowaPopulacja[nowaPopulacja.Count() - 1] = PoprawBledy(nowaPopulacja[nowaPopulacja.Count() - 1]);
                nowaPopulacja[nowaPopulacja.Count() - 1] = UsunPusteKolumny(nowaPopulacja[nowaPopulacja.Count() - 1]);
                
            }

            return nowaPopulacja;
        }

        public void uzupelnijPopulacje(List<List<string>> nowaPopulacja, List<int> listaWybranych)
        {
            for(int i = 0; i < listaWybranych.Count; i++)
            {
                if(nowaPopulacja.Count == this.WielkoscPopulacji)
                {
                    break;
                }

                nowaPopulacja.Add(new List<string>(Populacja[listaWybranych[i]]));
            }

            //Random r = new Random();
            Random r = getrandom;

            int wylosowanaLiczba = r.Next(100);

            if (wylosowanaLiczba <= this.CzestotliwoscMutacji)
            {
                string losowaSekwencja = WygenerujLosowaSekwencje();

                var osobnik = DopasujSekwencje(losowaSekwencja);
                nowaPopulacja.Add(osobnik);
            }

            if(nowaPopulacja.Count < this.WielkoscPopulacji)
            {
                while(nowaPopulacja.Count != this.WielkoscPopulacji)
                {
                    int index = r.Next(Populacja.Count() - 2);
                    if (!listaWybranych.Contains(index))
                    {
                        nowaPopulacja.Add(new List<string>(Populacja[index]));
                    }
                }
            }

            this.Populacja = nowaPopulacja;
        }

        public void Krzyzowanie(List<int> listaWybranych)
        {
            listaWybranych = listaWybranych.OrderBy(x => Guid.NewGuid()).ToList();
            List<List<string>> nowaPopulacja = new List<List<string>>();
            //Random r = new Random();
            Random r = getrandom;
            int wylosowaneKrzyzowanie = r.Next(100);

            if(wylosowaneKrzyzowanie <= 30)
            {
                nowaPopulacja = PierwszeKrzyzowanie(listaWybranych);
            }
            else if (wylosowaneKrzyzowanie >= 50)
            {
                nowaPopulacja = DrugieKrzyzowanie(listaWybranych);
            }

            uzupelnijPopulacje(nowaPopulacja, listaWybranych);
        }

        public void Mutacje()
        {
            //Random r = new Random();
            Random r = getrandom;
            int wylosowanaLiczba = r.Next(100);

            if (wylosowanaLiczba <= this.CzestotliwoscMutacji)
            {
                int index = r.Next(this.Populacja.Count() - 1);
                int sekwencja = r.Next(this.Populacja[index].Count());
                int pozycja = r.Next(this.Populacja[index][sekwencja].Count());

                List<char> tmp = new List<char>(this.Populacja[index][sekwencja]);
                tmp.Insert(pozycja, '_');
                this.Populacja[index][sekwencja] = new string(tmp.ToArray());

                this.Populacja[index] = PoprawBledy(this.Populacja[index]);
                this.Populacja[index] = UsunPusteKolumny(this.Populacja[index]);
            }
        }

        public void StartMeta(BackgroundWorker worker, DoWorkEventArgs e, ManualResetEvent wstrzymajMeta)
        {
            Queue<int> SredniaJakosc = new Queue<int>();
            int obecnaSredniaJakosc = 0;
            int granica = 0;

            if (this.CzestotliwoscMutacji < 1)
            {
                this.CzestotliwoscMutacji = 1;
            }

            if(this.CzestotliwoscMutacji > 100)
            {
                this.CzestotliwoscMutacji = 100;
            }

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
                Mutacje();
                int poprzedniaJakosc = this.NajlepszaJakosc;
                obecnaSredniaJakosc = WybierzNajlepsze();

                if (poprzedniaJakosc == this.NajlepszaJakosc)
                {
                    granica++;
                }
                else
                {
                    granica = 0;
                }

                obecnaSredniaJakosc = this.NajlepszaJakosc;

                if (SredniaJakosc.Count == 10)
                {
                    SredniaJakosc.Dequeue();
                }
                SredniaJakosc.Enqueue(obecnaSredniaJakosc);
                worker.ReportProgress(i, new List<int>(SredniaJakosc));
                
                if(granica == 25)
                {
                    granica = 0;
                    Populacja.Clear();
                    StworzPopulacje();
                    WybierzNajlepsze();
                }
            }
        }
    }
}
