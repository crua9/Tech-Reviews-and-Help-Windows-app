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
    public sealed partial class WinUA_Hello_Viewer : Page
    {
        public WinUA_Hello_Viewer()
        {
            this.InitializeComponent();
            Uri U = new Uri("https://www.youtube.com/");//https://www.youtube.com/watch?v=OLE5oAZanA4
            Video.Navigate(U);
        }

        private void Click_Me_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Hello Viewer";
           // textBlock.Visibility = true;
        }
    }
}
