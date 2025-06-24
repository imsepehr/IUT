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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());
            List<User> userlist = manageuser1.PrintAllUser();
            //dataGridView1.DataSource = userlist;
            


            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Phone";
            dataGridView1.Columns[3].Name = "City";
            dataGridView1.Columns[4].Name = "Street";
            dataGridView1.Columns[5].Name = "Birth Date";
            dataGridView1.Columns[6].Name = "National Code";


            foreach (var user in userlist)
            {
                string[] row = new string[] { user.FirstName, user.LastName, user.PhoneNumber, user.UAdress.City, user.UAdress.Street, user.BDate.ToString("MM/dd/yyyy"), (user.NationalCode).ToString() };
                dataGridView1.Rows.Add(row);
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
