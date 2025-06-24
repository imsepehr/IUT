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
    public class SaveLoadVSTime_serializer : ISaveLoadManageVaccineStationVSTime
    {
        public void SaveManageVaccineStationVSTimeListToFile(string filepath, List<DateTime> stationvstimelist)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(fs1, stationvstimelist);
           
            fs1.Close();


        }

        public List<DateTime> ReadManageVaccineStationVSTimeListFromFile(string filepath)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bformatter = new BinaryFormatter();
            List<DateTime> stationvstimelist = (List<DateTime>)bformatter.Deserialize(fs1);
            fs1.Close();
            return stationvstimelist;
        }
    }
}
