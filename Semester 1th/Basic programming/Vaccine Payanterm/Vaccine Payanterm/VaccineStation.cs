using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vaccine_Payanterm
{
    [Serializable]
    public class VaccineStation
    {
        public string Name { get; set; }
        public Adress VSAdress { get; set; }
        public DateTime SDate { get; set; }
        public DateTime EDate { get; set; }
        public int TimeSpan { get; set; }
        public int Limit { get; set; }



        public static string VaccineStationToString(VaccineStation vaccineStation)
        {
            return
                vaccineStation.Name + "," +
                vaccineStation.VSAdress.Country + "," +
                vaccineStation.VSAdress.City + "," +
                vaccineStation.VSAdress.Street + "," +
                vaccineStation.SDate + "," +
                vaccineStation.EDate + "," +
                vaccineStation.TimeSpan + "," +
                vaccineStation.Limit;
                
        }

        public static VaccineStation StringToVaccineStation(string vaccinestationtext)
        {
            string[] propertiesText = vaccinestationtext.Split(',');

            Adress adress = new Adress
            {
                Country = propertiesText[1],
                City = propertiesText[2],
                Street = propertiesText[3]

            };

            VaccineStation vaccineStation = new VaccineStation
            {
                Name = propertiesText[0],
                VSAdress = adress,
                SDate = Convert.ToDateTime(propertiesText[4]),
                EDate = Convert.ToDateTime(propertiesText[5]),
                TimeSpan = Convert.ToInt32(propertiesText[6]),
                Limit = Convert.ToInt32(propertiesText[7])


            };

            return vaccineStation;
        }

        
 

    }
}
