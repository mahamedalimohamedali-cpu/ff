namespace Personal_Utility_Hub
{
    partial class Frm_Notes
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
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.BackColor = System.Drawing.SystemColors.MenuText;
            this.Txt_Notes.ForeColor = System.Drawing.SystemColors.Menu;
            this.Txt_Notes.Location = new System.Drawing.Point(258, 117);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(257, 37);
            this.Txt_Notes.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(398, 182);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(117, 44);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Send.Location = new System.Drawing.Point(258, 182);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(117, 44);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send_ToDashbord";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your Note Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notse";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(328, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go_Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Txt_Notes);
            this.Name = "Frm_Notes";
            this.Text = "Frm_Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}