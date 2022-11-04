using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace czat
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
        private void Send(object sender, RoutedEventArgs e)
        {
            Button user = (Button)sender;
            TextBox message = new TextBox();
            if (user.Name == "Sender")
            {
                message.Text = send_content.Text;
                message.Style = (Style)Resources["you"];
                send_content.Text = "";
            }
            else
            {
                message.Text = rec_mess.Text;
                message.Style = (Style)Resources["other"];
                rec_mess.Text = "";
            }

            Container.Children.Add(message);

        }
    }
}
