
namespace WindowsDesktop.Students
{
    partial class FrmStudentList
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuardianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuardianPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(302, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(254, 25);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search (Roll/Reg/Name)";
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.ColumnId,
            this.roll,
            this.name,
            this.ColumnClass,
            this.ColumnGuardianName,
            this.ColumnGuardianPhone,
            this.details});
            this.dataGridViewStudentList.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(776, 354);
            this.dataGridViewStudentList.TabIndex = 2;
            this.dataGridViewStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellContentClick);
            this.dataGridViewStudentList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewStudentList_RowPostPaint);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 20;
            this.iconButtonSearch.Location = new System.Drawing.Point(556, 32);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(20, 20);
            this.iconButtonSearch.TabIndex = 3;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // sl
            // 
            this.sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sl.HeaderText = "#";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 39;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 5;
            // 
            // roll
            // 
            this.roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roll.DataPropertyName = "roll";
            this.roll.HeaderText = "Roll";
            this.roll.Name = "roll";
            this.roll.ReadOnly = true;
            this.roll.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // ColumnClass
            // 
            this.ColumnClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClass.DataPropertyName = "class_name";
            this.ColumnClass.HeaderText = "Class";
            this.ColumnClass.Name = "ColumnClass";
            this.ColumnClass.ReadOnly = true;
            this.ColumnClass.Width = 57;
            // 
            // ColumnGuardianName
            // 
            this.ColumnGuardianName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnGuardianName.DataPropertyName = "guardian_name";
            this.ColumnGuardianName.HeaderText = "Guardian Name";
            this.ColumnGuardianName.Name = "ColumnGuardianName";
            this.ColumnGuardianName.ReadOnly = true;
            this.ColumnGuardianName.Width = 97;
            // 
            // ColumnGuardianPhone
            // 
            this.ColumnGuardianPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnGuardianPhone.DataPropertyName = "guardian_phone";
            this.ColumnGuardianPhone.HeaderText = "Guardian Phone";
            this.ColumnGuardianPhone.Name = "ColumnGuardianPhone";
            this.ColumnGuardianPhone.ReadOnly = true;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.details.HeaderText = "Action";
            this.details.Name = "details";
            this.details.Text = "Details";
            this.details.UseColumnTextForLinkValue = true;
            this.details.Width = 43;
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FrmStudentList";
            this.Text = "FrmStudentList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuardianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuardianPhone;
        private System.Windows.Forms.DataGridViewLinkColumn details;
    }
}