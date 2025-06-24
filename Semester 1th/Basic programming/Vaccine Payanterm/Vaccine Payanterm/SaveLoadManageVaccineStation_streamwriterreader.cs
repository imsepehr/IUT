using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Vaccine_Payanterm
{
    [Serializable]
    public class SaveLoadManageVaccineStation_streamwriterreader : ISaveLoadManageVaccineStation
    {
        public void SaveVaccineStationListToFile(string filepath, List<VaccineStation> stationlist)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            foreach (var station in stationlist)
            {

                writer.WriteLine(VaccineStation.VaccineStationToString(station));
            }
            writer.Close();
            //fs1.Close();
        }

        public List<VaccineStation> ReadVaccineStationListFromFile(string filepath)
        {
            List<VaccineStation> stationlist = new List<VaccineStation>();
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs1);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                stationlist.Add(VaccineStation.StringToVaccineStation(line));
            }
            //fs1.Close();

            reader.Close();
            return stationlist;

        }
    }
}
