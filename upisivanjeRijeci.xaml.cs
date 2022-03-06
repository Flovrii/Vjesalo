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
    public sealed partial class upisivanjeRijeci : Page
    {
        public upisivanjeRijeci()
        {
            this.InitializeComponent();
        }
        public static class Global
        {
            public static string multiplayerRijec;

        }
        private async void gumbDalje_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mySound = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("click.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            mySound.SetSource(stream, file.ContentType);
            mySound.Play();
            Global.multiplayerRijec = upisRijeci.Text;
            this.Frame.Navigate(typeof(multiplayer));
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

        private void upisRijeci_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
