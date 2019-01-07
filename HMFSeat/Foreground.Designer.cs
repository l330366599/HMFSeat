namespace HMFSeat
{
    partial class Foreground
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI1,
            this.TSMI2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI1
            // 
            this.TSMI1.Name = "TSMI1";
            this.TSMI1.Size = new System.Drawing.Size(68, 21);
            this.TSMI1.Text = "座位预约";
            this.TSMI1.Click += new System.EventHandler(this.TSMI1_Click);
            // 
            // TSMI2
            // 
            this.TSMI2.Name = "TSMI2";
            this.TSMI2.Size = new System.Drawing.Size(68, 21);
            this.TSMI2.Text = "预约签到";
            this.TSMI2.Click += new System.EventHandler(this.TSMI2_Click);
            // 
            // Foreground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Foreground";
            this.Text = "Foreground";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Foreground_FormClosed);
            this.Load += new System.EventHandler(this.Foreground_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI2;
        public System.Windows.Forms.ToolStripMenuItem TSMI1;
    }
}