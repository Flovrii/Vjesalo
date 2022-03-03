using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static VješaloXD.upisivanjeRijeci;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VješaloXD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class multiplayer : Page
    {
        string word;
        int counterMiss = 0;
        List<Button> buttons;
        List<BitmapImage> images;
        List<TextBlock> fieldChar;
        public multiplayer()
        {
            this.InitializeComponent();
            images = new List<BitmapImage>();
            LoadImage();
            DoWordArea();
        }

        private void LoadImage()
        {
            for (int i = 1; i <= 7; i++)
            {
                var image = new BitmapImage(new Uri(@"ms-appx:/Images/pogreska" + i.ToString() + ".png"));
                images.Add(image);
            }
        }
        private string RandomWord()
        {
            string words = Global.multiplayerRijec;
            return words;
        }

        private void DoWordArea()
        {
            counterMiss = 0;
            CreateKeyboard();
            this.word = RandomWord();
            imageMiss.Source = images[0];
            fieldChar = new List<TextBlock>();
            wordArea.Children.Clear();
            for (int i = 0; i < this.word.Length; i++)
            {
                TextBlock textBlock = new TextBlock()
                {
                    Text = "_",
                    Margin = new Thickness(10),
                    FontSize = 72,
                    /* FontFamily = new FontFamily("Bradley Hand ITC"),*/
                };
                wordArea.Children.Add(textBlock);
                fieldChar.Add(textBlock);
            }
        }

        private void CreateKeyboard()
        {
            buttons = new List<Button>();
            firstRow.Children.Clear();
            secondRow.Children.Clear();
            thirdRow.Children.Clear();
            for (int i = 65; i < 91; i++)
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
            Button button = sender as Button;
            string character = button.Content.ToString();
            bool hit = false;
            for (int i = 0; i < this.word.Length; i++)
            {
                if (this.word[i].ToString().ToLower() == character.ToLower())
                {
                    hit = true;
                    fieldChar[i].Text = character.ToLower();
                }
            }
            if (hit == false)
            {
                counterMiss += 1;
                imageMiss.Source = images[counterMiss];
            }
            if (counterMiss == 6)
            {
                MessageToUserAsync("Krepo si!");
            }
            int count2 = 0;
            for (int i = 0; i < this.word.Length; i++)
            {
                if (fieldChar[i].Text != "_") count2++;
            }
            if (count2 == this.word.Length)
            {
                MessageToUserAsync("Čestitke! Prošao si level!");
                this.Frame.Navigate(typeof(singleplayer));
            }
            button.IsEnabled = false;
        }

        private async void MessageToUserAsync(string statement)
        {
            MessageDialog messageDialog = new MessageDialog("Igraj ponovno!", statement);
            await messageDialog.ShowAsync();
            DoWordArea();
        }


        private void gumbPrikaz1_Click(object sender, RoutedEventArgs e)
        {
            LoadImage();
            DoWordArea();
        }

        private async void povratak_button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            this.Frame.Navigate(typeof(selectMode));
        }
    }
}
