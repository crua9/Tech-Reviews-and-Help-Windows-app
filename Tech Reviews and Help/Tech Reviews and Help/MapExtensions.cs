﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Maps;

namespace Tech_Reviews_and_Help
{
    public static class MapExtensions
    {
        public static GeoboundingBox GetViewArea(this MapControl map)
        {
            Geopoint p1, p2;
            map.GetLocationFromOffset(new Point(0, 0), out p1);
            map.GetLocationFromOffset(new Point(map.ActualWidth, map.ActualHeight), out p2);
            return new GeoboundingBox(p1.Position, p2.Position);
        }

        public static async void SetViewArea(this MapControl map, Geopoint p1, Geopoint p2)
        {
            var b = GeoboundingBox.TryCompute(new[] { p1.Position, p2.Position });
            await map.TrySetViewBoundsAsync(b, new Thickness(1.0), MapAnimationKind.Bow);
        }
    }
}
