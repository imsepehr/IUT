
namespace Vaccine_Payanterm
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_nationalCode = new System.Windows.Forms.TextBox();
            this.lbl_nationalCode = new System.Windows.Forms.Label();
            this.lbl_bdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.lbl_postcode = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 144);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 116);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(23, 291);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(103, 23);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_confirm);
            this.panel2.Controls.Add(this.txt_nationalCode);
            this.panel2.Controls.Add(this.lbl_nationalCode);
            this.panel2.Controls.Add(this.lbl_bdate);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txt_country);
            this.panel2.Controls.Add(this.txt_city);
            this.panel2.Controls.Add(this.txt_street);
            this.panel2.Controls.Add(this.txt_postcode);
            this.panel2.Controls.Add(this.lbl_country);
            this.panel2.Controls.Add(this.lbl_city);
            this.panel2.Controls.Add(this.lbl_street);
            this.panel2.Controls.Add(this.lbl_postcode);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_firstName);
            this.panel2.Controls.Add(this.txt_lastName);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.lbl_firstName);
            this.panel2.Controls.Add(this.lbl_lastName);
            this.panel2.Controls.Add(this.lbl_phone);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 272);
            this.panel2.TabIndex = 2;
            // 
            // txt_nationalCode
            // 
            this.txt_nationalCode.Location = new System.Drawing.Point(552, 214);
            this.txt_nationalCode.Name = "txt_nationalCode";
            this.txt_nationalCode.Size = new System.Drawing.Size(123, 22);
            this.txt_nationalCode.TabIndex = 56;
            this.txt_nationalCode.TextChanged += new System.EventHandler(this.txt_nationalCode_TextChanged);
            // 
            // lbl_nationalCode
            // 
            this.lbl_nationalCode.AutoSize = true;
            this.lbl_nationalCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_nationalCode.Location = new System.Drawing.Point(577, 176);
            this.lbl_nationalCode.Name = "lbl_nationalCode";
            this.lbl_nationalCode.Size = new System.Drawing.Size(97, 17);
            this.lbl_nationalCode.TabIndex = 55;
            this.lbl_nationalCode.Text = "National Code";
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_bdate.Location = new System.Drawing.Point(442, 176);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(62, 17);
            this.lbl_bdate.TabIndex = 54;
            this.lbl_bdate.Text = "BirthDay";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(552, 127);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(123, 22);
            this.txt_country.TabIndex = 52;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(381, 127);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(123, 22);
            this.txt_city.TabIndex = 51;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(199, 127);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(123, 22);
            this.txt_street.TabIndex = 50;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(724, 214);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(123, 22);
            this.txt_postcode.TabIndex = 49;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_country.Location = new System.Drawing.Point(617, 95);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(57, 17);
            this.lbl_country.TabIndex = 48;
            this.lbl_country.Text = "Country";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_city.Location = new System.Drawing.Point(473, 95);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(31, 17);
            this.lbl_city.TabIndex = 47;
            this.lbl_city.Text = "City";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_street.Location = new System.Drawing.Point(276, 95);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(46, 17);
            this.lbl_street.TabIndex = 46;
            this.lbl_street.Text = "Street";
            // 
            // lbl_postcode
            // 
            this.lbl_postcode.AutoSize = true;
            this.lbl_postcode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_postcode.Location = new System.Drawing.Point(771, 176);
            this.lbl_postcode.Name = "lbl_postcode";
            this.lbl_postcode.Size = new System.Drawing.Size(73, 17);
            this.lbl_postcode.TabIndex = 45;
            this.lbl_postcode.Text = "Post Code";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(552, 51);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(123, 22);
            this.txt_password.TabIndex = 44;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(381, 50);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(123, 22);
            this.txt_firstName.TabIndex = 42;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(211, 50);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(123, 22);
            this.txt_lastName.TabIndex = 41;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(724, 127);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(123, 22);
            this.txt_phone.TabIndex = 40;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(724, 51);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(123, 22);
            this.txt_username.TabIndex = 39;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_password.Location = new System.Drawing.Point(606, 14);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 38;
            this.lbl_password.Text = "Password";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_firstName.Location = new System.Drawing.Point(428, 14);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(76, 17);
            this.lbl_firstName.TabIndex = 36;
            this.lbl_firstName.Text = "First Name";
            this.lbl_firstName.Click += new System.EventHandler(this.lbl_firstName_Click);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_lastName.Location = new System.Drawing.Point(258, 14);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(76, 17);
            this.lbl_lastName.TabIndex = 35;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.Click += new System.EventHandler(this.lbl_lastName_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_phone.Location = new System.Drawing.Point(795, 95);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(49, 17);
            this.lbl_phone.TabIndex = 34;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_username.Location = new System.Drawing.Point(772, 14);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 17);
            this.lbl_username.TabIndex = 33;
            this.lbl_username.Text = "Username";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(741, 291);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(103, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(23, 188);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(103, 48);
            this.btn_confirm.TabIndex = 57;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 28);
            this.btn_back.TabIndex = 58;
            this.btn_back.Text = "X";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 461);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_nationalCode;
        private System.Windows.Forms.Label lbl_nationalCode;
        private System.Windows.Forms.Label lbl_bdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.Label lbl_postcode;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_back;
    }
}