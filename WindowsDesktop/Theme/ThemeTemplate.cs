using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsDesktop.Theme
{
    public class ThemeTemplate
    {
        public static bool SValidate(Control control, ErrorProvider errorProvider)
        {
            var valid = true;
            //errorProvider = new ErrorProvider {BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError};
            errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            foreach (var textBox in control.Controls.OfType<TextBox>())
            {
                if (textBox.CausesValidation)
                {
                    errorProvider.SetError(textBox, string.Empty);

                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        errorProvider.SetError(textBox, "This field is required");
                        valid = false;
                    }
                }
            }

            return valid;
        }

        public static void SLabel(Control control)
        {
            foreach (var label in control.Controls.OfType<Label>())
            {
                label.ForeColor = STheme.SColor.ForColor;
                label.BackColor = STheme.SColor.BackColor;
                label.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }

        public static void SLinkLabel(Control control)
        {
            foreach (var linkLabel in control.Controls.OfType<LinkLabel>())
            {
                linkLabel.ForeColor = STheme.SColor.ForColor;
                linkLabel.BackColor = STheme.SColor.BackColor;
                linkLabel.Font= new Font(STheme.SFont.Font, linkLabel.Font.Size);
            }
        }

        public static void SRichTextBox(Control control)
        {
            foreach (var richTextBox in control.Controls.OfType<RichTextBox>())
            {
                richTextBox.BorderStyle = BorderStyle.FixedSingle;
                richTextBox.ForeColor = STheme.SColor.TextFieldForColor;
                richTextBox.BackColor = STheme.SColor.TextFieldBackgroundColor;
                richTextBox.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
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

            foreach (var iconButton in control.Controls.OfType<IconButton>())
            {
                iconButton.BackColor = STheme.SColor.BackColor;
                iconButton.ForeColor = STheme.SColor.ForColor;
                iconButton.TextAlign = ContentAlignment.MiddleLeft;
                iconButton.IconColor = STheme.SColor.ForColor;
                iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconButton.ImageAlign = ContentAlignment.MiddleLeft;
                iconButton.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }

        public static void SComboBox(Control control, ComboBoxStyle comboBoxStyle= ComboBoxStyle.DropDown)
        {
            foreach (var comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.ForeColor = STheme.SColor.TextFieldForColor;
                comboBox.BackColor = STheme.SColor.TextFieldBackgroundColor;
                comboBox.FlatStyle = FlatStyle.Standard;
                comboBox.DropDownStyle = comboBoxStyle;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }

        public static void SButton(Control control)
        {
            foreach (var button in control.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = STheme.SColor.ForColor;
                button.ForeColor = STheme.SColor.ForColor;
                button.BackColor = STheme.SColor.BackColor;
                button.Font = new Font(STheme.SFont.Font, STheme.SFont.Size + 2, FontStyle.Regular);
            }
        }

        public static void SDateTimePicker(Control control)
        {
            foreach (var dateTimePicker in control.Controls.OfType<DateTimePicker>())
            {
                dateTimePicker.CustomFormat = "dd-MMM-yyyy";
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.ForeColor = STheme.SColor.ForColor;
                dateTimePicker.BackColor = STheme.SColor.BackColor;
                dateTimePicker.Font = new Font(STheme.SFont.Font, STheme.SFont.Size, FontStyle.Regular);
                dateTimePicker.CalendarFont = new Font(STheme.SFont.Font, STheme.SFont.Size, FontStyle.Regular);
            }
        }

        public static void SDataGridView(Control control, DataGridViewCellBorderStyle cellBorderStyle= DataGridViewCellBorderStyle.None)
        {
            // DataGridView
            foreach (var gridView in control.Controls.OfType<DataGridView>())
            {
                gridView.BackgroundColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.BackColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.SelectionBackColor = STheme.SColor.ActiveBackColor;
                gridView.RowsDefaultCellStyle.SelectionForeColor = STheme.SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.BackColor = STheme.SColor.HoverBackColor;
                gridView.ColumnHeadersDefaultCellStyle.ForeColor = STheme.SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = STheme.SColor.HoverBackColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = STheme.SColor.ForColor;

                gridView.ColumnHeadersDefaultCellStyle.Font = new Font(STheme.SFont.Font, STheme.SFont.Size+2, FontStyle.Bold);
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
                gridView.CellBorderStyle = cellBorderStyle;
                gridView.RowTemplate.Resizable = DataGridViewTriState.False;
                gridView.RowTemplate.DividerHeight = 1;
                gridView.RowTemplate.Height = 25;
                gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

    }
}

