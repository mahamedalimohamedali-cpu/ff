using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Personal_Utility_Hub
{
    public partial class Frm_Notes : Form
    {
        public Frm_Notes()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Notes.Text = string.Empty;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {


            bool Case = MessageBox.Show("Do You Want To Copy In Clipboard?", "Conferm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
            if (Case)
            {
                Clipboard.SetText(Txt_Notes.Text);
            }
            else
            {
                
                bool FileCase = MessageBox.Show("Do You Want To Copy In TextFile?", "Conferm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;

                if (FileCase)
                {
                    string FilePath = "C:\\Users\\eltah\\Desktop\\pp.txt";

                    Txt_Notes.Text += "\n";

                    File.AppendAllText(FilePath, Txt_Notes.Text);

                    MessageBox.Show("Done It Save In (C:\\Users\\eltah\\Desktop\\pp.txt) ", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else 
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Notes.Text == string.Empty)
            {
                bool Case = MessageBox.Show("Do You Want To Leave Wituot Copy In Clipboard?", "Conferm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;

                if (Case)
                {
                    this.Close();
                }
            }
            else 
            {
                this.Close();
            }
        }
    }
}
