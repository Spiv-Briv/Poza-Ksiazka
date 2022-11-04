using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Management;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Dane
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox Outp = new TextBox();
            Outp.BorderBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 255, 255));
            Outp.BorderThickness = new Thickness(1);
            Outp.IsReadOnly = true;
            Person Osoba = new Person();
            if (this.data.SelectedDate == null)
            {
                Osoba.SetData(this.Imie.Text, this.Nazwisko.Text, null);
            }
            else
            {
                byte wiek = (byte)(2022 - this.data.SelectedDate.Value.Year);
                Osoba.SetData(this.Imie.Text, this.Nazwisko.Text, wiek);
            }
            Outp.Text = Osoba.GetData();
            this.Output.Children.Add(Outp);
            this.Imie.Text = "";
            this.Nazwisko.Text = "";
            this.data.SelectedDate = null;
        }
    }
}
