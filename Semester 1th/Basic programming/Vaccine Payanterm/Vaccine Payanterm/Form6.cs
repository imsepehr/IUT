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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string filepath = "Appointments";
            var manageappointment = new ManageAppointment(filepath, new SaveLoadManageAppointment_streamwriterreader());
            List<Appointment> appointments = manageappointment.PrintAllAppointment();


            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Phone";
            dataGridView1.Columns[3].Name = "National Code";
            dataGridView1.Columns[4].Name = "Vaccine Type";
            dataGridView1.Columns[5].Name = "Vaccine Station";
            dataGridView1.Columns[6].Name = "Date";

            foreach (var appointment in appointments)
            {
                string[] row = new string[] { appointment.user.FirstName, appointment.user.LastName, appointment.user.PhoneNumber, (appointment.user.NationalCode).ToString(), appointment.VaccineName, appointment.VaccineStation, appointment.VDate.ToString() };
                dataGridView1.Rows.Add(row);
            }

        }
    }
}
