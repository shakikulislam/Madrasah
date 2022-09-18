
namespace WindowsDesktop.Students
{
    partial class FrmStudent
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
            this.iconButtonAddStudent = new FontAwesome.Sharp.IconButton();
            this.panelStudentControl = new System.Windows.Forms.Panel();
            this.iconButtonStudentList = new FontAwesome.Sharp.IconButton();
            this.panelStudentBody = new System.Windows.Forms.Panel();
            this.panelStudentControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonAddStudent
            // 
            this.iconButtonAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddStudent.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.iconButtonAddStudent.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddStudent.IconSize = 32;
            this.iconButtonAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStudent.Location = new System.Drawing.Point(403, 12);
            this.iconButtonAddStudent.Name = "iconButtonAddStudent";
            this.iconButtonAddStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonAddStudent.Size = new System.Drawing.Size(160, 40);
            this.iconButtonAddStudent.TabIndex = 5;
            this.iconButtonAddStudent.Text = "Add Student";
            this.iconButtonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddStudent.UseVisualStyleBackColor = true;
            this.iconButtonAddStudent.Click += new System.EventHandler(this.iconButtonAddStudent_Click);
            // 
            // panelStudentControl
            // 
            this.panelStudentControl.Controls.Add(this.iconButtonStudentList);
            this.panelStudentControl.Controls.Add(this.iconButtonAddStudent);
            this.panelStudentControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentControl.Location = new System.Drawing.Point(0, 0);
            this.panelStudentControl.Name = "panelStudentControl";
            this.panelStudentControl.Size = new System.Drawing.Size(800, 75);
            this.panelStudentControl.TabIndex = 6;
            // 
            // iconButtonStudentList
            // 
            this.iconButtonStudentList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStudentList.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButtonStudentList.IconColor = System.Drawing.Color.Black;
            this.iconButtonStudentList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStudentList.IconSize = 32;
            this.iconButtonStudentList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStudentList.Location = new System.Drawing.Point(237, 12);
            this.iconButtonStudentList.Name = "iconButtonStudentList";
            this.iconButtonStudentList.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonStudentList.Size = new System.Drawing.Size(160, 40);
            this.iconButtonStudentList.TabIndex = 6;
            this.iconButtonStudentList.Text = "Student List";
            this.iconButtonStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStudentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStudentList.UseVisualStyleBackColor = true;
            this.iconButtonStudentList.Click += new System.EventHandler(this.iconButtonStudentList_Click);
            // 
            // panelStudentBody
            // 
            this.panelStudentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudentBody.Location = new System.Drawing.Point(0, 75);
            this.panelStudentBody.Name = "panelStudentBody";
            this.panelStudentBody.Size = new System.Drawing.Size(800, 375);
            this.panelStudentBody.TabIndex = 7;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStudentBody);
            this.Controls.Add(this.panelStudentControl);
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.panelStudentControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddStudent;
        private System.Windows.Forms.Panel panelStudentControl;
        private System.Windows.Forms.Panel panelStudentBody;
        private FontAwesome.Sharp.IconButton iconButtonStudentList;
    }
}