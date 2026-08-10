using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personal_Utility_Hub
{
    public partial class Frm_Dashbord : Form
    {
        public Frm_Dashbord()
        {
            InitializeComponent();
        }


        private void btn_Notes_Click(object sender, EventArgs e)
        {
            Form fr = new Frm_Notes();

         
            fr.ShowDialog();
          
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            Form fr = new Frm_Convert();

        
            fr.ShowDialog();

        }

        private void btn_UserProfile_Click(object sender, EventArgs e)
        {
            Form fr = new Frm_UserProfile();
          
            fr.ShowDialog();
        }
        
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
