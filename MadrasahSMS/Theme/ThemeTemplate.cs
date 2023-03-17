using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MadrasahSMS.Theme
{
    public class ThemeTemplate
    {
        public static void LoadTheme(Control control)
        {
            SLabel(control);
            SLinkLabel(control);
            SRichTextBox(control);
            STextBox(control);
            SNumericUpDown(control);
            SComboBox(control);
            SButton(control);
            SIconButton(control);
            SDateTimePicker(control);
            SDataGridView(control);
            STabControl(control);
            SPictureBox(control);
        }

        public static bool SValidate(Control control, ErrorProvider errorProvider)
        {
            var valid = true;
            //errorProvider = new ErrorProvider {BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError};
            errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            // TextBox Validate
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

            // ComboBox Validate
            foreach (var comboBox in control.Controls.OfType<ComboBox>())
            {
                if (comboBox.CausesValidation)
                {
                    errorProvider.SetError(comboBox, string.Empty);

                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        errorProvider.SetError(comboBox, "This field is required");
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
                linkLabel.ForeColor = STheme.SColor.LinkForColor;
                linkLabel.BackColor = STheme.SColor.BackColor;
                linkLabel.Font = new Font(STheme.SFont.Font, linkLabel.Font.Size - 2 <= 0 ? linkLabel.Font.Size : linkLabel.Font.Size - 2);
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
        }

        public static void SNumericUpDown(Control control)
        {
            foreach (var numericUpDown in control.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.BorderStyle = BorderStyle.FixedSingle;
                numericUpDown.ForeColor = STheme.SColor.TextFieldForColor;
                numericUpDown.BackColor = STheme.SColor.TextFieldBackgroundColor;
                numericUpDown.Font= new Font(STheme.SFont.Font, STheme.SFont.Size);
            }
        }

        public static void SComboBox(Control control, ComboBoxStyle comboBoxStyle= ComboBoxStyle.DropDownList)
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
        
        public static void SIconButton(Control control, int borderSize=1)
        {
            foreach (var button in control.Controls.OfType<IconButton>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = borderSize;
                button.FlatAppearance.BorderColor = STheme.SColor.ForColor;
                button.ForeColor = STheme.SColor.ForColor;
                button.BackColor = STheme.SColor.BackColor;
                button.IconColor = STheme.SColor.ForColor;
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

        public static void SDataGridView(Control control, BorderStyle borderStyle = BorderStyle.None, bool doubleHeader=false)
        {
            // DataGridView
            foreach (var gridView in control.Controls.OfType<DataGridView>())
            {
                var dividerHeight = borderStyle == BorderStyle.None ? 0 : 1;
                var cellBorder = borderStyle==BorderStyle.None ? DataGridViewCellBorderStyle.Single : DataGridViewCellBorderStyle.None;

                //var borderStyle = cellBorderStyle == DataGridViewCellBorderStyle.None ? BorderStyle.FixedSingle : BorderStyle.None;

                gridView.BackgroundColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.BackColor = STheme.SColor.BackColor;
                gridView.RowsDefaultCellStyle.SelectionBackColor = STheme.SColor.ActiveBackColor;
                gridView.RowsDefaultCellStyle.SelectionForeColor = STheme.SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.BackColor = STheme.SColor.HoverBackColor;
                gridView.ColumnHeadersDefaultCellStyle.ForeColor = STheme.SColor.ActiveForColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = STheme.SColor.HoverBackColor;
                gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = STheme.SColor.ForColor;

                gridView.BorderStyle = borderStyle;

                gridView.ColumnHeadersDefaultCellStyle.Font = new Font(STheme.SFont.Font, STheme.SFont.Size+2, FontStyle.Bold);
                gridView.RowsDefaultCellStyle.Font = new Font(STheme.SFont.Font,STheme.SFont.Size);

                gridView.AutoGenerateColumns = false;
                gridView.AllowUserToAddRows = false;
                gridView.AllowUserToDeleteRows = false;
                gridView.ShowEditingIcon = false;
                gridView.EnableHeadersVisualStyles = false;
                gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridView.MultiSelect = false;
                gridView.RowHeadersVisible = false;
                gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridView.ColumnHeadersHeight = doubleHeader ? 43 : 30;
                gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                gridView.CellBorderStyle = cellBorder;
                gridView.RowTemplate.Resizable = DataGridViewTriState.False;
                gridView.RowTemplate.DividerHeight = dividerHeight;
                gridView.RowTemplate.Height = 25;

            }
        }

        public static void STabControl(Control control)
        {
            foreach (var tabControl in control.Controls.OfType<TabControl>())
            {
                var itemSize = tabControl.ItemSize;
                itemSize.Height = 30;
                tabControl.ItemSize = itemSize;
                tabControl.BackColor = Color.White;
                tabControl.Font = new Font(STheme.SFont.Font, STheme.SFont.Size, FontStyle.Regular);
                
            }
        }

        public static void SPictureBox(Control control, BorderStyle borderStyle=BorderStyle.FixedSingle)
        {
            foreach (var pictureBox in control.Controls.OfType<PictureBox>())
            {
                pictureBox.BorderStyle = borderStyle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

