using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace Tech_Reviews_and_Help
{
    public class PointList
    {
        public PointList()
        {
            Points = new List<Geopoint>();
        }
        public string Name { get; set; }

        public List<Geopoint> Points { get; set; }

       
        public static IEnumerable<PointList> GetAreas()
        {
            var result = new List<PointList>
      {
        new PointList
        {
          Name = "Area1",
          Points = new List<Geopoint>
          {
            new Geopoint(new BasicGeoposition{Latitude = 38.900153, Longitude = -77.035057}),
            new Geopoint(new BasicGeoposition{Latitude = 38.900132, Longitude =  -77.033739}),
            new Geopoint(new BasicGeoposition{Latitude = 38.898905, Longitude =  -77.033744}),
            new Geopoint(new BasicGeoposition{Latitude = 38.898922 , Longitude = -77.034983})
          }
        }
      };
            return result;
        }

        public static IEnumerable<PointList> GetRandomPoints(Geopoint point1, Geopoint point2, int nrOfPoints)
        {
            var result = new List<PointList>();
            var p1 = new BasicGeoposition
            {
                Latitude = Math.Min(point1.Position.Latitude, point2.Position.Latitude),
                Longitude = Math.Min(point1.Position.Longitude, point2.Position.Longitude)
            };
            var p2 = new BasicGeoposition
            {
                Latitude = Math.Max(point1.Position.Latitude, point2.Position.Latitude),
                Longitude = Math.Max(point1.Position.Longitude, point2.Position.Longitude)
            };

            var dLat = p2.Latitude - p1.Latitude;
            var dLon = p2.Longitude - p1.Longitude;

            var r = new Random(DateTime.Now.Millisecond);
            for (var i = 0; i < nrOfPoints; i++)
            {
                var item = new PointList { Name = "Point " + i };
                item.Points.Add(new Geopoint(
                  new BasicGeoposition
                  {
                      Latitude = p1.Latitude + (r.NextDouble() * dLat),
                      Longitude = p1.Longitude + (r.NextDouble() * dLon)
                  }));
                result.Add(item);
            }
            return result;
        }
    }
}
