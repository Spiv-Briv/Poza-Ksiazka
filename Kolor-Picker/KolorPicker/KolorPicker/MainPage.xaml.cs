using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Color = Windows.UI.Color;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace KolorPicker
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

        private void ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slider = (Slider)sender;
            if (slider.Name == "red")
            {
                this.redval.Text = slider.Value.ToString();
            }
            if (slider.Name == "green")
            {
                this.greval.Text = slider.Value.ToString();
            }
            if (slider.Name == "blue")
            {
                this.blueval.Text = slider.Value.ToString();
            }
            this.Kolor.Background = new SolidColorBrush(Color.FromArgb(255, (byte)this.red.Value, (byte)this.green.Value, (byte)this.blue.Value));
        }
    }
}
