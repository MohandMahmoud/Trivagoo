namespace WindowsFormsApp1
{
    partial class signup_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.btn_login_info = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_address = new System.Windows.Forms.Button();
            this.btn_prsonal_info = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_personal_info = new System.Windows.Forms.Panel();
            this.btn_go_page_2 = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_L_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_f_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_address = new System.Windows.Forms.Panel();
            this.btn_go_page_3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_login_info = new System.Windows.Forms.Panel();
            this.picBox_visabilty_pass_conf = new System.Windows.Forms.PictureBox();
            this.picBox_visabilty_pass = new System.Windows.Forms.PictureBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.rdb_admin = new System.Windows.Forms.RadioButton();
            this.rdb_hotel = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rdb_customer = new System.Windows.Forms.RadioButton();
            this.txt_pass_conf_signup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pass_signup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email_signup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_personal_info.SuspendLayout();
            this.pnl_address.SuspendLayout();
            this.pnl_login_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_visabilty_pass_conf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_visabilty_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.btn_login_info);
            this.panel1.Controls.Add(this.btn_address);
            this.panel1.Controls.Add(this.btn_prsonal_info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 120);
            this.panel1.TabIndex = 0;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.line2.Location = new System.Drawing.Point(254, 37);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(95, 5);
            this.line2.TabIndex = 3;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.line1.Location = new System.Drawing.Point(101, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(95, 5);
            this.line1.TabIndex = 0;
            // 
            // btn_login_info
            // 
            this.btn_login_info.FlatAppearance.BorderSize = 0;
            this.btn_login_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_info.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btn_login_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login_info.ImageIndex = 0;
            this.btn_login_info.ImageList = this.imageList1;
            this.btn_login_info.Location = new System.Drawing.Point(313, 10);
            this.btn_login_info.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login_info.Name = "btn_login_info";
            this.btn_login_info.Size = new System.Drawing.Size(130, 100);
            this.btn_login_info.TabIndex = 2;
            this.btn_login_info.Text = "Login Information";
            this.btn_login_info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_login_info.UseVisualStyleBackColor = true;
            this.btn_login_info.Click += new System.EventHandler(this.Btn_login_info_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "work-in-progress (2).png");
            this.imageList1.Images.SetKeyName(1, "work-in-progress (1).png");
            this.imageList1.Images.SetKeyName(2, "work-in-progress.png");
            // 
            // btn_address
            // 
            this.btn_address.FlatAppearance.BorderSize = 0;
            this.btn_address.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_address.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btn_address.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_address.ImageIndex = 1;
            this.btn_address.ImageList = this.imageList1;
            this.btn_address.Location = new System.Drawing.Point(159, 10);
            this.btn_address.Margin = new System.Windows.Forms.Padding(0);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(130, 100);
            this.btn_address.TabIndex = 1;
            this.btn_address.Text = "Address";
            this.btn_address.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_address.UseVisualStyleBackColor = true;
            this.btn_address.Click += new System.EventHandler(this.Btn_address_Click);
            // 
            // btn_prsonal_info
            // 
            this.btn_prsonal_info.FlatAppearance.BorderSize = 0;
            this.btn_prsonal_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_prsonal_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_prsonal_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prsonal_info.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsonal_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btn_prsonal_info.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_prsonal_info.ImageIndex = 2;
            this.btn_prsonal_info.ImageList = this.imageList1;
            this.btn_prsonal_info.Location = new System.Drawing.Point(5, 10);
            this.btn_prsonal_info.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prsonal_info.Name = "btn_prsonal_info";
            this.btn_prsonal_info.Size = new System.Drawing.Size(130, 100);
            this.btn_prsonal_info.TabIndex = 0;
            this.btn_prsonal_info.Text = "Personal Information";
            this.btn_prsonal_info.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_prsonal_info.UseVisualStyleBackColor = true;
            this.btn_prsonal_info.Click += new System.EventHandler(this.Btn_prsonal_info_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_personal_info);
            this.pnl_main.Controls.Add(this.pnl_address);
            this.pnl_main.Controls.Add(this.pnl_login_info);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 120);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(438, 381);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_personal_info
            // 
            this.pnl_personal_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_personal_info.Controls.Add(this.btn_go_page_2);
            this.pnl_personal_info.Controls.Add(this.txt_phone);
            this.pnl_personal_info.Controls.Add(this.label4);
            this.pnl_personal_info.Controls.Add(this.txt_ssn);
            this.pnl_personal_info.Controls.Add(this.label2);
            this.pnl_personal_info.Controls.Add(this.txt_L_name);
            this.pnl_personal_info.Controls.Add(this.label1);
            this.pnl_personal_info.Controls.Add(this.txt_f_name);
            this.pnl_personal_info.Controls.Add(this.label3);
            this.pnl_personal_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_personal_info.Location = new System.Drawing.Point(0, 0);
            this.pnl_personal_info.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_personal_info.Name = "pnl_personal_info";
            this.pnl_personal_info.Size = new System.Drawing.Size(417, 381);
            this.pnl_personal_info.TabIndex = 2;
            // 
            // btn_go_page_2
            // 
            this.btn_go_page_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_go_page_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go_page_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_page_2.ForeColor = System.Drawing.Color.Black;
            this.btn_go_page_2.Location = new System.Drawing.Point(228, 317);
            this.btn_go_page_2.Name = "btn_go_page_2";
            this.btn_go_page_2.Size = new System.Drawing.Size(177, 36);
            this.btn_go_page_2.TabIndex = 25;
            this.btn_go_page_2.Text = "Next";
            this.btn_go_page_2.UseVisualStyleBackColor = false;
            this.btn_go_page_2.Click += new System.EventHandler(this.Btn_go_page_2_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_phone.Location = new System.Drawing.Point(128, 228);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(277, 31);
            this.txt_phone.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 44);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ssn
            // 
            this.txt_ssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_ssn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ssn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ssn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_ssn.Location = new System.Drawing.Point(128, 158);
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.Size = new System.Drawing.Size(277, 31);
            this.txt_ssn.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "SSN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_L_name
            // 
            this.txt_L_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_L_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_L_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_L_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_L_name.Location = new System.Drawing.Point(128, 88);
            this.txt_L_name.Name = "txt_L_name";
            this.txt_L_name.Size = new System.Drawing.Size(277, 31);
            this.txt_L_name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Last Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_f_name
            // 
            this.txt_f_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_f_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_f_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_f_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_f_name.Location = new System.Drawing.Point(128, 18);
            this.txt_f_name.Name = "txt_f_name";
            this.txt_f_name.Size = new System.Drawing.Size(277, 31);
            this.txt_f_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_address
            // 
            this.pnl_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_address.Controls.Add(this.btn_go_page_3);
            this.pnl_address.Controls.Add(this.textBox1);
            this.pnl_address.Controls.Add(this.label6);
            this.pnl_address.Controls.Add(this.txt_street);
            this.pnl_address.Controls.Add(this.label5);
            this.pnl_address.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_address.Location = new System.Drawing.Point(417, 0);
            this.pnl_address.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_address.Name = "pnl_address";
            this.pnl_address.Size = new System.Drawing.Size(10, 381);
            this.pnl_address.TabIndex = 1;
            // 
            // btn_go_page_3
            // 
            this.btn_go_page_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_go_page_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go_page_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_page_3.ForeColor = System.Drawing.Color.Black;
            this.btn_go_page_3.Location = new System.Drawing.Point(241, 300);
            this.btn_go_page_3.Name = "btn_go_page_3";
            this.btn_go_page_3.Size = new System.Drawing.Size(177, 36);
            this.btn_go_page_3.TabIndex = 25;
            this.btn_go_page_3.Text = "Next";
            this.btn_go_page_3.UseVisualStyleBackColor = false;
            this.btn_go_page_3.Click += new System.EventHandler(this.Btn_go_page_3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox1.Location = new System.Drawing.Point(130, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 31);
            this.textBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(14, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "City";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_street
            // 
            this.txt_street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_street.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_street.Location = new System.Drawing.Point(130, 88);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(277, 31);
            this.txt_street.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(14, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Street";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_login_info
            // 
            this.pnl_login_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_login_info.Controls.Add(this.picBox_visabilty_pass_conf);
            this.pnl_login_info.Controls.Add(this.picBox_visabilty_pass);
            this.pnl_login_info.Controls.Add(this.btn_finish);
            this.pnl_login_info.Controls.Add(this.rdb_admin);
            this.pnl_login_info.Controls.Add(this.rdb_hotel);
            this.pnl_login_info.Controls.Add(this.label10);
            this.pnl_login_info.Controls.Add(this.rdb_customer);
            this.pnl_login_info.Controls.Add(this.txt_pass_conf_signup);
            this.pnl_login_info.Controls.Add(this.label9);
            this.pnl_login_info.Controls.Add(this.txt_pass_signup);
            this.pnl_login_info.Controls.Add(this.label8);
            this.pnl_login_info.Controls.Add(this.txt_email_signup);
            this.pnl_login_info.Controls.Add(this.label7);
            this.pnl_login_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_login_info.Location = new System.Drawing.Point(427, 0);
            this.pnl_login_info.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_login_info.Name = "pnl_login_info";
            this.pnl_login_info.Size = new System.Drawing.Size(11, 381);
            this.pnl_login_info.TabIndex = 0;
            // 
            // picBox_visabilty_pass_conf
            // 
            this.picBox_visabilty_pass_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.picBox_visabilty_pass_conf.Image = global::WindowsFormsApp1.Properties.Resources.visibility;
            this.picBox_visabilty_pass_conf.Location = new System.Drawing.Point(391, 191);
            this.picBox_visabilty_pass_conf.Name = "picBox_visabilty_pass_conf";
            this.picBox_visabilty_pass_conf.Size = new System.Drawing.Size(36, 36);
            this.picBox_visabilty_pass_conf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_visabilty_pass_conf.TabIndex = 35;
            this.picBox_visabilty_pass_conf.TabStop = false;
            this.picBox_visabilty_pass_conf.Click += new System.EventHandler(this.PicBox_visabilty_pass_conf_Click);
            // 
            // picBox_visabilty_pass
            // 
            this.picBox_visabilty_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.picBox_visabilty_pass.Image = global::WindowsFormsApp1.Properties.Resources.visibility;
            this.picBox_visabilty_pass.Location = new System.Drawing.Point(391, 111);
            this.picBox_visabilty_pass.Name = "picBox_visabilty_pass";
            this.picBox_visabilty_pass.Size = new System.Drawing.Size(36, 33);
            this.picBox_visabilty_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_visabilty_pass.TabIndex = 34;
            this.picBox_visabilty_pass.TabStop = false;
            this.picBox_visabilty_pass.Click += new System.EventHandler(this.PicBox_visabilty_pass_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.ForeColor = System.Drawing.Color.Black;
            this.btn_finish.Location = new System.Drawing.Point(237, 333);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(177, 36);
            this.btn_finish.TabIndex = 33;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = false;
            this.btn_finish.Click += new System.EventHandler(this.Btn_finish_Click);
            // 
            // rdb_admin
            // 
            this.rdb_admin.AutoSize = true;
            this.rdb_admin.Location = new System.Drawing.Point(343, 287);
            this.rdb_admin.Name = "rdb_admin";
            this.rdb_admin.Size = new System.Drawing.Size(54, 17);
            this.rdb_admin.TabIndex = 32;
            this.rdb_admin.TabStop = true;
            this.rdb_admin.Text = "Admin";
            this.rdb_admin.UseVisualStyleBackColor = true;
            // 
            // rdb_hotel
            // 
            this.rdb_hotel.AutoSize = true;
            this.rdb_hotel.Location = new System.Drawing.Point(247, 287);
            this.rdb_hotel.Name = "rdb_hotel";
            this.rdb_hotel.Size = new System.Drawing.Size(50, 17);
            this.rdb_hotel.TabIndex = 31;
            this.rdb_hotel.TabStop = true;
            this.rdb_hotel.Text = "Hotel";
            this.rdb_hotel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(16, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "Your Role";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdb_customer
            // 
            this.rdb_customer.AutoSize = true;
            this.rdb_customer.Location = new System.Drawing.Point(132, 287);
            this.rdb_customer.Name = "rdb_customer";
            this.rdb_customer.Size = new System.Drawing.Size(69, 17);
            this.rdb_customer.TabIndex = 29;
            this.rdb_customer.TabStop = true;
            this.rdb_customer.Text = "Customer";
            this.rdb_customer.UseVisualStyleBackColor = true;
            // 
            // txt_pass_conf_signup
            // 
            this.txt_pass_conf_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_pass_conf_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_conf_signup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pass_conf_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_pass_conf_signup.Location = new System.Drawing.Point(137, 195);
            this.txt_pass_conf_signup.Name = "txt_pass_conf_signup";
            this.txt_pass_conf_signup.Size = new System.Drawing.Size(248, 31);
            this.txt_pass_conf_signup.TabIndex = 28;
            this.txt_pass_conf_signup.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label9.Location = new System.Drawing.Point(21, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 58);
            this.label9.TabIndex = 27;
            this.label9.Text = "Confirm Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pass_signup
            // 
            this.txt_pass_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_pass_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_signup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pass_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_pass_signup.Location = new System.Drawing.Point(137, 113);
            this.txt_pass_signup.Name = "txt_pass_signup";
            this.txt_pass_signup.Size = new System.Drawing.Size(248, 31);
            this.txt_pass_signup.TabIndex = 26;
            this.txt_pass_signup.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(21, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_email_signup
            // 
            this.txt_email_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_email_signup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email_signup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_email_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_email_signup.Location = new System.Drawing.Point(137, 39);
            this.txt_email_signup.Name = "txt_email_signup";
            this.txt_email_signup.Size = new System.Drawing.Size(277, 31);
            this.txt_email_signup.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label7.Location = new System.Drawing.Point(21, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 501);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Name = "signup_form";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_form_FormClosing);
            this.panel1.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_personal_info.ResumeLayout(false);
            this.pnl_personal_info.PerformLayout();
            this.pnl_address.ResumeLayout(false);
            this.pnl_address.PerformLayout();
            this.pnl_login_info.ResumeLayout(false);
            this.pnl_login_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_visabilty_pass_conf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_visabilty_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_address;
        private System.Windows.Forms.Button btn_prsonal_info;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Button btn_login_info;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_personal_info;
        private System.Windows.Forms.Panel pnl_address;
        private System.Windows.Forms.Panel pnl_login_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_f_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ssn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_L_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_go_page_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_go_page_3;
        private System.Windows.Forms.RadioButton rdb_admin;
        private System.Windows.Forms.RadioButton rdb_hotel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdb_customer;
        private System.Windows.Forms.TextBox txt_pass_conf_signup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pass_signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email_signup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.PictureBox picBox_visabilty_pass_conf;
        private System.Windows.Forms.PictureBox picBox_visabilty_pass;
    }
}