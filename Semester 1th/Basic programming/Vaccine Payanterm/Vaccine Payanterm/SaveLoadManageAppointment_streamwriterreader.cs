using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Vaccine_Payanterm
{
    public class SaveLoadManageAppointment_streamwriterreader : ISaveLoadManageAppointment
    {
        public void SaveAppointmentListToFile(string filepath, List<Appointment> appointmentlist)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            foreach (var appointment in appointmentlist)
            {
                writer.WriteLine(Appointment.AppointmentToString(appointment));
            }
            writer.Close();
            //fs1.Close();
        }

        public List<Appointment> ReadAppointmentListFromFile(string filepath)
        {
            List<Appointment> appointmentlist = new List<Appointment>();
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs1);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                appointmentlist.Add(Appointment.StringToAppointment(line));
            }
            //fs1.Close();

            reader.Close();
            return appointmentlist;

        }

    }
}
