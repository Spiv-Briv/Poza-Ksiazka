using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Mapa
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Miasto[] City = {
            null,
            new Miasto(1, "Gorzów Wlkp.", "GOR", 0, 0),
            new Miasto(2, "Klodawa", "KLO", -16, -64),
            new Miasto(3, "Santok", "SAN", 117, -6),
            new Miasto(4, "Nowiny Wlk.","NOW",-154,66),
            new Miasto(5, "Deszczno", "DES", 46,66),
            new Miasto(6, "Strzelce Kraj.", "STR", 195, -160),
            new Miasto(7, "Krzeszyce", "KRE", -155, 161),
            new Miasto(8, "Kostrzyn n/O.", "KOS", -392, 168),
            new Miasto(9, "Skwierzyna", "SKW", 179, 154),
            new Miasto(10, "Dębno", "DEB", -364, -5)
            //new Miasto(, "Baczyna", "BAC", )
        };
        private int[,] pol = {
            {0,0,0,0 },
            {2, 4, 5, 3},
            {0, 10, 1, 6 },
            {6, 1, 9, 0 },
            {10, 8, 7, 1 },
            {1, 4, 9, 7 },
            {0, 2, 3, 0 },
            {4, 8, 9, 5 },
            {10, 0, 0, 7 },
            {5, 7, 0, 3 },
            {0, 0, 8, 2 }
        };
        public MainPage()
        {
            this.InitializeComponent();

            for (int i = 1; i < City.Length; i++)
            {
                Mapa.Children.Add(City[i].Pokaz());


            }
            for (int i = 1; i < pol.Length / 4; i++)
            {
                City[i].Drogi(City[pol[i, 0]], City[pol[i, 1]], City[pol[i, 2]], City[pol[i, 3]]);
                Mapa.Children.Add(City[i].Polacz(0));
                Mapa.Children.Add(City[i].Polacz(1));
                Mapa.Children.Add(City[i].Polacz(2));
                Mapa.Children.Add(City[i].Polacz(3));

            }
        }
    }
}
