
namespace MadrasahSMS.Settings
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOffNameBangla = new System.Windows.Forms.TextBox();
            this.textBoxOffNameEnglish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOffNameArabic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.errorProviderSetting = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonBrowseLogo = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.toolTipSetting = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxEffectOnFinal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office Name Bangla";
            // 
            // textBoxOffNameBangla
            // 
            this.textBoxOffNameBangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOffNameBangla.Location = new System.Drawing.Point(169, 26);
            this.textBoxOffNameBangla.Name = "textBoxOffNameBangla";
            this.textBoxOffNameBangla.Size = new System.Drawing.Size(399, 23);
            this.textBoxOffNameBangla.TabIndex = 2;
            // 
            // textBoxOffNameEnglish
            // 
            this.textBoxOffNameEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOffNameEnglish.Location = new System.Drawing.Point(169, 55);
            this.textBoxOffNameEnglish.Name = "textBoxOffNameEnglish";
            this.textBoxOffNameEnglish.Size = new System.Drawing.Size(399, 23);
            this.textBoxOffNameEnglish.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Office Name English";
            // 
            // textBoxOffNameArabic
            // 
            this.textBoxOffNameArabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOffNameArabic.Location = new System.Drawing.Point(169, 84);
            this.textBoxOffNameArabic.Name = "textBoxOffNameArabic";
            this.textBoxOffNameArabic.Size = new System.Drawing.Size(399, 23);
            this.textBoxOffNameArabic.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Office Name Arabic";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(515, 395);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(160, 43);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // errorProviderSetting
            // 
            this.errorProviderSetting.ContainerControl = this;
            // 
            // buttonBrowseLogo
            // 
            this.buttonBrowseLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseLogo.Location = new System.Drawing.Point(575, 127);
            this.buttonBrowseLogo.Name = "buttonBrowseLogo";
            this.buttonBrowseLogo.Size = new System.Drawing.Size(100, 30);
            this.buttonBrowseLogo.TabIndex = 9;
            this.buttonBrowseLogo.Text = "Browse Logo";
            this.buttonBrowseLogo.UseVisualStyleBackColor = true;
            this.buttonBrowseLogo.Click += new System.EventHandler(this.buttonBrowseLogo_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(575, 26);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            this.toolTipSetting.SetToolTip(this.pictureBoxLogo, "Square Image Needed");
            // 
            // checkBoxEffectOnFinal
            // 
            this.checkBoxEffectOnFinal.AutoSize = true;
            this.checkBoxEffectOnFinal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEffectOnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEffectOnFinal.Location = new System.Drawing.Point(360, 113);
            this.checkBoxEffectOnFinal.Name = "checkBoxEffectOnFinal";
            this.checkBoxEffectOnFinal.Size = new System.Drawing.Size(208, 21);
            this.checkBoxEffectOnFinal.TabIndex = 10;
            this.checkBoxEffectOnFinal.Text = "Previous exam effect on final";
            this.checkBoxEffectOnFinal.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.checkBoxEffectOnFinal);
            this.Controls.Add(this.buttonBrowseLogo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxOffNameArabic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOffNameEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOffNameBangla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOffNameBangla;
        private System.Windows.Forms.TextBox textBoxOffNameEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOffNameArabic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ErrorProvider errorProviderSetting;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBrowseLogo;
        private System.Windows.Forms.ToolTip toolTipSetting;
        private System.Windows.Forms.CheckBox checkBoxEffectOnFinal;
    }
}