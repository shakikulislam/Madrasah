
namespace MadrasahSMS
{
    partial class FrmResultProcess
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelClassTeacher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubjectMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObtainedMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObtainedPct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGradePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLetterGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSearch.Controls.Add(this.labelClassTeacher);
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.comboBoxClass);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.comboBoxExam);
            this.panelSearch.Controls.Add(this.buttonProcess);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Location = new System.Drawing.Point(110, 11);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(680, 78);
            this.panelSearch.TabIndex = 18;
            // 
            // labelClassTeacher
            // 
            this.labelClassTeacher.AutoSize = true;
            this.labelClassTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassTeacher.Location = new System.Drawing.Point(133, 46);
            this.labelClassTeacher.Name = "labelClassTeacher";
            this.labelClassTeacher.Size = new System.Drawing.Size(13, 17);
            this.labelClassTeacher.TabIndex = 18;
            this.labelClassTeacher.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Class Teacher :";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(319, 12);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(239, 24);
            this.comboBoxClass.TabIndex = 0;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Location = new System.Drawing.Point(68, 12);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(197, 24);
            this.comboBoxExam.TabIndex = 5;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(564, 12);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(112, 51);
            this.buttonProcess.TabIndex = 15;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
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
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnRoll,
            this.ColumnName,
            this.ColumnSubjectMarks,
            this.ColumnObtainedMark,
            this.ColumnObtainedPct,
            this.ColumnGradePoint,
            this.ColumnLetterGrade});
            this.dataGridViewStudentList.Location = new System.Drawing.Point(12, 95);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(877, 411);
            this.dataGridViewStudentList.TabIndex = 17;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnRoll
            // 
            this.ColumnRoll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRoll.HeaderText = "Roll";
            this.ColumnRoll.Name = "ColumnRoll";
            this.ColumnRoll.ReadOnly = true;
            this.ColumnRoll.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSubjectMarks
            // 
            this.ColumnSubjectMarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSubjectMarks.HeaderText = "Subject Marks";
            this.ColumnSubjectMarks.Name = "ColumnSubjectMarks";
            this.ColumnSubjectMarks.ReadOnly = true;
            // 
            // ColumnObtainedMark
            // 
            this.ColumnObtainedMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnObtainedMark.HeaderText = "Obtained Mark";
            this.ColumnObtainedMark.Name = "ColumnObtainedMark";
            this.ColumnObtainedMark.ReadOnly = true;
            this.ColumnObtainedMark.Width = 102;
            // 
            // ColumnObtainedPct
            // 
            this.ColumnObtainedPct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnObtainedPct.HeaderText = "Obtained PCT";
            this.ColumnObtainedPct.Name = "ColumnObtainedPct";
            this.ColumnObtainedPct.ReadOnly = true;
            this.ColumnObtainedPct.Width = 99;
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
            // FrmResultProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Name = "FrmResultProcess";
            this.Text = "Result Process";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClassTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubjectMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObtainedMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObtainedPct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGradePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLetterGrade;
    }
}