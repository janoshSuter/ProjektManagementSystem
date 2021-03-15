using ProjektManagementSystem.DokumenteForms;
using ProjektManagementSystem.ProjekteForms;
using System;
//zusätzlicher Namespace
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ProjektManagementSystem
{
    public partial class ProjekteDetailsForm : Form
    {
        DataContext dbContext;
        internal int projektId;
        DokumenteForm dokumenteForm;

        public ProjekteDetailsForm(DataContext dbcontext, int projektid)
        {
            dbContext = dbcontext;
            this.projektId = projektid;
            InitializeComponent();
            loadVorgehensmodeleToComboBox();
            loadMitarbeiterToComboBox();
        }

        public TextBox ProjektTitelTextBox { get => projektTitelTextBox; set => projektTitelTextBox = value; }
        public TextBox BeschreibungTextBox { get => beschreibungTextBox; set => beschreibungTextBox = value; }
        public TextBox StatusTextBox { get => statusTextBox; set => statusTextBox = value; }
        public TextBox PrioTextBox { get => prioTextBox; set => prioTextBox = value; }
        public TextBox FortschrittTextBox { get => fortschrittTextBox; set => fortschrittTextBox = value; }
        public DateTimePicker BewilligunsDatePicker { get => bewilligungsDatePicker; set => bewilligungsDatePicker = value; }
        public DateTimePicker EnddatumGeplantDatePicker { get => endDatumGeplantDatePicker; set => endDatumGeplantDatePicker = value; }
        public DateTimePicker EnddatumEffektivDatePicker { get => endDatumEffektivDatePicker; set => endDatumEffektivDatePicker = value; }
        public DateTimePicker StartdatumEffektivDatePicker { get => startdatumEffektivDatePicker; set => startdatumEffektivDatePicker = value; }
        public ComboBox VorgehensmodelComboBox { get => vorgehensmodelComboBox; set => vorgehensmodelComboBox = value; }
        public ComboBox ProjektleiterComboBox { get => projektleiterComboBox; set => projektleiterComboBox = value; }
        public DateTimePicker StartdatumGeplantDatePicker { get => startdatumGeplantDatePicker; set => startdatumGeplantDatePicker = value; }

        private void activateStartEffektivDatePicker_Click(object sender, EventArgs e)
        {
            StartdatumEffektivDatePicker.Enabled = true;
            StartdatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            StartdatumEffektivDatePicker.Value = DateTime.Now;
        }

        private void activateEndEffektiveDatePicker_Click(object sender, EventArgs e)
        {
            EnddatumEffektivDatePicker.Enabled = true;
            EnddatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            EnddatumEffektivDatePicker.Value = DateTime.Now;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void loadVorgehensmodeleToComboBox()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Vorgehensmodel> my_vorgehensmodel = dbContext.GetTable<Vorgehensmodel>();

                //Auswerten der typisierten Liste
                var eintraege = from vorgehensmodel in my_vorgehensmodel
                                select new
                                { // result selector 
                                    vorgehensmodel
                                };

                //Ausgabe
                this.vorgehensmodelComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    VorgehensmodelComboboxItem item = new VorgehensmodelComboboxItem(i.vorgehensmodel);
                    vorgehensmodelComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
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
                this.projektleiterComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    MitarbeiterComboboxItem item = new MitarbeiterComboboxItem(i.mitarbeiter);
                    projektleiterComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void projektleiterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = (projektleiterComboBox.SelectedItem as MitarbeiterComboboxItem).Value;
        }

        private void vorgehensmodelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vorgehensmodel model = (vorgehensmodelComboBox.SelectedItem as VorgehensmodelComboboxItem).Value;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dokumenteForm = new DokumenteForm(dbContext, -1, -1, projektId, -1);
            dokumenteForm.ShowDialog();
        }
    }
}
