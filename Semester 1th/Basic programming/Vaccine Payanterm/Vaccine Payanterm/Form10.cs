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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string filepath = "stationfile";
            var managestation = new ManageVaccineStation(filepath, new SaveLoadManageVaccineStation_streamwriterreader());
            List<VaccineStation> vaccineStations = managestation.PrintAllVaccineStation();

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Country";
            dataGridView1.Columns[2].Name = "City";
            dataGridView1.Columns[3].Name = "Street";
            dataGridView1.Columns[4].Name = "StartTime";
            dataGridView1.Columns[5].Name = "EndTime";
            dataGridView1.Columns[6].Name = "TimeSpan";
            dataGridView1.Columns[7].Name = "Capacity";

            foreach (var station in vaccineStations)
            {
                string[] row = new string[] { station.Name, station.VSAdress.Country, station.VSAdress.City, station.VSAdress.Street, station.SDate.ToString("t"), station.EDate.ToString("t"), station.TimeSpan.ToString(), station.Limit.ToString() };
                dataGridView1.Rows.Add(row);
            }

        }
    }
}
