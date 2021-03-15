using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektManagementSystem.ProjekteDetailsForm;

namespace ProjektManagementSystem.ExterneKostenForms
{
    public partial class AddExterneKostenForm : Form
    {
        DataContext dbContext;
        internal int aktivitaetId;
        public bool editMode;

        public AddExterneKostenForm(DataContext dbcontext, bool editmode, int aktivitaetid)
        {
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            editMode = editmode;
            InitializeComponent();
            loadKostenartToComboBox();
            KostenGeplantTextBox.Enabled = !editMode;
        }

        private void loadKostenartToComboBox()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Kostenart> kostenartTableDefinition = dbContext.GetTable<Kostenart>();

                //Auswerten der typisierten Liste
                var eintraege = from kostenart in kostenartTableDefinition
                                select new
                                { // result selector 
                                    kostenart
                                };

                //Ausgabe
                this.kostenartComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    KostenartComboboxItem item = new KostenartComboboxItem(i.kostenart);
                    kostenartComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        public TextBox AbweichungsgrundTextBox { get => abweichungsgrundTextBox; set => abweichungsgrundTextBox = value; }
        public TextBox KostenGeplantTextBox { get => kostenGeplantTextBox; set => kostenGeplantTextBox = value; }
        public TextBox KostenEffektivTextBox { get => kostenEffektivTextBox; set => kostenEffektivTextBox = value; }
        public ComboBox KostenartComboBox { get => kostenartComboBox; set => kostenartComboBox = value; }

    }
}
