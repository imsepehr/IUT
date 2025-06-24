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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_postcode_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            Adress newadress = new Adress();
            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());

            newUser.Username = txt_username.Text.ToString();
            newUser.Password = txt_password.Text.ToString();
            newUser.FirstName = txt_firstName.Text.ToString();
            newUser.LastName = txt_lastName.Text.ToString();
            newUser.PhoneNumber = txt_phone.Text.ToString();
            //newUser.UAdress.Country = txt_country.Text.ToString();
            //newUser.UAdress.City = txt_city.Text.ToString();
            //newUser.UAdress.Street = txt_street.Text.ToString();
            //newUser.UAdress.PostCode = txt_postcode.Text.ToString();
            newUser.UAdress = new Adress { Country = txt_country.Text.ToString(), City = txt_city.Text.ToString(), Street = txt_street.Text.ToString(), PostCode = txt_postcode.Text.ToString() };
            newUser.BDate = dateTimePicker1.Value;
            newUser.NationalCode = Convert.ToInt64(txt_nationalCode.Text);

            manageuser1.AddUser(newUser);

            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_repassword.Text = string.Empty;
            txt_firstName.Text = string.Empty;
            txt_lastName.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_country.Text = string.Empty;
            txt_city.Text = string.Empty;
            txt_street.Text = string.Empty;
            txt_postcode.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            txt_nationalCode.Text = string.Empty;
            
        }
    }
}
