
namespace MadrasahSMS
{
    partial class FrmMarksEntry
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
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLetterGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMandatory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.linkLabelAbsentList = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerExamDate = new System.Windows.Forms.DateTimePicker();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.linkLabelSetAbsent = new System.Windows.Forms.LinkLabel();
            this.labelSubjectMark = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.labelDueEntry = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMarkEntry = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderMark = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMark)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(320, 12);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(239, 24);
            this.comboBoxClass.TabIndex = 0;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnRoll,
            this.ColumnReg,
            this.ColumnName,
            this.ColumnMark,
            this.ColumnGradePoint,
            this.ColumnLetterGrade,
            this.ColumnId,
            this.ColumnSubjectMarks,
            this.ColumnStatus,
            this.ColumnMandatory});
            this.dataGridViewStudentList.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(680, 247);
            this.dataGridViewStudentList.TabIndex = 2;
            this.dataGridViewStudentList.SelectionChanged += new System.EventHandler(this.dataGridViewStudentList_SelectionChanged);
            this.dataGridViewStudentList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStudentList_KeyDown);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCheck.HeaderText = "";
            this.ColumnCheck.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCheck.Width = 21;
            // 
            // ColumnRoll
            // 
            this.ColumnRoll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRoll.HeaderText = "Roll";
            this.ColumnRoll.Name = "ColumnRoll";
            this.ColumnRoll.ReadOnly = true;
            this.ColumnRoll.Width = 50;
            // 
            // ColumnReg
            // 
            this.ColumnReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnReg.HeaderText = "Reg";
            this.ColumnReg.Name = "ColumnReg";
            this.ColumnReg.ReadOnly = true;
            this.ColumnReg.Width = 52;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnMark
            // 
            this.ColumnMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnMark.HeaderText = "Mark";
            this.ColumnMark.Name = "ColumnMark";
            this.ColumnMark.ReadOnly = true;
            this.ColumnMark.Width = 56;
            // 
            // ColumnGradePoint
            // 
            this.ColumnGradePoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnGradePoint.HeaderText = "Grade Point";
            this.ColumnGradePoint.Name = "ColumnGradePoint";
            this.ColumnGradePoint.ReadOnly = true;
            this.ColumnGradePoint.Width = 88;
            // 
            // ColumnLetterGrade
            // 
            this.ColumnLetterGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnLetterGrade.HeaderText = "Letter Grade";
            this.ColumnLetterGrade.Name = "ColumnLetterGrade";
            this.ColumnLetterGrade.ReadOnly = true;
            this.ColumnLetterGrade.Width = 91;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnSubjectMarks
            // 
            this.ColumnSubjectMarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSubjectMarks.HeaderText = "Subject Marks";
            this.ColumnSubjectMarks.Name = "ColumnSubjectMarks";
            this.ColumnSubjectMarks.ReadOnly = true;
            this.ColumnSubjectMarks.Visible = false;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Visible = false;
            // 
            // ColumnMandatory
            // 
            this.ColumnMandatory.HeaderText = "Mandatory";
            this.ColumnMandatory.Name = "ColumnMandatory";
            this.ColumnMandatory.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(567, 46);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 37);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exam";
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Location = new System.Drawing.Point(68, 12);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(188, 24);
            this.comboBoxExam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subject";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(68, 42);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(279, 24);
            this.comboBoxSubject.TabIndex = 7;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(74, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(376, 23);
            this.textBoxName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Roll";
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Enabled = false;
            this.textBoxRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoll.Location = new System.Drawing.Point(74, 60);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(203, 23);
            this.textBoxRoll.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Reg";
            // 
            // textBoxReg
            // 
            this.textBoxReg.Enabled = false;
            this.textBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReg.Location = new System.Drawing.Point(350, 60);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(203, 23);
            this.textBoxReg.TabIndex = 13;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(567, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(109, 34);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSearch.Controls.Add(this.linkLabelAbsentList);
            this.panelSearch.Controls.Add(this.comboBoxClass);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.label8);
            this.panelSearch.Controls.Add(this.dateTimePickerExamDate);
            this.panelSearch.Controls.Add(this.comboBoxExam);
            this.panelSearch.Controls.Add(this.buttonOk);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.comboBoxSubject);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Location = new System.Drawing.Point(12, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(680, 78);
            this.panelSearch.TabIndex = 16;
            // 
            // linkLabelAbsentList
            // 
            this.linkLabelAbsentList.AutoSize = true;
            this.linkLabelAbsentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAbsentList.Location = new System.Drawing.Point(577, 53);
            this.linkLabelAbsentList.Name = "linkLabelAbsentList";
            this.linkLabelAbsentList.Size = new System.Drawing.Size(78, 17);
            this.linkLabelAbsentList.TabIndex = 19;
            this.linkLabelAbsentList.TabStop = true;
            this.linkLabelAbsentList.Text = "Absent List";
            this.linkLabelAbsentList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbsentList_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Exam Date";
            // 
            // dateTimePickerExamDate
            // 
            this.dateTimePickerExamDate.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerExamDate.Enabled = false;
            this.dateTimePickerExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExamDate.Location = new System.Drawing.Point(442, 43);
            this.dateTimePickerExamDate.Name = "dateTimePickerExamDate";
            this.dateTimePickerExamDate.Size = new System.Drawing.Size(117, 23);
            this.dateTimePickerExamDate.TabIndex = 16;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelUpdate.Controls.Add(this.linkLabelSetAbsent);
            this.panelUpdate.Controls.Add(this.labelSubjectMark);
            this.panelUpdate.Controls.Add(this.textBoxMark);
            this.panelUpdate.Controls.Add(this.labelDueEntry);
            this.panelUpdate.Controls.Add(this.label11);
            this.panelUpdate.Controls.Add(this.labelMarkEntry);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.labelTotalStudent);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.textBoxName);
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Controls.Add(this.textBoxReg);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.textBoxRoll);
            this.panelUpdate.Enabled = false;
            this.panelUpdate.Location = new System.Drawing.Point(12, 340);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(680, 98);
            this.panelUpdate.TabIndex = 16;
            // 
            // linkLabelSetAbsent
            // 
            this.linkLabelSetAbsent.AutoSize = true;
            this.linkLabelSetAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSetAbsent.Location = new System.Drawing.Point(465, 33);
            this.linkLabelSetAbsent.Name = "linkLabelSetAbsent";
            this.linkLabelSetAbsent.Size = new System.Drawing.Size(77, 17);
            this.linkLabelSetAbsent.TabIndex = 23;
            this.linkLabelSetAbsent.TabStop = true;
            this.linkLabelSetAbsent.Text = "Set Absent";
            this.linkLabelSetAbsent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetAbsent_LinkClicked);
            // 
            // labelSubjectMark
            // 
            this.labelSubjectMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjectMark.ForeColor = System.Drawing.Color.Red;
            this.labelSubjectMark.Location = new System.Drawing.Point(542, 0);
            this.labelSubjectMark.Name = "labelSubjectMark";
            this.labelSubjectMark.Size = new System.Drawing.Size(125, 17);
            this.labelSubjectMark.TabIndex = 22;
            this.labelSubjectMark.Text = "Max Mark: 0";
            this.labelSubjectMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMark.Location = new System.Drawing.Point(567, 21);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(100, 23);
            this.textBoxMark.TabIndex = 21;
            this.textBoxMark.Text = "0";
            this.textBoxMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMark_KeyDown);
            this.textBoxMark.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMark_KeyUp);
            // 
            // labelDueEntry
            // 
            this.labelDueEntry.AutoSize = true;
            this.labelDueEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueEntry.Location = new System.Drawing.Point(476, 2);
            this.labelDueEntry.Name = "labelDueEntry";
            this.labelDueEntry.Size = new System.Drawing.Size(16, 17);
            this.labelDueEntry.TabIndex = 20;
            this.labelDueEntry.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Due Entry";
            // 
            // labelMarkEntry
            // 
            this.labelMarkEntry.AutoSize = true;
            this.labelMarkEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarkEntry.Location = new System.Drawing.Point(324, 2);
            this.labelMarkEntry.Name = "labelMarkEntry";
            this.labelMarkEntry.Size = new System.Drawing.Size(16, 17);
            this.labelMarkEntry.TabIndex = 18;
            this.labelMarkEntry.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mark Entry";
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.labelTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(122, 2);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(16, 17);
            this.labelTotalStudent.TabIndex = 16;
            this.labelTotalStudent.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Student";
            // 
            // errorProviderMark
            // 
            this.errorProviderMark.ContainerControl = this;
            // 
            // FrmMarksEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Name = "FrmMarksEntry";
            this.Text = "Marks Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReg;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label labelMarkEntry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderMark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerExamDate;
        private System.Windows.Forms.Label labelDueEntry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label labelSubjectMark;
        private System.Windows.Forms.DataGridViewImageColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLetterGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnMandatory;
        private System.Windows.Forms.LinkLabel linkLabelAbsentList;
        private System.Windows.Forms.LinkLabel linkLabelSetAbsent;
    }
}