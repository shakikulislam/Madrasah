
namespace WindowsDesktop
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconButtonAddress = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButtonStudent = new FontAwesome.Sharp.IconButton();
            this.panelLeftMenuLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.labelCurrentChild = new System.Windows.Forms.Label();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelOfficeName = new System.Windows.Forms.Label();
            this.iconButtonAddStudent = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentChild)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.iconButtonAddStudent);
            this.panelSideMenu.Controls.Add(this.iconButtonAddress);
            this.panelSideMenu.Controls.Add(this.iconButton1);
            this.panelSideMenu.Controls.Add(this.iconButton3);
            this.panelSideMenu.Controls.Add(this.iconButtonStudent);
            this.panelSideMenu.Controls.Add(this.panelLeftMenuLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(160, 484);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconButtonAddress
            // 
            this.iconButtonAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAddress.FlatAppearance.BorderSize = 0;
            this.iconButtonAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddress.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButtonAddress.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddress.IconSize = 32;
            this.iconButtonAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddress.Location = new System.Drawing.Point(0, 183);
            this.iconButtonAddress.Name = "iconButtonAddress";
            this.iconButtonAddress.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonAddress.Size = new System.Drawing.Size(160, 40);
            this.iconButtonAddress.TabIndex = 5;
            this.iconButtonAddress.Text = "Address";
            this.iconButtonAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddress.UseVisualStyleBackColor = true;
            this.iconButtonAddress.Click += new System.EventHandler(this.iconButtonAddress_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.LandmarkFlag;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 143);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton1.Size = new System.Drawing.Size(160, 40);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Syllabus";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 103);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton3.Size = new System.Drawing.Size(160, 40);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Staff";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButtonStudent
            // 
            this.iconButtonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonStudent.FlatAppearance.BorderSize = 0;
            this.iconButtonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonStudent.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButtonStudent.IconColor = System.Drawing.Color.Black;
            this.iconButtonStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStudent.IconSize = 32;
            this.iconButtonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStudent.Location = new System.Drawing.Point(0, 63);
            this.iconButtonStudent.Name = "iconButtonStudent";
            this.iconButtonStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonStudent.Size = new System.Drawing.Size(160, 40);
            this.iconButtonStudent.TabIndex = 3;
            this.iconButtonStudent.Text = "Student";
            this.iconButtonStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStudent.UseVisualStyleBackColor = true;
            this.iconButtonStudent.Click += new System.EventHandler(this.iconButtonStudent_Click);
            // 
            // panelLeftMenuLogo
            // 
            this.panelLeftMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenuLogo.Name = "panelLeftMenuLogo";
            this.panelLeftMenuLogo.Size = new System.Drawing.Size(160, 63);
            this.panelLeftMenuLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.iconButtonMinimize);
            this.panelTitleBar.Controls.Add(this.labelCurrentChild);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.iconButtonMaximize);
            this.panelTitleBar.Controls.Add(this.iconPictureBoxCurrentChild);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(160, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(724, 30);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.MediumPurple;
            this.iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimize.IconSize = 20;
            this.iconButtonMinimize.Location = new System.Drawing.Point(648, 5);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Size = new System.Drawing.Size(20, 20);
            this.iconButtonMinimize.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.iconButtonMinimize, "Minimize");
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // labelCurrentChild
            // 
            this.labelCurrentChild.AutoSize = true;
            this.labelCurrentChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelCurrentChild.Location = new System.Drawing.Point(35, 7);
            this.labelCurrentChild.Name = "labelCurrentChild";
            this.labelCurrentChild.Size = new System.Drawing.Size(23, 17);
            this.labelCurrentChild.TabIndex = 3;
            this.labelCurrentChild.Text = "...";
            this.labelCurrentChild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.iconButtonClose.IconColor = System.Drawing.Color.MediumPurple;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 20;
            this.iconButtonClose.Location = new System.Drawing.Point(696, 5);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(20, 20);
            this.iconButtonClose.TabIndex = 0;
            this.toolTipMain.SetToolTip(this.iconButtonClose, "Close");
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonMaximize
            // 
            this.iconButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonMaximize.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaximize.IconColor = System.Drawing.Color.MediumPurple;
            this.iconButtonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaximize.IconSize = 20;
            this.iconButtonMaximize.Location = new System.Drawing.Point(672, 5);
            this.iconButtonMaximize.Name = "iconButtonMaximize";
            this.iconButtonMaximize.Size = new System.Drawing.Size(20, 20);
            this.iconButtonMaximize.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.iconButtonMaximize, "Maximize");
            this.iconButtonMaximize.UseVisualStyleBackColor = true;
            this.iconButtonMaximize.Click += new System.EventHandler(this.iconButtonMaximize_Click);
            // 
            // iconPictureBoxCurrentChild
            // 
            this.iconPictureBoxCurrentChild.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxCurrentChild.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxCurrentChild.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCurrentChild.IconSize = 25;
            this.iconPictureBoxCurrentChild.Location = new System.Drawing.Point(6, 3);
            this.iconPictureBoxCurrentChild.Name = "iconPictureBoxCurrentChild";
            this.iconPictureBoxCurrentChild.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBoxCurrentChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxCurrentChild.TabIndex = 2;
            this.iconPictureBoxCurrentChild.TabStop = false;
            this.iconPictureBoxCurrentChild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.Location = new System.Drawing.Point(159, 30);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(725, 424);
            this.panelBody.TabIndex = 3;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.labelOfficeName);
            this.panelFooter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(160, 454);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(724, 30);
            this.panelFooter.TabIndex = 4;
            // 
            // labelOfficeName
            // 
            this.labelOfficeName.AutoSize = true;
            this.labelOfficeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficeName.ForeColor = System.Drawing.Color.Black;
            this.labelOfficeName.Location = new System.Drawing.Point(6, 7);
            this.labelOfficeName.Name = "labelOfficeName";
            this.labelOfficeName.Size = new System.Drawing.Size(52, 17);
            this.labelOfficeName.TabIndex = 0;
            this.labelOfficeName.Text = "label1";
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
            this.iconButtonAddStudent.Location = new System.Drawing.Point(3, 229);
            this.iconButtonAddStudent.Name = "iconButtonAddStudent";
            this.iconButtonAddStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButtonAddStudent.Size = new System.Drawing.Size(160, 40);
            this.iconButtonAddStudent.TabIndex = 4;
            this.iconButtonAddStudent.Text = "Add Student";
            this.iconButtonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddStudent.UseVisualStyleBackColor = true;
            this.iconButtonAddStudent.Click += new System.EventHandler(this.iconButtonAddStudent_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 484);
            this.ControlBox = false;
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentChild)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLeftMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButtonStudent;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentChild;
        private System.Windows.Forms.Label labelCurrentChild;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonMaximize;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelOfficeName;
        private FontAwesome.Sharp.IconButton iconButtonAddress;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonAddStudent;
    }
}

