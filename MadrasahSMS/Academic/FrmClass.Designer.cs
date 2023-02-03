
namespace MadrasahSMS.Academic
{
    partial class FrmClass
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
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownClassNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonClassUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.buttonAddNewClass = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.ColumnClassSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelClassForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClass)).BeginInit();
            this.panelClassForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(119, 74);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(358, 24);
            this.comboBoxTeacher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Teacher";
            // 
            // numericUpDownClassNumber
            // 
            this.numericUpDownClassNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownClassNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownClassNumber.Location = new System.Drawing.Point(4, 75);
            this.numericUpDownClassNumber.Name = "numericUpDownClassNumber";
            this.numericUpDownClassNumber.Size = new System.Drawing.Size(96, 23);
            this.numericUpDownClassNumber.TabIndex = 4;
            // 
            // buttonClassUpdate
            // 
            this.buttonClassUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClassUpdate.Location = new System.Drawing.Point(520, 71);
            this.buttonClassUpdate.Name = "buttonClassUpdate";
            this.buttonClassUpdate.Size = new System.Drawing.Size(160, 36);
            this.buttonClassUpdate.TabIndex = 1;
            this.buttonClassUpdate.Text = "Add";
            this.buttonClassUpdate.UseVisualStyleBackColor = true;
            this.buttonClassUpdate.Visible = false;
            this.buttonClassUpdate.Click += new System.EventHandler(this.buttonClassUpdate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Class Number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassName.Location = new System.Drawing.Point(4, 26);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(473, 23);
            this.textBoxClassName.TabIndex = 3;
            // 
            // buttonAddNewClass
            // 
            this.buttonAddNewClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddNewClass.Location = new System.Drawing.Point(520, 34);
            this.buttonAddNewClass.Name = "buttonAddNewClass";
            this.buttonAddNewClass.Size = new System.Drawing.Size(160, 36);
            this.buttonAddNewClass.TabIndex = 0;
            this.buttonAddNewClass.Text = "Add Class";
            this.buttonAddNewClass.UseVisualStyleBackColor = true;
            this.buttonAddNewClass.Click += new System.EventHandler(this.buttonAddNewClass_Click);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClassSl,
            this.teacher_name,
            this.ColumnClassName,
            this.ColumnClassId,
            this.ColumnClassNumber});
            this.dataGridViewClass.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.Size = new System.Drawing.Size(683, 182);
            this.dataGridViewClass.TabIndex = 0;
            this.dataGridViewClass.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewClass_RowPostPaint);
            this.dataGridViewClass.DoubleClick += new System.EventHandler(this.dataGridViewClass_DoubleClick);
            // 
            // ColumnClassSl
            // 
            this.ColumnClassSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClassSl.HeaderText = "#";
            this.ColumnClassSl.Name = "ColumnClassSl";
            this.ColumnClassSl.ReadOnly = true;
            this.ColumnClassSl.Width = 39;
            // 
            // teacher_name
            // 
            this.teacher_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "Teacher Name";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // ColumnClassName
            // 
            this.ColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnClassName.DataPropertyName = "className";
            this.ColumnClassName.HeaderText = "Class Name";
            this.ColumnClassName.Name = "ColumnClassName";
            this.ColumnClassName.ReadOnly = true;
            this.ColumnClassName.Width = 88;
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
            // errorProviderClass
            // 
            this.errorProviderClass.ContainerControl = this;
            // 
            // panelClassForm
            // 
            this.panelClassForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelClassForm.Controls.Add(this.label2);
            this.panelClassForm.Controls.Add(this.comboBoxTeacher);
            this.panelClassForm.Controls.Add(this.label1);
            this.panelClassForm.Controls.Add(this.label4);
            this.panelClassForm.Controls.Add(this.textBoxClassName);
            this.panelClassForm.Controls.Add(this.numericUpDownClassNumber);
            this.panelClassForm.Location = new System.Drawing.Point(26, 7);
            this.panelClassForm.Name = "panelClassForm";
            this.panelClassForm.Size = new System.Drawing.Size(494, 107);
            this.panelClassForm.TabIndex = 44;
            this.panelClassForm.Visible = false;
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 329);
            this.Controls.Add(this.panelClassForm);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.buttonClassUpdate);
            this.Controls.Add(this.buttonAddNewClass);
            this.Name = "FrmClass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClass)).EndInit();
            this.panelClassForm.ResumeLayout(false);
            this.panelClassForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownClassNumber;
        private System.Windows.Forms.Button buttonClassUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Button buttonAddNewClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.ErrorProvider errorProviderClass;
        private System.Windows.Forms.Panel panelClassForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassNumber;
    }
}