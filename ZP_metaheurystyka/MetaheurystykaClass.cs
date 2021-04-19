using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    for(int j = 0; j < maksymalnaDlugosc - dopasowanie[i].Count(); i++)
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
            int najlepszaJakosc = 0;
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

            if (wielkoscRuletki >= listaJakosci.Count)
            {
                for(int i = 0; i < listaJakosci.Count; i++)
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
        public void StartMeta(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Queue<int> SredniaJakosc = new Queue<int>();
            int obecnaSredniaJakosc = 0;

            StworzPopulacje();
            for(int i = 0; i < this.LiczbaIteracji; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                var listaWybranych = Ruletka();
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
