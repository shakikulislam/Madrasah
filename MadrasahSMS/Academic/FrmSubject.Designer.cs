
namespace MadrasahSMS.Academic
{
    partial class FrmSubject
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
            this.textBoxSubjectCode = new System.Windows.Forms.TextBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridViewSubjectList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.errorProviderSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabelCancel = new System.Windows.Forms.LinkLabel();
            this.checkBoxMandatory = new System.Windows.Forms.CheckBox();
            this.ColumnSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMandatory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSubjectCode
            // 
            this.textBoxSubjectCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSubjectCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectCode.Location = new System.Drawing.Point(96, 12);
            this.textBoxSubjectCode.Name = "textBoxSubjectCode";
            this.textBoxSubjectCode.Size = new System.Drawing.Size(121, 25);
            this.textBoxSubjectCode.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(510, 11);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(162, 25);
            this.comboBoxClass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(551, 43);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(121, 39);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridViewSubjectList
            // 
            this.dataGridViewSubjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSl,
            this.ColumnCode,
            this.ColumnName,
            this.ColumnMandatory,
            this.ColumnMark,
            this.ColumnClass,
            this.ColumnTeacher,
            this.ColumnSubjectId,
            this.ColumnClassId,
            this.ColumnTeacherId});
            this.dataGridViewSubjectList.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewSubjectList.Name = "dataGridViewSubjectList";
            this.dataGridViewSubjectList.Size = new System.Drawing.Size(660, 313);
            this.dataGridViewSubjectList.TabIndex = 4;
            this.dataGridViewSubjectList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjectList_CellDoubleClick);
            this.dataGridViewSubjectList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSubjectList_RowPostPaint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Code";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject Name";
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSubjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectName.Location = new System.Drawing.Point(96, 43);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(439, 25);
            this.textBoxSubjectName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mark";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teacher";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTeacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(96, 74);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(439, 25);
            this.comboBoxTeacher.TabIndex = 4;
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMark.Location = new System.Drawing.Point(279, 13);
            this.numericUpDownMark.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(77, 23);
            this.numericUpDownMark.TabIndex = 2;
            // 
            // errorProviderSubject
            // 
            this.errorProviderSubject.ContainerControl = this;
            // 
            // linkLabelCancel
            // 
            this.linkLabelCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelCancel.AutoSize = true;
            this.linkLabelCancel.Location = new System.Drawing.Point(591, 83);
            this.linkLabelCancel.Name = "linkLabelCancel";
            this.linkLabelCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabelCancel.TabIndex = 12;
            this.linkLabelCancel.TabStop = true;
            this.linkLabelCancel.Text = "Cancel";
            this.linkLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCancel_LinkClicked);
            // 
            // checkBoxMandatory
            // 
            this.checkBoxMandatory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxMandatory.AutoSize = true;
            this.checkBoxMandatory.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMandatory.FlatAppearance.BorderSize = 0;
            this.checkBoxMandatory.Location = new System.Drawing.Point(376, 16);
            this.checkBoxMandatory.Name = "checkBoxMandatory";
            this.checkBoxMandatory.Size = new System.Drawing.Size(76, 17);
            this.checkBoxMandatory.TabIndex = 13;
            this.checkBoxMandatory.Text = "Mandatory";
            this.checkBoxMandatory.UseVisualStyleBackColor = true;
            // 
            // ColumnSl
            // 
            this.ColumnSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSl.HeaderText = "#";
            this.ColumnSl.Name = "ColumnSl";
            this.ColumnSl.ReadOnly = true;
            this.ColumnSl.Width = 39;
            // 
            // ColumnCode
            // 
            this.ColumnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCode.HeaderText = "Code";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 57;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnMandatory
            // 
            this.ColumnMandatory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnMandatory.HeaderText = "Mandatory";
            this.ColumnMandatory.Name = "ColumnMandatory";
            this.ColumnMandatory.ReadOnly = true;
            this.ColumnMandatory.Width = 63;
            // 
            // ColumnMark
            // 
            this.ColumnMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnMark.HeaderText = "Mark";
            this.ColumnMark.Name = "ColumnMark";
            this.ColumnMark.ReadOnly = true;
            this.ColumnMark.Width = 56;
            // 
            // ColumnClass
            // 
            this.ColumnClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClass.HeaderText = "Class";
            this.ColumnClass.Name = "ColumnClass";
            this.ColumnClass.ReadOnly = true;
            this.ColumnClass.Width = 57;
            // 
            // ColumnTeacher
            // 
            this.ColumnTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTeacher.HeaderText = "Teacher";
            this.ColumnTeacher.Name = "ColumnTeacher";
            this.ColumnTeacher.ReadOnly = true;
            this.ColumnTeacher.Width = 72;
            // 
            // ColumnSubjectId
            // 
            this.ColumnSubjectId.HeaderText = "id";
            this.ColumnSubjectId.Name = "ColumnSubjectId";
            this.ColumnSubjectId.ReadOnly = true;
            this.ColumnSubjectId.Visible = false;
            // 
            // ColumnClassId
            // 
            this.ColumnClassId.HeaderText = "class id";
            this.ColumnClassId.Name = "ColumnClassId";
            this.ColumnClassId.ReadOnly = true;
            this.ColumnClassId.Visible = false;
            // 
            // ColumnTeacherId
            // 
            this.ColumnTeacherId.HeaderText = "teacher id";
            this.ColumnTeacherId.Name = "ColumnTeacherId";
            this.ColumnTeacherId.ReadOnly = true;
            this.ColumnTeacherId.Visible = false;
            // 
            // FrmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.checkBoxMandatory);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.linkLabelCancel);
            this.Controls.Add(this.numericUpDownMark);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.textBoxSubjectCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSubjectList);
            this.Controls.Add(this.label1);
            this.Name = "FrmSubject";
            this.Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubjectCode;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridViewSubjectList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.ErrorProvider errorProviderSubject;
        private System.Windows.Forms.LinkLabel linkLabelCancel;
        private System.Windows.Forms.CheckBox checkBoxMandatory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnMandatory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherId;
    }
}