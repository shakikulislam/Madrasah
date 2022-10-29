
namespace WindowsDesktop.Exam
{
    partial class FrmExamSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassList = new System.Windows.Forms.ComboBox();
            this.buttonAddSchedule = new System.Windows.Forms.Button();
            this.dateTimePickerExamDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxExamList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSubjectList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxAmPm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderExamSchedule = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewExamSchedule = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelCancel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExamSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // comboBoxClassList
            // 
            this.comboBoxClassList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassList.FormattingEnabled = true;
            this.comboBoxClassList.Location = new System.Drawing.Point(408, 12);
            this.comboBoxClassList.Name = "comboBoxClassList";
            this.comboBoxClassList.Size = new System.Drawing.Size(279, 24);
            this.comboBoxClassList.TabIndex = 2;
            this.comboBoxClassList.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassList_SelectedIndexChanged);
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSchedule.Location = new System.Drawing.Point(548, 70);
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            this.buttonAddSchedule.Size = new System.Drawing.Size(139, 32);
            this.buttonAddSchedule.TabIndex = 3;
            this.buttonAddSchedule.Text = "Add";
            this.buttonAddSchedule.UseVisualStyleBackColor = true;
            this.buttonAddSchedule.Click += new System.EventHandler(this.buttonAddSchedule_Click);
            // 
            // dateTimePickerExamDate
            // 
            this.dateTimePickerExamDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExamDate.Location = new System.Drawing.Point(73, 75);
            this.dateTimePickerExamDate.Name = "dateTimePickerExamDate";
            this.dateTimePickerExamDate.Size = new System.Drawing.Size(140, 23);
            this.dateTimePickerExamDate.TabIndex = 4;
            // 
            // comboBoxExamList
            // 
            this.comboBoxExamList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxExamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamList.FormattingEnabled = true;
            this.comboBoxExamList.Location = new System.Drawing.Point(73, 12);
            this.comboBoxExamList.Name = "comboBoxExamList";
            this.comboBoxExamList.Size = new System.Drawing.Size(279, 24);
            this.comboBoxExamList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exam";
            // 
            // comboBoxSubjectList
            // 
            this.comboBoxSubjectList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubjectList.FormattingEnabled = true;
            this.comboBoxSubjectList.Location = new System.Drawing.Point(73, 42);
            this.comboBoxSubjectList.Name = "comboBoxSubjectList";
            this.comboBoxSubjectList.Size = new System.Drawing.Size(614, 24);
            this.comboBoxSubjectList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Location = new System.Drawing.Point(314, 74);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(58, 24);
            this.comboBoxHour.TabIndex = 10;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(392, 74);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(58, 24);
            this.comboBoxMinutes.TabIndex = 11;
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Location = new System.Drawing.Point(468, 74);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.Size = new System.Drawing.Size(58, 24);
            this.comboBoxAmPm.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time";
            // 
            // errorProviderExamSchedule
            // 
            this.errorProviderExamSchedule.ContainerControl = this;
            // 
            // dataGridViewExamSchedule
            // 
            this.dataGridViewExamSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExamSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EXAM_NAME,
            this.CLASS_NAME,
            this.SUBJECT_NAME,
            this.EXAM_DATE,
            this.EXAM_TIME});
            this.dataGridViewExamSchedule.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewExamSchedule.Name = "dataGridViewExamSchedule";
            this.dataGridViewExamSchedule.Size = new System.Drawing.Size(690, 316);
            this.dataGridViewExamSchedule.TabIndex = 16;
            this.dataGridViewExamSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExamSchedule_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // EXAM_NAME
            // 
            this.EXAM_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EXAM_NAME.DataPropertyName = "EXAM_NAME";
            this.EXAM_NAME.HeaderText = "Exam";
            this.EXAM_NAME.Name = "EXAM_NAME";
            this.EXAM_NAME.ReadOnly = true;
            this.EXAM_NAME.Width = 58;
            // 
            // CLASS_NAME
            // 
            this.CLASS_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CLASS_NAME.DataPropertyName = "CLASS_NAME";
            this.CLASS_NAME.HeaderText = "Class";
            this.CLASS_NAME.Name = "CLASS_NAME";
            this.CLASS_NAME.ReadOnly = true;
            this.CLASS_NAME.Width = 57;
            // 
            // SUBJECT_NAME
            // 
            this.SUBJECT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUBJECT_NAME.DataPropertyName = "SUBJECT_NAME";
            this.SUBJECT_NAME.HeaderText = "Subject";
            this.SUBJECT_NAME.Name = "SUBJECT_NAME";
            this.SUBJECT_NAME.ReadOnly = true;
            // 
            // EXAM_DATE
            // 
            this.EXAM_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EXAM_DATE.DataPropertyName = "EXAM_DATE";
            this.EXAM_DATE.HeaderText = "Date";
            this.EXAM_DATE.Name = "EXAM_DATE";
            this.EXAM_DATE.ReadOnly = true;
            this.EXAM_DATE.Width = 55;
            // 
            // EXAM_TIME
            // 
            this.EXAM_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EXAM_TIME.DataPropertyName = "EXAM_TIME";
            this.EXAM_TIME.HeaderText = "Time";
            this.EXAM_TIME.Name = "EXAM_TIME";
            this.EXAM_TIME.ReadOnly = true;
            this.EXAM_TIME.Width = 55;
            // 
            // linkLabelCancel
            // 
            this.linkLabelCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelCancel.AutoSize = true;
            this.linkLabelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCancel.Location = new System.Drawing.Point(636, 78);
            this.linkLabelCancel.Name = "linkLabelCancel";
            this.linkLabelCancel.Size = new System.Drawing.Size(51, 17);
            this.linkLabelCancel.TabIndex = 17;
            this.linkLabelCancel.TabStop = true;
            this.linkLabelCancel.Text = "Cancel";
            this.linkLabelCancel.Visible = false;
            this.linkLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCancel_LinkClicked);
            // 
            // FrmExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.buttonAddSchedule);
            this.Controls.Add(this.linkLabelCancel);
            this.Controls.Add(this.dataGridViewExamSchedule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAmPm);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSubjectList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxExamList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerExamDate);
            this.Controls.Add(this.comboBoxClassList);
            this.Controls.Add(this.label1);
            this.Name = "FrmExamSchedule";
            this.Text = "Seat Plan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExamSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClassList;
        private System.Windows.Forms.Button buttonAddSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerExamDate;
        private System.Windows.Forms.ComboBox comboBoxExamList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSubjectList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.ComboBox comboBoxAmPm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderExamSchedule;
        private System.Windows.Forms.DataGridView dataGridViewExamSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_TIME;
        private System.Windows.Forms.LinkLabel linkLabelCancel;
    }
}