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
        public singleplayer()
        {
            this.InitializeComponent();
        }

        private void gumbLevel1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(singleplayerLevel));
            globalIzbor = 1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(selectMode));
        }

        private void gumbLevel3_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 3;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel4_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 4;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel5_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 5;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel2_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 2;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel6_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 6;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel7_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 7;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel8_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 8;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel9_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 9;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel10_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 10;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel11_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 11;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel12_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 12;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel13_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 13;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel14_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 14;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel15_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 15;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel16_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 16;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel17_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 17;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel18_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 18;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel19_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 19;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private void gumbLevel20_Click(object sender, RoutedEventArgs e)
        {
            globalIzbor = 20;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }
    }
}
