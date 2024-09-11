namespace Activity_2
{
    partial class frm_profileform
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
            this.pb_profilepic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_profilepic
            // 
            this.pb_profilepic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_profilepic.Image = global::Activity_2.Properties.Resources.user_profile_icon_free_vector;
            this.pb_profilepic.Location = new System.Drawing.Point(41, 24);
            this.pb_profilepic.Name = "pb_profilepic";
            this.pb_profilepic.Size = new System.Drawing.Size(231, 234);
            this.pb_profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profilepic.TabIndex = 0;
            this.pb_profilepic.TabStop = false;
            this.pb_profilepic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pb_profilepic);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 698);
            this.panel1.TabIndex = 1;
            // 
            // frm_profileform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 691);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_profileform";
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_profilepic;
        private System.Windows.Forms.Panel panel1;
    }
}

