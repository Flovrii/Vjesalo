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
    public sealed partial class singleplayer : Page
    {
        public static int globalIzbor;
        public string rijec;
        public string[] arrayRijec = {"slon", "bambi", "bmw","eminem" ,"nogomet" ,"aligator" ,"chevrolet" ,"ghostbusters" ,"metallica" ,"badminton","majmun" ,"lexus" ,"jumanji","subaru","titanic","hrvanje","mitsubishi","pingvin","odbojka","nirvana" };
        public singleplayer()
        {
            this.InitializeComponent();
        }

        private void gumbLevel1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
        }



        /*private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 2;
            rijec = arrayRijec[globalIzbor];
        }*/

    }
}
