using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Statki
{
    internal class Statek
    {
        private byte Rozmiar { get; }
        private byte Rotacja { get; }
        private byte PozycjaX { get; }
        private byte PozycjaY { get; }
        private bool Fill { get; }
        public Statek(byte rozmiar, byte rotacja, byte pozycjaX, byte pozycjaY, bool fill)
        {
            Rozmiar = rozmiar;
            Rotacja = rotacja;
            PozycjaX = pozycjaX;
            PozycjaY = pozycjaY;
            Fill = fill;
        }
        public byte GetV(int mod)
        {
            if (mod == 1) return Rozmiar;
            if (mod == 2) return Rotacja;
            if (mod == 3) return PozycjaX;
            if (mod == 4) return PozycjaY;
            return 255;
        }
        public Rectangle Wyswietl()
        {
            Rectangle st = new Rectangle();
            if (Fill == true) st.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 150, 250));
            else st.Name = "Preview";
            st.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            st.HorizontalAlignment = HorizontalAlignment.Left;
            st.VerticalAlignment = VerticalAlignment.Top;
            if (this.Rotacja == 1)
            {
                st.Width = 50;
                st.Height = 50 * this.Rozmiar;
            }
            else
            {
                st.Width = 50 * this.Rozmiar;
                st.Height = 50;
            }
            st.Margin = new Thickness((PozycjaX - 1) * 50, (PozycjaY - 1) * 50, 0, 0);
            return st;
        }
        public Rectangle Wyswietl(byte Enemy, bool hit)
        {
            Rectangle st = new Rectangle();
            if (Fill == true)
                if (Enemy == 1)
                    if (hit == true) st.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 255, 0));
                    else st.Fill = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
                else
                    if (hit == true) st.Fill = new SolidColorBrush(Color.FromArgb(100, 255, 0, 0));
                else st.Fill = new SolidColorBrush(Color.FromArgb(100, 0, 0, 0));

            else st.Name = "Preview";
            if (Enemy == 1)
                if (hit == true) st.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                else st.Stroke = new SolidColorBrush(Color.FromArgb(255, 200, 200, 200));
            else
                    if (hit == true) st.Stroke = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            else st.Stroke = new SolidColorBrush(Color.FromArgb(255, 50, 50, 50));
            st.HorizontalAlignment = HorizontalAlignment.Left;
            st.VerticalAlignment = VerticalAlignment.Top;
            if (this.Rotacja == 1)
            {
                st.Width = 50;
                st.Height = 50 * this.Rozmiar;
            }
            else
            {
                st.Width = 50 * this.Rozmiar;
                st.Height = 50;
            }
            st.Margin = new Thickness((PozycjaX - 1) * 50, (PozycjaY - 1) * 50, 0, 0);
            return st;
        }
    }
}
