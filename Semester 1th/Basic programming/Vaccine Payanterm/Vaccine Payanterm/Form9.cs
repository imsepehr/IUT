using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccine_Payanterm
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            VaccineStation station = new VaccineStation();
            string filepath = "stationfile";
            var managestation = new ManageVaccineStation(filepath, new SaveLoadManageVaccineStation_streamwriterreader());
            var managestation2 = new ManageVaccineStation("temp", new SaveLoadManageVaccineStation_streamwriterreader());

            station.Name = txt_name.Text.ToString();
            station.VSAdress = new Adress { Country = txt_country.Text, City = txt_city.Text, Street = txt_street.Text };
            station.TimeSpan = Convert.ToInt32(txt_timespan.Text);
            station.Limit = Convert.ToInt32(txt_capacity.Text);
            station.SDate = new DateTime(2020, 1, 1, Convert.ToInt32(txt_stime.Text), 0, 0);
            station.EDate = new DateTime(2020, 1, 1, Convert.ToInt32(txt_etime.Text), 0, 0);
            

            managestation.AddVaccineStation(station, station.Name + "Monday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Tuesday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Wednesday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Thursday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Friday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Saturday", new SaveLoadVSTime_serializer());
            managestation2.AddVaccineStation(station, station.Name + "Sunday", new SaveLoadVSTime_serializer());

            txt_name.Text = string.Empty;
            txt_country.Text = string.Empty;
            txt_city.Text = string.Empty;
            txt_street.Text = string.Empty;
            txt_stime.Text = string.Empty;
            txt_etime.Text = string.Empty;
            txt_timespan.Text = string.Empty;
            txt_capacity.Text = string.Empty;


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
