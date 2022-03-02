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

        private async void gumbLevel1_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            this.Frame.Navigate(typeof(singleplayerLevel));
            
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            this.Frame.Navigate(typeof(selectMode));
            
        }

        private async void gumbLevel3_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 3;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel4_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 4;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel5_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 5;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel2_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 2;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel6_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 6;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel7_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 7;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel8_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 8;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel9_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 9;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel10_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 10;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel11_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 11;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel12_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 12;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel13_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 13;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel14_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 14;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel15_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 15;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel16_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 16;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel17_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 17;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel18_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 18;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel19_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 19;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }

        private async void gumbLevel20_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            globalIzbor = 20;
            this.Frame.Navigate(typeof(singleplayerLevel));
        }
    }
}
