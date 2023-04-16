
namespace MadrasahSMS.Staff
{
    partial class FrmStaff
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.menuStripStaff = new System.Windows.Forms.MenuStrip();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 24);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(600, 358);
            this.panelBody.TabIndex = 7;
            // 
            // menuStripStaff
            // 
            this.menuStripStaff.BackColor = System.Drawing.Color.Transparent;
            this.menuStripStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffListToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.userManageToolStripMenuItem});
            this.menuStripStaff.Location = new System.Drawing.Point(0, 0);
            this.menuStripStaff.Name = "menuStripStaff";
            this.menuStripStaff.Size = new System.Drawing.Size(600, 24);
            this.menuStripStaff.TabIndex = 8;
            this.menuStripStaff.Text = "menuStrip1";
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // userManageToolStripMenuItem
            // 
            this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
            this.userManageToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.userManageToolStripMenuItem.Text = "User Manage";
            this.userManageToolStripMenuItem.Click += new System.EventHandler(this.userManageToolStripMenuItem_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.menuStripStaff);
            this.MainMenuStrip = this.menuStripStaff;
            this.Name = "FrmStaff";
            this.Text = "Staff";
            this.menuStripStaff.ResumeLayout(false);
            this.menuStripStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.MenuStrip menuStripStaff;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManageToolStripMenuItem;
    }
}