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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 1;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 2;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 3; 
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 4;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 5;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 6;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 7;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 8;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 9;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 10;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 11;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 12;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 13;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 14; 
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 15;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 16;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 17;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 18;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 19;
            rijec = arrayRijec[globalIzbor];
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 20;
            rijec = arrayRijec[globalIzbor];
        }
    }
}
