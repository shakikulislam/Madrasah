
namespace WindowsDesktop.Academic
{
    partial class FrmDepartment
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
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.ColumnDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddDepartment.Location = new System.Drawing.Point(336, 56);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(160, 38);
            this.buttonAddDepartment.TabIndex = 44;
            this.buttonAddDepartment.Text = "Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Visible = false;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Department Name";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDepartmentName.Location = new System.Drawing.Point(47, 74);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.ReadOnly = true;
            this.textBoxDepartmentName.Size = new System.Drawing.Size(232, 20);
            this.textBoxDepartmentName.TabIndex = 42;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddNew.Location = new System.Drawing.Point(336, 12);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(160, 38);
            this.buttonAddNew.TabIndex = 41;
            this.buttonAddNew.Text = "Add Department";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDepartmentName,
            this.ColumnDepartmentId});
            this.dataGridViewDepartment.Location = new System.Drawing.Point(47, 114);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.Size = new System.Drawing.Size(449, 175);
            this.dataGridViewDepartment.TabIndex = 40;
            this.dataGridViewDepartment.DoubleClick += new System.EventHandler(this.dataGridViewDepartment_DoubleClick);
            // 
            // ColumnDepartmentName
            // 
            this.ColumnDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDepartmentName.DataPropertyName = "name";
            this.ColumnDepartmentName.HeaderText = "Name";
            this.ColumnDepartmentName.Name = "ColumnDepartmentName";
            this.ColumnDepartmentName.ReadOnly = true;
            // 
            // ColumnDepartmentId
            // 
            this.ColumnDepartmentId.DataPropertyName = "id";
            this.ColumnDepartmentId.HeaderText = "ID";
            this.ColumnDepartmentId.Name = "ColumnDepartmentId";
            this.ColumnDepartmentId.ReadOnly = true;
            this.ColumnDepartmentId.Visible = false;
            // 
            // errorProviderDepartment
            // 
            this.errorProviderDepartment.ContainerControl = this;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 308);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Name = "FrmDepartment";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentId;
        private System.Windows.Forms.ErrorProvider errorProviderDepartment;
    }
}