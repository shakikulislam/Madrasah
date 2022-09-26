
namespace WindowsDesktop
{
    partial class FrmAcademic
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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.panelClass = new System.Windows.Forms.Panel();
            this.numericUpDownClassNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClassDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClassUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.buttonAddNewClass = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.ColumnDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnClassSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopMenu.SuspendLayout();
            this.panelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.panelDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.buttonDepartment);
            this.panelTopMenu.Controls.Add(this.buttonClass);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(800, 117);
            this.panelTopMenu.TabIndex = 0;
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDepartment.Location = new System.Drawing.Point(237, 12);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(160, 38);
            this.buttonDepartment.TabIndex = 34;
            this.buttonDepartment.Text = "Department";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClass.Location = new System.Drawing.Point(403, 12);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(160, 38);
            this.buttonClass.TabIndex = 33;
            this.buttonClass.Text = "Class";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // panelClass
            // 
            this.panelClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelClass.Controls.Add(this.comboBoxTeacher);
            this.panelClass.Controls.Add(this.label4);
            this.panelClass.Controls.Add(this.numericUpDownClassNumber);
            this.panelClass.Controls.Add(this.comboBoxClassDepartment);
            this.panelClass.Controls.Add(this.label3);
            this.panelClass.Controls.Add(this.buttonClassUpdate);
            this.panelClass.Controls.Add(this.label2);
            this.panelClass.Controls.Add(this.label1);
            this.panelClass.Controls.Add(this.textBoxClassName);
            this.panelClass.Controls.Add(this.buttonAddNewClass);
            this.panelClass.Controls.Add(this.dataGridViewClass);
            this.panelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelClass.Location = new System.Drawing.Point(49, 130);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(660, 315);
            this.panelClass.TabIndex = 1;
            this.panelClass.Visible = false;
            // 
            // numericUpDownClassNumber
            // 
            this.numericUpDownClassNumber.Enabled = false;
            this.numericUpDownClassNumber.Location = new System.Drawing.Point(10, 278);
            this.numericUpDownClassNumber.Name = "numericUpDownClassNumber";
            this.numericUpDownClassNumber.Size = new System.Drawing.Size(201, 23);
            this.numericUpDownClassNumber.TabIndex = 42;
            // 
            // comboBoxClassDepartment
            // 
            this.comboBoxClassDepartment.Enabled = false;
            this.comboBoxClassDepartment.FormattingEnabled = true;
            this.comboBoxClassDepartment.Location = new System.Drawing.Point(10, 228);
            this.comboBoxClassDepartment.Name = "comboBoxClassDepartment";
            this.comboBoxClassDepartment.Size = new System.Drawing.Size(201, 24);
            this.comboBoxClassDepartment.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Department";
            // 
            // buttonClassUpdate
            // 
            this.buttonClassUpdate.Location = new System.Drawing.Point(486, 265);
            this.buttonClassUpdate.Name = "buttonClassUpdate";
            this.buttonClassUpdate.Size = new System.Drawing.Size(160, 36);
            this.buttonClassUpdate.TabIndex = 39;
            this.buttonClassUpdate.Text = "Add";
            this.buttonClassUpdate.UseVisualStyleBackColor = true;
            this.buttonClassUpdate.Visible = false;
            this.buttonClassUpdate.Click += new System.EventHandler(this.buttonClassUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Class Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Enabled = false;
            this.textBoxClassName.Location = new System.Drawing.Point(276, 229);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(201, 23);
            this.textBoxClassName.TabIndex = 35;
            // 
            // buttonAddNewClass
            // 
            this.buttonAddNewClass.Location = new System.Drawing.Point(486, 228);
            this.buttonAddNewClass.Name = "buttonAddNewClass";
            this.buttonAddNewClass.Size = new System.Drawing.Size(160, 36);
            this.buttonAddNewClass.TabIndex = 34;
            this.buttonAddNewClass.Text = "Add Class";
            this.buttonAddNewClass.UseVisualStyleBackColor = true;
            this.buttonAddNewClass.Click += new System.EventHandler(this.buttonAddNewClass_Click);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClassSl,
            this.ColumnClassDepartment,
            this.ColumnClassName,
            this.teacher_name,
            this.ColumnClassId,
            this.ColumnClassNumber});
            this.dataGridViewClass.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.Size = new System.Drawing.Size(654, 202);
            this.dataGridViewClass.TabIndex = 0;
            this.dataGridViewClass.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewClass_RowPostPaint);
            this.dataGridViewClass.DoubleClick += new System.EventHandler(this.dataGridViewClass_DoubleClick);
            // 
            // panelDepartment
            // 
            this.panelDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDepartment.Controls.Add(this.buttonAddDepartment);
            this.panelDepartment.Controls.Add(this.label5);
            this.panelDepartment.Controls.Add(this.textBoxDepartmentName);
            this.panelDepartment.Controls.Add(this.buttonAddNew);
            this.panelDepartment.Controls.Add(this.dataGridViewDepartment);
            this.panelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDepartment.Location = new System.Drawing.Point(21, 372);
            this.panelDepartment.Name = "panelDepartment";
            this.panelDepartment.Size = new System.Drawing.Size(394, 73);
            this.panelDepartment.TabIndex = 2;
            this.panelDepartment.Visible = false;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddDepartment.Location = new System.Drawing.Point(314, 134);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(160, 38);
            this.buttonAddDepartment.TabIndex = 39;
            this.buttonAddDepartment.Text = "Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Visible = false;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Department Name";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(342, 97);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.ReadOnly = true;
            this.textBoxDepartmentName.Size = new System.Drawing.Size(232, 23);
            this.textBoxDepartmentName.TabIndex = 36;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddNew.Location = new System.Drawing.Point(229, 23);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(160, 38);
            this.buttonAddNew.TabIndex = 34;
            this.buttonAddNew.Text = "Add Department";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDepartmentName,
            this.ColumnDepartmentId});
            this.dataGridViewDepartment.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.Size = new System.Drawing.Size(320, 309);
            this.dataGridViewDepartment.TabIndex = 0;
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
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.Enabled = false;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(276, 277);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTeacher.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Teacher";
            // 
            // ColumnClassSl
            // 
            this.ColumnClassSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClassSl.HeaderText = "#";
            this.ColumnClassSl.Name = "ColumnClassSl";
            this.ColumnClassSl.ReadOnly = true;
            this.ColumnClassSl.Width = 41;
            // 
            // ColumnClassDepartment
            // 
            this.ColumnClassDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClassDepartment.DataPropertyName = "department";
            this.ColumnClassDepartment.HeaderText = "Department";
            this.ColumnClassDepartment.Name = "ColumnClassDepartment";
            this.ColumnClassDepartment.ReadOnly = true;
            this.ColumnClassDepartment.Width = 107;
            // 
            // ColumnClassName
            // 
            this.ColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClassName.DataPropertyName = "name";
            this.ColumnClassName.HeaderText = "Name";
            this.ColumnClassName.Name = "ColumnClassName";
            this.ColumnClassName.ReadOnly = true;
            this.ColumnClassName.Width = 70;
            // 
            // teacher_name
            // 
            this.teacher_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // ColumnClassId
            // 
            this.ColumnClassId.DataPropertyName = "id";
            this.ColumnClassId.HeaderText = "ID";
            this.ColumnClassId.Name = "ColumnClassId";
            this.ColumnClassId.ReadOnly = true;
            this.ColumnClassId.Visible = false;
            // 
            // ColumnClassNumber
            // 
            this.ColumnClassNumber.DataPropertyName = "classNumber";
            this.ColumnClassNumber.HeaderText = "Class Number";
            this.ColumnClassNumber.Name = "ColumnClassNumber";
            this.ColumnClassNumber.ReadOnly = true;
            this.ColumnClassNumber.Visible = false;
            // 
            // FrmAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelClass);
            this.Controls.Add(this.panelDepartment);
            this.Controls.Add(this.panelTopMenu);
            this.Name = "FrmAcademic";
            this.Text = "Academic Details";
            this.panelTopMenu.ResumeLayout(false);
            this.panelClass.ResumeLayout(false);
            this.panelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.panelDepartment.ResumeLayout(false);
            this.panelDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Button buttonAddNewClass;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClassUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClassDepartment;
        private System.Windows.Forms.Panel panelDepartment;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button buttonDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartmentId;
        private System.Windows.Forms.NumericUpDown numericUpDownClassNumber;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassNumber;
    }
}