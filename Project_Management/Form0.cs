using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Project_Management
{
    public partial class Form0 : Form
    {
        private string temporaryPassword; 
        private string temporaryUsername;

        void HideAllPanel2()
        {
            pnl_Signup.Hide();
            pnl_ForgotPass.Hide();
            pnl_Login.Hide();
        }
        
        
        public Form0()
        {
            
            InitializeComponent();
            Int_Data();
            HideAllPanel2();
            pnl_Login.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e) //close application
        {
            Application.Exit();
        }

        private void btn_Minus_Click(object sender, EventArgs e) // minimized the application
        {
            
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Minimized; 
                }
            
        }

        private void btn_Login_CreateAccount_Click(object sender, EventArgs e)
        {
            //HideAllPanel2();
            pnl_Login.Hide();
            pnl_Signup.Show();
        }

        private void btn_createAccount_cancel_Click(object sender, EventArgs e)
        {
            pnl_Signup.Hide();
            pnl_Login.Show();
            
        }

        private void btn_forgetPass_back_Click(object sender, EventArgs e)
        {
            pnl_ForgotPass.Hide();
            pnl_Login.Show();
        }

        private void btn_forgetPass_signUp_Click(object sender, EventArgs e)
        {
            pnl_ForgotPass.Hide();
            pnl_Signup.Show();
        }

       
        
        private void btn_login_clickHere_Click(object sender, EventArgs e)
        {
            
            pnl_Login.Hide();
            pnl_ForgotPass.Show();
        }

        public string temporaryUser;
        private void btn_Login_LogIn_Click(object sender, EventArgs e)
        {


            String lgn_pass = txt_Login_Password.Text;
            String lgn_user_name = txt_Login_Username.Text;


           



          
            
            
            try
            {


                SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                string query = "select * from tb_account where ac_username='" + txt_Login_Username.Text.Trim() + "'and ac_password='"+txt_Login_Password.Text.Trim()+"' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, sql);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if(dtbl.Rows.Count==1)
                {

                    if (checkBox1.Checked)
                    {
                        save_data();
                    }
                    else
                    {

                    }
                    this.Hide();
                    temporaryUser = lgn_user_name;
                    Form1 f2 = new Form1(temporaryUser);
                    f2.ShowDialog();
                }


                



                 

              
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid User Name or Password");
            }
        }

       
        
        
        private void btn_forgetPass_resetPassword_Click(object sender, EventArgs e)
        {


            String Given_Email = txtbox_forgetPass_email.Text;
            
            
            try
            {
                  SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                string query = "select * from tb_account where ac_email='" + txtbox_forgetPass_email.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sql);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if(dtbl.Rows.Count==1)
                {
                    string password4;
                    
                    SqlDataReader reader = null;
                    SqlConnection sql4 = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                    string query4 = "select ac_password from tb_account where ac_email='" + txtbox_forgetPass_email.Text.Trim() + "'";
                    SqlCommand cmd4 = new SqlCommand(query4, sql4);
                    sql4.Open();
                    password4 = (string)cmd4.ExecuteScalar();

                    MessageBox.Show("Password :", password4);

                   
                    //db_accountDataContext db = new db_accountDataContext();
                //tb_account acc = db.tb_accounts.SingleOrDefault(x => x.ac_email == Given_Email);
               
                
                    //temporaryUsername = ac_username;
                   // temporaryPassword=acc.ac_password;
                   // emailSendStart();
                }
                else
                {
                    MessageBox.Show("Email Address Did not Matched");
                    txtbox_forgetPass_email.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email Address Did not Matched");
            }
            
              
         
        }


        public void emailSendStart()
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("aiubprojectmanagement@gmail.com", "trkk12345");
                MailMessage msg = new MailMessage();
                msg.To.Add(txtbox_forgetPass_email.Text);
                msg.From = new MailAddress("aiubprojectmanagement@gmail.com");
                msg.Subject = "Reset password";
                msg.Body = @"Your Name: "+temporaryUsername+@"
Your Password: "+temporaryPassword;
                client.Send(msg);
                MessageBox.Show("Password has been sent Successfully!!!");
                txtbox_forgetPass_email.Text = "";
                pnl_ForgotPass.Hide();
                pnl_Login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has been Occured :-( ");
                txtbox_forgetPass_email.Text = "";
            }


        }

        private void btn_createAccount_signup_Click(object sender, EventArgs e)
        {

            String name = txt_CreateAccount_Name.Text;
            String email = txt_CreateAccount_Email.Text;
            String pass = txt_CreateAccount_Password.Text;
            String re_pass = txt_CreateAccount_ReEnterPassword.Text;
            String user_name = txt_CreateAccount_Username.Text;

            



                if (pass == re_pass)
                {
                    if (name != null && email != null && pass != null && user_name != null)
                    {
                        if ((user_name.Length >= 4) && (pass.Length >= 4))
                        {
                            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                            string query = "select * from tb_account where ac_username='" + txt_CreateAccount_Username.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sql);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Username is Already exist");
            }
            else
            {

                SqlConnection sql1 = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                string query1 = "select * from tb_account where ac_email='" + txt_CreateAccount_Email.Text.Trim() + "'";

                SqlDataAdapter sda1 = new SqlDataAdapter(query1, sql1);

                DataTable dtbl1 = new DataTable();
                sda1.Fill(dtbl1);

                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Email is Already exist");
                }



                else
                {

                    SqlConnection sql2 = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                    sql2.Open();
                    if (sql2.State == ConnectionState.Open)
                    {
                        string query2 = "insert into tb_account (ac_serial,ac_name,ac_email,ac_username,ac_password) values ('" + 3 + "','" + txt_CreateAccount_Name.Text + "','" + txt_CreateAccount_Email.Text + "','" + txt_CreateAccount_Username.Text + "','" + txt_CreateAccount_Password.Text + "')";
                        SqlCommand cmd = new SqlCommand(query2, sql2);
                        cmd.ExecuteNonQuery();
                        sql2.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Value not saved");
                    }

                    try
                    {

                        MessageBox.Show("Sign Up Successfully");
                        txt_CreateAccount_Name.Text = "";
                        txt_CreateAccount_Email.Text = "";
                        txt_CreateAccount_Password.Text = "";
                        txt_CreateAccount_ReEnterPassword.Text = "";
                        txt_CreateAccount_Username.Text = "";
                        pnl_Signup.Hide();
                        pnl_ForgotPass.Hide();
                        pnl_Login.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Wrong Try Again");
                    }



                    
                    

                    





                }
            }
                       
                    }
                    else
                    {
                        MessageBox.Show("Follow the signup rules user name and password length should be in 4 letter");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Fill the box");
                    }
                }
                else
                {
                    MessageBox.Show("Given Passwords are not same");
                }
        }
            
        
     

        private void chk_Login_PasswordMode_CheckedChanged(object sender, EventArgs e)
        {
         
            if (chk_Login_PasswordMode.Checked)
            {
                txt_Login_Password.isPassword = true;
            }
            else
            {
                txt_Login_Password.isPassword = false;
            }
           
        }

        private void txt_Login_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Login_Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Login_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_LogIn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_CreateAccount_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Email.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Username.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateAccount_ReEnterPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateAccount_ReEnterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_createAccount_signup.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        int move;
        int movex;
        int movey;

        private void pnl_Login_Top_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void pnl_Login_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void pnl_Login_Top_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        
        private void btn_Login_LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pnl_Login_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void txtbox_forgetPass_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ////btn_forgetPass_resetPassword.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_CreateAccount_Terms_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"By Signing up you are agreed that 
You will stay away from abusive use of the application");
        }


        private void Int_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txt_Login_Username.Text = Properties.Settings.Default.UserName;
                    txt_Login_Password.Text = Properties.Settings.Default.Password;
                    checkBox1.Checked = true;
                }
                else
                {
                    txt_Login_Username.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void save_data()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = txt_Login_Username.Text;
                Properties.Settings.Default.Password = txt_Login_Password.Text;
                Properties.Settings.Default.Remme = "Yes";
                Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.UserName = txt_Login_Username.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "No";
                Properties.Settings.Default.Save();
            }
        }


    }
}
