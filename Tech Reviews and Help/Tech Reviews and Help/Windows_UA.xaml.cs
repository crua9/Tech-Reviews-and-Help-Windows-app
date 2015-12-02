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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Tech_Reviews_and_Help
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Windows_UA : Page
    {
        public Windows_UA()
        {
            this.InitializeComponent();
            
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
                Frame.Navigate(typeof(WinUA_Hello_Viewer));
            //TitleTextBlock.Text = "Universal App Hello";
         
        }

        private void Map1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WindowsUA_Map));
        }
    }
}
