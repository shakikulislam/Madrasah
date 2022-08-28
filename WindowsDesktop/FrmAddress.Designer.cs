
namespace WindowsDesktop
{
    partial class FrmAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDivision = new System.Windows.Forms.ListView();
            this.columnHeaderDivisionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDistrict = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUpazila = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listViewUnion = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxUpazila = new System.Windows.Forms.TextBox();
            this.textBoxUnion = new System.Windows.Forms.TextBox();
            this.dataGridViewDivision = new System.Windows.Forms.DataGridView();
            this.ColumnDivisionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDivisionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDivisionNameEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDivisionNameBn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDistrict = new System.Windows.Forms.DataGridView();
            this.ColumnDistrictId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistrictEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistrictBn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUpazila = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewUnion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpazila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "District";
            // 
            // listViewDivision
            // 
            this.listViewDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDivisionName});
            this.listViewDivision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDivision.FullRowSelect = true;
            this.listViewDivision.HideSelection = false;
            this.listViewDivision.Location = new System.Drawing.Point(532, 262);
            this.listViewDivision.MultiSelect = false;
            this.listViewDivision.Name = "listViewDivision";
            this.listViewDivision.Size = new System.Drawing.Size(212, 200);
            this.listViewDivision.TabIndex = 8;
            this.listViewDivision.UseCompatibleStateImageBehavior = false;
            this.listViewDivision.View = System.Windows.Forms.View.Details;
            this.listViewDivision.Click += new System.EventHandler(this.listViewDivision_Click);
            // 
            // columnHeaderDivisionName
            // 
            this.columnHeaderDivisionName.Text = "Name";
            this.columnHeaderDivisionName.Width = 180;
            // 
            // listViewDistrict
            // 
            this.listViewDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewDistrict.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDistrict.FullRowSelect = true;
            this.listViewDistrict.HideSelection = false;
            this.listViewDistrict.Location = new System.Drawing.Point(750, 262);
            this.listViewDistrict.MultiSelect = false;
            this.listViewDistrict.Name = "listViewDistrict";
            this.listViewDistrict.Size = new System.Drawing.Size(212, 200);
            this.listViewDistrict.TabIndex = 9;
            this.listViewDistrict.UseCompatibleStateImageBehavior = false;
            this.listViewDistrict.View = System.Windows.Forms.View.Details;
            this.listViewDistrict.Click += new System.EventHandler(this.listViewDistrict_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // listViewUpazila
            // 
            this.listViewUpazila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewUpazila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewUpazila.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUpazila.FullRowSelect = true;
            this.listViewUpazila.HideSelection = false;
            this.listViewUpazila.Location = new System.Drawing.Point(532, 352);
            this.listViewUpazila.MultiSelect = false;
            this.listViewUpazila.Name = "listViewUpazila";
            this.listViewUpazila.Size = new System.Drawing.Size(212, 200);
            this.listViewUpazila.TabIndex = 11;
            this.listViewUpazila.UseCompatibleStateImageBehavior = false;
            this.listViewUpazila.View = System.Windows.Forms.View.Details;
            this.listViewUpazila.Click += new System.EventHandler(this.listViewUpazila_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Upazila";
            // 
            // listViewUnion
            // 
            this.listViewUnion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewUnion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUnion.FullRowSelect = true;
            this.listViewUnion.HideSelection = false;
            this.listViewUnion.Location = new System.Drawing.Point(750, 335);
            this.listViewUnion.MultiSelect = false;
            this.listViewUnion.Name = "listViewUnion";
            this.listViewUnion.Size = new System.Drawing.Size(212, 200);
            this.listViewUnion.TabIndex = 13;
            this.listViewUnion.UseCompatibleStateImageBehavior = false;
            this.listViewUnion.View = System.Windows.Forms.View.Details;
            this.listViewUnion.Click += new System.EventHandler(this.listViewUnion_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Union";
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDivision.Location = new System.Drawing.Point(532, 48);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.ReadOnly = true;
            this.textBoxDivision.Size = new System.Drawing.Size(223, 25);
            this.textBoxDivision.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Division";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "District";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Upazila";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Union";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDistrict.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistrict.Location = new System.Drawing.Point(532, 79);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.ReadOnly = true;
            this.textBoxDistrict.Size = new System.Drawing.Size(223, 25);
            this.textBoxDistrict.TabIndex = 19;
            // 
            // textBoxUpazila
            // 
            this.textBoxUpazila.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpazila.Location = new System.Drawing.Point(532, 110);
            this.textBoxUpazila.Name = "textBoxUpazila";
            this.textBoxUpazila.ReadOnly = true;
            this.textBoxUpazila.Size = new System.Drawing.Size(223, 25);
            this.textBoxUpazila.TabIndex = 20;
            // 
            // textBoxUnion
            // 
            this.textBoxUnion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnion.Location = new System.Drawing.Point(532, 141);
            this.textBoxUnion.Name = "textBoxUnion";
            this.textBoxUnion.ReadOnly = true;
            this.textBoxUnion.Size = new System.Drawing.Size(223, 25);
            this.textBoxUnion.TabIndex = 21;
            // 
            // dataGridViewDivision
            // 
            this.dataGridViewDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDivision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDivisionId,
            this.ColumnDivisionName,
            this.ColumnDivisionNameEn,
            this.ColumnDivisionNameBn});
            this.dataGridViewDivision.Location = new System.Drawing.Point(15, 29);
            this.dataGridViewDivision.Name = "dataGridViewDivision";
            this.dataGridViewDivision.Size = new System.Drawing.Size(212, 200);
            this.dataGridViewDivision.TabIndex = 22;
            this.dataGridViewDivision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDivision_CellClick);
            // 
            // ColumnDivisionId
            // 
            this.ColumnDivisionId.DataPropertyName = "id";
            this.ColumnDivisionId.HeaderText = "ID";
            this.ColumnDivisionId.Name = "ColumnDivisionId";
            this.ColumnDivisionId.ReadOnly = true;
            this.ColumnDivisionId.Visible = false;
            // 
            // ColumnDivisionName
            // 
            this.ColumnDivisionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDivisionName.DataPropertyName = "bnen";
            this.ColumnDivisionName.HeaderText = "Name";
            this.ColumnDivisionName.Name = "ColumnDivisionName";
            this.ColumnDivisionName.ReadOnly = true;
            // 
            // ColumnDivisionNameEn
            // 
            this.ColumnDivisionNameEn.DataPropertyName = "name";
            this.ColumnDivisionNameEn.HeaderText = "EN";
            this.ColumnDivisionNameEn.Name = "ColumnDivisionNameEn";
            this.ColumnDivisionNameEn.ReadOnly = true;
            this.ColumnDivisionNameEn.Visible = false;
            // 
            // ColumnDivisionNameBn
            // 
            this.ColumnDivisionNameBn.DataPropertyName = "name_bn";
            this.ColumnDivisionNameBn.HeaderText = "BN";
            this.ColumnDivisionNameBn.Name = "ColumnDivisionNameBn";
            this.ColumnDivisionNameBn.ReadOnly = true;
            this.ColumnDivisionNameBn.Visible = false;
            // 
            // dataGridViewDistrict
            // 
            this.dataGridViewDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistrict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDistrictId,
            this.ColumnDistrictName,
            this.ColumnDistrictEn,
            this.ColumnDistrictBn});
            this.dataGridViewDistrict.Location = new System.Drawing.Point(236, 29);
            this.dataGridViewDistrict.Name = "dataGridViewDistrict";
            this.dataGridViewDistrict.Size = new System.Drawing.Size(212, 200);
            this.dataGridViewDistrict.TabIndex = 23;
            this.dataGridViewDistrict.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDistrict_CellClick);
            // 
            // ColumnDistrictId
            // 
            this.ColumnDistrictId.DataPropertyName = "id";
            this.ColumnDistrictId.HeaderText = "ID";
            this.ColumnDistrictId.Name = "ColumnDistrictId";
            this.ColumnDistrictId.ReadOnly = true;
            this.ColumnDistrictId.Visible = false;
            // 
            // ColumnDistrictName
            // 
            this.ColumnDistrictName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDistrictName.DataPropertyName = "bnen";
            this.ColumnDistrictName.HeaderText = "Name";
            this.ColumnDistrictName.Name = "ColumnDistrictName";
            this.ColumnDistrictName.ReadOnly = true;
            // 
            // ColumnDistrictEn
            // 
            this.ColumnDistrictEn.DataPropertyName = "name";
            this.ColumnDistrictEn.HeaderText = "EN";
            this.ColumnDistrictEn.Name = "ColumnDistrictEn";
            this.ColumnDistrictEn.ReadOnly = true;
            this.ColumnDistrictEn.Visible = false;
            // 
            // ColumnDistrictBn
            // 
            this.ColumnDistrictBn.DataPropertyName = "name_bn";
            this.ColumnDistrictBn.HeaderText = "BN";
            this.ColumnDistrictBn.Name = "ColumnDistrictBn";
            this.ColumnDistrictBn.ReadOnly = true;
            this.ColumnDistrictBn.Visible = false;
            // 
            // dataGridViewUpazila
            // 
            this.dataGridViewUpazila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpazila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewUpazila.Location = new System.Drawing.Point(15, 262);
            this.dataGridViewUpazila.Name = "dataGridViewUpazila";
            this.dataGridViewUpazila.Size = new System.Drawing.Size(212, 200);
            this.dataGridViewUpazila.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bnen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "EN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name_bn";
            this.dataGridViewTextBoxColumn4.HeaderText = "BN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewUnion
            // 
            this.dataGridViewUnion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewUnion.Location = new System.Drawing.Point(236, 262);
            this.dataGridViewUnion.Name = "dataGridViewUnion";
            this.dataGridViewUnion.Size = new System.Drawing.Size(212, 200);
            this.dataGridViewUnion.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bnen";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn7.HeaderText = "EN";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "name_bn";
            this.dataGridViewTextBoxColumn8.HeaderText = "BN";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // FrmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 547);
            this.Controls.Add(this.dataGridViewUnion);
            this.Controls.Add(this.dataGridViewUpazila);
            this.Controls.Add(this.dataGridViewDistrict);
            this.Controls.Add(this.dataGridViewDivision);
            this.Controls.Add(this.textBoxUnion);
            this.Controls.Add(this.textBoxUpazila);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDivision);
            this.Controls.Add(this.listViewUnion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewUpazila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewDistrict);
            this.Controls.Add(this.listViewDivision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddress";
            this.Text = "Address Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpazila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDivision;
        private System.Windows.Forms.ColumnHeader columnHeaderDivisionName;
        private System.Windows.Forms.ListView listViewDistrict;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewUpazila;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewUnion;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxUpazila;
        private System.Windows.Forms.TextBox textBoxUnion;
        private System.Windows.Forms.DataGridView dataGridViewDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDivisionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDivisionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDivisionNameEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDivisionNameBn;
        private System.Windows.Forms.DataGridView dataGridViewDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistrictId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistrictEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistrictBn;
        private System.Windows.Forms.DataGridView dataGridViewUpazila;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridViewUnion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}