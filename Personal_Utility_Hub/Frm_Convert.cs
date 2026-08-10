using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Personal_Utility_Hub
{
    public partial class Frm_Convert : Form
    {
       
        public Frm_Convert()
        {
            InitializeComponent();
        }

        int Number = default(int);


        private void btn_UpperCase_Click(object sender, EventArgs e)
        {
            Txt_Letter.Text = Txt_Letter.Text.ToUpper();
        }

        private void btn_Lower_Click(object sender, EventArgs e)
        {
            Txt_Letter.Text = Txt_Letter.Text.ToLower();
        }

        private void btn_TitleCase_Click(object sender, EventArgs e)
        {

            if (Txt_Letter.Text != string.Empty)
            {
                char c = char.ToUpper(Txt_Letter.Text.First());

                string Sub = Txt_Letter.Text.Substring(1);

                Txt_Letter.Text = c + Sub;
            }
        }

        private void btn_Bin_Click(object sender, EventArgs e)
        {
             int Number = Convert.ToInt32(Txt_Number.Text);

             string Bin = Convert.ToString(Number, 2);// 2 is Base Hear

            Txt_Number.Text = Bin;
        }

        private void btn_Hex_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(Txt_Number.Text);

            string Hex = Convert.ToString(Number, 16).ToUpper();// 16 is Base Hear

            Txt_Number.Text = Hex;
        }

        private void btn_Octal_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(Txt_Number.Text);

            string Oct = Convert.ToString(Number, 8);// 8 is Base Hear

            Txt_Number.Text = Oct;

        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            int Key = 101;
            char r = default(char);
            string Result = string.Empty;
            for (int i =0; i <Number;i++) 
            {
                r = Txt_Encrypt.Text[i];
                r ^=  (char)Key;
                Result += r;
            }

            Txt_Encrypt.Text = Result;
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            int Key = 101;
            char r = default(char);
            string Result = string.Empty;

            for (int i = 0; i <Number; i++)
            {
                r = Txt_Encrypt.Text[i];
                r ^= (char)Key;
                Result += r;
            }

            Txt_Encrypt.Text = Result;
        }

        private void Txt_Encrypt_TextChanged(object sender, EventArgs e)
        {

            Number = Txt_Encrypt.Text.Length;
        }

       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
