using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management
{
    public partial class UserControl_Viva : UserControl
    {
        public UserControl_Viva(string name, string id)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = id;
        }

        private void UserControl_Viva_Load(object sender, EventArgs e)
        {

        }
    }
}
