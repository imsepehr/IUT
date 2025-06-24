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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string filepath2 = "stationfile";
            var managestation1 = new ManageVaccineStation(filepath2, new SaveLoadManageVaccineStation_streamwriterreader());
            List<VaccineStation> stations = managestation1.PrintAllVaccineStation();
            int i = 0;
            foreach (var station in stations)
            {
                comboBox2.Items.Insert(i, station.Name);
                i++;
            }

            dataGridView1.Columns.Add("time", "Time");
            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            dataGridView1.Columns.Add(dgvCmb);



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_importdate_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string filepath_time = comboBox2.Text.ToString() + comboBox_daysofweek.Text.ToString();
            SaveLoadVSTime_serializer vsloader = new SaveLoadVSTime_serializer();
            List<DateTime> dateTimes = vsloader.ReadManageVaccineStationVSTimeListFromFile(filepath_time);
           

            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[0].Name = "Time";

            //dataGridView1.Columns.Add("time", "Time");
            //DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            //dgvCmb.ValueType = typeof(bool);
            //dgvCmb.Name = "Chk";
            //dgvCmb.HeaderText = "CheckBox";
            //dataGridView1.Columns.Add(dgvCmb);

            foreach (var time in dateTimes)
            {
                string[] row = new string[] { time.ToString("t") };
                dataGridView1.Rows.Add(row);
                
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            string filepath = "Appointments";
            var manageappointment = new ManageAppointment(filepath, new SaveLoadManageAppointment_streamwriterreader());

            appointment.user = new User { FirstName = txt_firstName.Text.ToString(), LastName = txt_lastName.Text.ToString(), PhoneNumber = txt_phone.Text.ToString(), NationalCode = Convert.ToInt64(txt_natinalCode.Text) };
            appointment.VaccineName = comboBox1.Text.ToString();
            appointment.VaccineStation = comboBox2.Text.ToString();
            


            


            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["Chk"].Value!=null)
                {
                    if((bool)(row.Cells["Chk"].Value)==true)
                    {
                        break;
                    }
                }

                counter++;
            }


            string filepath_time = comboBox2.Text.ToString() + comboBox_daysofweek.Text.ToString();
            SaveLoadVSTime_serializer vsloader = new SaveLoadVSTime_serializer();
            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes = vsloader.ReadManageVaccineStationVSTimeListFromFile(filepath_time);


            appointment.VDate = Convert.ToDateTime(dateTimes[counter]);
            manageappointment.AddAppointment(appointment);

            dateTimes.Remove(dateTimes[counter]);
            vsloader.SaveManageVaccineStationVSTimeListToFile(filepath_time, dateTimes);


            txt_firstName.Text = string.Empty;
            txt_lastName.Text = string.Empty;
            txt_natinalCode.Text = string.Empty;
            txt_phone.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox_daysofweek.Text = string.Empty;

            DialogResult d;
            d = MessageBox.Show("The Appointment Registred ", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
