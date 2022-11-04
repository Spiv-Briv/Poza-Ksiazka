using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Race
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Racer[] racer = new Racer[5];
        private int msc = 1;
        Random random = new Random();
        public MainPage()
        {
            this.InitializeComponent();
            Generuj();
        }
        private void Generuj()
        {
            this.racer[0] = new Racer(1, random.Next(20, 40), 1, Windows.UI.Color.FromArgb(255, (byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
            Rectangle recta = new Rectangle();
            recta.Name = "R" + racer[0].RectId;
            recta.Fill = new SolidColorBrush(racer[0].Kolor);
            recta.Width = 100;
            recta.Height = 50;
            recta.HorizontalAlignment = HorizontalAlignment.Left;
            recta.Tapped += gracz_Click;
            this.Pole.Children.Add(recta);

            for (int i = 1; i < racer.Length; i++)
            {
                this.racer[i] = new Racer(i + 1, random.Next(20, 40), random.Next(1000, 2137), Windows.UI.Color.FromArgb(255, (byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
                Rectangle rect = new Rectangle();
                rect.Name = "R" + racer[i].RectId;
                rect.Fill = new SolidColorBrush(racer[i].Kolor);
                rect.Width = 100;
                rect.Height = 50;
                rect.HorizontalAlignment = HorizontalAlignment.Left;
                this.Pole.Children.Add(rect);
            }
        }
        private void Klatka()
        {

            for (int i = 0; i < racer.Length; i++)
            {
                racer[i].UpdatePos((float)(random.NextDouble() + 0.5));
                Rectangle rect = (Rectangle)FindName("R" + racer[i].RectId);
                if (rect != null)
                {
                    rect.Translation = racer[i].DisplayPos();
                    if (racer[i].CheckEnd() == true)
                    {
                        TextBlock text = new TextBlock();
                        Rectangle rectangle = new Rectangle();
                        rectangle.Name = "M" + racer[i].RectId;
                        rectangle.Fill = new SolidColorBrush(racer[i].Kolor);
                        rectangle.Width = 100;
                        rectangle.Height = 50;
                        rectangle.HorizontalAlignment = HorizontalAlignment.Right;
                        if (racer[i].Id == 1)
                        {
                            text.Text = msc + ". Ty";
                        }
                        else
                        {
                            text.Text = msc + ". Zawodnik " + racer[i].Id;
                        }

                        text.HorizontalAlignment = HorizontalAlignment.Right;
                        this.Wyniki.Children.Add(text);
                        this.Wyniki.Children.Add(rectangle);
                        this.Pole.Children.Remove(rect);
                        if (this.msc == this.racer.Length)
                        {
                            this.Start.IsEnabled = false;
                        }
                        this.msc++;
                    }
                }
            }
        }
        private void gracz_Click(object sender, RoutedEventArgs e)
        {
            Rectangle Gracz = sender as Rectangle;
            //racer[0].UpdatePos(5);

            //Gracz.Translation = racer[0].DisplayPos();
        }
        private void Zacznij(object sender, RoutedEventArgs e)
        {
            Klatka();
        }
    }
}
