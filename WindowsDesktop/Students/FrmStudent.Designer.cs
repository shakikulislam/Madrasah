
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
            this.SuspendLayout();
            // 
            // iconButtonAddStudent
            // 
            this.iconButtonAddStudent.FlatAppearance.BorderSize = 0;
            this.iconButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddStudent.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.iconButtonAddStudent.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddStudent.IconSize = 32;
            this.iconButtonAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStudent.Location = new System.Drawing.Point(291, 52);
            this.iconButtonAddStudent.Name = "iconButtonAddStudent";
            this.iconButtonAddStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonAddStudent.Size = new System.Drawing.Size(160, 40);
            this.iconButtonAddStudent.TabIndex = 5;
            this.iconButtonAddStudent.Text = "Add Student";
            this.iconButtonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddStudent.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonAddStudent);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddStudent;
    }
}