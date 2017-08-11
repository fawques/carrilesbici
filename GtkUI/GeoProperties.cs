namespace GtkUI
{
	public class GeoProperties
	{
		public string ID { get; set; }
		public string CODI_CAPA { get; set; }
		public string CODI_SUBCA { get; set; }
		public string TOOLTIP { get; set; }


		public override string ToString()
		{
			return $"{{ID: {ID}, TOOLTIP: {TOOLTIP}}}";
		}
	}
}