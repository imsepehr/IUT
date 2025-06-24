using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Vaccine_Payanterm
{
    [Serializable]
    public class Appointment
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string PhoneNumber { get; set; }
        //public long  NationalCode { get; set; }
        public User user { get; set; }
        public DateTime VDate{ get; set; }
        //public Adress VAdress { get; set; }
        //public DayOfWeek VDate { get; set; }
        public string VaccineName { get; set; }
        public string VaccineStation { get; set; }

        public static string AppointmentToString(Appointment appointment)
        {
            return

                appointment.user.FirstName + "," +
                appointment.user.LastName + "," +
                appointment.user.PhoneNumber + "," +
                appointment.user.NationalCode + "," +
                appointment.VDate + "," +
                appointment.VaccineName + "," +
                appointment.VaccineStation;
                

        }


        public static Appointment StringToAppointment(string appointmenttext)
        {
            string[] propertiesText = appointmenttext.Split(',');

            User _user = new User
            {
                FirstName = propertiesText[0],
                LastName = propertiesText[1],
                PhoneNumber = propertiesText[2],
                NationalCode = Convert.ToInt64(propertiesText[3])

            };


            Appointment appointment = new Appointment
            {

                user = _user,
                VDate = Convert.ToDateTime(propertiesText[4]),
                VaccineName = propertiesText[5],
                VaccineStation = propertiesText[6]

            };

            return appointment;
        }
    }
}
