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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Form frmDashbord = new Frm_Dashbord();
            if (textBox1.Text == "Admin" && textBox2.Text == "1234") 
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                frmDashbord.ShowDialog();
             
            }
            else
            {

                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;

                bool Case = MessageBox.Show("Password Or User Name Is Not Correct!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)==DialogResult.OK;

                if (Case)
                {
                    textBox2.Text = string.Empty;
                    textBox1.Text = string.Empty;
                }
                else 
                {
                    this.Close();
                }
            }
        }

      
    }
}
