namespace C___GUIproject
{
    partial class frm_frame1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_formpanelright = new Panel();
            pnl_formpanelleft = new Panel();
            SuspendLayout();
            // 
            // pnl_formpanelright
            // 
            pnl_formpanelright.Dock = DockStyle.Right;
            pnl_formpanelright.Location = new Point(376, 0);
            pnl_formpanelright.Name = "pnl_formpanelright";
            pnl_formpanelright.Size = new Size(606, 753);
            pnl_formpanelright.TabIndex = 0;
            // 
            // pnl_formpanelleft
            // 
            pnl_formpanelleft.Dock = DockStyle.Left;
            pnl_formpanelleft.Location = new Point(0, 0);
            pnl_formpanelleft.Name = "pnl_formpanelleft";
            pnl_formpanelleft.Size = new Size(368, 753);
            pnl_formpanelleft.TabIndex = 1;
            pnl_formpanelleft.Paint += pnl_formpanelleft_Paint;
            // 
            // frm_frame1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(982, 753);
            Controls.Add(pnl_formpanelleft);
            Controls.Add(pnl_formpanelright);
            ForeColor = Color.DarkGoldenrod;
            Name = "frm_frame1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frame 1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_formpanelright;
        private Panel pnl_formpanelleft;
    }
}
