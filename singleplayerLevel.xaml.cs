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
        public string rijec2 = "tost";
        public string[] arrIspis;
        public string temp;
        private void gumbPrikaz_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < rijec2.Length; i++)
            {
                count++;
            }
            for (int i=0;i<count;i++)
            {
                temp += "_ ";
            }
            ispisRijeci.Text = temp;
        }

        
    }
}
