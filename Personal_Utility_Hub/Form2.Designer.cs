namespace Personal_Utility_Hub
{
    partial class Frm_Dashbord
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
            this.btn_UserProfile = new System.Windows.Forms.Button();
            this.btn_Notes = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_UserProfile
            // 
            this.btn_UserProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserProfile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_UserProfile.Location = new System.Drawing.Point(274, 277);
            this.btn_UserProfile.Name = "btn_UserProfile";
            this.btn_UserProfile.Size = new System.Drawing.Size(185, 74);
            this.btn_UserProfile.TabIndex = 3;
            this.btn_UserProfile.Text = "UserProfile";
            this.btn_UserProfile.UseVisualStyleBackColor = false;
            this.btn_UserProfile.Click += new System.EventHandler(this.btn_UserProfile_Click);
            // 
            // btn_Notes
            // 
            this.btn_Notes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Notes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Notes.Location = new System.Drawing.Point(274, 43);
            this.btn_Notes.Name = "btn_Notes";
            this.btn_Notes.Size = new System.Drawing.Size(185, 74);
            this.btn_Notes.TabIndex = 1;
            this.btn_Notes.Text = "Notes";
            this.btn_Notes.UseVisualStyleBackColor = false;
            this.btn_Notes.Click += new System.EventHandler(this.btn_Notes_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Logout.Location = new System.Drawing.Point(274, 394);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(185, 74);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Convert.Location = new System.Drawing.Point(274, 160);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(185, 74);
            this.btn_Convert.TabIndex = 2;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // Frm_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(776, 491);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Notes);
            this.Controls.Add(this.btn_UserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Dashbord";
            this.Text = "Dashbord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UserProfile;
        private System.Windows.Forms.Button btn_Notes;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Convert;
    }
}