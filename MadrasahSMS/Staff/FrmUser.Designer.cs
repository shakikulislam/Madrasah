
namespace MadrasahSMS.Staff
{
    partial class FrmUser
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
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmpList = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnUlSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlDesig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUlSl,
            this.ColumnUlId,
            this.ColumnUlEmpId,
            this.ColumnUlDesig,
            this.ColumnUlUserName,
            this.ColumnUlName,
            this.ColumnUlPass});
            this.dataGridViewUserList.Location = new System.Drawing.Point(12, 279);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.Size = new System.Drawing.Size(364, 159);
            this.dataGridViewUserList.TabIndex = 0;
            this.dataGridViewUserList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewUserList_RowPostPaint);
            // 
            // dataGridViewEmpList
            // 
            this.dataGridViewEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSl,
            this.ColumnEmpId,
            this.ColumnName,
            this.ColumnDesig});
            this.dataGridViewEmpList.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewEmpList.Name = "dataGridViewEmpList";
            this.dataGridViewEmpList.Size = new System.Drawing.Size(598, 204);
            this.dataGridViewEmpList.TabIndex = 1;
            this.dataGridViewEmpList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewEmpList_RowPostPaint);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnSl
            // 
            this.ColumnSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSl.HeaderText = "#";
            this.ColumnSl.Name = "ColumnSl";
            this.ColumnSl.ReadOnly = true;
            this.ColumnSl.Width = 39;
            // 
            // ColumnEmpId
            // 
            this.ColumnEmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEmpId.HeaderText = "Emp ID";
            this.ColumnEmpId.Name = "ColumnEmpId";
            this.ColumnEmpId.ReadOnly = true;
            this.ColumnEmpId.Width = 67;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnDesig
            // 
            this.ColumnDesig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDesig.HeaderText = "Designation";
            this.ColumnDesig.Name = "ColumnDesig";
            this.ColumnDesig.ReadOnly = true;
            this.ColumnDesig.Width = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User List";
            // 
            // ColumnUlSl
            // 
            this.ColumnUlSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnUlSl.HeaderText = "#";
            this.ColumnUlSl.Name = "ColumnUlSl";
            this.ColumnUlSl.ReadOnly = true;
            this.ColumnUlSl.Width = 39;
            // 
            // ColumnUlId
            // 
            this.ColumnUlId.HeaderText = "ID";
            this.ColumnUlId.Name = "ColumnUlId";
            this.ColumnUlId.ReadOnly = true;
            this.ColumnUlId.Visible = false;
            // 
            // ColumnUlEmpId
            // 
            this.ColumnUlEmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnUlEmpId.HeaderText = "Emp ID";
            this.ColumnUlEmpId.Name = "ColumnUlEmpId";
            this.ColumnUlEmpId.ReadOnly = true;
            this.ColumnUlEmpId.Width = 67;
            // 
            // ColumnUlDesig
            // 
            this.ColumnUlDesig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnUlDesig.HeaderText = "Designation";
            this.ColumnUlDesig.Name = "ColumnUlDesig";
            this.ColumnUlDesig.ReadOnly = true;
            this.ColumnUlDesig.Width = 88;
            // 
            // ColumnUlUserName
            // 
            this.ColumnUlUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUlUserName.HeaderText = "User Name";
            this.ColumnUlUserName.Name = "ColumnUlUserName";
            this.ColumnUlUserName.ReadOnly = true;
            // 
            // ColumnUlName
            // 
            this.ColumnUlName.HeaderText = "Emp Name";
            this.ColumnUlName.Name = "ColumnUlName";
            this.ColumnUlName.ReadOnly = true;
            this.ColumnUlName.Visible = false;
            // 
            // ColumnUlPass
            // 
            this.ColumnUlPass.HeaderText = "Password";
            this.ColumnUlPass.Name = "ColumnUlPass";
            this.ColumnUlPass.ReadOnly = true;
            this.ColumnUlPass.Visible = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmpList);
            this.Controls.Add(this.dataGridViewUserList);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.DataGridView dataGridViewEmpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlDesig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlPass;
    }
}