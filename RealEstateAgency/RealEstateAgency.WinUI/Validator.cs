using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public class Validator
    {
        public static string RequiredField = Properties.Resources.Validation_RequiredField;
        public static string MinLengthField = Properties.Resources.Validation_MinLengthField;

        public static bool SetErrorAndPreventSave(Control control, string value, ErrorProvider errorProvider, CancelEventArgs e)
        {
            errorProvider.SetError(control, value);
            if (e != null)
            {
                e.Cancel = true;
            }
            return false;
        }

        public static bool ValidateRequiredField(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return SetErrorAndPreventSave(textBox, RequiredField, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidateMinLength(ErrorProvider errorProvider, TextBox textBox, int minLength, CancelEventArgs e = null)
        {
            if (textBox.Text.Length < minLength)
            {
                return SetErrorAndPreventSave(textBox, MinLengthField + " " + minLength.ToString(), errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidatePhoneNumber(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (!Regex.IsMatch(textBox.Text, @"^[0-9]\d{2}-\d{3}-(\d{4}|\d{3})*$"))
            {
                return SetErrorAndPreventSave(textBox, Properties.Resources.Validation_PhoneNumber, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidateEmail(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (!Regex.IsMatch(textBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return SetErrorAndPreventSave(textBox, Properties.Resources.Validation_EmailField, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidateRequiredComboBox(ErrorProvider errorProvider, ComboBox comboBox, CancelEventArgs e = null)
        {
            if(comboBox.SelectedValue.ToString() == "0")
            {
                return SetErrorAndPreventSave(comboBox, Properties.Resources.Validation_RequiredField, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(comboBox, null);
                return true;
            }
        }

        public static bool ValidateGreaterThanZero(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            decimal result;
            if (decimal.TryParse(textBox.Text, out result))
            {
                if (result <= 0)
                {
                    SetErrorAndPreventSave(textBox, Properties.Resources.Validation_GreaterThanZero, errorProvider, e);
                }
                else
                {
                    errorProvider.SetError(textBox, null);
                    return true;
                }
            }
            else
            {
                SetErrorAndPreventSave(textBox, Properties.Resources.Validation_MustBeANumber, errorProvider, e);
                return false;
            }
            return false;
        }
    }
}