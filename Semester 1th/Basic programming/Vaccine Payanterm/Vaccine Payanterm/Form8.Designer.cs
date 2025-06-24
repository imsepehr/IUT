
namespace Vaccine_Payanterm
{
    partial class Form8
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_nationalCode = new System.Windows.Forms.TextBox();
            this.lbl_nationalCode = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_daysofweek = new System.Windows.Forms.Label();
            this.comboBox_daysofweek = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_vaccineStation = new System.Windows.Forms.Label();
            this.lbl_vaccineType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_importdate = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 123);
            this.panel1.TabIndex = 1;
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
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(741, 309);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(103, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(23, 309);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(103, 23);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_importdate);
            this.panel2.Controls.Add(this.lbl_daysofweek);
            this.panel2.Controls.Add(this.comboBox_daysofweek);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.lbl_vaccineStation);
            this.panel2.Controls.Add(this.lbl_vaccineType);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btn_confirm);
            this.panel2.Controls.Add(this.txt_nationalCode);
            this.panel2.Controls.Add(this.lbl_nationalCode);
            this.panel2.Controls.Add(this.txt_firstName);
            this.panel2.Controls.Add(this.txt_lastName);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.lbl_firstName);
            this.panel2.Controls.Add(this.lbl_lastName);
            this.panel2.Controls.Add(this.lbl_phone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 303);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(396, 241);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(103, 48);
            this.btn_confirm.TabIndex = 57;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_nationalCode
            // 
            this.txt_nationalCode.Location = new System.Drawing.Point(734, 267);
            this.txt_nationalCode.Name = "txt_nationalCode";
            this.txt_nationalCode.Size = new System.Drawing.Size(123, 22);
            this.txt_nationalCode.TabIndex = 56;
            // 
            // lbl_nationalCode
            // 
            this.lbl_nationalCode.AutoSize = true;
            this.lbl_nationalCode.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_nationalCode.Location = new System.Drawing.Point(759, 229);
            this.lbl_nationalCode.Name = "lbl_nationalCode";
            this.lbl_nationalCode.Size = new System.Drawing.Size(97, 17);
            this.lbl_nationalCode.TabIndex = 55;
            this.lbl_nationalCode.Text = "National Code";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(737, 178);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(123, 22);
            this.txt_firstName.TabIndex = 42;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(567, 178);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(123, 22);
            this.txt_lastName.TabIndex = 41;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(396, 178);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(123, 22);
            this.txt_phone.TabIndex = 40;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_firstName.Location = new System.Drawing.Point(784, 142);
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
            this.lbl_lastName.Location = new System.Drawing.Point(614, 142);
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
            this.lbl_phone.Location = new System.Drawing.Point(470, 142);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(49, 17);
            this.lbl_phone.TabIndex = 34;
            this.lbl_phone.Text = "Phone";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(339, 153);
            this.dataGridView2.TabIndex = 58;
            // 
            // lbl_daysofweek
            // 
            this.lbl_daysofweek.AutoSize = true;
            this.lbl_daysofweek.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_daysofweek.Location = new System.Drawing.Point(412, 54);
            this.lbl_daysofweek.Name = "lbl_daysofweek";
            this.lbl_daysofweek.Size = new System.Drawing.Size(99, 17);
            this.lbl_daysofweek.TabIndex = 64;
            this.lbl_daysofweek.Text = "Days Of Week";
            this.lbl_daysofweek.Click += new System.EventHandler(this.lbl_daysofweek_Click);
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
            this.comboBox_daysofweek.Location = new System.Drawing.Point(396, 84);
            this.comboBox_daysofweek.Name = "comboBox_daysofweek";
            this.comboBox_daysofweek.Size = new System.Drawing.Size(122, 24);
            this.comboBox_daysofweek.TabIndex = 63;
            this.comboBox_daysofweek.SelectedIndexChanged += new System.EventHandler(this.comboBox_daysofweek_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(567, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 24);
            this.comboBox2.TabIndex = 62;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lbl_vaccineStation
            // 
            this.lbl_vaccineStation.AutoSize = true;
            this.lbl_vaccineStation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_vaccineStation.Location = new System.Drawing.Point(586, 54);
            this.lbl_vaccineStation.Name = "lbl_vaccineStation";
            this.lbl_vaccineStation.Size = new System.Drawing.Size(106, 17);
            this.lbl_vaccineStation.TabIndex = 61;
            this.lbl_vaccineStation.Text = "Vaccine Station";
            this.lbl_vaccineStation.Click += new System.EventHandler(this.lbl_vaccineStation_Click);
            // 
            // lbl_vaccineType
            // 
            this.lbl_vaccineType.AutoSize = true;
            this.lbl_vaccineType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_vaccineType.Location = new System.Drawing.Point(754, 54);
            this.lbl_vaccineType.Name = "lbl_vaccineType";
            this.lbl_vaccineType.Size = new System.Drawing.Size(94, 17);
            this.lbl_vaccineType.TabIndex = 60;
            this.lbl_vaccineType.Text = "Vaccine Type";
            this.lbl_vaccineType.Click += new System.EventHandler(this.lbl_vaccineType_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Astrazinka",
            "Sinofarm",
            "Barekat"});
            this.comboBox1.Location = new System.Drawing.Point(737, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 24);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_importdate
            // 
            this.btn_importdate.Location = new System.Drawing.Point(104, 241);
            this.btn_importdate.Name = "btn_importdate";
            this.btn_importdate.Size = new System.Drawing.Size(103, 48);
            this.btn_importdate.TabIndex = 65;
            this.btn_importdate.Text = "Import Date";
            this.btn_importdate.UseVisualStyleBackColor = true;
            this.btn_importdate.Click += new System.EventHandler(this.btn_importdate_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 25);
            this.btn_back.TabIndex = 66;
            this.btn_back.Text = "X";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(871, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_nationalCode;
        private System.Windows.Forms.Label lbl_nationalCode;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_daysofweek;
        private System.Windows.Forms.ComboBox comboBox_daysofweek;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_vaccineStation;
        private System.Windows.Forms.Label lbl_vaccineType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_importdate;
        private System.Windows.Forms.Button btn_back;
    }
}