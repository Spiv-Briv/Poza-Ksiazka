using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Mapa
{
    internal class Miasto
    {
        string Name;
        string Shortname;
        int ID;
        int X;
        int Y;
        Miasto[] Polo = new Miasto[4];
        public Miasto(int ID, string Name, string Shortname, int X, int Y)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shortname = Shortname;
            this.X = X;
            this.Y = Y;
        }
        public Miasto(int ID, string Name, string Shortname, int X, int Y, Miasto N)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shortname = Shortname;
            this.X = X;
            this.Y = Y;
            this.Polo[0] = N;
        }
        public Miasto(int ID, string Name, string Shortname, int X, int Y, Miasto N, Miasto W)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shortname = Shortname;
            this.X = X;
            this.Y = Y;
            this.Polo[0] = N;
            this.Polo[1] = W;
        }
        public Miasto(int ID, string Name, string Shortname, int X, int Y, Miasto N, Miasto W, Miasto S)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shortname = Shortname;
            this.X = X;
            this.Y = Y;
            this.Polo[0] = N;
            this.Polo[1] = W;
            this.Polo[2] = S;
        }
        public Miasto(int ID, string Name, string Shortname, int X, int Y, Miasto N, Miasto W, Miasto S, Miasto E)
        {
            this.ID = ID;
            this.Name = Name;
            this.Shortname = Shortname;
            this.X = X;
            this.Y = Y;
            this.Polo[0] = N;
            this.Polo[1] = W;
            this.Polo[2] = S;
            this.Polo[3] = E;
        }
        public void Drogi(Miasto A, Miasto B, Miasto C, Miasto D)
        {
            this.Polo[0] = A;
            this.Polo[1] = B;
            this.Polo[2] = C;
            this.Polo[3] = D;
        }
        public TextBlock Pokaz()
        {
            TextBlock block = new TextBlock();
            block.Text = Name;
            block.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left;
            block.HorizontalTextAlignment = Windows.UI.Xaml.TextAlignment.Center;
            block.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;
            block.Width = 100;
            block.Height = 20;
            block.Margin = new Windows.UI.Xaml.Thickness(500 - (block.Width / 2) + X, 300 - (block.Height) + Y, 0, 0);
            block.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));

            return block;
        }
        public Line Polacz(int i)
        {
            Line linia = new Line();
            linia.X1 = 0;
            linia.X2 = 0;
            linia.Y1 = 0;
            linia.Y2 = 0;
            if (Polo[i] != null)
            {
                //Line linia = new Line();
                int roznicaX = Polo[i].X - this.X;
                int roznicaY = Polo[i].Y - this.Y;
                if (roznicaX < 0) roznicaX *= -1;
                if (roznicaY < 0) roznicaY *= -1;
                if (roznicaX > roznicaY)
                {
                    if (this.X < Polo[i].X)
                    {
                        linia.X1 = this.X + 500;
                        linia.X2 = Polo[i].X + 500;
                        linia.Y1 = this.Y + 290;
                        linia.Y2 = Polo[i].Y + 290;
                    }
                    if (this.X > Polo[i].X)
                    {
                        linia.X1 = Polo[i].X + 500;
                        linia.X2 = this.X + 500;
                        linia.Y1 = Polo[i].Y + 290;
                        linia.Y2 = this.Y + 290;
                    }
                }
                else
                {
                    if (this.Y < Polo[i].Y)
                    {
                        linia.X1 = this.X + 500;
                        linia.X2 = Polo[i].X + 500;
                        linia.Y1 = this.Y + 290;
                        linia.Y2 = Polo[i].Y + 290;
                    }
                    if (this.Y > Polo[i].Y)
                    {
                        linia.X1 = this.X + 500;
                        linia.X2 = Polo[i].X + 500;
                        linia.Y1 = this.Y + 290;
                        linia.Y2 = Polo[i].Y + 290;
                    }
                }
                linia.Stroke = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                linia.StrokeThickness = 1;
                return linia;
            }
            else
            {
                return linia;
            }
        }
    }
}
