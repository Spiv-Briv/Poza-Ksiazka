using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace TablicaMendelejewa
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Atom[] at =
        {
            new Atom("H","Wodór",1,0,1.008,0.082,1,1,1,0,0,0,0,0,0),
            new Atom("He","Hel",2,2,4.003,0.179,1,18,2,0,0,0,0,0,0),
            new Atom("Li","Lit",3,4,6.94,535,2,1,2,1,0,0,0,0,0),
            new Atom("Be","Beryl",4,5,9.012,1848,2,2,2,2,0,0,0,0,0),
            new Atom("B","Bor",5,6,10.81,2340,2,13,2,3,0,0,0,0,0),
            new Atom("C","Węgiel",6,6,12.011,2090,2,14,2,4,0,0,0,0,0),
            new Atom("N","Azot",7,7,14.007,808.5,2,15,2,5,0,0,0,0,0),
            new Atom("O","Tlen",8,8,15.999,1.429,2,16,2,6,0,0,0,0,0),
            new Atom("F","Fluor",9,10,18.998,1.696,2,17,2,7,0,0,0,0,0),
            new Atom("Ne","Neon",10,10,20.180,0.825,2,18,2,8,0,0,0,0,0),
            new Atom("Na","Sód",11,12,23.00,968,3,1,2,8,1,0,0,0,0),
            new Atom("Mg","Magnez",12,12,24.31,1738,3,2,2,8,2,0,0,0,0),
            new Atom("Al","Glin",13,14,26.98,2700,3,13,2,8,3,0,0,0,0),
            new Atom("Si","Krzem",14,14,28.09,2330,3,14,2,8,4,0,0,0,0),
            new Atom("P","Fosfor",15,16,30.97,2160,3,15,2,8,5,0,0,0,0),
            new Atom("S","Siarka",16,16,32.06,1960,3,16,2,8,6,0,0,0,0),
            new Atom("Cl","Chlor",17,18,35.45,3.214,3,17,2,8,7,0,0,0,0),
            new Atom("Ar","Argon",18,22,39.95,1.784,3,18,2,8,8,0,0,0,0),
            new Atom("K","Potas",19,20,39.10,856,4,1,2,8,8,1,0,0,0),
            new Atom("Ca","Wapń",20,20,40.08,1550,4,2,2,8,8,2,0,0,0),
            new Atom("Sc","Skand",21,24,44.96,2989,4,3,2,8,9,2,0,0,0),
            new Atom("Ti","Tytan",22,26,47.87,4507,4,4,2,8,10,2,0,0,0),
            new Atom("V","Wanad",23,28,50.94,6110,4,5,2,8,11,2,0,0,0),
            new Atom("Cr","Chrom",24,28,52.00,7190,4,6,2,8,13,1,0,0,0),
            new Atom("Mn","Mangan",25,30,54.94,7470,4,7,2,8,13,2,0,0,0),
            new Atom("Fe","Żelazo",26,30,55.845,7874,4,8,2,8,14,2,0,0,0),
            new Atom("Co","Kobalt",27,32,58.933,8900,4,9,2,8,15,2,0,0,0),
            new Atom("Ni","Nikiel",28,31,58.693,8908,4,10,2,8,16,2,0,0,0),
            new Atom("Cu","Miedź",29,35,63.546,8960,4,11,2,8,18,1,0,0,0),
            new Atom("Zn","Cynk",30,35,65.387,7140,4,12,2,8,18,2,0,0,0),
            new Atom("Ga","Gal",31,39,69.723,5904,4,13,2,8,18,3,0,0,0),
            new Atom("Ge","German",32,41,72.63,5323,4,14,2,8,18,4,0,0,0),
            new Atom("As","Arsen",33,42,74.922,5727,4,15,2,8,18,5,0,0,0),
            new Atom("Se","Selen",34,45,78.971,4819,4,16,2,8,18,6,0,0,0),
            new Atom("Br","Brom",35,45,79.904,3120,4,17,2,8,18,7,0,0,0),
            new Atom("Kr","Krypton",36,48,83.798,3.75,4,18,2,8,18,8,0,0,0),
            new Atom("Rb","Rubid",37,48,85.468,1532,5,1,2,8,18,8,1,0,0),
            new Atom("Sr","Stront",38,50,87.62,2630,5,2,2,8,18,8,2,0,0),
            new Atom("Y","Itr",39,50,88.906,4472,5,3,2,8,18,9,2,0,0),
            new Atom("Zr","Cyrkon",40,51,91.224,6511,5,4,2,8,18,10,2,0,0),
            new Atom("Nb","Niob",41,52,92.906,8570,5,5,2,8,18,12,1,0,0),
            new Atom("Mo","Molibden",42,54,95.95,10280,5,6,2,8,18,13,1,0,0),
            new Atom("Tc","Technet",43,55,98,11500,5,7,2,8,18,13,2,0,0),
            new Atom("Ru","Ruten",44,57,101.07,12370,5,8,2,8,18,15,1,0,0),
            new Atom("Rh","Rod",45,58,102.91,12450,5,9,2,8,18,16,1,0,0),
            new Atom("Pd","Pallad",46,60,106.42,12023,5,10,2,8,18,18,0,0,0),
            new Atom("Ag","Srebro",47,61,107.87,10490,5,11,2,18,18,18,1,0,0),
            new Atom("Cd","Kadm",48,64,112.41,8650,5,12,2,8,18,18,2,0,0),
            new Atom("In","Ind",49,66,114.82,7310,5,13,2,8,18,18,3,0,0),
            new Atom("Sn","Cyna",50,69,118.71,7310,5,14,2,8,18,18,4,0,0),
            new Atom("Sb","Antymon",51,71,121.76,6697,5,15,2,8,18,18,5,0,0),
            new Atom("Te","Tellur",52,76,127.60,6240,5,16,2,8,18,18,6,0,0),
            new Atom("I","Jod",53,74,126.90,4940,5,17,2,8,18,18,7,0,0),
            new Atom("Xe","Ksenon",54,77,131.29,5.9,5,18,2,8,18,18,8,0,0),
            new Atom("Cz","Ces",55,78,132.91,1879,6,1,2,8,18,18,8,1,0),
            new Atom("Ba","Bar",56,81,137.33,3510,6,2,2,8,18,18,8,2,0),
            new Atom("La","Lantan",57,82,138.91,6146,6,3,2,8,18,18,9,2,0),
            new Atom("Ce","Cer",58,82,140.12,6689,8,3,2,8,18,19,9,2,0),
            new Atom("Pr","Prazeodym",59,82,140.91,6640,8,4,2,8,18,21,8,2,0),
            new Atom("Nd","Neodym",60,84,144.24,7010,8,5,2,8,18,22,8,2,0),
            new Atom("Pm","Promet",61,84,145,7264,8,6,2,8,18,23,8,2,0),
            new Atom("Sm","Samar",62,88,150.36,7353,8,7,2,8,18,24,8,2,0),
            new Atom("Eu","Europ",63,88,151.96,5244,8,8,2,8,18,25,8,2,0),
            new Atom("Gd","Gadolin",64,93,157.25,7901,8,9,2,8,18,25,9,2,0),
            new Atom("Tb","Terb",65,94,158.93,8219,8,10,2,8,18,27,8,2,0),
            new Atom("Dy","Dysproz",66,96,162.50,8551,8,11,2,8,18,28,8,2,0),
            new Atom("Ho","Holm",67,98,164.93,8795,8,12,2,8,18,29,8,2,0),
            new Atom("Er","Erb",68,99,167.26,9066,8,13,2,8,18,30,8,2,0),
            new Atom("Tm","Tul",69,100,168.93,9320,8,14,2,8,18,31,8,2,0),
            new Atom("Yb","Iterb",70,103,173.05,6570,8,15,2,8,18,32,8,2,0),
            new Atom("Lu","Lutet",71,104,174.97,9841,8,16,2,8,18,32,9,2,0),
            new Atom("Hf","Hafn",72,106,178.49,13310,6,4,2,8,18,32,10,2,0),
            new Atom("Ta","Tantal",73,108,180.95,16650,6,5,2,8,18,32,11,2,0),
            new Atom("W","Wolfram",74,110,183.84,19250,6,6,2,8,18,32,12,2,0),
            new Atom("Re","Ren",75,111,186.21,21020,6,7,2,8,18,32,13,2,0),
            new Atom("Os","Osm",76,114,190.23,22590,6,8,2,8,18,32,14,2,0),
            new Atom("Ir","Iryd",77,115,192.22,22560,6,9,2,8,18,32,15,2,0),
            new Atom("Pt","Platyna",78,117,195.08,21450,6,10,2,8,18,32,17,1,0),
            new Atom("Au","Złoto",79,118,196.97,19300,6,11,2,8,18,32,18,1,0),
            new Atom("Hg","Rtęć",80,121,200.59,13534,6,12,2,8,18,32,18,2,0),
            new Atom("Tl","Tal",81,123,204.38,11850,6,13,2,8,18,32,18,3,0),
            new Atom("Pb","Ołów",82,125,207.2,11340,6,14,2,8,18,32,18,4,0),
            new Atom("Bi","Bizmut",83,126,208.98,9780,6,15,2,8,18,32,18,5,0),
            new Atom("Po","Polon",84,125,209,9196,6,16,2,8,18,32,18,6,0),
            new Atom("At","Astat",85,125,210,6,17,2,8,18,32,18,7,0),
            new Atom("Rd","Radon",86,136,222,9.73,6,18,2,8,18,32,18,8,0),
            new Atom("Fr","Frans",87,136,223,7,1,2,8,18,32,18,8,1),
            new Atom("Ra","Rad",88,138,226,5000,7,2,2,8,18,32,18,8,2),
            new Atom("Ac","Aktyn",89,138,227,10070,7,3,2,8,18,32,18,9,2),
            new Atom("Th","Tor",90,142,232.04,11724,9,3,2,8,18,32,10,2),
            new Atom("Pa","Protaktyn",91,140,231.04,15370,9,4,2,8,18,32,20,9,2),
            new Atom("U","Uran",92,146,238.03,19050,9,5,2,8,18,32,21,9,2),
            new Atom("Np","Neptun",93,144,237,20450,9,6,2,8,18,32,22,9,2),
            new Atom("Pu","Pluton",94,150,244,19816,9,7,2,8,18,32,24,8,2),
            new Atom("Am","Ameryk",95,148,243,13670,9,8,2,8,18,32,25,8,2),
            new Atom("Cm","Kiur",96,151,247,13510,9,9,2,8,18,32,25,9,2),
            new Atom("Bk","Berkel",97,150,247,14780,9,10,2,8,18,32,27,8,2),
            new Atom("Cf","Kaliforn",98,153,251,15100,9,11,2,8,18,32,28,8,2),
            new Atom("Es","Einstein",99,153,252,9,12,2,8,18,32,29,8,2),
            new Atom("Fm","Ferm",100,157,257,9,13,2,8,18,32,30,8,2),
            new Atom("Md","Mendelew",101,157,258,9,14,2,8,18,32,31,8,2),
            new Atom("No","Nobel",102,157,259,9,15,2,8,18,32,32,8,2),
            new Atom("Lr","Lorens",103,159,266,9,16,2,8,18,32,32,8,3),
            new Atom("Rf","Rutherford",104,163,267,7,4,2,8,18,32,32,10,2),
            new Atom("Db","Dubn",105,163,268,7,5,2,8,18,32,32,11,2),
            new Atom("Sg","Seabord",106,165,269,7,6,2,8,18,32,32,12,2),
            new Atom("Bh","Bohr",107,163,270,7,7,2,8,18,32,32,13,2),
            new Atom("Hs","Has",108,169,277,7,8,2,8,18,32,32,14,2),
            new Atom("Mt","Meitner",109,169,278,7,9,2,8,18,32,32,15,2),
            new Atom("Ds","Darmsztadt",110,171,281,7,10,2,8,18,32,32,17,1),
            new Atom("Rg","Roentgen",111,170,282,7,11,2,8,18,32,32,17,2),
            new Atom("Cn","Kopernik",112,173,285,7,12,2,8,18,32,32,18,2),
            new Atom("Nh","Nihon",113,173,286,7,13,2,8,18,32,32,18,3),
            new Atom("Fl","Flerow",114,175,289,7,14,2,8,18,32,32,18,4),
            new Atom("Mc","Moscow",115,174,290,7,15,2,8,18,32,32,18,5),
            new Atom("Lv","Liwermor",116,176,293,7,16,2,8,18,32,32,18,6),
            new Atom("Ts","Tenes",117,177,294,7,17,2,8,18,32,32,18,7),
            new Atom("Og","Oganeson",118,176,294,7,18,2,8,18,32,32,18,8)
        };
        private int[] help = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public MainPage()
        {
            this.InitializeComponent();
            //this.Display.Children.Add((UIElement)at[0].Display(6));
            for (int i = 0; i < at.Length; i++)
            {
                this.Tabela.Children.Add((UIElement)at[i].Display(2));
                this.Tabela.Children[i].PointerPressed += Highlight;
            }
            //this.Tabela.Children.Add((Grid)at[0].Information());
        }

        private void Highlight(object sender, PointerRoutedEventArgs e)
        {
            Grid siatka = (Grid)sender;
            if(this.Tabela.Children.Count == 1)
            {
                this.Tabela.Children.Clear();
                for (int i = 0; i < at.Length; i++)
                {
                    this.Tabela.Children.Add((UIElement)at[i].Display(2));
                    this.Tabela.Children[i].PointerPressed += Highlight;
                }
            }
            else
            {
                int j = this.Tabela.Children.IndexOf(siatka);
                this.Tabela.Children.Clear();
                this.Tabela.Children.Add((Grid)at[j].Information());
                this.Tabela.Children[0].PointerPressed += Highlight;
            }
        }
        private void Highlight_Search(object sender, PointerRoutedEventArgs e)
        {
            Grid siatka = (Grid)sender;
            int j = this.Search.Children.IndexOf(siatka);
            this.Display.Children.Clear();
            this.Display.Children.Add(at[this.help[j-1]].Display(6, false));
        }

        private void Szukanie(object sender, TextChangedEventArgs e)
        {
            for(int i = this.Search.Children.Count() - 1; i > 0; i--)
            {
                this.Search.Children.RemoveAt(i);
            }
            
            TextBox capture = (TextBox)sender;
            string Fraza = capture.Text;
            for(int i = 0; i < this.at.Length; i++)
            {
                int index = 1;
                if (at[i].Contains(Fraza)&&Fraza!="")
                {
                    this.help[index - 1] = i;
                    this.Search.Children.Add(at[i].Display(3,false));
                    this.Search.Children[index].PointerPressed += Highlight_Search;
                    index++;
                }
                if (index == 8)
                {
                    break;
                }
            }
        }
    }
}
