using System;
namespace GtkUI
{
	public class GeoFeature
	{
		public GeoProperties Properties { get; set; }

		public GeoGeometry Geometry { get; set; }

		public string Type { get; set; }

		public override string ToString()
		{
			return Properties + "-" + Geometry;
		}
	}
}
