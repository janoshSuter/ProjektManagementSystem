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

namespace ProjektManagementSystem.RessourceForms
{
    public partial class AddRessourceForm : Form
    {
        DataContext dbContext;
        internal int aktivitaetId;
        public bool editMode;

        public AddRessourceForm(DataContext dbcontext, bool editmode, int aktivitaetid)
        {
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            editMode = editmode;
            InitializeComponent();
            loadMitarbeiterToComboBox();
        }

        private void loadMitarbeiterToComboBox()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Mitarbeiter> my_mitarbeiter = dbContext.GetTable<Mitarbeiter>();

                //Auswerten der typisierten Liste
                var eintraege = from mitarbeiter in my_mitarbeiter
                                select new
                                { // result selector 
                                    mitarbeiter
                                };

                //Ausgabe
                this.mitarbeiterComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    MitarbeiterComboboxItem item = new MitarbeiterComboboxItem(i.mitarbeiter);
                    mitarbeiterComboBox.Items.Add(item);
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

        public TextBox PensumTextBox { get => pensumTextBox; set => pensumTextBox = value; }
        public TextBox FunktionTextBox { get => funktionTextBox; set => funktionTextBox = value; }
        public TextBox StundenGeplantTextBox { get => stundenGeplantTextBox; set => stundenGeplantTextBox = value; }
        public TextBox StundenEffektivTextBox { get => stundenEffektivTextBox; set => stundenEffektivTextBox = value; }
        public ComboBox MitarbeiterComboBox { get => mitarbeiterComboBox; set => mitarbeiterComboBox = value; }
    }
}
