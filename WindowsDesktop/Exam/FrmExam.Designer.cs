
namespace WindowsDesktop.Exam
{
    partial class FrmExam
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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.buttonExamSchedule = new System.Windows.Forms.Button();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 70);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 380);
            this.panelBody.TabIndex = 5;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.buttonExamSchedule);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 70);
            this.panelTopMenu.TabIndex = 4;
            // 
            // buttonExamSchedule
            // 
            this.buttonExamSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExamSchedule.Location = new System.Drawing.Point(337, 12);
            this.buttonExamSchedule.Name = "buttonExamSchedule";
            this.buttonExamSchedule.Size = new System.Drawing.Size(126, 38);
            this.buttonExamSchedule.TabIndex = 36;
            this.buttonExamSchedule.Text = "Exam Schedule";
            this.buttonExamSchedule.UseVisualStyleBackColor = true;
            this.buttonExamSchedule.Click += new System.EventHandler(this.buttonExamSchedule_Click);
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "FrmExam";
            this.Text = "Exam";
            this.panelTopMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Button buttonExamSchedule;
    }
}