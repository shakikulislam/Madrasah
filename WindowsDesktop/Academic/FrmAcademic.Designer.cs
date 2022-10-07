﻿
namespace WindowsDesktop.Academic
{
    partial class FrmAcademic
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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.panelAcademicBody = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.buttonSubject);
            this.panelTopMenu.Controls.Add(this.buttonDepartment);
            this.panelTopMenu.Controls.Add(this.buttonClass);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 74);
            this.panelTopMenu.TabIndex = 0;
            // 
            // buttonSubject
            // 
            this.buttonSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubject.Location = new System.Drawing.Point(486, 12);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(160, 38);
            this.buttonSubject.TabIndex = 35;
            this.buttonSubject.Text = "Subject";
            this.buttonSubject.UseVisualStyleBackColor = true;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDepartment.Location = new System.Drawing.Point(154, 12);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(160, 38);
            this.buttonDepartment.TabIndex = 34;
            this.buttonDepartment.Text = "Department";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClass.Location = new System.Drawing.Point(320, 12);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(160, 38);
            this.buttonClass.TabIndex = 33;
            this.buttonClass.Text = "Class";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // panelAcademicBody
            // 
            this.panelAcademicBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcademicBody.Location = new System.Drawing.Point(0, 74);
            this.panelAcademicBody.Name = "panelAcademicBody";
            this.panelAcademicBody.Size = new System.Drawing.Size(800, 376);
            this.panelAcademicBody.TabIndex = 3;
            // 
            // FrmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAcademicBody);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "FrmAcademic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Academic Details";
            this.panelTopMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Button buttonDepartment;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Panel panelAcademicBody;
    }
}