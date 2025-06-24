using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vaccine_Payanterm
{
    public interface ISaveLoadManageVaccineStationVSTime
    {
        void SaveManageVaccineStationVSTimeListToFile(string filepath, List<DateTime> stationvstimelist);
        List<DateTime> ReadManageVaccineStationVSTimeListFromFile(string filepath);
    }
    public interface ISaveLoadManageVaccineStation
    {
        void SaveVaccineStationListToFile(string filepath, List<VaccineStation> stationlist);
        List<VaccineStation> ReadVaccineStationListFromFile(string filepath);
    }

    [Serializable]
    public class ManageVaccineStation
    {
        private List<VaccineStation> stationlist { get; set; }
        private readonly string FilePath;
        private readonly ISaveLoadManageVaccineStation _SaveLoader;

        public ManageVaccineStation(string filePath, ISaveLoadManageVaccineStation saveLoader)
        {
            FilePath = filePath;
            _SaveLoader = saveLoader;
           
           
            stationlist = new List<VaccineStation>();

            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            else
                stationlist = _SaveLoader.ReadVaccineStationListFromFile(FilePath);

            //if (!File.Exists(VSTimeFilePath))
            //    File.Create(VSTimeFilePath).Close();
            //else
            //    VSTimes = _VSTimeSaveLoader.ReadManageVaccineStationVSTimeListFromFile(VSTimeFilePath);

        }


        public void AddVaccineStation(VaccineStation station,string vstimefilepath,ISaveLoadManageVaccineStationVSTime vstimesaveloader)
        {
            stationlist.Add(station);
            _SaveLoader.SaveVaccineStationListToFile(FilePath, stationlist);

            List<DateTime> vstimelist = new List<DateTime>();
            //DateTime dateTime = station.SDate;
            //while(station.EDate!=station.EDate)
            //{
            //    vstimelist.Add(station.SDate.AddMinutes(station.TimeSpan));
            //    station.SDate = station.SDate.AddMinutes(station.TimeSpan);
            //    //dateTime.AddMinutes(station.TimeSpan);
            //}
            for (int i = 0; i<station.Limit; i++)
            {
                vstimelist.Add(station.SDate.AddMinutes(station.TimeSpan));
                station.SDate = station.SDate.AddMinutes(station.TimeSpan);
            }
            vstimesaveloader.SaveManageVaccineStationVSTimeListToFile(vstimefilepath, vstimelist);
        }

        public void RemoveUser(VaccineStation station, string vstimefilepath)
        {
            stationlist.Remove(station);
            _SaveLoader.SaveVaccineStationListToFile(FilePath, stationlist);
            File.Delete(vstimefilepath);
        }

        public List<VaccineStation> PrintAllVaccineStation()
        {
            return stationlist;
        }


    }
}
