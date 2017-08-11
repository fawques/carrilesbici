using System;
using System.Collections.Generic;

namespace GtkUI
{
	[Newtonsoft.Json.JsonArray]
	public class Point
	{
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Point(double[] points)
		{
			X = points[0];
			Y = points[1];
		}

		public double X
		{
			get;
			set;
		}

		public double Y
		{
			get;
			set;
		}
	}
}