
namespace WindowsDesktop.Academic
{
    partial class FrmExam
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
            this.textBoxExamName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewExamList = new System.Windows.Forms.DataGridView();
            this.numericUpDownEffectPersent = new System.Windows.Forms.NumericUpDown();
            this.errorProviderExam = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxEffectOnFinal = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEffectFinal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEffectPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectPersent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Exam";
            // 
            // textBoxExamName
            // 
            this.textBoxExamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamName.Location = new System.Drawing.Point(167, 41);
            this.textBoxExamName.Name = "textBoxExamName";
            this.textBoxExamName.Size = new System.Drawing.Size(467, 23);
            this.textBoxExamName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(552, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 33);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewExamList
            // 
            this.dataGridViewExamList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewExamList.CausesValidation = false;
            this.dataGridViewExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSl,
            this.ColumnName,
            this.ColumnEffectFinal,
            this.ColumnEffectPercent,
            this.ColumnId});
            this.dataGridViewExamList.Location = new System.Drawing.Point(54, 126);
            this.dataGridViewExamList.Name = "dataGridViewExamList";
            this.dataGridViewExamList.Size = new System.Drawing.Size(692, 312);
            this.dataGridViewExamList.TabIndex = 3;
            this.dataGridViewExamList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewExamList_RowPostPaint);
            this.dataGridViewExamList.DoubleClick += new System.EventHandler(this.dataGridViewExamList_DoubleClick);
            // 
            // numericUpDownEffectPersent
            // 
            this.numericUpDownEffectPersent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownEffectPersent.Enabled = false;
            this.numericUpDownEffectPersent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEffectPersent.Location = new System.Drawing.Point(339, 76);
            this.numericUpDownEffectPersent.Name = "numericUpDownEffectPersent";
            this.numericUpDownEffectPersent.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownEffectPersent.TabIndex = 5;
            // 
            // errorProviderExam
            // 
            this.errorProviderExam.ContainerControl = this;
            // 
            // checkBoxEffectOnFinal
            // 
            this.checkBoxEffectOnFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxEffectOnFinal.AutoSize = true;
            this.checkBoxEffectOnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEffectOnFinal.Location = new System.Drawing.Point(167, 77);
            this.checkBoxEffectOnFinal.Name = "checkBoxEffectOnFinal";
            this.checkBoxEffectOnFinal.Size = new System.Drawing.Size(155, 21);
            this.checkBoxEffectOnFinal.TabIndex = 6;
            this.checkBoxEffectOnFinal.Text = "Effect on Final Exam";
            this.checkBoxEffectOnFinal.UseVisualStyleBackColor = true;
            this.checkBoxEffectOnFinal.CheckedChanged += new System.EventHandler(this.checkBoxEffectOnFinal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "%";
            // 
            // ColumnSl
            // 
            this.ColumnSl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSl.HeaderText = "#";
            this.ColumnSl.Name = "ColumnSl";
            this.ColumnSl.ReadOnly = true;
            this.ColumnSl.Width = 39;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "name";
            this.ColumnName.HeaderText = "Exam Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnEffectFinal
            // 
            this.ColumnEffectFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEffectFinal.DataPropertyName = "effect_on_final";
            this.ColumnEffectFinal.HeaderText = "Effect Final";
            this.ColumnEffectFinal.Name = "ColumnEffectFinal";
            this.ColumnEffectFinal.ReadOnly = true;
            this.ColumnEffectFinal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEffectFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEffectFinal.Width = 85;
            // 
            // ColumnEffectPercent
            // 
            this.ColumnEffectPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEffectPercent.DataPropertyName = "effect_percent";
            this.ColumnEffectPercent.HeaderText = "Percent";
            this.ColumnEffectPercent.Name = "ColumnEffectPercent";
            this.ColumnEffectPercent.ReadOnly = true;
            this.ColumnEffectPercent.Width = 69;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(464, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxEffectOnFinal);
            this.Controls.Add(this.numericUpDownEffectPersent);
            this.Controls.Add(this.dataGridViewExamList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxExamName);
            this.Controls.Add(this.label1);
            this.Name = "FrmExam";
            this.Text = "FrmExam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectPersent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExamName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewExamList;
        private System.Windows.Forms.NumericUpDown numericUpDownEffectPersent;
        private System.Windows.Forms.ErrorProvider errorProviderExam;
        private System.Windows.Forms.CheckBox checkBoxEffectOnFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEffectFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEffectPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.Button buttonCancel;
    }
}