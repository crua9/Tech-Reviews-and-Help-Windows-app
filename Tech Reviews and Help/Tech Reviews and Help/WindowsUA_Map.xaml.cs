using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class WindowsUA_Map : Page
    {
        public WindowsUA_Map()
        {
            this.InitializeComponent();
            WinUAMap.Style = MapStyle.Aerial3DWithRoads;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            WinUAMap.Center = new Windows.Devices.Geolocation.Geopoint(
                new Windows.Devices.Geolocation.BasicGeoposition()
                {
                    Latitude = 38.897663,
                    Longitude = -77.036554,
                });
            WinUAMap.ZoomLevel = 15;
            base.OnNavigatedTo(e);
        }

// button
     
        private void Shops(object sender, RoutedEventArgs e)
        {
            var strokeColor = Colors.DarkBlue;
            var fillColor = Colors.Blue;
            foreach (var dataobject in PointList.GetAreas())
            {
                var shape = new MapPolygon
                {
                    StrokeColor = strokeColor,
                    StrokeThickness = 3,
                    FillColor = fillColor,
                    StrokeDashed = false,
                    ZIndex = 3,
                    Path = new Geopath(dataobject.Points.Select(p => p.Position))
                };
                shape.AddData(dataobject);
                WinUAMap.MapElements.Add(shape);
            }
        }

       

        private void Clear(object sender, RoutedEventArgs e)
        {
            WinUAMap.MapElements.Clear();
        }


// zoom


        private void ZoomOut(object sender, RoutedEventArgs e)
        {
            var newZoom = WinUAMap.ZoomLevel - 1;
            if (newZoom < 1) newZoom = 1;
            WinUAMap.ZoomLevel = newZoom;
        }

        private void ZoomIn(object sender, RoutedEventArgs e)
        {
            var newZoom = WinUAMap.ZoomLevel + 1;
            if (newZoom > WinUAMap.MaxZoomLevel) newZoom = WinUAMap.MaxZoomLevel;
            WinUAMap.ZoomLevel = newZoom;
        }
    }
}
