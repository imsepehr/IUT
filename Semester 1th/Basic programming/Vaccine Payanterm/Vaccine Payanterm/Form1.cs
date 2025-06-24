using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vaccine_Payanterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string filepath = "admin";
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs1);
            string line = reader.ReadLine();
            string[] propertiesText = line.Split(',');
            

            Form2 form2 = new Form2();
            if(txt_username.Text==propertiesText[0] && txt_password.Text==propertiesText[1])
            {
                this.Hide();
                form2.ShowDialog();
                //this.Show();
                this.Close();
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Password Or Username Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }
    }
}
