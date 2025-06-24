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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }

       

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            string filepath = "Appointments";
            var manageappointment = new ManageAppointment(filepath, new SaveLoadManageAppointment_streamwriterreader());

            appointment.user = new User { FirstName = txt_firstName.Text, LastName = txt_lastName.Text, PhoneNumber = txt_phone.Text, NationalCode = Convert.ToInt64(txt_nationalCode.Text) };
            appointment.VaccineName = comboBox1.Text;
            appointment.VaccineStation = comboBox2.Text;

            int counter = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Chk1"].Value != null)
                {
                    if ((bool)(row.Cells["Chk1"].Value) == true)
                    {
                        break;
                    }
                }

                counter++;
            }

            string filepath_time = comboBox2.Text.ToString() + comboBox_daysofweek.Text.ToString();
            SaveLoadVSTime_serializer vsloader = new SaveLoadVSTime_serializer();
            List<DateTime> dateTimes = vsloader.ReadManageVaccineStationVSTimeListFromFile(filepath_time);
            appointment.VDate = Convert.ToDateTime(dateTimes[counter]);

            //manageappointment.AddAppointment(appointment);
            
            manageappointment.insertAppointment(counter, appointment);
            List<Appointment> appointments = manageappointment.PrintAllAppointment();
            manageappointment.RemoveAppointment(appointments[counter+1]);
            

            dateTimes.Remove(dateTimes[counter]);
            vsloader.SaveManageVaccineStationVSTimeListToFile(filepath_time, dateTimes);
            

            
            
            txt_firstName.Text = string.Empty;
            txt_lastName.Text = string.Empty;
            txt_nationalCode.Text = string.Empty;
            txt_phone.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox_daysofweek.Text = string.Empty;

        }

        private void lbl_lastName_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_firstName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_bdate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string filepath = "Appointments";
            var manageappointment = new ManageAppointment(filepath, new SaveLoadManageAppointment_streamwriterreader());
            List<Appointment> appointments = manageappointment.PrintAllAppointment();


            foreach (var appointment in appointments)
            {
                string[] row = new string[] { appointment.user.FirstName, appointment.user.LastName, appointment.user.PhoneNumber, (appointment.user.NationalCode).ToString(), appointment.VDate.ToString() };
                dataGridView1.Rows.Add(row);
            }

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Phone";
            dataGridView1.Columns[3].Name = "National Code";
            dataGridView1.Columns[4].Name = "Date";

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            dataGridView1.Columns.Add(dgvCmb);

            dataGridView2.Columns.Add("time", "Time");
            DataGridViewCheckBoxColumn dgvCmb2 = new DataGridViewCheckBoxColumn();
            dgvCmb2.ValueType = typeof(bool);
            dgvCmb2.Name = "Chk1";
            dgvCmb2.HeaderText = "CheckBox";
            dataGridView2.Columns.Add(dgvCmb2);


            string filepath2 = "stationfile";
            var managestation1 = new ManageVaccineStation(filepath2, new SaveLoadManageVaccineStation_streamwriterreader());
            List<VaccineStation> stations = managestation1.PrintAllVaccineStation();
            int i = 0;
            foreach (var station in stations)
            {
                comboBox2.Items.Insert(i, station.Name);
                i++;
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            Appointment appointment= new Appointment();
            string filepath = "Appointments";
            var manageappointment = new ManageAppointment(filepath, new SaveLoadManageAppointment_streamwriterreader());
            List<Appointment> appointments = manageappointment.PrintAllAppointment();

            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Chk"].Value != null)
                {
                    if ((bool)(row.Cells["Chk"].Value) == true)
                    {
                        break;
                    }
                }

                counter++;
            }

            txt_firstName.Text = appointments[counter].user.FirstName;
            txt_lastName.Text = appointments[counter].user.LastName;
            txt_phone.Text = appointments[counter].user.PhoneNumber;
            txt_nationalCode.Text = appointments[counter].user.NationalCode.ToString();
            comboBox1.Text = appointments[counter].VaccineName;
            comboBox2.Text = appointments[counter].VaccineStation;
            


        }

        private void comboBox_daysofweek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_daysofweek_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vaccineStation_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_vaccineType_Click(object sender, EventArgs e)
        {

        }

        private void btn_importdate_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string filepath_time = comboBox2.Text.ToString() + comboBox_daysofweek.Text.ToString();
            SaveLoadVSTime_serializer vsloader = new SaveLoadVSTime_serializer();
            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes = vsloader.ReadManageVaccineStationVSTimeListFromFile(filepath_time);

            foreach (var time in dateTimes)
            {
                string[] row = new string[] { time.ToString("t") };
                dataGridView2.Rows.Add(row);

            }




        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
