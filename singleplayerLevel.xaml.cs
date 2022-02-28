using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
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
            CreateKeyboard();
            images = new List<BitmapImage>();
            LoadImage();
        }

        public int count = 0; // treba za zbroj za ispis _ u textblock
        public string rijecZaPog;
        public string[] arrIspis;
        public string temp;
        string word;

        List<Button> buttons;
        List<BitmapImage> images;
        private void LoadImage()
        {
            for(int i=0;i<7;i++)
            {
                var image = new BitmapImage(new Uri(@"ms-appx:/Images/pogreska" + i.ToString() + ".png"));
                images.Add(image);
            }
        }
        
        private string RandomWord()
        {
            string[] words = { "slon", "bambi", "bmw", "eminem", "nogomet", "aligator", "chevrolet", "ghostbusters", "metallica", "badminton", "majmun", "lexus", "jumanji", "subaru", "titanic", "hrvanje", "mitsubishi", "pingvin", "odbojka", "nirvana" };
            Random r = new Random();
            return words[r.Next(words.Length)];
        }
        /*
        private void DoWordArea()
        {
            CreateKeyboard();
            this.word = RandomWord();
            imageMiss.Source = images[0];
        }*/


        private void gumbPrikaz_Click(object sender, RoutedEventArgs e)
        {
            int temp2 = singleplayer.globalIzbor;
            rijecZaPog = RandomWord();
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



        private void CreateKeyboard()
        {
            buttons = new List<Button>();
            firstRow.Children.Clear();
            secondRow.Children.Clear();
            thirdRow.Children.Clear();
            for (int i=65;i<91;i++)
            {
                Button button = new Button()
                {
                    Content = ((char)i).ToString(),
                    FontSize = 55,
                    Width = 90,
                    Height = 90,
                    CornerRadius = new CornerRadius(10),
                    Margin = new Thickness(2),
                    FontFamily = new FontFamily("Bradley Hand ITC"),
                };
                button.Click += BT_Click_Key;
                if (i % 65 < 8) firstRow.Children.Add(button);
                else if (i % 65 >= 8 && i % 65 < 16) secondRow.Children.Add(button);
                else thirdRow.Children.Add(button);
                buttons.Add(button);
            }
        }

        private void BT_Click_Key(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            this.Frame.Navigate(typeof(singleplayer));
        }

    }
}
