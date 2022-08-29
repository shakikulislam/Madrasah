using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsDesktop.Theme
{
    public class ThemeTemplate
    {
        public static void SLabel(Control control)
        {
            foreach (var label in control.Controls.OfType<Label>())
            {
                label.ForeColor = STheme.SColor.ForColor;
                label.BackColor = STheme.SColor.BackColor;
                label.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }
        public static void STextBox(Control control)
        {
            foreach (var textBox in control.Controls.OfType<TextBox>())
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = STheme.SColor.TextFieldForColor;
                textBox.BackColor = STheme.SColor.TextFieldBackgroundColor;
                textBox.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }
        public static void SDataGridView(Control control)
        {
            // DataGridView
            foreach (var gridView in control.Controls.OfType<DataGridView>())
            {
                gridView.BackgroundColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.BackColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.SelectionBackColor = STheme.SColor.ActiveBackColor;
                gridView.RowsDefaultCellStyle.SelectionForeColor = STheme.SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.BackColor = STheme.SColor.BackColor;
                gridView.ColumnHeadersDefaultCellStyle.ForeColor = STheme.SColor.ForColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = STheme.SColor.BackColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = STheme.SColor.ForColor;
                gridView.ColumnHeadersDefaultCellStyle.Font = new Font(STheme.SFont.Font, STheme.SFont.Size+2, STheme.SFont.Style);
                gridView.RowsDefaultCellStyle.Font = new Font(STheme.SFont.Font,STheme.SFont.Size);

                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.ShowEditingIcon = false;
                gridView.EnableHeadersVisualStyles = false;
                gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridView.RowHeadersVisible = false;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gridView.ColumnHeadersHeight = 30;
                gridView.MultiSelect = false;
                gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                gridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                gridView.RowTemplate.Resizable = DataGridViewTriState.False;
                gridView.RowTemplate.DividerHeight = 1;
                gridView.RowTemplate.Height = 25;
                gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }
    }
}

