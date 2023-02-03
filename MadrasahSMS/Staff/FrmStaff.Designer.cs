
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
            this.iconButtonAddStaff = new FontAwesome.Sharp.IconButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.iconButtonStaffList = new FontAwesome.Sharp.IconButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonAddStaff
            // 
            this.iconButtonAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddStaff.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.iconButtonAddStaff.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddStaff.IconSize = 32;
            this.iconButtonAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStaff.Location = new System.Drawing.Point(403, 12);
            this.iconButtonAddStaff.Name = "iconButtonAddStaff";
            this.iconButtonAddStaff.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonAddStaff.Size = new System.Drawing.Size(160, 40);
            this.iconButtonAddStaff.TabIndex = 5;
            this.iconButtonAddStaff.Text = "Add Staff";
            this.iconButtonAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddStaff.UseVisualStyleBackColor = true;
            this.iconButtonAddStaff.Click += new System.EventHandler(this.iconButtonAddStaff_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.iconButtonStaffList);
            this.panelControl.Controls.Add(this.iconButtonAddStaff);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(800, 75);
            this.panelControl.TabIndex = 6;
            // 
            // iconButtonStaffList
            // 
            this.iconButtonStaffList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonStaffList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStaffList.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButtonStaffList.IconColor = System.Drawing.Color.Black;
            this.iconButtonStaffList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStaffList.IconSize = 32;
            this.iconButtonStaffList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStaffList.Location = new System.Drawing.Point(237, 12);
            this.iconButtonStaffList.Name = "iconButtonStaffList";
            this.iconButtonStaffList.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonStaffList.Size = new System.Drawing.Size(160, 40);
            this.iconButtonStaffList.TabIndex = 6;
            this.iconButtonStaffList.Text = "Staff List";
            this.iconButtonStaffList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStaffList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStaffList.UseVisualStyleBackColor = true;
            this.iconButtonStaffList.Click += new System.EventHandler(this.iconButtonStaffList_Click);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 75);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 375);
            this.panelBody.TabIndex = 7;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelControl);
            this.Name = "FrmStaff";
            this.Text = "Staff";
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddStaff;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton iconButtonStaffList;
    }
}