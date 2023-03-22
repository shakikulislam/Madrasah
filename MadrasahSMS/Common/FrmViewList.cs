using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MadrasahSMS.Theme;

namespace MadrasahSMS.Common
{
    public partial class FrmViewList : Form
    {
        private static FrmViewList _viewList;
        private static bool _decision;

        public FrmViewList()
        {
            InitializeComponent();

            ThemeTemplate.LoadTheme(panelBody);
        }

        public static bool Show(string fromTitle, DataTable data, string[] columnHeader, int? fillColumnIndex = null, bool makeDecision = false, string decisionButtonText="")
        {
            _viewList = new FrmViewList();

            _viewList.labelTitle.Text = fromTitle;

            foreach (var headerTitle in columnHeader)
            {
                var columnName = "ColumnHeader" + headerTitle.Replace(" ", string.Empty);
                _viewList.dataGridViewList.Columns.Add(columnName, headerTitle);
                _viewList.dataGridViewList.Columns[columnName].ReadOnly = true;
            }

            foreach (DataRow row in data.Rows)
            {
                var s = _viewList.dataGridViewList.Rows.Add();
                for (var i = 0; i < columnHeader.Length; i++)
                {
                    _viewList.dataGridViewList.Rows[s].Cells[i].Value = row[i].ToString();
                }
            }

            _viewList.dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (fillColumnIndex != null)
            {
                _viewList.dataGridViewList.Columns[(int)fillColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            _viewList.linkLabelAction.Text = decisionButtonText;
            _viewList.linkLabelAction.Visible = makeDecision;
            _decision = false;

            _viewList.ShowDialog();
            return _decision;
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
            _viewList.Close();
        }
        
        private void linkLabelAction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(ContentText.ProcessWithoutAbsentList, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _decision = true;
                _viewList.Close();
            }
        }
    }
}
