using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using WebApplication1.DTO;
namespace WebApplication1.Models
{
    public class HomeModel
    {
        public string getCarriles()
        {

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\SilviaD\\Documents\\Visual Studio 2013\\Projects\\WebApplication1\\WebApplication1\\CARRIL_BICI.geojson", Encoding.GetEncoding("iso-8859-1"));
            string content = file.ReadToEnd();
            file.Close();

            string a = JsonConvert.DeserializeObject(content, new JsonSerializerSettings() { Culture = new System.Globalization.CultureInfo("es-ES") }).ToString();
            return a;
            /*List<CarrilesBici> listCarrilesBici = new List<CarrilesBici>();
            foreach (var item in deserialized.features)
            {
                listCarrilesBici.Add(new CarrilesBici()
                {
                    GEO_ID = item.properties.GEO_ID,
                    LSAD = item.properties.LSAD,
                    NAME = item.properties.NAME,
                    STATE = item.properties.STATE,
                    COUNTY = item.properties.COUNTY,
                    CENSUSAREA = item.properties.CENSUSAREA,
                    coordinates = item.geometry.coordinates.ToString()
                });
            }*/
        }
	}
}