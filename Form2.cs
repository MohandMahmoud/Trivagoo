using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class signup_form : Form
    {
        readonly Database_control database_Control = new Database_control();
        public signup_form()
        {
            InitializeComponent();
        }

        private void Btn_go_page_3_Click(object sender, EventArgs e)
        {
            pnl_login_info.Width = pnl_main.Width;
            line2.BackColor = Color.FromArgb(59, 249, 81);
        }

        private void Btn_go_page_2_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_main.Width;
            pnl_personal_info.Width = pnl_login_info.Width = 0;
            line1.BackColor = Color.FromArgb(59, 249, 81);
            line2.BackColor = Color.FromArgb(167, 167, 167);
        }

        private void Btn_finish_Click(object sender, EventArgs e)
        {
            bool isEmailExist = database_Control.CheckIfEmailExist(txt_email_signup.Text);
            bool isPhoneExist = database_Control.CheckIfPhoneExist(txt_phone.Text);
            bool isEmail;
            try
            {
                MailAddress m = new MailAddress(txt_email_signup.Text);
                isEmail = true;
            }
            catch (Exception)
            {
                isEmail = false;


            }
            if (isEmail)
            {

                if (!isEmailExist && !isPhoneExist)
                {

                    if (txt_pass_signup.TextLength < 6)
                    {

                        MessageBox.Show("Password is less than 6 chars!!\nPlease make it at least 6", "Opps!!!");

                    }
                    else
                    {
                        if (txt_pass_signup.Text == txt_pass_conf_signup.Text)
                        {

                            if (rdb_admin.Checked)
                            {
                                database_Control.AddUser(new User_in_DataBase(txt_email_signup.Text, txt_pass_signup.Text, txt_f_name.Text, txt_L_name.Text, 1, txt_phone.Text, txt_ssn.Text));
                                var form1 = (login_form)Tag;
                                form1.Show();
                                Close();

                            }
                            else if (rdb_hotel.Checked)
                            {
                                database_Control.AddUser(new User_in_DataBase(txt_email_signup.Text, txt_pass_signup.Text, txt_f_name.Text, txt_L_name.Text, 2, txt_phone.Text, txt_ssn.Text));
                                var form1 = (login_form)Tag;
                                form1.Show();
                                Close();
                            }
                            else if (rdb_customer.Checked)
                            {
                                database_Control.AddUser(new User_in_DataBase(txt_email_signup.Text, txt_pass_signup.Text, txt_f_name.Text, txt_L_name.Text, 0, txt_phone.Text, txt_ssn.Text));
                                var form1 = (login_form)Tag;
                                form1.Show();
                                Close();
                            }
                            else MessageBox.Show("You Must choose your role!!", "Opps!!!");


                        }
                        else
                        {
                            MessageBox.Show("Password is not the same!!\nPlease retype it", "Opps!!!");

                        }
                    }

                }
                else
                {

                    if (isEmailExist)
                    {
                        MessageBox.Show("Email is used before!!\nPlease Enter another one", "Opps!!!");
                    }
                    if (isPhoneExist)
                    {

                        MessageBox.Show("Phone Number is used before!!\nPlease Enter another one", "Opps!!!");
                    }
                }



            }


        }

        private void Btn_prsonal_info_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_login_info.Width = 0;
            line1.BackColor = line2.BackColor = Color.FromArgb(167, 167, 167);

        }

        private void Btn_address_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_main.Width;
            pnl_personal_info.Width = pnl_login_info.Width = 0;
            line1.BackColor = Color.FromArgb(59, 249, 81);
            line2.BackColor = Color.FromArgb(167, 167, 167);
        }

        private void Btn_login_info_Click(object sender, EventArgs e)
        {
            pnl_login_info.Width = pnl_main.Width;
            line2.BackColor = Color.FromArgb(59, 249, 81);
        }

        private void PicBox_visabilty_pass_Click(object sender, EventArgs e)
        {
            txt_pass_signup.UseSystemPasswordChar = !txt_pass_signup.UseSystemPasswordChar;
        }

        private void PicBox_visabilty_pass_conf_Click(object sender, EventArgs e)
        {
            txt_pass_conf_signup.UseSystemPasswordChar = !txt_pass_conf_signup.UseSystemPasswordChar;
        }

        private void Signup_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = (login_form)Tag;
            form1.Show();

        }
    }

}