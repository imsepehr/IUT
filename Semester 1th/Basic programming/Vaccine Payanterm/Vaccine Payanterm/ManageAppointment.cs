using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Vaccine_Payanterm
{
    public interface ISaveLoadManageAppointment
    {
        void SaveAppointmentListToFile(string filepath, List<Appointment> userlist);
        List<Appointment> ReadAppointmentListFromFile(string filepath);
    }
    [Serializable]
    class ManageAppointment
    {
        private readonly string FilePath;
        private List<Appointment> AppointmentList { get; set; }
        private readonly ISaveLoadManageAppointment _SaveLoader;

        public ManageAppointment(string filePath, ISaveLoadManageAppointment saveLoader)
        {
            FilePath = filePath;
            _SaveLoader = saveLoader;
            AppointmentList = new List<Appointment>();

            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            else
                AppointmentList = _SaveLoader.ReadAppointmentListFromFile(FilePath);
        }

        public void AddAppointment(Appointment appointment)
        {
            AppointmentList.Add(appointment);
            _SaveLoader.SaveAppointmentListToFile(FilePath, AppointmentList);
        }

        public void RemoveAppointment(Appointment appointment)
        {
            AppointmentList.Remove(appointment);
            _SaveLoader.SaveAppointmentListToFile(FilePath, AppointmentList);
        }

        public List<Appointment> PrintAllAppointment()
        {

            //foreach (var user in UserList)
            //{
            //    Console.WriteLine(User.UserToString(user));
            //}

            return AppointmentList;
        }

        public void insertAppointment(int index,Appointment appointment)
        {
            AppointmentList.Insert(index, appointment);
            _SaveLoader.SaveAppointmentListToFile(FilePath, AppointmentList);

        }


    }




}
