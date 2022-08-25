
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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLeftMenuLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.labelCurrentChild = new System.Windows.Forms.Label();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelSideMenu.Controls.Add(this.iconButton3);
            this.panelSideMenu.Controls.Add(this.iconButton2);
            this.panelSideMenu.Controls.Add(this.iconButton1);
            this.panelSideMenu.Controls.Add(this.panelLeftMenuLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(159, 484);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 160);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton3.Size = new System.Drawing.Size(159, 40);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Dashboard";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Laravel;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 120);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton2.Size = new System.Drawing.Size(159, 40);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Dashboard";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.LandmarkFlag;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 80);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton1.Size = new System.Drawing.Size(159, 40);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLeftMenuLogo
            // 
            this.panelLeftMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenuLogo.Name = "panelLeftMenuLogo";
            this.panelLeftMenuLogo.Size = new System.Drawing.Size(159, 80);
            this.panelLeftMenuLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.iconButtonMinimize);
            this.panelTitleBar.Controls.Add(this.labelCurrentChild);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.iconButtonMaximize);
            this.panelTitleBar.Controls.Add(this.iconPictureBoxCurrentChild);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(159, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(725, 40);
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
            this.iconButtonMinimize.Location = new System.Drawing.Point(649, 10);
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
            this.labelCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelCurrentChild.Location = new System.Drawing.Point(44, 14);
            this.labelCurrentChild.Name = "labelCurrentChild";
            this.labelCurrentChild.Size = new System.Drawing.Size(35, 13);
            this.labelCurrentChild.TabIndex = 3;
            this.labelCurrentChild.Text = "label1";
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
            this.iconButtonClose.Location = new System.Drawing.Point(697, 10);
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
            this.iconButtonMaximize.Location = new System.Drawing.Point(673, 10);
            this.iconButtonMaximize.Name = "iconButtonMaximize";
            this.iconButtonMaximize.Size = new System.Drawing.Size(20, 20);
            this.iconButtonMaximize.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.iconButtonMaximize, "Maximize");
            this.iconButtonMaximize.UseVisualStyleBackColor = true;
            this.iconButtonMaximize.Click += new System.EventHandler(this.iconButtonMaximize_Click);
            // 
            // iconPictureBoxCurrentChild
            // 
            this.iconPictureBoxCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxCurrentChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCurrentChild.Location = new System.Drawing.Point(6, 4);
            this.iconPictureBoxCurrentChild.Name = "iconPictureBoxCurrentChild";
            this.iconPictureBoxCurrentChild.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxCurrentChild.TabIndex = 2;
            this.iconPictureBoxCurrentChild.TabStop = false;
            this.iconPictureBoxCurrentChild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(159, 40);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(725, 5);
            this.panelShadow.TabIndex = 2;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(159, 45);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(725, 439);
            this.panelBody.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(884, 484);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelShadow);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLeftMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrentChild;
        private System.Windows.Forms.Label labelCurrentChild;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonMaximize;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

