using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MadrasahSMS.Common;
using MadrasahSMS.DbContext;
using MadrasahSMS.Properties;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Settings
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            this.BackColor = STheme.SColor.BackColor;
            ThemeTemplate.LoadTheme(this);
            LoadLanguage();
            LoadData();
        }

        private void LoadLanguage()
        {
            this.Text = ContentText.Settings;
        }

        private void LoadData()
        {
            textBoxOffNameBangla.Text = GlobalSettings.OfficeInfo.NameBangla;
            textBoxOffNameEnglish.Text = GlobalSettings.OfficeInfo.NameEnglish;
            textBoxOffNameArabic.Text = GlobalSettings.OfficeInfo.NameArabic;
            pictureBoxLogo.Image = GlobalSettings.OfficeInfo.Logo;
            checkBoxEffectOnFinal.Checked = GlobalSettings.OfficeInfo.PreExamEffFinal;
        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                var valid = ThemeTemplate.SValidate(this, errorProviderSetting);
                if (valid)
                {
                    var eff_final = checkBoxEffectOnFinal.Checked ? 1 : 0;
                    var cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE S_OFFICE SET NAME_EN=N'" + textBoxOffNameEnglish.Text.Trim() +
                                      "', NAME_BN=N'" + textBoxOffNameBangla.Text.Trim() +
                                      "', NAME_AR=N'" + textBoxOffNameArabic.Text.Trim() +
                                      "', LOGO=@img , " +
                                      "PRE_EXAM_EFF_FINAL = " + eff_final +
                                      " WHERE ID=" + GlobalSettings.OfficeInfo.Id;
                    
                    cmd.Parameters.AddWithValue("@img", GlobalSettings.ImageToByte(pictureBoxLogo.Image));
                    
                    var isUpdate = Db.QueryExecute(cmd);
                    if (isUpdate)
                    {
                        AppObject.Office();
                        MessageBox.Show(ContentText.UpdateSuccess);
                    }
                    else
                    {
                        MessageBox.Show(ContentText.UpdateFailed);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBrowseLogo_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png", Multiselect = false };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    if (MessageBox.Show("Set default?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        pictureBoxLogo.Image = Resources.NoLogo;
                    }
                }
            }
            catch (Exception ex)
            {
                pictureBoxLogo.Image = Resources.NoLogo;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
