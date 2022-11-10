using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Core.Direct;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace TablicaMendelejewa
{
    internal class Atom
    {
        private string Symbol { get; }
        private string Nazwa { get; }
        private int Proton { get; }
        private int Neutron { get; }
        private int Elektron { get; }
        private double? Gestosc { get; }
        private double Masa { get; }
        private int Okres { get; }
        private int Grupa { get; }
        private int[] Powloki { get; }
        /*public Atom(string symbol, string nazwa, int proton, int neutron, int elektron, double masa, double? gestosc, int okres, int grupa, int pow1, int pow2, int pow3, int pow4, int pow5, int pow6, int pow7)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Proton = proton;
            Neutron = neutron;
            Elektron = elektron;
            Gestosc = gestosc;
            Masa = masa;
            Okres = okres;
            Grupa = grupa;
        }*/
        public Atom(string symbol, string nazwa, int proton, int neutron, double masa, double? gestosc, int okres, int grupa, int pow1, int pow2, int pow3, int pow4, int pow5, int pow6, int pow7)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Proton = proton;
            Neutron = neutron;
            Elektron = proton;
            Gestosc = gestosc;
            Masa = masa;
            Okres = okres;
            Grupa = grupa;
            Powloki = new int[] { pow1, pow2, pow3, pow4, pow5, pow6, pow7};
        }
        public Atom(string symbol, string nazwa, int proton, int neutron, double masa, int okres, int grupa, int pow1, int pow2, int pow3, int pow4, int pow5, int pow6, int pow7)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Proton = proton;
            Neutron = neutron;
            Elektron = proton;
            Gestosc = null;
            Masa = masa;
            Okres = okres;
            Grupa = grupa;
            Powloki = new int[] { pow1, pow2, pow3, pow4, pow5, pow6, pow7 };
        }
        public string GetNazwa()
        {
            return this.Nazwa;
        }
        public Grid Display(int size)
        {
            int Scale = 4;

            Grid Siatka = new Grid();
            TextBlock Symbol = new TextBlock();
            TextBlock Nazwa = new TextBlock();
            TextBlock atNum = new TextBlock();
            TextBlock MassNum = new TextBlock();
            TextBlock AtCont = new TextBlock();
            TextBlock Dens = new TextBlock();

            Symbol.Text = this.Symbol;
            Nazwa.Text = this.Nazwa;
            atNum.Text = this.Proton.ToString();
            MassNum.Text = this.Masa.ToString();
            AtCont.Text = "p: " + this.Proton + "\nn: " + this.Neutron + "\ne: " + this.Elektron;
            if (this.Gestosc == null)
            {
                Dens.Text = "";
            }
            else
            {
                Dens.Text = this.Gestosc + "kg/m3";
            }

            Symbol.VerticalAlignment = VerticalAlignment.Center;
            Symbol.HorizontalAlignment = HorizontalAlignment.Center;
            Symbol.FontWeight = FontWeights.SemiBold;

            Nazwa.VerticalAlignment = VerticalAlignment.Center;
            Nazwa.HorizontalAlignment = HorizontalAlignment.Center;
            Nazwa.FontStyle = FontStyle.Italic;


            atNum.HorizontalAlignment = HorizontalAlignment.Left;

            MassNum.HorizontalAlignment = HorizontalAlignment.Right;

            AtCont.VerticalAlignment = VerticalAlignment.Bottom;
            AtCont.HorizontalAlignment = HorizontalAlignment.Left;

            Dens.VerticalAlignment = VerticalAlignment.Bottom;
            Dens.HorizontalAlignment = HorizontalAlignment.Right;

            Siatka.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 170, 170));
            Siatka.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 255));

            Symbol.Foreground = Nazwa.Foreground = atNum.Foreground = MassNum.Foreground = AtCont.Foreground = Dens.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
            Symbol.FontFamily = Nazwa.FontFamily = atNum.FontFamily = MassNum.FontFamily = AtCont.FontFamily = Dens.FontFamily = new FontFamily("Calibri");
            if (size == 0)
            {
                Scale = 1;

                Siatka.Height = 24;
                Siatka.Width = 18;
                Siatka.CornerRadius = new CornerRadius(1);
                Siatka.BorderThickness = new Thickness(0, 0, 1, 2);

                Symbol.FontSize = 12;
                Symbol.FontWeight = FontWeights.Normal;

                atNum.Text = "";
                Dens.Text = "";
                AtCont.Text = "";
                MassNum.Text = "";
                Nazwa.Text = "";
            }
            if (size == 1)
            {
                Scale = 2;

                Siatka.Height = 40;
                Siatka.Width = 30;
                Siatka.Padding = new Thickness(1);
                Siatka.CornerRadius = new CornerRadius(2);
                Siatka.BorderThickness = new Thickness(0, 0, 1, 2);

                Symbol.Margin = new Thickness(0, 6, 0, 0);

                Symbol.FontSize = 18;
                atNum.FontSize = 11;

                Dens.Text = "";
                AtCont.Text = "";
                MassNum.Text = "";
                Nazwa.Text = "";
            }
            if (size == 2)
            {
                Scale = 3;

                Siatka.Height = 60;
                Siatka.Width = 45;
                Siatka.Padding = new Thickness(1);
                Siatka.CornerRadius = new CornerRadius(3);
                Siatka.BorderThickness = new Thickness(0, 0, 2, 3);

                Nazwa.Margin = new Thickness(0, 19, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 14);

                Symbol.FontSize = 22;
                Nazwa.FontSize = 10;
                atNum.FontSize = MassNum.FontSize = 10;

                Dens.Text = "";
                AtCont.Text = "";
                MassNum.HorizontalAlignment = HorizontalAlignment.Center;
                MassNum.VerticalAlignment = VerticalAlignment.Bottom;
            }
            if (size == 3)
            {
                Scale = 3;

                Siatka.Height = 68;
                Siatka.Width = 51;
                Siatka.Padding = new Thickness(2);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 2, 3);

                Nazwa.Margin = new Thickness(0, 24, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 10);
                AtCont.Margin = new Thickness(0, 0, 0, 10);

                Symbol.FontSize = 26;
                Nazwa.FontSize = 11;
                AtCont.FontSize = Dens.FontSize = 9;
                atNum.FontSize = MassNum.FontSize = 10;

                AtCont.Text = "";
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 4)
            {
                Scale = 4;

                Siatka.Height = 80;
                Siatka.Width = 60;
                Siatka.Padding = new Thickness(3);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 3, 4);

                Nazwa.Margin = new Thickness(0, 32, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 10);
                AtCont.Margin = new Thickness(0, 0, 0, 10);

                Symbol.FontSize = 30;
                Nazwa.FontSize = 12;
                AtCont.FontSize = Dens.FontSize = 9;
                atNum.FontSize = MassNum.FontSize = 10;

                AtCont.Text = "";
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 5)
            {
                Scale = 4;

                Siatka.Height = 100;
                Siatka.Width = 75;
                Siatka.Padding = new Thickness(5);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 3, 4);

                Nazwa.Margin = new Thickness(0, 17, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 30);
                AtCont.Margin = new Thickness(0, 0, 0, 13);

                Symbol.FontSize = 38;
                Nazwa.FontSize = 12;
                AtCont.FontSize = Dens.FontSize = 10;
                atNum.FontSize = MassNum.FontSize = 11;

                AtCont.Text = "p: " + this.Proton + "  n: " + this.Neutron + "  e: " + this.Elektron;
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 6)
            {
                Scale = 5;

                Siatka.Height = 160;
                Siatka.Width = 120;
                Siatka.Padding = new Thickness(7);
                Siatka.CornerRadius = new CornerRadius(15);
                Siatka.BorderThickness = new Thickness(0, 0, 4, 7);

                Nazwa.Margin = new Thickness(0, 28, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 48);

                Symbol.FontSize = 60;
                Nazwa.FontSize = 19;
                AtCont.FontSize = Dens.FontSize = 13;
                atNum.FontSize = MassNum.FontSize = 18;
            }
            if (size == 7)
            {
                Scale = 5;

                Siatka.Height = 200;
                Siatka.Width = 150;
                Siatka.Padding = new Thickness(7);
                Siatka.CornerRadius = new CornerRadius(15);
                Siatka.BorderThickness = new Thickness(0, 0, 4, 7);

                Nazwa.Margin = new Thickness(0, 35, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 60);

                Symbol.FontSize = 76;
                Nazwa.FontSize = 24;
                AtCont.FontSize = Dens.FontSize = 16;
                atNum.FontSize = MassNum.FontSize = 22;
            }
            Siatka.Children.Add(Nazwa);
            Siatka.Children.Add(Symbol);
            Siatka.Children.Add(AtCont);
            Siatka.Children.Add(atNum);
            Siatka.Children.Add(MassNum);
            Siatka.Children.Add(Dens);

            if (Okres <= 7)
            {
                Siatka.Margin = new Thickness(Scale * (Grupa - 1) + Siatka.Width * (Grupa - 1), Scale * (Okres - 1) + Siatka.Height * (Okres - 1), 0, 0);
            }
            else
            {
                Siatka.Margin = new Thickness(Scale * (Grupa + 5) + Siatka.Width * (Grupa - 1), Scale * (Okres + 8) + Siatka.Height * (Okres - 1), 0, 0);
            }

            Siatka.PointerEntered += MouseHoverOn;
            Siatka.PointerExited += MouseHoverOff;
            return Siatka;
        }
        public Grid Display(int size, bool margin)
        {
            int Scale = 4;

            Grid Siatka = new Grid();
            TextBlock Symbol = new TextBlock();
            TextBlock Nazwa = new TextBlock();
            TextBlock atNum = new TextBlock();
            TextBlock MassNum = new TextBlock();
            TextBlock AtCont = new TextBlock();
            TextBlock Dens = new TextBlock();

            Symbol.Text = this.Symbol;
            Nazwa.Text = this.Nazwa;
            atNum.Text = this.Proton.ToString();
            MassNum.Text = this.Masa.ToString();
            AtCont.Text = "p: " + this.Proton + "\nn: " + this.Neutron + "\ne: " + this.Elektron;
            if (this.Gestosc == null)
            {
                Dens.Text = "";
            }
            else
            {
                Dens.Text = this.Gestosc + "kg/m3";
            }
            
            Symbol.VerticalAlignment = VerticalAlignment.Center;
            Symbol.HorizontalAlignment = HorizontalAlignment.Center;
            Symbol.FontWeight = FontWeights.SemiBold;

            Nazwa.VerticalAlignment = VerticalAlignment.Center;
            Nazwa.HorizontalAlignment = HorizontalAlignment.Center;
            Nazwa.FontStyle = FontStyle.Italic;
            

            atNum.HorizontalAlignment = HorizontalAlignment.Left;
            
            MassNum.HorizontalAlignment = HorizontalAlignment.Right;
            
            AtCont.VerticalAlignment = VerticalAlignment.Bottom;
            AtCont.HorizontalAlignment = HorizontalAlignment.Left;
            
            Dens.VerticalAlignment = VerticalAlignment.Bottom;
            Dens.HorizontalAlignment = HorizontalAlignment.Right;
            
            Siatka.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 170, 170));
            Siatka.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 255));

            Symbol.Foreground = Nazwa.Foreground = atNum.Foreground = MassNum.Foreground = AtCont.Foreground = Dens.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
            Symbol.FontFamily = Nazwa.FontFamily = atNum.FontFamily = MassNum.FontFamily = AtCont.FontFamily = Dens.FontFamily = new FontFamily("Calibri");
            if (size == 0)
            {
                Scale = 1;

                Siatka.Height = 24;
                Siatka.Width = 18;
                Siatka.CornerRadius = new CornerRadius(1);
                Siatka.BorderThickness = new Thickness(0, 0, 1, 2);

                Symbol.FontSize = 12;
                Symbol.FontWeight = FontWeights.Normal;

                atNum.Text = "";
                Dens.Text = "";
                AtCont.Text = "";
                MassNum.Text = "";
                Nazwa.Text = "";
            }
            if (size == 1)
            {
                Scale = 2;

                Siatka.Height = 40;
                Siatka.Width = 30;
                Siatka.Padding = new Thickness(1);
                Siatka.CornerRadius = new CornerRadius(2);
                Siatka.BorderThickness = new Thickness(0, 0, 1, 2);

                Symbol.Margin = new Thickness(0, 6, 0, 0);

                Symbol.FontSize = 18;
                atNum.FontSize = 11;

                Dens.Text = "";
                AtCont.Text = "";
                MassNum.Text = "";
                Nazwa.Text = "";
            }
            if (size == 2)
            {
                Scale = 3;

                Siatka.Height = 60;
                Siatka.Width = 45;
                Siatka.Padding = new Thickness(1);
                Siatka.CornerRadius = new CornerRadius(3);
                Siatka.BorderThickness = new Thickness(0, 0, 2, 3);

                Nazwa.Margin = new Thickness(0, 19, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 14);

                Symbol.FontSize = 22;
                Nazwa.FontSize = 10;
                atNum.FontSize = MassNum.FontSize = 10;

                Dens.Text = "";
                AtCont.Text = "";
                MassNum.HorizontalAlignment = HorizontalAlignment.Center;
                MassNum.VerticalAlignment = VerticalAlignment.Bottom;
            }
            if (size == 3)
            {
                Scale = 3;

                Siatka.Height = 68;
                Siatka.Width = 51;
                Siatka.Padding = new Thickness(2);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 2, 3);

                Nazwa.Margin = new Thickness(0, 24, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 10);
                AtCont.Margin = new Thickness(0, 0, 0, 10);

                Symbol.FontSize = 26;
                Nazwa.FontSize = 11;
                AtCont.FontSize = Dens.FontSize = 9;
                atNum.FontSize = MassNum.FontSize = 10;

                AtCont.Text = "";
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 4)
            {
                Scale = 4;

                Siatka.Height = 80;
                Siatka.Width = 60;
                Siatka.Padding = new Thickness(3);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 3, 4);

                Nazwa.Margin = new Thickness(0, 32, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 10);
                AtCont.Margin = new Thickness(0, 0, 0, 10);

                Symbol.FontSize = 30;
                Nazwa.FontSize = 12;
                AtCont.FontSize = Dens.FontSize = 9;
                atNum.FontSize = MassNum.FontSize = 10;

                AtCont.Text = "";
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 5)
            {
                Scale = 4;

                Siatka.Height = 100;
                Siatka.Width = 75;
                Siatka.Padding = new Thickness(5);
                Siatka.CornerRadius = new CornerRadius(5);
                Siatka.BorderThickness = new Thickness(0, 0, 3, 4);

                Nazwa.Margin = new Thickness(0, 17, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 30);
                AtCont.Margin = new Thickness(0, 0, 0, 13);

                Symbol.FontSize = 38;
                Nazwa.FontSize = 12;
                AtCont.FontSize = Dens.FontSize = 10;
                atNum.FontSize = MassNum.FontSize = 11;

                AtCont.Text = "p: " + this.Proton + "  n: " + this.Neutron + "  e: " + this.Elektron;
                AtCont.HorizontalAlignment = HorizontalAlignment.Center;
                Dens.HorizontalAlignment = HorizontalAlignment.Center;
            }
            if (size == 6)
            {
                Scale = 5;

                Siatka.Height = 160;
                Siatka.Width = 120;
                Siatka.Padding = new Thickness(7);
                Siatka.CornerRadius = new CornerRadius(15);
                Siatka.BorderThickness = new Thickness(0, 0, 4, 7);

                Nazwa.Margin = new Thickness(0, 28, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 48);

                Symbol.FontSize = 60;
                Nazwa.FontSize = 19;
                AtCont.FontSize = Dens.FontSize = 13;
                atNum.FontSize = MassNum.FontSize = 18;
            }
            if (size == 7)
            {
                Scale = 5;

                Siatka.Height = 200;
                Siatka.Width = 150;
                Siatka.Padding = new Thickness(7);
                Siatka.CornerRadius = new CornerRadius(15);
                Siatka.BorderThickness = new Thickness(0, 0, 4, 7);

                Nazwa.Margin = new Thickness(0, 35, 0, 0);
                Symbol.Margin = new Thickness(0, 0, 0, 60);

                Symbol.FontSize = 76;
                Nazwa.FontSize = 24;
                AtCont.FontSize = Dens.FontSize = 16;
                atNum.FontSize = MassNum.FontSize = 22;
            }
            Siatka.Children.Add(Nazwa);
            Siatka.Children.Add(Symbol);
            Siatka.Children.Add(AtCont);
            Siatka.Children.Add(atNum);
            Siatka.Children.Add(MassNum);
            Siatka.Children.Add(Dens);
            Siatka.Name = this.Nazwa;

            if (Okres <= 7 && margin)
            {
                Siatka.Margin = new Thickness(Scale * (Grupa - 1) + Siatka.Width * (Grupa - 1), Scale * (Okres - 1) + Siatka.Height * (Okres - 1), 0, 0);
            }
            else
            {
                Siatka.Margin = new Thickness(0);
            }

            Siatka.VerticalAlignment = VerticalAlignment.Bottom;
            Siatka.PointerEntered += MouseHoverOn;
            Siatka.PointerExited += MouseHoverOff;
            return Siatka;
        }
        public bool Contains(string Fraza)
        {
            for(int i = 0; i < this.Nazwa.Length - Fraza.Length+1; i++)
            {
                bool equal = true;
                string nazwa_low = this.Nazwa.ToLower();
                string phrase = Fraza.ToLower();
                for(int j = 0; j < phrase.Length; j++)
                {
                    if (nazwa_low[i + j] != phrase[j])
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    return true;
                }
            }
            return false;
        }
        public Grid Information()
        {
            Grid Siatka = new Grid();
            TextBlock Symbol = new TextBlock();
            TextBlock Nazwa = new TextBlock();
            TextBlock atNum = new TextBlock();
            TextBlock MassNum = new TextBlock();
            TextBlock Prot = new TextBlock();
            TextBlock Neut = new TextBlock();
            TextBlock Elek = new TextBlock();
            TextBlock Dens = new TextBlock();
            TextBlock Powloki = new TextBlock();

            Symbol.Text = "Symbol: " + this.Symbol;
            Nazwa.Text = this.Nazwa;
            atNum.Text = "Liczba atomowa: " + this.Proton.ToString();
            MassNum.Text = "Masa atomowa (u): " + this.Masa.ToString();
            Prot.Text = "Protony: " + this.Proton;
            Neut.Text = "Neutrony: " + this.Neutron;
            Elek.Text = "Elektrony: " + this.Elektron;
            if (this.Gestosc == null)
            {
                Dens.Text = "Gęstość nieznana";
            }
            else
            {
                Dens.Text = "Gęstość: " + this.Gestosc + "kg/m3 (" + Math.Round((double)this.Gestosc/997,4) + " gęstości wody)";

            }
            Powloki.Text = "Położenie elektronów na powłokach elektronowych: " + this.Powloki[0].ToString();
            for(int i = 1; i < this.Powloki.Length; i++)
            {
                if (this.Powloki[i] != 0)
                {
                    Powloki.Text += ", " + this.Powloki[i];
                }
            }

            Siatka.Width = 800;
            Siatka.Height = 600;
            Siatka.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 170, 170));
            Siatka.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 235, 235));
            Siatka.Padding = new Thickness(15);
            Siatka.CornerRadius = new CornerRadius(25);
            Siatka.BorderThickness = new Thickness(0, 0, 7, 15);
            Siatka.Margin = new Thickness(25);

            Symbol.Foreground = Nazwa.Foreground = atNum.Foreground = MassNum.Foreground = Prot.Foreground = Neut.Foreground = Elek.Foreground = Dens.Foreground = Powloki.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0));
            Symbol.FontFamily = Nazwa.FontFamily = atNum.FontFamily = MassNum.FontFamily = Prot.FontFamily = Neut.FontFamily = Elek.FontFamily = Dens.FontFamily = Powloki.FontFamily = new FontFamily("Calibri");

            Nazwa.Margin = new Thickness(0, 0, 0, 0);
            Nazwa.FontSize = 48;
            Nazwa.FontWeight = FontWeights.Bold;
            Nazwa.HorizontalAlignment = HorizontalAlignment.Center;

            Symbol.FontSize = 36;
            Symbol.Margin = new Thickness(0, 50, 0, 0);

            atNum.FontSize = 32;
            atNum.Margin = new Thickness(0,100,0,0);

            MassNum.HorizontalAlignment = HorizontalAlignment.Right;
            MassNum.FontSize = 28;
            MassNum.Margin = new Thickness(0, 100, 0, 0);

            Dens.FontSize = 28;
            Dens.Margin = new Thickness(0, 150, 0, 0);

            Powloki.FontSize = Prot.FontSize = Neut.FontSize = Elek.FontSize = 24;
            Prot.Margin = new Thickness(0, 200, 0, 0);
            Neut.Margin = new Thickness(200, 200, 0, 0);
            Elek.Margin = new Thickness(425, 200, 0, 0);
            Powloki.Margin = new Thickness(0, 250, 0, 0);
            
            StackPanel stak = new StackPanel();
            stak.Orientation = Orientation.Horizontal;
            stak.VerticalAlignment = VerticalAlignment.Bottom;
            stak.HorizontalAlignment = HorizontalAlignment.Right;
            stak.Spacing = 5;
            for(int i = 0; i <= 7; i++)
            {
                stak.Children.Add(Display(i,false));
            }

            Siatka.Children.Add(Nazwa);
            Siatka.Children.Add(Symbol);
            Siatka.Children.Add(Prot);
            Siatka.Children.Add(Neut);
            Siatka.Children.Add(Elek);
            Siatka.Children.Add(atNum);
            Siatka.Children.Add(MassNum);
            Siatka.Children.Add(Dens);
            Siatka.Children.Add(Powloki);
            Siatka.Children.Add(stak);
            

            return Siatka;
        }
            private void MouseHoverOff(object sender, PointerRoutedEventArgs e)
        {
            Grid Siatka = (Grid)sender;
            Siatka.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 255));
            Siatka.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 170, 170));
        }

        private void MouseHoverOn(object sender, PointerRoutedEventArgs e)
        {
            Grid Siatka = (Grid)sender;
            Siatka.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255,125,255,255));
            Siatka.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 200, 200));
        }
    }
}
