
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
            this.buttonExam = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.panelAcademicBody = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.buttonExam);
            this.panelTopMenu.Controls.Add(this.buttonSubject);
            this.panelTopMenu.Controls.Add(this.buttonClass);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 70);
            this.panelTopMenu.TabIndex = 0;
            // 
            // buttonExam
            // 
            this.buttonExam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExam.Location = new System.Drawing.Point(469, 12);
            this.buttonExam.Name = "buttonExam";
            this.buttonExam.Size = new System.Drawing.Size(126, 38);
            this.buttonExam.TabIndex = 36;
            this.buttonExam.Text = "Exam";
            this.buttonExam.UseVisualStyleBackColor = true;
            this.buttonExam.Click += new System.EventHandler(this.buttonExam_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubject.Location = new System.Drawing.Point(337, 12);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(126, 38);
            this.buttonSubject.TabIndex = 35;
            this.buttonSubject.Text = "Subject";
            this.buttonSubject.UseVisualStyleBackColor = true;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClass.Location = new System.Drawing.Point(205, 12);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(126, 38);
            this.buttonClass.TabIndex = 33;
            this.buttonClass.Text = "Class";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // panelAcademicBody
            // 
            this.panelAcademicBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcademicBody.Location = new System.Drawing.Point(0, 70);
            this.panelAcademicBody.Name = "panelAcademicBody";
            this.panelAcademicBody.Size = new System.Drawing.Size(800, 380);
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
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Panel panelAcademicBody;
        private System.Windows.Forms.Button buttonExam;
    }
}