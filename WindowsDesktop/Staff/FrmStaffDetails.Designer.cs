
namespace WindowsDesktop.Staff
{
    partial class FrmStaffDetails
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanelControl = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label57 = new System.Windows.Forms.Label();
            this.textBoxReviewPerDetails = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBoxReviewPerVillage = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.comboBoxReviewPerUnion = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.comboBoxReviewPerUpazila = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.comboBoxReviewPerDistrict = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBoxReviewPerDivision = new System.Windows.Forms.ComboBox();
            this.textBoxReviewPreDetails = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.comboBoxReviewPreVillage = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.comboBoxReviewPreUnion = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.comboBoxReviewPreUpazila = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.comboBoxReviewPreDistrict = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBoxReviewPreDivision = new System.Windows.Forms.ComboBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControlProfile = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInformation = new System.Windows.Forms.TabPage();
            this.comboBoxDesignation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpId = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxStaff = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonPersonalInformationUpdate = new System.Windows.Forms.Button();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.buttonAddressUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label58 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitleBar.SuspendLayout();
            this.flowLayoutPanelControl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tabControlProfile.SuspendLayout();
            this.tabPagePersonalInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaff)).BeginInit();
            this.tabPageAddress.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(802, 30);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTitle.Location = new System.Drawing.Point(6, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(23, 17);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "...";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.iconButtonClose.Location = new System.Drawing.Point(774, 5);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(20, 20);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // flowLayoutPanelControl
            // 
            this.flowLayoutPanelControl.AutoSize = true;
            this.flowLayoutPanelControl.Controls.Add(this.buttonProfile);
            this.flowLayoutPanelControl.Controls.Add(this.buttonResult);
            this.flowLayoutPanelControl.Controls.Add(this.button3);
            this.flowLayoutPanelControl.Controls.Add(this.button4);
            this.flowLayoutPanelControl.Controls.Add(this.button1);
            this.flowLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelControl.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanelControl.Name = "flowLayoutPanelControl";
            this.flowLayoutPanelControl.Size = new System.Drawing.Size(802, 30);
            this.flowLayoutPanelControl.TabIndex = 3;
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(0, 0);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(114, 30);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(114, 0);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(114, 30);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(228, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(342, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.label57);
            this.panel5.Location = new System.Drawing.Point(98, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 33);
            this.panel5.TabIndex = 147;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(3, 7);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(150, 17);
            this.label57.TabIndex = 109;
            this.label57.Text = "Permanent Address";
            // 
            // textBoxReviewPerDetails
            // 
            this.textBoxReviewPerDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxReviewPerDetails.CausesValidation = false;
            this.textBoxReviewPerDetails.Location = new System.Drawing.Point(98, 476);
            this.textBoxReviewPerDetails.Multiline = true;
            this.textBoxReviewPerDetails.Name = "textBoxReviewPerDetails";
            this.textBoxReviewPerDetails.Size = new System.Drawing.Size(428, 51);
            this.textBoxReviewPerDetails.TabIndex = 107;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(98, 456);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(196, 17);
            this.label44.TabIndex = 106;
            this.label44.Text = "Details (house #/road # etc...)";
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(98, 409);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(50, 17);
            this.label45.TabIndex = 105;
            this.label45.Text = "Village";
            // 
            // comboBoxReviewPerVillage
            // 
            this.comboBoxReviewPerVillage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPerVillage.DisplayMember = "name";
            this.comboBoxReviewPerVillage.FormattingEnabled = true;
            this.comboBoxReviewPerVillage.Location = new System.Drawing.Point(98, 429);
            this.comboBoxReviewPerVillage.Name = "comboBoxReviewPerVillage";
            this.comboBoxReviewPerVillage.Size = new System.Drawing.Size(428, 24);
            this.comboBoxReviewPerVillage.TabIndex = 104;
            this.comboBoxReviewPerVillage.ValueMember = "id";
            this.comboBoxReviewPerVillage.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPerVillage_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(317, 362);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 17);
            this.label46.TabIndex = 103;
            this.label46.Text = "Union";
            // 
            // comboBoxReviewPerUnion
            // 
            this.comboBoxReviewPerUnion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPerUnion.DisplayMember = "name";
            this.comboBoxReviewPerUnion.FormattingEnabled = true;
            this.comboBoxReviewPerUnion.Location = new System.Drawing.Point(317, 382);
            this.comboBoxReviewPerUnion.Name = "comboBoxReviewPerUnion";
            this.comboBoxReviewPerUnion.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPerUnion.TabIndex = 102;
            this.comboBoxReviewPerUnion.ValueMember = "id";
            this.comboBoxReviewPerUnion.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPerUnion_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(98, 362);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(55, 17);
            this.label47.TabIndex = 101;
            this.label47.Text = "Upazila";
            // 
            // comboBoxReviewPerUpazila
            // 
            this.comboBoxReviewPerUpazila.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPerUpazila.DisplayMember = "name";
            this.comboBoxReviewPerUpazila.FormattingEnabled = true;
            this.comboBoxReviewPerUpazila.Location = new System.Drawing.Point(98, 382);
            this.comboBoxReviewPerUpazila.Name = "comboBoxReviewPerUpazila";
            this.comboBoxReviewPerUpazila.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPerUpazila.TabIndex = 100;
            this.comboBoxReviewPerUpazila.ValueMember = "id";
            this.comboBoxReviewPerUpazila.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPerUpazila_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(317, 315);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(51, 17);
            this.label48.TabIndex = 99;
            this.label48.Text = "District";
            // 
            // comboBoxReviewPerDistrict
            // 
            this.comboBoxReviewPerDistrict.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPerDistrict.DisplayMember = "name";
            this.comboBoxReviewPerDistrict.FormattingEnabled = true;
            this.comboBoxReviewPerDistrict.Location = new System.Drawing.Point(317, 335);
            this.comboBoxReviewPerDistrict.Name = "comboBoxReviewPerDistrict";
            this.comboBoxReviewPerDistrict.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPerDistrict.TabIndex = 98;
            this.comboBoxReviewPerDistrict.ValueMember = "id";
            this.comboBoxReviewPerDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPerDistrict_SelectedIndexChanged);
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(98, 315);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(57, 17);
            this.label49.TabIndex = 97;
            this.label49.Text = "Division";
            // 
            // comboBoxReviewPerDivision
            // 
            this.comboBoxReviewPerDivision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPerDivision.DisplayMember = "name";
            this.comboBoxReviewPerDivision.FormattingEnabled = true;
            this.comboBoxReviewPerDivision.Location = new System.Drawing.Point(98, 335);
            this.comboBoxReviewPerDivision.Name = "comboBoxReviewPerDivision";
            this.comboBoxReviewPerDivision.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPerDivision.TabIndex = 95;
            this.comboBoxReviewPerDivision.ValueMember = "id";
            this.comboBoxReviewPerDivision.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPerDivision_SelectedIndexChanged);
            // 
            // textBoxReviewPreDetails
            // 
            this.textBoxReviewPreDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxReviewPreDetails.CausesValidation = false;
            this.textBoxReviewPreDetails.Location = new System.Drawing.Point(98, 212);
            this.textBoxReviewPreDetails.Multiline = true;
            this.textBoxReviewPreDetails.Name = "textBoxReviewPreDetails";
            this.textBoxReviewPreDetails.Size = new System.Drawing.Size(428, 51);
            this.textBoxReviewPreDetails.TabIndex = 94;
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(98, 192);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(196, 17);
            this.label51.TabIndex = 93;
            this.label51.Text = "Details (house #/road # etc...)";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(98, 145);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(50, 17);
            this.label52.TabIndex = 92;
            this.label52.Text = "Village";
            // 
            // comboBoxReviewPreVillage
            // 
            this.comboBoxReviewPreVillage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPreVillage.DisplayMember = "name";
            this.comboBoxReviewPreVillage.FormattingEnabled = true;
            this.comboBoxReviewPreVillage.Location = new System.Drawing.Point(98, 165);
            this.comboBoxReviewPreVillage.Name = "comboBoxReviewPreVillage";
            this.comboBoxReviewPreVillage.Size = new System.Drawing.Size(428, 24);
            this.comboBoxReviewPreVillage.TabIndex = 91;
            this.comboBoxReviewPreVillage.ValueMember = "id";
            this.comboBoxReviewPreVillage.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPreVillage_SelectedIndexChanged);
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(317, 98);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(45, 17);
            this.label53.TabIndex = 90;
            this.label53.Text = "Union";
            // 
            // comboBoxReviewPreUnion
            // 
            this.comboBoxReviewPreUnion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPreUnion.DisplayMember = "name";
            this.comboBoxReviewPreUnion.FormattingEnabled = true;
            this.comboBoxReviewPreUnion.Location = new System.Drawing.Point(317, 118);
            this.comboBoxReviewPreUnion.Name = "comboBoxReviewPreUnion";
            this.comboBoxReviewPreUnion.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPreUnion.TabIndex = 89;
            this.comboBoxReviewPreUnion.ValueMember = "id";
            this.comboBoxReviewPreUnion.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPreUnion_SelectedIndexChanged);
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(98, 98);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 17);
            this.label54.TabIndex = 88;
            this.label54.Text = "Upazila";
            // 
            // comboBoxReviewPreUpazila
            // 
            this.comboBoxReviewPreUpazila.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPreUpazila.DisplayMember = "name";
            this.comboBoxReviewPreUpazila.FormattingEnabled = true;
            this.comboBoxReviewPreUpazila.Location = new System.Drawing.Point(98, 118);
            this.comboBoxReviewPreUpazila.Name = "comboBoxReviewPreUpazila";
            this.comboBoxReviewPreUpazila.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPreUpazila.TabIndex = 87;
            this.comboBoxReviewPreUpazila.ValueMember = "id";
            this.comboBoxReviewPreUpazila.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPreUpazila_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(317, 51);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(51, 17);
            this.label55.TabIndex = 86;
            this.label55.Text = "District";
            // 
            // comboBoxReviewPreDistrict
            // 
            this.comboBoxReviewPreDistrict.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPreDistrict.DisplayMember = "name";
            this.comboBoxReviewPreDistrict.FormattingEnabled = true;
            this.comboBoxReviewPreDistrict.Location = new System.Drawing.Point(317, 71);
            this.comboBoxReviewPreDistrict.Name = "comboBoxReviewPreDistrict";
            this.comboBoxReviewPreDistrict.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPreDistrict.TabIndex = 85;
            this.comboBoxReviewPreDistrict.ValueMember = "id";
            this.comboBoxReviewPreDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPreDistrict_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(98, 51);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(57, 17);
            this.label56.TabIndex = 84;
            this.label56.Text = "Division";
            // 
            // comboBoxReviewPreDivision
            // 
            this.comboBoxReviewPreDivision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxReviewPreDivision.DisplayMember = "name";
            this.comboBoxReviewPreDivision.FormattingEnabled = true;
            this.comboBoxReviewPreDivision.Location = new System.Drawing.Point(98, 71);
            this.comboBoxReviewPreDivision.Name = "comboBoxReviewPreDivision";
            this.comboBoxReviewPreDivision.Size = new System.Drawing.Size(209, 24);
            this.comboBoxReviewPreDivision.TabIndex = 82;
            this.comboBoxReviewPreDivision.ValueMember = "id";
            this.comboBoxReviewPreDivision.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewPreDivision_SelectedIndexChanged);
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.tabControlProfile);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 80);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(802, 462);
            this.panelBody.TabIndex = 38;
            // 
            // tabControlProfile
            // 
            this.tabControlProfile.Controls.Add(this.tabPagePersonalInformation);
            this.tabControlProfile.Controls.Add(this.tabPageAddress);
            this.tabControlProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlProfile.Location = new System.Drawing.Point(69, 6);
            this.tabControlProfile.Name = "tabControlProfile";
            this.tabControlProfile.SelectedIndex = 0;
            this.tabControlProfile.Size = new System.Drawing.Size(676, 444);
            this.tabControlProfile.TabIndex = 38;
            this.tabControlProfile.Visible = false;
            // 
            // tabPagePersonalInformation
            // 
            this.tabPagePersonalInformation.Controls.Add(this.comboBoxDesignation);
            this.tabPagePersonalInformation.Controls.Add(this.label3);
            this.tabPagePersonalInformation.Controls.Add(this.label4);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxEmpId);
            this.tabPagePersonalInformation.Controls.Add(this.buttonBrowse);
            this.tabPagePersonalInformation.Controls.Add(this.pictureBoxStaff);
            this.tabPagePersonalInformation.Controls.Add(this.label5);
            this.tabPagePersonalInformation.Controls.Add(this.dateTimePickerJoiningDate);
            this.tabPagePersonalInformation.Controls.Add(this.label26);
            this.tabPagePersonalInformation.Controls.Add(this.dateTimePickerDob);
            this.tabPagePersonalInformation.Controls.Add(this.label27);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxNid);
            this.tabPagePersonalInformation.Controls.Add(this.label30);
            this.tabPagePersonalInformation.Controls.Add(this.label31);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxPhone);
            this.tabPagePersonalInformation.Controls.Add(this.textBoxFullName);
            this.tabPagePersonalInformation.Controls.Add(this.buttonPersonalInformationUpdate);
            this.tabPagePersonalInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonalInformation.Name = "tabPagePersonalInformation";
            this.tabPagePersonalInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInformation.Size = new System.Drawing.Size(668, 415);
            this.tabPagePersonalInformation.TabIndex = 0;
            this.tabPagePersonalInformation.Text = "Personal Information";
            this.tabPagePersonalInformation.UseVisualStyleBackColor = true;
            // 
            // comboBoxDesignation
            // 
            this.comboBoxDesignation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDesignation.FormattingEnabled = true;
            this.comboBoxDesignation.Location = new System.Drawing.Point(383, 41);
            this.comboBoxDesignation.Name = "comboBoxDesignation";
            this.comboBoxDesignation.Size = new System.Drawing.Size(133, 24);
            this.comboBoxDesignation.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Employee ID";
            // 
            // textBoxEmpId
            // 
            this.textBoxEmpId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmpId.CausesValidation = false;
            this.textBoxEmpId.Location = new System.Drawing.Point(115, 41);
            this.textBoxEmpId.Name = "textBoxEmpId";
            this.textBoxEmpId.Size = new System.Drawing.Size(116, 23);
            this.textBoxEmpId.TabIndex = 57;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBrowse.Location = new System.Drawing.Point(540, 166);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(112, 34);
            this.buttonBrowse.TabIndex = 56;
            this.buttonBrowse.Text = "Browse Image";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBoxStaff
            // 
            this.pictureBoxStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxStaff.Image = global::WindowsDesktop.Properties.Resources.no_person_image;
            this.pictureBoxStaff.Location = new System.Drawing.Point(540, 41);
            this.pictureBoxStaff.Name = "pictureBoxStaff";
            this.pictureBoxStaff.Size = new System.Drawing.Size(112, 119);
            this.pictureBoxStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStaff.TabIndex = 55;
            this.pictureBoxStaff.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Joining Date";
            // 
            // dateTimePickerJoiningDate
            // 
            this.dateTimePickerJoiningDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerJoiningDate.Location = new System.Drawing.Point(400, 178);
            this.dateTimePickerJoiningDate.Name = "dateTimePickerJoiningDate";
            this.dateTimePickerJoiningDate.Size = new System.Drawing.Size(116, 23);
            this.dateTimePickerJoiningDate.TabIndex = 53;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 181);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 17);
            this.label26.TabIndex = 51;
            this.label26.Text = "Date of Birth";
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerDob.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDob.Location = new System.Drawing.Point(115, 178);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(116, 23);
            this.dateTimePickerDob.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(78, 152);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 17);
            this.label27.TabIndex = 52;
            this.label27.Text = "NID";
            // 
            // textBoxNid
            // 
            this.textBoxNid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNid.Location = new System.Drawing.Point(115, 149);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(401, 23);
            this.textBoxNid.TabIndex = 47;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(38, 118);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 17);
            this.label30.TabIndex = 50;
            this.label30.Text = "Phone No";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(38, 84);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 17);
            this.label31.TabIndex = 49;
            this.label31.Text = "Full Name";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPhone.Location = new System.Drawing.Point(115, 115);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(401, 23);
            this.textBoxPhone.TabIndex = 46;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFullName.Location = new System.Drawing.Point(115, 81);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(401, 23);
            this.textBoxFullName.TabIndex = 45;
            // 
            // buttonPersonalInformationUpdate
            // 
            this.buttonPersonalInformationUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPersonalInformationUpdate.Location = new System.Drawing.Point(360, 224);
            this.buttonPersonalInformationUpdate.Name = "buttonPersonalInformationUpdate";
            this.buttonPersonalInformationUpdate.Size = new System.Drawing.Size(156, 39);
            this.buttonPersonalInformationUpdate.TabIndex = 44;
            this.buttonPersonalInformationUpdate.Text = "Update";
            this.buttonPersonalInformationUpdate.UseVisualStyleBackColor = true;
            this.buttonPersonalInformationUpdate.Click += new System.EventHandler(this.buttonPersonalInformationUpdate_Click);
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.AutoScroll = true;
            this.tabPageAddress.Controls.Add(this.buttonAddressUpdate);
            this.tabPageAddress.Controls.Add(this.panel3);
            this.tabPageAddress.Controls.Add(this.panel5);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPreDivision);
            this.tabPageAddress.Controls.Add(this.label56);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPreDistrict);
            this.tabPageAddress.Controls.Add(this.label55);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPreUpazila);
            this.tabPageAddress.Controls.Add(this.label54);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPreUnion);
            this.tabPageAddress.Controls.Add(this.label53);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPreVillage);
            this.tabPageAddress.Controls.Add(this.label52);
            this.tabPageAddress.Controls.Add(this.label51);
            this.tabPageAddress.Controls.Add(this.textBoxReviewPreDetails);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPerDivision);
            this.tabPageAddress.Controls.Add(this.label49);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPerDistrict);
            this.tabPageAddress.Controls.Add(this.label48);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPerUpazila);
            this.tabPageAddress.Controls.Add(this.label47);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPerUnion);
            this.tabPageAddress.Controls.Add(this.label46);
            this.tabPageAddress.Controls.Add(this.comboBoxReviewPerVillage);
            this.tabPageAddress.Controls.Add(this.label1);
            this.tabPageAddress.Controls.Add(this.label45);
            this.tabPageAddress.Controls.Add(this.label44);
            this.tabPageAddress.Controls.Add(this.textBoxReviewPerDetails);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddress.Size = new System.Drawing.Size(668, 415);
            this.tabPageAddress.TabIndex = 1;
            this.tabPageAddress.Text = "Address";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // buttonAddressUpdate
            // 
            this.buttonAddressUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddressUpdate.Location = new System.Drawing.Point(370, 533);
            this.buttonAddressUpdate.Name = "buttonAddressUpdate";
            this.buttonAddressUpdate.Size = new System.Drawing.Size(156, 39);
            this.buttonAddressUpdate.TabIndex = 148;
            this.buttonAddressUpdate.Text = "Update";
            this.buttonAddressUpdate.UseVisualStyleBackColor = true;
            this.buttonAddressUpdate.Click += new System.EventHandler(this.buttonAddressUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.label58);
            this.panel3.Location = new System.Drawing.Point(98, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 33);
            this.panel3.TabIndex = 147;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(3, 7);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(128, 17);
            this.label58.TabIndex = 109;
            this.label58.Text = "Present Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 105;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(802, 20);
            this.panel7.TabIndex = 38;
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // FrmStaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(802, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.flowLayoutPanelControl);
            this.Controls.Add(this.panelTitleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.flowLayoutPanelControl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tabControlProfile.ResumeLayout(false);
            this.tabPagePersonalInformation.ResumeLayout(false);
            this.tabPagePersonalInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaff)).EndInit();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControl;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBoxReviewPerDetails;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox comboBoxReviewPerVillage;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox comboBoxReviewPerUnion;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox comboBoxReviewPerUpazila;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox comboBoxReviewPerDistrict;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox comboBoxReviewPerDivision;
        private System.Windows.Forms.TextBox textBoxReviewPreDetails;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox comboBoxReviewPreVillage;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox comboBoxReviewPreUnion;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox comboBoxReviewPreUpazila;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox comboBoxReviewPreDistrict;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBoxReviewPreDivision;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlProfile;
        private System.Windows.Forms.TabPage tabPagePersonalInformation;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button buttonPersonalInformationUpdate;
        private System.Windows.Forms.Button buttonAddressUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.ComboBox comboBoxDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpId;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoiningDate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFullName;
    }
}