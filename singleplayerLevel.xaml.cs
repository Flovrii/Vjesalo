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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VješaloXD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class singleplayerLevel : Page
    {
        public singleplayerLevel()
        {
            this.InitializeComponent();
        }
        public int count = 0; // treba za zbroj za ispis _ u textblock
        public string rijecZaPog;
        public string[] arrIspis;
        public string[] arrayRijec = { "slon", "bambi", "bmw", "eminem", "nogomet", "aligator", "chevrolet", "ghostbusters", "metallica", "badminton", "majmun", "lexus", "jumanji", "subaru", "titanic", "hrvanje", "mitsubishi", "pingvin", "odbojka", "nirvana" };
        public string temp;
        public string[] arrayFulano;
        private void gumbPrikaz_Click(object sender, RoutedEventArgs e)
        {
            int temp2 = singleplayer.globalIzbor;
            rijecZaPog = arrayRijec[temp2];
            for (int i = 0; i < rijecZaPog.Length; i++)
            {
                count++;
            }
            for (int i=0;i<count;i++)
            {
                temp += "_ ";
            }
            ispisRijeci.Text = temp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayer));
        }

    }
}
