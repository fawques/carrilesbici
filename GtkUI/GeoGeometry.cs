using System.Collections.Generic;

namespace GtkUI
{
	public class GeoGeometry
	{
		public string Type { get; set; }
		public List<List<double>> Coordinates { get; set; }

		public override string ToString()
		{
			string s = $"{{Type: {Type}, Coordinates: [";
			foreach (var point in Coordinates)
			{
				s += $"({point[0]},{point[1]}), ";
			}
			s += "]";
			return s;
		}
	}
}