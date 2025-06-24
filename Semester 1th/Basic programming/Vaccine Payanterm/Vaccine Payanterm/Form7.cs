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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());
            List<User> userlist = manageuser1.PrintAllUser();
           
           


            foreach (var user in userlist)
            {
                string[] row = new string[] { user.FirstName, user.LastName, user.PhoneNumber, (user.NationalCode).ToString() };
                dataGridView1.Rows.Add(row);
            }


        }

        private void Form7_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Phone";
            dataGridView1.Columns[3].Name = "National Code";

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            dataGridView1.Columns.Add(dgvCmb);
        }

        private void txt_nationalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_firstName_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lastName_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());
            List<User> users = manageuser1.PrintAllUser();

            bool flag = false;
            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Chk"].Value != null)
                {
                    if ((bool)(row.Cells["Chk"].Value) == true)
                    {
                        flag = true;
                        break;
                    }
                }

                counter++;
            }

            txt_firstName.Text = users[counter].FirstName;
            txt_lastName.Text = users[counter].LastName;
            txt_password.Text = users[counter].Password;
            txt_username.Text = users[counter].Username;
            txt_phone.Text = users[counter].PhoneNumber;
            txt_nationalCode.Text = users[counter].NationalCode.ToString();
            txt_postcode.Text = users[counter].UAdress.PostCode;
            txt_city.Text = users[counter].UAdress.City;
            txt_country.Text = users[counter].UAdress.Country;
            txt_street.Text = users[counter].UAdress.Street;




        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());


            newUser.Username = txt_username.Text.ToString();
            newUser.Password = txt_password.Text.ToString();
            newUser.FirstName = txt_firstName.Text.ToString();
            newUser.LastName = txt_lastName.Text.ToString();
            newUser.PhoneNumber = txt_phone.Text.ToString();
            newUser.UAdress = new Adress { Country = txt_country.Text.ToString(), City = txt_city.Text.ToString(), Street = txt_street.Text.ToString(), PostCode = txt_postcode.Text.ToString() };
            newUser.BDate = dateTimePicker1.Value;
            newUser.NationalCode = Convert.ToInt64(txt_nationalCode.Text);

            

            
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

            List<User> users = manageuser1.PrintAllUser();
            manageuser1.RemoveUser(users[counter]);
            manageuser1.insertUser(counter, newUser);
            


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
