using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public class Validator
    {
        public static string RequiredField = Properties.Resources.Validation_RequiredField;
        public static string MinLengthField = Properties.Resources.Validation_MinLengthField;

        public static bool ValidateRequiredField(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, RequiredField);
                if (e != null)
                {
                    e.Cancel = true;
                }
                return false;
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
                errorProvider.SetError(textBox, MinLengthField + " " + minLength.ToString());
                if (e != null)
                {
                    e.Cancel = true;
                }
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidatePhoneNumber(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (!Regex.IsMatch(textBox.Text, @"/^[+] *[(]{ 0,1}[0 - 9]{ 1,4}[)]{ 0,1}[-\s\./ 0 - 9]*$/g"))
            {
                errorProvider.SetError(textBox, Properties.Resources.Validation_PhoneNumber);
                if (e != null)
                {
                    e.Cancel = true;
                }
                return false;
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
                errorProvider.SetError(textBox, Properties.Resources.Validation_EmailField);
                if (e != null)
                {
                    e.Cancel = true;
                }
                return false;
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }
    }
}