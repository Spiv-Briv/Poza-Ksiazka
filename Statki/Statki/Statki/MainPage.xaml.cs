using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Statki
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Pole[] fi = { new Pole(), new Pole() };
        Pole[] hit = { new Pole(), new Pole() };
        Grid[] pola = new Grid[2];
        Statek[,] epik = new Statek[2, 10];
        byte side = 0;
        int[] Statki = { 4, 3, 2, 1 };
        int Sta_In = 3;
        byte or;
        bool edit = true;
        public MainPage()
        {
            this.InitializeComponent();
            pola[0] = (Grid)FindName("lewy");
            pola[1] = (Grid)FindName("prawy");
        }
        public void Dodaj(object sender, RoutedEventArgs e)
        {
            if (this.Pio.IsChecked == true)
            {
                or = 1;
            }
            else
            {
                or = 0;
            }
            Statek statek = new Statek((byte)this.Rozmiar.Value, or, (byte)this.X.Value, (byte)this.Y.Value, true);
            if (fi[side].CanTake(statek))
            {
                this.pola[side].Children.Add(statek.Wyswietl());
                fi[side].Take(statek, false);
                hit[side].Take(statek, true);
                this.X.Value = 1;
                this.Y.Value = 1;
                Statki[Sta_In]--;
                if (Statki[Sta_In] == 0)
                {
                    Sta_In--;
                }
                if (this.Sta_In == 0)
                {
                    this.Pio.IsEnabled = false;
                    this.Poz.IsEnabled = false;
                }
                if (this.Sta_In < 0)
                {
                    if (side == 0)
                    {
                        Statki[0] = 4;
                        Statki[1] = 3;
                        Statki[2] = 2;
                        Statki[3] = 1;
                        Sta_In = 3;
                        this.Pio.IsEnabled = true;
                        this.Poz.IsEnabled = true;
                        this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
                        side = 1;
                    }
                    else
                    {
                        this.Menu.Children.Remove(this.Pio);
                        this.Menu.Children.Remove(this.Poz);
                        this.Menu.Children.Remove(this.Rozmiar);
                        this.Menu.Children.Remove(this.dodaj);
                        Button button = new Button();
                        button.Name = "Killer";
                        button.Click += Atak;
                        button.Content = "Zaatakuj";
                        this.Menu.Children.Add(button);
                        this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
                        this.edit = false;
                    }

                }
                this.Rozmiar.Value = Sta_In + 1;
                this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
            }
        }
        private void Atak(object sender, RoutedEventArgs e)
        {
            Statek statek = new Statek(1, 0, (byte)this.X.Value, (byte)this.Y.Value, true);
            this.pola[side].Children.Add(statek.Wyswietl(side, !hit[side].CanTake(statek)));
            if (side == 1) side = 0;
            else side = 1;

        }
        private void Preview(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (edit)
            {
                if (this.Pio != null)
                {
                    if (this.Pio.IsChecked == true)
                    {
                        or = 1;
                        if (Y.Value + this.Rozmiar.Value - 1 > 10)
                        {
                            Y.Value = 11 - this.Rozmiar.Value;
                        }
                    }
                    else
                    {
                        or = 0;
                        if (X.Value + this.Rozmiar.Value - 1 > 10)
                        {
                            X.Value = 11 - this.Rozmiar.Value;
                        }
                    }
                    if (FindName("Preview") != null) this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
                    Statek statek = new Statek((byte)this.Rozmiar.Value, or, (byte)this.X.Value, (byte)this.Y.Value, false);
                    if (this.pola[side] != null) this.pola[side].Children.Add(statek.Wyswietl());
                }
            }
            else
            {
                if (FindName("Preview") != null) this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
                Statek statek = new Statek(1, 0, (byte)this.X.Value, (byte)this.Y.Value, false);
                if (this.pola[side] != null) this.pola[side].Children.Add(statek.Wyswietl());
            }
        }

        private void Preview2(object sender, RoutedEventArgs e)
        {
            if (this.Pio.IsChecked == true)
            {
                or = 1;
                if (Y.Value + this.Rozmiar.Value - 1 > 10)
                {
                    Y.Value = 11 - this.Rozmiar.Value;
                }
            }
            else
            {
                or = 0;
                if (X.Value + this.Rozmiar.Value - 1 > 10)
                {
                    X.Value = 11 - this.Rozmiar.Value;
                }
            }

            if (FindName("Preview") != null) this.pola[side].Children.Remove((Rectangle)FindName("Preview"));
            Statek statek = new Statek((byte)this.Rozmiar.Value, or, (byte)this.X.Value, (byte)this.Y.Value, false);
            if (this.pola[side] != null) this.pola[side].Children.Add(statek.Wyswietl());
        }
    }
}
