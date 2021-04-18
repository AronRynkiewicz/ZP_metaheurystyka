using System;
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
            generator = Generator;
            parametry = Parametry;
            Zauktalizuj(this.InstancjaTextBox, this.JakoscInstancjiTextBox, generator.Sekwencje, generator.JakoscDopasowania);


            heurystyka = new MetaheurystykaClass(generator.Sekwencje, generator.Alfabet, parametry.LiczbaIteracji, parametry.WielkoscPopulacji, parametry.ProcentKrzyzowania, parametry.CzestotliwoscMutacji);
            heurystyka.StartMeta();
            Zauktalizuj(this.DopasowanieTextBox, this.JakoscDopasowaniaTextBox, heurystyka.NajlepszeDopasowanie, heurystyka.NajlepszaJakosc);
        }

        private void UruchomMetaheurystykeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
