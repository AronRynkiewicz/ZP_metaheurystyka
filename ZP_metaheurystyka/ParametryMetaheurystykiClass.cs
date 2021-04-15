using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP_metaheurystyka
{
    public class ParametryMetaheurystykiClass
    {
        public int LiczbaIteracji { get; set; }
        public int WielkoscPopulacji { get; set; }
        public double ProcentKrzyzowania { get; set; }
        public double CzestotliwoscMutacji { get; set; }

        public ParametryMetaheurystykiClass(int iteracje, int populacja, double krzyzowanie, double mutacje)
        {
            this.LiczbaIteracji = iteracje;
            this.WielkoscPopulacji = populacja;
            this.ProcentKrzyzowania = krzyzowanie;
            this.CzestotliwoscMutacji = mutacje;
        }
    }
}
