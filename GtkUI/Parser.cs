using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using System.Linq;

namespace GtkUI
{
	public class Parser
	{
		public string GeoJsonFile { get; set; }

		public GeoInfo Parse()
		{
			System.IO.StreamReader file = new System.IO.StreamReader(GeoJsonFile, Encoding.GetEncoding("iso-8859-1"));
			string content = file.ReadToEnd();
			file.Close();

			GeoInfo deserialized = JsonConvert.DeserializeObject<GeoInfo>(content, new JsonSerializerSettings() { Culture = new System.Globalization.CultureInfo("es-ES") });
			foreach (var item in deserialized.Features)
			{
				Console.WriteLine(item);
				//listCarrilesBici.Add(new Path()
				//{
				//	GEO_ID = item.Properties.GEO_ID,
				//	LSAD = item.Properties.LSAD,
				//	NAME = item.Properties.NAME,
				//	STATE = item.Properties.STATE,
				//	COUNTY = item.Properties.COUNTY,
				//	CENSUSAREA = item.Properties.CENSUSAREA,
				//	coordinates = item.Geometry.Coordinates.ToString()
				//});
			}
			double maxCoord, minCoord;
			var doubleList = deserialized.Features.Select(f => f.Geometry).SelectMany(g => g.Coordinates).SelectMany(list => list).ToList();

			maxCoord = doubleList.Max();
			minCoord = doubleList.Min();
			Console.WriteLine($"MaxCoord={maxCoord}");
			Console.WriteLine($"MinCoord={minCoord}");

			var normalizedDoubleList = doubleList.Select(d => d / maxCoord);
			Console.WriteLine($"NewMinCoord={normalizedDoubleList.Min()}");

			return deserialized;
		}
	}
}
