using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Common
{
    public partial class FrmViewList : Form
    {
        public FrmViewList(string fromTitle, DataTable data, string[] columnHeader, int? fillColumnIndex = null)
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelBody);

            labelTitle.Text = fromTitle;

            foreach (string headerTitle in columnHeader)
            {
                dataGridViewList.Columns.Add("ColumnHeader" + headerTitle.Replace(" ", string.Empty), headerTitle);
            }

            foreach (DataRow row in data.Rows)
            {
                var s = dataGridViewList.Rows.Add();
                for (int i = 0; i < columnHeader.Length; i++)
                {
                    dataGridViewList.Rows[s].Cells[i].Value = row[i].ToString();
                }
            }

            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (fillColumnIndex != null)
            {
                dataGridViewList.Columns[(int) fillColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        // Drag Control
        #region Drag Control

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
