
namespace Vaccine_Payanterm
{
    partial class Form4
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_daysofweek = new System.Windows.Forms.Label();
            this.comboBox_daysofweek = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_importdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_vaccineStation = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_natinalCode = new System.Windows.Forms.Label();
            this.txt_natinalCode = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_vaccineType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_daysofweek);
            this.panel1.Controls.Add(this.comboBox_daysofweek);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lbl_vaccineStation);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.lbl_natinalCode);
            this.panel1.Controls.Add(this.txt_natinalCode);
            this.panel1.Controls.Add(this.txt_lastName);
            this.panel1.Controls.Add(this.lbl_lastName);
            this.panel1.Controls.Add(this.lbl_firstName);
            this.panel1.Controls.Add(this.txt_firstName);
            this.panel1.Controls.Add(this.lbl_vaccineType);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 417);
            this.panel1.TabIndex = 5;
            // 
            // lbl_daysofweek
            // 
            this.lbl_daysofweek.AutoSize = true;
            this.lbl_daysofweek.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_daysofweek.Location = new System.Drawing.Point(412, 23);
            this.lbl_daysofweek.Name = "lbl_daysofweek";
            this.lbl_daysofweek.Size = new System.Drawing.Size(99, 17);
            this.lbl_daysofweek.TabIndex = 15;
            this.lbl_daysofweek.Text = "Days Of Week";
            // 
            // comboBox_daysofweek
            // 
            this.comboBox_daysofweek.FormattingEnabled = true;
            this.comboBox_daysofweek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox_daysofweek.Location = new System.Drawing.Point(411, 53);
            this.comboBox_daysofweek.Name = "comboBox_daysofweek";
            this.comboBox_daysofweek.Size = new System.Drawing.Size(107, 24);
            this.comboBox_daysofweek.TabIndex = 14;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(422, 239);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_importdate);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 411);
            this.panel2.TabIndex = 12;
            // 
            // btn_importdate
            // 
            this.btn_importdate.Location = new System.Drawing.Point(76, 385);
            this.btn_importdate.Name = "btn_importdate";
            this.btn_importdate.Size = new System.Drawing.Size(161, 23);
            this.btn_importdate.TabIndex = 13;
            this.btn_importdate.Text = "Available Times";
            this.btn_importdate.UseVisualStyleBackColor = true;
            this.btn_importdate.Click += new System.EventHandler(this.btn_importdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(582, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_vaccineStation
            // 
            this.lbl_vaccineStation.AutoSize = true;
            this.lbl_vaccineStation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_vaccineStation.Location = new System.Drawing.Point(586, 23);
            this.lbl_vaccineStation.Name = "lbl_vaccineStation";
            this.lbl_vaccineStation.Size = new System.Drawing.Size(106, 17);
            this.lbl_vaccineStation.TabIndex = 10;
            this.lbl_vaccineStation.Text = "Vaccine Station";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(748, 240);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_phone.TabIndex = 9;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_phone.Location = new System.Drawing.Point(799, 205);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(49, 17);
            this.lbl_phone.TabIndex = 8;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_natinalCode
            // 
            this.lbl_natinalCode.AutoSize = true;
            this.lbl_natinalCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_natinalCode.Location = new System.Drawing.Point(408, 115);
            this.lbl_natinalCode.Name = "lbl_natinalCode";
            this.lbl_natinalCode.Size = new System.Drawing.Size(89, 17);
            this.lbl_natinalCode.TabIndex = 7;
            this.lbl_natinalCode.Text = "Natinal Code";
            // 
            // txt_natinalCode
            // 
            this.txt_natinalCode.Location = new System.Drawing.Point(411, 154);
            this.txt_natinalCode.Name = "txt_natinalCode";
            this.txt_natinalCode.Size = new System.Drawing.Size(100, 22);
            this.txt_natinalCode.TabIndex = 6;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(589, 154);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 22);
            this.txt_lastName.TabIndex = 5;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_lastName.Location = new System.Drawing.Point(586, 115);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(76, 17);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name";
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_firstName.Location = new System.Drawing.Point(772, 115);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(76, 17);
            this.lbl_firstName.TabIndex = 3;
            this.lbl_firstName.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(748, 154);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 22);
            this.txt_firstName.TabIndex = 2;
            // 
            // lbl_vaccineType
            // 
            this.lbl_vaccineType.AutoSize = true;
            this.lbl_vaccineType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_vaccineType.Location = new System.Drawing.Point(754, 23);
            this.lbl_vaccineType.Name = "lbl_vaccineType";
            this.lbl_vaccineType.Size = new System.Drawing.Size(94, 17);
            this.lbl_vaccineType.TabIndex = 1;
            this.lbl_vaccineType.Text = "Vaccine Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Astrazinka",
            "Sinofarm",
            "Barekat"});
            this.comboBox1.Location = new System.Drawing.Point(737, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1034, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_natinalCode;
        private System.Windows.Forms.TextBox txt_natinalCode;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lbl_vaccineType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_vaccineStation;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_importdate;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl_daysofweek;
        private System.Windows.Forms.ComboBox comboBox_daysofweek;
    }
}