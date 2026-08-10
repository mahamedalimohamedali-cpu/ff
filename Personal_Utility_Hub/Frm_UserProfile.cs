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
    public partial class Frm_UserProfile : Form
    {
        public Frm_UserProfile()
        {
            InitializeComponent();
        }


        struct stPerson 
        {
            public string FirstName;
            public string LastName;
            public int BirthDay;
            public string Address;
            public string Phone;
        }
        

        private void btn_Print_Click(object sender, EventArgs e)
        {
            

            stPerson P1 = new stPerson();

            DateTime dt = new DateTime();

            dt = DateTime.Now;

            P1.FirstName = Txt_FirstName.Text;
            P1.LastName = Txt_LastName.Text;
            P1.BirthDay  = dt.Year - Convert.ToInt32(Txt_BirthDay.Text);
            P1.Address   = Txt_Address.Text;
            P1.Phone     = Txt_Phone.Text;

            if (!P1.Equals(default(stPerson)))
            {
                MessageBox.Show("You Data....\n" +
                    $"Name : {P1.FirstName + P1.LastName}\n" +
                    $"Age: {P1.BirthDay}\n" +
                    $"Address: {P1.Address}\n" +
                    $"Phone: {P1.Phone}\n", "UserProfile", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else 
            {
                MessageBox.Show("Data Not Exste To Print?", "UserProfile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool Case= MessageBox.Show("Do You Want Close Without Full Data?", "UserProfile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)==DialogResult.Yes;

            if (Case) 
            {
                this.Close();
            }
        }
    }
}
