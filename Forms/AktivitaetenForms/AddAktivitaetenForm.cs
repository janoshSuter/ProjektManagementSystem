using ProjektManagementSystem.DokumenteForms;
using ProjektManagementSystem.ExterneKostenForms;
using ProjektManagementSystem.RessourceForms;
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

namespace ProjektManagementSystem.VorgehensmodelForms
{
    public partial class AddAktivitaetenForm : Form
    {
        DokumenteForm dokumenteForm;
        RessourceForm ressourcesForm;
        ExterneKostenForm externeKostenForm;
        DataContext dbContext;
        Boolean editMode;
        internal int aktvitaetId;
        private string savePath;

        public AddAktivitaetenForm(DataContext dbcontext, Boolean editmode, string usersavepath, int aktvitaetid)
        {
            InitializeComponent();
            dbContext = dbcontext;
            editMode = editmode;
            aktvitaetId = aktvitaetid;
            savePath = usersavepath;
            loadMitarbeiterToComboBox();
            updateUi();
        }

        private void updateUi()
        {
            ressourceEditButton.Visible = editMode;
            kostenEditButton.Visible = editMode;
            linkLabel1.Visible = editMode;
            EnddatumGeplantDatePicker.Enabled = !editMode;
            StartdatumGeplantDatePicker.Enabled = !editMode;
            ressourcenLabelUpdate();
            externeKostenLabelUpdate();
        }

        private void ressourcenLabelUpdate()
        {
            Table<Ressource> resourceTableDefinition = dbContext.GetTable<Ressource>();
            var zu_phasenRessourcen = from ressource in resourceTableDefinition
                                        where ressource.aktivitaetId == aktvitaetId
                                        select new
                                        {
                                            ressource
                                        };

            ressourcenLabel.Text = "";
            foreach (var ressource in zu_phasenRessourcen)
            {
                ressourcenLabel.Text += "- " + ressource.ressource.funktion + "\n";
            }
        }

        private void externeKostenLabelUpdate()
        {
            Table<ExterneKosten> externeKostenTableDefinition = dbContext.GetTable<ExterneKosten>();
            var zu_phasenExterneKosten = from externeKosten in externeKostenTableDefinition
                                       where externeKosten.aktivitaetId == aktvitaetId
                                       select new
                                       {
                                           externeKosten
                                       };

            externeKostenLabel.Text = "";
            foreach (var externeKosten in zu_phasenExterneKosten)
            {
                externeKostenLabel.Text += "- " + externeKosten.externeKosten.geplannteKosten.ToString() + ".-\n";
            }
        }

        public TextBox BeschreibungTextBox { get => beschreibungTextBox; set => beschreibungTextBox = value; }
        public TextBox FortschrittTextBox { get => fortschrittTextBox; set => fortschrittTextBox = value; }
        public TextBox BudgetTextBox { get => budgetTextBox; set => budgetTextBox = value; }
        public DateTimePicker StartdatumGeplantDatePicker { get => startdatumGeplantDatePicker; set => startdatumGeplantDatePicker = value; }
        public DateTimePicker StartdatumEffektivDatePicker { get => startdatumEffektivDatePicker; set => startdatumEffektivDatePicker = value; }
        public DateTimePicker EnddatumEffektivDatePicker { get => enddatumEffektivDatePicker; set => enddatumEffektivDatePicker = value; }
        public DateTimePicker EnddatumGeplantDatePicker { get => enddatumGeplantDatePicker; set => enddatumGeplantDatePicker = value; }
        public ComboBox VerantwortlicherComboBox { get => verantwortlicherComboBox; set => verantwortlicherComboBox = value; }

        private void activateStartEffektivDatePicker_Click(object sender, EventArgs e)
        {
            startdatumEffektivDatePicker.Enabled = true;
            startdatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            startdatumEffektivDatePicker.Value = DateTime.Now;

        }
        private void activateEndEffektiveDatePicker_Click(object sender, EventArgs e)
        {
            enddatumEffektivDatePicker.Enabled = true;
            enddatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            enddatumEffektivDatePicker.Value = DateTime.Now;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                this.VerantwortlicherComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    MitarbeiterComboboxItem item = new MitarbeiterComboboxItem(i.mitarbeiter);
                    VerantwortlicherComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void verantwortlicherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = (VerantwortlicherComboBox.SelectedItem as MitarbeiterComboboxItem).Value;
        }

        private void ressourcenBearbeitenButton_Click(object sender, EventArgs e)
        {
            ressourcesForm = new RessourceForm(dbContext, aktvitaetId);
            ressourcesForm.ShowDialog();

            updateUi();
        }
        
        private void externeKostenBearbeitenButton_Click(object sender, EventArgs e)
        {
            externeKostenForm = new ExterneKostenForm(dbContext, aktvitaetId);
            externeKostenForm.ShowDialog();

            updateUi();
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
            dokumenteForm = new DokumenteForm(dbContext, savePath, aktvitaetId, -1, -1, -1);
            dokumenteForm.ShowDialog();

            updateUi();
        }
    }
}
