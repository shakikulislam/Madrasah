
namespace WindowsDesktop
{
    partial class FrmAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDivision = new System.Windows.Forms.ListView();
            this.columnHeaderDivisionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDistrict = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewUpazila = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listViewUnion = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.textBoxUpazila = new System.Windows.Forms.TextBox();
            this.textBoxUnion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "District";
            // 
            // listViewDivision
            // 
            this.listViewDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDivisionName});
            this.listViewDivision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDivision.FullRowSelect = true;
            this.listViewDivision.HideSelection = false;
            this.listViewDivision.Location = new System.Drawing.Point(15, 29);
            this.listViewDivision.MultiSelect = false;
            this.listViewDivision.Name = "listViewDivision";
            this.listViewDivision.Size = new System.Drawing.Size(212, 200);
            this.listViewDivision.TabIndex = 8;
            this.listViewDivision.UseCompatibleStateImageBehavior = false;
            this.listViewDivision.View = System.Windows.Forms.View.Details;
            this.listViewDivision.Click += new System.EventHandler(this.listViewDivision_Click);
            // 
            // columnHeaderDivisionName
            // 
            this.columnHeaderDivisionName.Text = "Name";
            this.columnHeaderDivisionName.Width = 180;
            // 
            // listViewDistrict
            // 
            this.listViewDistrict.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewDistrict.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDistrict.FullRowSelect = true;
            this.listViewDistrict.HideSelection = false;
            this.listViewDistrict.Location = new System.Drawing.Point(236, 29);
            this.listViewDistrict.MultiSelect = false;
            this.listViewDistrict.Name = "listViewDistrict";
            this.listViewDistrict.Size = new System.Drawing.Size(212, 200);
            this.listViewDistrict.TabIndex = 9;
            this.listViewDistrict.UseCompatibleStateImageBehavior = false;
            this.listViewDistrict.View = System.Windows.Forms.View.Details;
            this.listViewDistrict.Click += new System.EventHandler(this.listViewDistrict_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 180;
            // 
            // listViewUpazila
            // 
            this.listViewUpazila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewUpazila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewUpazila.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUpazila.FullRowSelect = true;
            this.listViewUpazila.HideSelection = false;
            this.listViewUpazila.Location = new System.Drawing.Point(15, 262);
            this.listViewUpazila.MultiSelect = false;
            this.listViewUpazila.Name = "listViewUpazila";
            this.listViewUpazila.Size = new System.Drawing.Size(212, 200);
            this.listViewUpazila.TabIndex = 11;
            this.listViewUpazila.UseCompatibleStateImageBehavior = false;
            this.listViewUpazila.View = System.Windows.Forms.View.Details;
            this.listViewUpazila.Click += new System.EventHandler(this.listViewUpazila_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Upazila";
            // 
            // listViewUnion
            // 
            this.listViewUnion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewUnion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUnion.FullRowSelect = true;
            this.listViewUnion.HideSelection = false;
            this.listViewUnion.Location = new System.Drawing.Point(236, 262);
            this.listViewUnion.MultiSelect = false;
            this.listViewUnion.Name = "listViewUnion";
            this.listViewUnion.Size = new System.Drawing.Size(212, 200);
            this.listViewUnion.TabIndex = 13;
            this.listViewUnion.UseCompatibleStateImageBehavior = false;
            this.listViewUnion.View = System.Windows.Forms.View.Details;
            this.listViewUnion.Click += new System.EventHandler(this.listViewUnion_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Union";
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDivision.Location = new System.Drawing.Point(532, 48);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.ReadOnly = true;
            this.textBoxDivision.Size = new System.Drawing.Size(223, 25);
            this.textBoxDivision.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Division";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "District";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Upazila";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Union";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDistrict.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistrict.Location = new System.Drawing.Point(532, 79);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.ReadOnly = true;
            this.textBoxDistrict.Size = new System.Drawing.Size(223, 25);
            this.textBoxDistrict.TabIndex = 19;
            // 
            // textBoxUpazila
            // 
            this.textBoxUpazila.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpazila.Location = new System.Drawing.Point(532, 110);
            this.textBoxUpazila.Name = "textBoxUpazila";
            this.textBoxUpazila.ReadOnly = true;
            this.textBoxUpazila.Size = new System.Drawing.Size(223, 25);
            this.textBoxUpazila.TabIndex = 20;
            // 
            // textBoxUnion
            // 
            this.textBoxUnion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnion.Location = new System.Drawing.Point(532, 141);
            this.textBoxUnion.Name = "textBoxUnion";
            this.textBoxUnion.ReadOnly = true;
            this.textBoxUnion.Size = new System.Drawing.Size(223, 25);
            this.textBoxUnion.TabIndex = 21;
            // 
            // FrmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.textBoxUnion);
            this.Controls.Add(this.textBoxUpazila);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDivision);
            this.Controls.Add(this.listViewUnion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewUpazila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewDistrict);
            this.Controls.Add(this.listViewDivision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddress";
            this.Text = "Address Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDivision;
        private System.Windows.Forms.ColumnHeader columnHeaderDivisionName;
        private System.Windows.Forms.ListView listViewDistrict;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewUpazila;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewUnion;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.TextBox textBoxUpazila;
        private System.Windows.Forms.TextBox textBoxUnion;
    }
}