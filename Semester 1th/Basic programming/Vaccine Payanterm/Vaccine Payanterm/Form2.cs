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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string filepath = "usersfile";
            var manageuser1 = new ManageUser(filepath, new SaveLoadeManageUser_streamwriterreader());
            List<User> userlist = new List<User>();
            userlist = manageuser1.PrintAllUser();
            //string userlisttext = "";
            //foreach (var user in userlist)
            //{
            //    userlisttext += User.UserToString(user);

            //}
        }

        private void customizeDesign()
        {
            panel_submenuUser.Visible = false;
            panel_submenuAppointment.Visible = false;
            panel_summenuApp.Visible = false;
            panel_submenustation.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panel_submenuUser.Visible == true)
                panel_submenuUser.Visible = false;
            if (panel_submenuAppointment.Visible == true)
                panel_submenuAppointment.Visible = false;
            if (panel_summenuApp.Visible == true)
                panel_summenuApp.Visible = false;
            if (panel_submenustation.Visible == true)
                panel_submenustation.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
               
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_submenuUser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            
            
            //...
            //code
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            //...
            //code
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            //code
            hideSubMenu();
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_submenuAppointment);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            //...
            //code
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            //...
            //code
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            //...
            //code
            hideSubMenu();
        }

        private void btn_App_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_summenuApp);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            //...
            //code
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            //...
            //code
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //...
            //code
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childForm.Controls.Add(childForm);
            panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btn_stations_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_submenustation);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_addstation_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
            hideSubMenu();
        }

        private void btn_allstations_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
            hideSubMenu();
        }
    }
}
