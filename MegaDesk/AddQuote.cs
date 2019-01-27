using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void textWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(textWidth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textWidth.Select(0, textWidth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textWidth, errorMsg);
            }
        }

        private void textWidth_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textWidth, "");
        }

        private bool ValidWidth(string width, out string errorMessage)
        {
            // Confirm that the email address string is not empty.

            int parsedWidth;
            if (!int.TryParse(width, out parsedWidth))
            {
                errorMessage = "Please enter a number.";
                return false;
            }

            if (parsedWidth < 24 || parsedWidth > 96)
            {
                errorMessage = "The width should be from 24 to 96.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(textDepth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textDepth.Select(0, textDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textDepth, errorMsg);
            }
        }

        private bool ValidDepth(string depth, out string errorMessage)
        {
            // Confirm that the email address string is not empty.

            int parsedDepth;
            if (!int.TryParse(depth, out parsedDepth))
            {
                errorMessage = "Please enter a number.";
                return false;
            }

            if (parsedDepth < 24 || parsedDepth > 96)
            {
                errorMessage = "The depth should be from 12 to 48.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void textDepth_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textDepth, "");
        }
    }
}
