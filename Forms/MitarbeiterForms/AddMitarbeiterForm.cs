using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektManagementSystem
{
    public partial class AddMitarbeiterForm : Form
    {
        public AddMitarbeiterForm(bool v)
        {
            InitializeComponent();
        }

        public TextBox getVornameTextBox()
        {
            return VornameTextBox;
        }        
        
        public TextBox getNachnameTextBox()
        {
            return nachnameTextBox;
        }        
        
        public TextBox getAbteilungTextBox()
        {
            return abteilungTextBox;
        }        
        public TextBox getArbeitspesnumTextBox()
        {
            return arbeitspensumTextBox;
        }        
        
        public TextBox getFunktionsbeschreibungTextBox()
        {
            return funktionsbeschreibungTextBox;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
