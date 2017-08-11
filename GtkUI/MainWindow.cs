using System;
using Gtk;
using GtkUI;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		var parser = new Parser();
		parser.GeoJsonFile = "CARRIL_BICI.geojson";
		parser.Parse();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
