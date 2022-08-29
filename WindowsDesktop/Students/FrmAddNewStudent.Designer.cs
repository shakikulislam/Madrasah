
namespace WindowsDesktop.Students
{
    partial class FrmAddNewStudent
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
            this.groupBoxAcademicInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelNewStudent = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelNewStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAcademicInfo
            // 
            this.groupBoxAcademicInfo.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAcademicInfo.Name = "groupBoxAcademicInfo";
            this.groupBoxAcademicInfo.Size = new System.Drawing.Size(510, 165);
            this.groupBoxAcademicInfo.TabIndex = 0;
            this.groupBoxAcademicInfo.TabStop = false;
            this.groupBoxAcademicInfo.Text = "Academic Information";
            // 
            // flowLayoutPanelNewStudent
            // 
            this.flowLayoutPanelNewStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelNewStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanelNewStudent.Controls.Add(this.groupBoxAcademicInfo);
            this.flowLayoutPanelNewStudent.Controls.Add(this.groupBox1);
            this.flowLayoutPanelNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelNewStudent.Location = new System.Drawing.Point(78, 12);
            this.flowLayoutPanelNewStudent.Name = "flowLayoutPanelNewStudent";
            this.flowLayoutPanelNewStudent.Size = new System.Drawing.Size(766, 367);
            this.flowLayoutPanelNewStudent.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(519, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Academic Information";
            // 
            // FrmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 472);
            this.Controls.Add(this.flowLayoutPanelNewStudent);
            this.Name = "FrmAddNewStudent";
            this.Text = "FrmAddNewStudent";
            this.flowLayoutPanelNewStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcademicInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNewStudent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}