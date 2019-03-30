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
using ExcelDataReader;
using System.Xml;
using System.Resources;
using System.Data.OleDb;
using LinqToExcel;
using Remotion.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Project_Management
{
    public partial class Form1 : Form
    {   
        int num = 0;
        int MenuPanelWidth;
        int ifCourseChoosed = 0;
        bool MenuHidden;
        public string temporaryCourse;
        public string temporaryUser;
        public int createGroupVariable = 0;
        public int EditGroupVariable = 0;

       

        public Form1(string temporaryUser)
        {
            this.temporaryUser = temporaryUser;
            InitializeComponent();
            MenuPanelWidth = pnl_LeftCatagory.Width;
            MenuHidden = true;
            pnl_LeftCatagory.Hide();
            HideAllPanel();
            pnl_CourseChooser.Show();
           // picbox_help_slide.Image =
               // Image.FromFile("img/1.jpg");
            
        }

        private void HideAllPanel()
        {
            pnl_CreateGroup.Hide();
            pnl_CreateGroupTop.Hide();
            pnl_ViewAGroup.Hide();
            pnl_EditGroup.Hide();
            pnl_ShowGroups.Hide();
            pnl_ImportSection.Hide();
            pnl_ShowSections.Hide();
            pnl_Viva.Hide();
            pnl_LeftCatagory.Hide();
            pnl_AddStudent.Hide();
            
            pnl_AddTopic.Hide();
            pnl_FirstPage.Hide();
            createGroupVariable = 0;
            EditGroupVariable = 0;
           

        }

        private void ClearAllFlowLayoutPanel()
        {
            flp_show_sec.Controls.Clear();
            flp_showGroups.Controls.Clear();
            flw_ViewGroup.Controls.Clear();
            txt_ViewGroup_GroupName.Text = "";
            txt_ViewGroup_GroupNumber.Text = "";
            txt_ViewGroup_NumberOfMember.Text = "";
            txt_ViewGroup_ProjectTitle.Text = "";
            fl_CreateGroup.Controls.Clear();
            flp_editgroup.Controls.Clear();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(ifCourseChoosed==1)
            {
            HideAllPanel();
            MenuHidden = true;
           //
            } 
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (ifCourseChoosed == 1)
            {
                pnl_LeftCatagory.Show();
                timer_Menu.Start();
            }
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        private void timer_Menu_Tick(object sender, EventArgs e)
        {
            
            if (MenuHidden)
            {
                pnl_LeftCatagory.Width = pnl_LeftCatagory.Width + 10;
                if (pnl_LeftCatagory.Width >= MenuPanelWidth)
                {
                    timer_Menu.Stop();
                    MenuHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_LeftCatagory.Width = pnl_LeftCatagory.Width - 10;
                if (pnl_LeftCatagory.Width <= 0)
                {
                    timer_Menu.Stop();
                    MenuHidden = true;
                    this.Refresh();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized; 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_ImportSection.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {

            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_CreateGroupTop.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();

        }

        private void btn_EditGroup_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_EditGroup.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void btn_ShowGroups_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_ShowGroups.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void btn_ViewAGroup_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_ViewAGroup.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void btn_Viva_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_Viva.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void btn_ShowSections_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            ClearAllFlowLayoutPanel();
            MenuHidden = true;
            pnl_ShowSections.Show();
            DataClass.CreateGroupAddStudent.Clear();
            DataClass.CreateGroupTemporary.Clear();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 f1 = new Form0();
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            createGroupVariable = 1;
            pnl_AddStudent.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btnCreateManually_Click(sender, e);
        }

        private void btnCreateManually_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            MenuHidden = true;
            pnl_CreateGroupTop.Hide();
            pnl_CreateGroup.Show();

        }

        private void btn_ImportGroup_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string a= ofd.FileName;
                string b = ofd.SafeFileName;
                pnl_CreateGroupTop.Hide();
                pnl_CreateGroup.Show();
            }
        }

        private void txt_ProjectTitle_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_GroupNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_GroupName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ProjectTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnl_CreateGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_NumberOfMember_Click(object sender, EventArgs e)
        {

        }

        private void lbl_GroupNumber_Click(object sender, EventArgs e)
        {

        }

        private void txt_NumberOfMember_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_SemesterChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_StudentName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_StudentId_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Section_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ProjectPart_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveGroup_Click(object sender, EventArgs e)
        {

            if ((txt_CreateGroup_NumberOfMember.Text != "") && (txt_CreateGroup_GroupName.Text != "") && (txt_CreateGroup_GroupNumber.Text != "") && (txt_CreateGroup_ProjectTitle.Text != "") && (cmb_CreateGroup_SemesterChooser.Text != "          Semester"))
            {
                string GroupName = txt_CreateGroup_GroupName.Text.ToString();
                string GroupNumber = txt_CreateGroup_GroupNumber.Text.ToString();
                int NoOfMember = int.Parse(txt_CreateGroup_NumberOfMember.Text);
                string ProjectTitle = txt_CreateGroup_ProjectTitle.Text.ToString();
                string semester = cmb_CreateGroup_SemesterChooser.Text.ToString();
                string subject = temporaryCourse;
                string username = temporaryUser;




                if ((NoOfMember >= 1) && (NoOfMember <= 4))
                {



                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True"))
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;

                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = @"INSERT INTO [tb_group] ([grp_groupNumber], [grp_groupName],[grp_projecttitle],[grp_NumberOfMember],[grp_semester],[grp_subject],[grp_userName]) VALUES ( @number, @name,@title,@member,@sem,@sub,@user)";
                        command.Parameters.Add("@number", SqlDbType.VarChar, 150).Value = GroupNumber;
                        command.Parameters.Add("@name", SqlDbType.VarChar, 150).Value = GroupName;
                        command.Parameters.Add("@title", SqlDbType.VarChar, 150).Value = ProjectTitle;
                        command.Parameters.Add("@member", SqlDbType.Int).Value = NoOfMember;
                        command.Parameters.Add("@sem", SqlDbType.VarChar, 150).Value = semester;
                        command.Parameters.Add("@sub", SqlDbType.VarChar, 150).Value = subject;
                        command.Parameters.Add("@user", SqlDbType.VarChar, 150).Value = username;

                        connection.Open();

                        command.ExecuteNonQuery();
                    }














                    /*  db_accountDataContext db1 = new db_accountDataContext();
                       tb_group acc1 = new tb_group();
                       acc1.grp_groupNumber = GroupNumber;
                       acc1.grp_groupName = GroupName;
                       acc1.grp_projectTitle = ProjectTitle;
                       acc1.grp_NumberOfMember = NoOfMember;
                       acc1.grp_semester = semester;
                       acc1.grp_subject = subject;
                       acc1.grp_userName = username;
                       db1.tb_groups.InsertOnSubmit(acc1);
                       db1.SubmitChanges();*/


                    int mark = 0;



                    foreach (string[] V1 in DataClass.CreateGroupTemporary)
                    {
                        string ax = V1[0];
                        string bx = V1[1];
                        string cx = V1[2];
                        string dx = V1[3];


                       
                        
                        // MessageBox.Show(V1[1]);

                        
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                        using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True"))
                         {
                             SqlCommand command = new SqlCommand();
                             command.Connection = connection;

                             command.CommandType = System.Data.CommandType.Text;
                             command.CommandText = @"INSERT INTO [tb_groupMember] ([grpm_stdName], [grpm_stdId],[grpm_section],[grpm_stdPart],[grpm_stdMark],[grpm_groupNumber],[grpm_subject],[grpm_semester]) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)";
                             command.Parameters.Add("@a", SqlDbType.VarChar, 150).Value = ax;
                             command.Parameters.Add("@b", SqlDbType.VarChar, 150).Value =bx;
                             command.Parameters.Add("@c", SqlDbType.VarChar, 150).Value = cx;
                             command.Parameters.Add("@d", SqlDbType.VarChar, 150).Value = dx;
                             
                             command.Parameters.Add("@e", SqlDbType.Int).Value = mark;
                             command.Parameters.Add("@f", SqlDbType.VarChar, 150).Value =GroupNumber;
                             command.Parameters.Add("@g", SqlDbType.VarChar, 150).Value = subject;
                             command.Parameters.Add("@h", SqlDbType.VarChar, 150).Value = semester;
                             

                             connection.Open();

                             command.ExecuteNonQuery();
                         }

                        


                       db_accountDataContext db = new db_accountDataContext();
                        tb_groupMember acc = new tb_groupMember();
                        acc.grpm_stdName = ax;
                        acc.grpm_stdId = bx;
                        acc.grpm_section = cx;
                        acc.grpm_stdPart = dx;
                        acc.grpm_stdMark = 0;
                        acc.grpm_groupNumber = GroupNumber;
                        acc.grpm_subject = subject;
                        acc.grpm_semester = semester;
                        acc.grpm_username = username;
                        db.tb_groupMembers.InsertOnSubmit(acc);
                        db.SubmitChanges();



                    }
                    MessageBox.Show("Group Created Successfully");
                    DataClass.CreateGroupAddStudent.Clear();
                    DataClass.CreateGroupTemporary.Clear();
                    fl_CreateGroup.Controls.Clear();
                    txt_CreateGroup_NumberOfMember.Text = "";
                    txt_CreateGroup_GroupName.Text = "";
                    txt_CreateGroup_GroupNumber.Text = "";
                    txt_CreateGroup_ProjectTitle.Text = "";

                }
                else
                {
                    MessageBox.Show("Invalid Group Number. Group Member should be maximum 4");
                }
            }


            else
            {
                MessageBox.Show("Please Fill all the required Fields");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            if(ifCourseChoosed==1)
            {
            HideAllPanel();
            MenuHidden = true;
            
            }
            else
            {
                MessageBox.Show("Please Choose a Course First");
            }
        }

        DataSet result;
        string text2 = "Sheet1";
        string text1;
        private void btn_ImportSection_ImportSection_Click(object sender, EventArgs e)
        {

            if (txt_ImportSection_SheetName.Text == "")
            {
                MessageBox.Show("Please choose a Sheet name First");
            }
            else
            {

                string sheetName = txt_ImportSection_SheetName.Text;
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Excel workbook|*.xls";
                if (ofd.ShowDialog() == DialogResult.OK)
                {


                    text1 = ofd.FileName;
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet DtSet;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    MyConnection =
                        new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + text1 +
                                                              ";Extended Properties=Excel 8.0;");
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [" + sheetName + "$]", MyConnection);
                    MyCommand.TableMappings.Add("Table", "Net-informations.com");
                    DtSet = new System.Data.DataSet();
                    MyCommand.Fill(DtSet);
                    dataGridView1.DataSource = DtSet.Tables[0];
                    MyConnection.Close();



                }
            }
        }

        private void txt_EditGroup_GroupNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ShowGroups_GroupName_Click(object sender, EventArgs e)
        {

        }

        private void btn_ShowGroups_Go_Click(object sender, EventArgs e)
        {
            flp_showGroups.Controls.Clear();

            flp_showGroups.AutoScroll = false;
            flp_showGroups.HorizontalScroll.Enabled = false;
            flp_showGroups.HorizontalScroll.Visible = false;
            flp_showGroups.HorizontalScroll.Maximum = 0;
            flp_showGroups.AutoScroll = true;

            string semester = cmb_ShowGroups_SemesterChoose.Text.ToString();
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                        where p.grp_semester.Contains(semester)
                        where p.grp_subject.Contains(temporaryCourse)
                        where p.grp_userName.Contains(temporaryUser)
                        select p;

            foreach (var a in prods)
            {
                string grpnum = a.grp_groupNumber;
                string grpname = a.grp_groupName;
                string numOfmem = a.grp_NumberOfMember.ToString();
                string projName = a.grp_projectTitle;

                this.flp_showGroups.Controls.Add(new UcShowGroups(grpnum, grpname, numOfmem, projName));

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CourseChooser_Go_Click(object sender, EventArgs e)
        {
            if (cmb_CourseChooser_ChooseSubject.Text!="                         Course")
            {
            pnl_CourseChooser.Hide();
            HideAllPanel();
            pnl_FirstPage.Show();
            ifCourseChoosed = 1;
            temporaryCourse = cmb_CourseChooser_ChooseSubject.Text;
            }
            else
            {
                MessageBox.Show("Please Select a Course to continue");
            }
        }

        private void btn_ImportSection_Save_Click(object sender, EventArgs e)
        {
            if (txt_ImportSection_Section.Text == "")
            {
                MessageBox.Show("Section Cannot be Empty");
            }
            else
            {

                for (int i = 0; i < dataGridView1.RowCount - 1; i++) // array rows
                {

                   // db_accountDataContext db = new db_accountDataContext();
                   // tb_section acc = new tb_section();
                    string v1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string v2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string v3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string v4 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    //string s5 = txt_ImportSection_Section.Text;
                    string v5 = cmb_ImportSection_SemesterChooser.Text.ToString();
                    string v6 = "No";
                    string v7 = temporaryCourse;
                    string v8 = temporaryUser;

                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UH9DSCF\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True"))
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;

                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = @"INSERT INTO [tb_section] ([serial], [sec_st_name],[sec_st_id],[sec_st_section],[sec_semester],[sec_inGroup],[sec_subject],[sec_username]) VALUES (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)";
                        command.Parameters.Add("@s1", SqlDbType.VarChar, 150).Value = v1;
                        command.Parameters.Add("@s2", SqlDbType.VarChar, 150).Value = v2;
                        command.Parameters.Add("@s3", SqlDbType.VarChar, 150).Value = v3;
                        command.Parameters.Add("@s4", SqlDbType.VarChar, 150).Value = v4;

                        command.Parameters.Add("@s5", SqlDbType.VarChar, 150).Value = v5;
                        command.Parameters.Add("@s6", SqlDbType.VarChar, 150).Value = v6;
                        command.Parameters.Add("@s7", SqlDbType.VarChar, 150).Value = v7;
                        command.Parameters.Add("@s8", SqlDbType.VarChar, 150).Value = v8;


                        connection.Open();

                        command.ExecuteNonQuery();
                    }


                    //db.tb_sections.InsertOnSubmit(acc);
                    //db.SubmitChanges();
                }

                MessageBox.Show("Data Saved Successfully");
                txt_ImportSection_SheetName.Text = "";
                txt_ImportSection_Section.Text = "";
                cmb_ImportSection_SemesterChooser.SelectedIndex = 0;
            }


        }

        private void btn_viva_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawString(this.textBox1.Text, this.textBox1.Font, Brushes.Black, 10, 25);
        }

        private void btn_showgroup_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void cmb_CourseChooser_ChooseSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_CourseChooser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_ShowGroups_Paint(object sender, PaintEventArgs e)
        {

        }

        private void previousImage(object sender, EventArgs e)
        {
            num--;
            if (num < 1)
            {
                num = 1;
            }
           // picbox_help_slide.Image =
               // Image.FromFile("img/" + num + ".jpg");
        }

        private void nextImage(object sender, EventArgs e)
        {
            num++;
            if (num == 6)
            {
                num = 1;
            }
            //picbox_help_slide.Image =
               // Image.FromFile("img/" + num + ".jpg");
        }

        private void btn_Facebook_Tonmoy_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.facebook.com/tonmoy.asif";
                myProcess.Start();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void btn_Facebook_Rony_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/sakawathossain.rony";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_Facebook_Karno_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/karno.sarker";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_Facebook_Kanon_Click(object sender, EventArgs e)
        {
            {
                Process myProcess = new Process();

                try
                {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.facebook.com/rafique.kanon";
                    myProcess.Start();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }

        private void btn_AddStudent_Back_Click(object sender, EventArgs e)
        {
            if (createGroupVariable ==1)
            {
                createGroupVariable = 0;
                HideAllPanel();
                pnl_CreateGroup.Show();
            }
            else if (EditGroupVariable == 1)
            {
               EditGroupVariable = 0;
                HideAllPanel();
                pnl_EditGroup.Show();
            }
            flp_addStudent.Controls.Clear();
        }

        private void btn_AddStudent_Go_Click(object sender, EventArgs e)
        {
            flp_addStudent.Controls.Clear();
            string semester = cmb_AddStudent_SemesterChooser.Text.ToString();
            string section = cmb_AddStudent_SectionChooser.Text.ToString();

            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_sections
                where p.sec_semester.Contains(semester)
                where p.sec_st_section.Contains(section)
                select p;

            foreach (var a in prods)
            {
                string sname = a.sec_st_name;
                string sid = a.sec_st_id;
                string sSec = a.sec_st_section;
                string sSelect = a.sec_inGroup;

                 this.flp_addStudent.Controls.Add(new UcAddStudent(sname, sid, sSec, sSelect));

            }


        }
        public string[] ArrayEditGroup = new string[4];
        private void btn_ViewGroup_Go_Click(object sender, EventArgs e)
        {
            flw_ViewGroup.Controls.Clear();
            flw_ViewGroup.AutoScroll = false;
            flw_ViewGroup.HorizontalScroll.Enabled = false;
            flw_ViewGroup.HorizontalScroll.Visible = false;
            flw_ViewGroup.HorizontalScroll.Maximum = 0;
            flw_ViewGroup.AutoScroll = true;

            txt_ViewGroup_GroupName.Text = "";
            //txt_ViewGroup_GroupNumber.Text = "";
            txt_ViewGroup_NumberOfMember.Text = "";
            txt_ViewGroup_ProjectTitle.Text = "";
            string semester = cmb_ViewGroup_Semester.Text.ToString();
            string grpnum = txt_ViewGroup_GroupNumber.Text.ToString();
            tb_group tbg = new tb_group();
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpnum)
                where p.grp_userName.Contains(temporaryUser)
                where p.grp_subject.Contains(temporaryCourse)
                select p;
            foreach (var a in prods)
            {
                
                txt_ViewGroup_GroupName.Text = a.grp_groupName;
                txt_ViewGroup_ProjectTitle.Text = a.grp_projectTitle;
                txt_ViewGroup_NumberOfMember.Text = a.grp_NumberOfMember.ToString();
              

            }
          
            db_accountDataContext db1 = new db_accountDataContext();
            var prods1 = from p in db1.tb_groupMembers
                where p.grpm_semester.Contains(semester)
                where p.grpm_groupNumber.Contains(grpnum)
                where p.grpm_username.Contains(temporaryUser)
                where p.grpm_subject.Contains(temporaryCourse)
                select p;
            foreach (var a in prods1)
            {
                string name = a.grpm_stdName;
                string id = a.grpm_stdId;
               
                string section = a.grpm_section;
                string part = a.grpm_stdPart;
                string mark = a.grpm_stdMark.ToString();
              

                this.flw_ViewGroup.Controls.Add(new UserControl_ViewGroup(name, id, section, part, mark));

            }
        }

        private void btn_Viva_Go_Click(object sender, EventArgs e)
        {
            string semester = cmb_Viva_Semester.Text.ToString();
            string grpNumber = txt_Viva_GroupNumber.Text.ToString();
            // MessageBox.Show(semester);
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups

                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpNumber)
                select p;



            var pord = from q in db.tb_groupMembers

                where q.grpm_semester.Contains(semester)
                where q.grpm_groupNumber.Contains(grpNumber)
                select q;


            foreach (var a in prods)
            {
                string groupname = a.grp_groupName;
                string projecttitle = a.grp_projectTitle;


                // this.flp_show_sec.Controls.Add(new Uc_ShowSection(secstudentnum, secstudentid, secstudentsec, secingroup));
                txt_Viva_GroupName.Text = groupname;
                txt_Viva_ProjectTitle.Text = projecttitle;
            }

            foreach (var b in pord)
            {
                string stuname = b.grpm_stdName;
                string stuid = b.grpm_stdId;


                this.flw_Viva.Controls.Add(new UserControl_Viva(stuname, stuid));
                // txt_viva_name1.Text = stuname;
                // txt_viva_id1.Text = stuid;
            }
        }

        private void btn_ShowSections_Go_Click(object sender, EventArgs e)
        {
            ClearAllFlowLayoutPanel();
            flp_show_sec.AutoScroll = false;
            flp_show_sec.HorizontalScroll.Enabled = false;
            flp_show_sec.HorizontalScroll.Visible = false;
            flp_show_sec.HorizontalScroll.Maximum = 0;
            flp_show_sec.AutoScroll = true;


            string semester = cmb_ShowSections_SemesterChooser.Text.ToString();
            string section = cmb_ShowSections_SectionChooser.Text.ToString();
            // MessageBox.Show(semester);
            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_sections
                where p.sec_semester.Contains(semester)
                where p.sec_st_section.Contains(section)
                where p.sec_subject.Contains(temporaryCourse)
                where p.sec_username.Contains(temporaryUser)
                select p;


            foreach (var a in prods)
            {
                string secstudentnum = a.sec_st_name;
                string secstudentid = a.sec_st_id;
                string secstudentsec = a.sec_st_section;
                string secingroup = a.sec_inGroup;

                this.flp_show_sec.Controls.Add(new Uc_ShowSection(secstudentnum, secstudentid, secstudentsec, secingroup));
                //txt_Viva_GroupName.Text = secstudentnum;
            }
        }

        private void btn_EditGroup_AddMember_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            EditGroupVariable = 1;
            pnl_AddStudent.Show();
        }

        public string[] ArrayEditGroup1 = new string[4];
        private void btn_EditGroup_Go_Click(object sender, EventArgs e)
        {
            flp_editgroup.Controls.Clear();
            string semester = cmb_EditGroup_SemesterChooser.Text.ToString();
            string grpno = txt_EditGroup_GroupNo.Text.ToString();

            db_accountDataContext db = new db_accountDataContext();
            var prods = from p in db.tb_groups
                where p.grp_semester.Contains(semester)
                where p.grp_groupNumber.Contains(grpno)
                select p;

            var prod = from q in db.tb_groupMembers
                where q.grpm_semester.Contains(semester)
                where q.grpm_groupNumber.Contains(grpno)
                select q;




            foreach (var a in prods)
            {
                string grpname = a.grp_groupName;
                string projecttitle = a.grp_projectTitle;
                string noofmem = a.grp_NumberOfMember.ToString();


                //this.flp_addStudent.Controls.Add(new UcAddStudent(sname, sid, sSec, sSelect));
                txt_EditGroup_GroupName.Text = grpname;
                txt_EditGroup_ProjectTitle.Text = projecttitle;
                txt_EditGroup_NumberOfMember.Text = noofmem;
            }

            foreach (var b in prod)
            {
                string stuname = b.grpm_stdName;
                string stuid = b.grpm_stdId;
                string stusec = b.grpm_section;
                string stupart = b.grpm_stdPart;



                ArrayEditGroup1[0] = stuname;
                ArrayEditGroup1[1] = stuid;
                ArrayEditGroup1[2] = stusec;
                ArrayEditGroup1[3] = stupart;
                DataClass.EDitGroupTemporaryList.Add(ArrayEditGroup1);
                DataClass.EditGroupAddStudentList.Add(ArrayEditGroup1);



                this.flp_editgroup.Controls.Add(new UcEditGroup(stuname, stuid, stusec, stupart));

            }

        }


        //private UcAddStudent s1;

        public void btn_AddStudent_Save_Click(object sender, EventArgs e)
        {
            
            flp_editgroup.Controls.Clear();
            fl_CreateGroup.Controls.Clear();
            //foreach (Control s in flp_addStudent.Controls)
            //{

            //    //if (s.Name=="")
            //  //  {
            //        MessageBox.Show(s.Name);
            //  //  }
            //    // if()
            //    //if(s)
            //    //if (s.Contains())
            //    // {
            //    //     MessageBox.Show(label1.Text.ToString());
            //    // }
            //    // else
            //    //  MessageBox.Show("what");
            //}


            if (createGroupVariable == 1)
            {
                foreach (string[] c in DataClass.CreateGroupAddStudent)
                {
                    fl_CreateGroup.Controls.Add(new UcCreateGroup(c[0], c[1], c[2], c[3]));
                }

                HideAllPanel();
                pnl_CreateGroup.Show();
                createGroupVariable = 0;
            }
            else if (EditGroupVariable == 1)
            {
                foreach (string[] c in DataClass.EditGroupAddStudentList)
                {
                    flp_editgroup.Controls.Add(new UcEditGroup(c[0], c[1], c[2], c[3]));
                }

                HideAllPanel();
                pnl_EditGroup.Show();
                EditGroupVariable = 0;
            }
            flp_addStudent.Controls.Clear();

        }

        int move;
        int movex;
        int movey;

        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void pnl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void pnl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void cmb_ImportSection_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ImportSection_Section.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ImportSection_Section_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ImportSection_ImportSection.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_CreateGroup_SemesterChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_CreateGroup_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_GroupName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_GroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_ProjectTitle.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_ProjectTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_CreateGroup_NumberOfMember.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_CreateGroup_NumberOfMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CreateGroup_AddMember.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_CourseChooser_ChooseSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_CourseChooser_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowSections_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_ShowSections_SectionChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowSections_SectionChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ShowSections_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ShowGroups_SemesterChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ShowGroups_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ViewGroup_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_ViewGroup_Semester.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_ViewGroup_Semester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ViewGroup_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_EditGroup_GroupNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_EditGroup_SemesterChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_EditGroup_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_EditGroup_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Viva_GroupNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Viva_Semester.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_Viva_Semester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Viva_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_AddStudent_SemesterChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_AddStudent_SectionChooser.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmb_AddStudent_SectionChooser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AddStudent_Go.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_AddTopic_topic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AddTopic_Ok.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_Editroup_Save_Click(object sender, EventArgs e)
        {

            string GroupName = txt_EditGroup_GroupName.Text.ToString();
            string GroupNumber = txt_EditGroup_GroupNo.Text.ToString();
            int NoOfMember = int.Parse(txt_EditGroup_NumberOfMember.Text);
            string ProjectTitle = txt_EditGroup_ProjectTitle.Text.ToString();
            string semester = cmb_EditGroup_SemesterChooser.Text.ToString();
            string subject = temporaryCourse;
            string username = temporaryUser;
            
            db_accountDataContext db1 = new db_accountDataContext();
            tb_group acc1 = db1.tb_groups.SingleOrDefault(x => x.grp_groupNumber == GroupNumber);
            acc1.grp_groupName = GroupName;
            acc1.grp_projectTitle = ProjectTitle;
            acc1.grp_NumberOfMember = NoOfMember;
            acc1.grp_semester = semester;
            acc1.grp_subject = subject;
            acc1.grp_userName = username;
            // db1.tb_groups.InsertOnSubmit(acc1);
            db1.SubmitChanges();
            
            
            foreach (string[] V1 in DataClass.EDitGroupTemporaryList)
            {
                string ax = V1[0];
                string bx = V1[1];
                string cx = V1[2];
                string dx = V1[3];
                // MessageBox.Show(V1[1]);
                

                db_accountDataContext db = new db_accountDataContext();
                tb_groupMember acc = db.tb_groupMembers.SingleOrDefault(x => x.grpm_stdId == bx);

                acc.grpm_stdName = ax;
                acc.grpm_section = cx;
                acc.grpm_stdPart = dx;
                acc.grpm_stdMark = 0;
                acc.grpm_groupNumber = GroupNumber;
                acc.grpm_subject = subject;
                acc.grpm_semester = semester;
                acc.grpm_username = username;
               //db.tb_groupMembers.InsertOnSubmit(acc);
                db.SubmitChanges();

                MessageBox.Show("Success");
            }
        }

        private void pnl_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_ImportSection_SemesterChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_ShowSections_SemesterChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_ImportSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_ImportSection_SheetName_Enter(object sender, EventArgs e)
        {
            if (txt_ImportSection_SheetName.Text == "Enter Sheet Name")
            {
                txt_ImportSection_SheetName.Text = "";
                txt_ImportSection_SheetName.ForeColor = Color.White;
               
            }
        }

        private void txt_ImportSection_SheetName_Leave(object sender, EventArgs e)
        {
            if (txt_ImportSection_SheetName.Text == "")
            {
                txt_ImportSection_SheetName.Text = "Enter Sheet Name";
                txt_ImportSection_SheetName.ForeColor = Color.Gray;
            }
        }

        }
    }

