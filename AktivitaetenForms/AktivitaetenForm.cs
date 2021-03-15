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
    public partial class AktivitaetenForm : Form
    {

        AddAktivitaetenForm addAktivitaetenForm;
        DataContext dbContext;
        int phaseId;

        const string dateFormat = "dd.MM.yyyy";

        public AktivitaetenForm(DataContext dbcontext, int phaseid)
        {
            phaseId = phaseid;
            dbContext = dbcontext;
            InitializeComponent();
            loadAktivitaetenDataGrid();
        }

        private void loadAktivitaetenDataGrid()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Aktivitaet> my_aktivitaet = dbContext.GetTable<Aktivitaet>();
                Table<Phase> my_joinPhase = dbContext.GetTable<Phase>();

                //Auswerten der typisierten Liste
                var eintraege = from aktivitaet in my_aktivitaet
                                join phase in my_joinPhase on aktivitaet.phaseId equals phase.phaseId
                                where phase.phaseId == phaseId
                                select new
                                { // result selector 
                                    aktivitaet
                                };

                //Ausgabe
                this.aktivitaetenDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    Mitarbeiter verantwortlicherMitarbeiter = loadMitarbeiter(i.aktivitaet.verantwortlicherMitarbeiterId);

                    object[] newRow = {
                        i.aktivitaet.aktivitaetId.ToString(),
                        verantwortlicherMitarbeiter.vorname + " " + verantwortlicherMitarbeiter.nachname,
                        i.aktivitaet.beschreibung,
                        i.aktivitaet.startdatumGeplant.Date.ToString(dateFormat),
                        i.aktivitaet.startdatumEffektiv.HasValue ? i.aktivitaet.startdatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.aktivitaet.enddatumGeplant.Date.ToString(dateFormat),
                        i.aktivitaet.enddatumEffektiv.HasValue ? i.aktivitaet.enddatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.aktivitaet.budget, 
                        i.aktivitaet.fortschritt,

                    };
                    aktivitaetenDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private Mitarbeiter loadMitarbeiter(int verantwortlicherMitarbeiterId)
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Mitarbeiter> my_mitarbeiter = dbContext.GetTable<Mitarbeiter>();

                //Auswerten der typisierten Liste
                var eintraege = from mitarbeiter in my_mitarbeiter
                                where mitarbeiter.mitarbeiterId == verantwortlicherMitarbeiterId
                                select new
                                { // result selector 
                                    mitarbeiter
                                };

                if (eintraege.Any()) {
                    return eintraege.FirstOrDefault().mitarbeiter;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addAktivitaetenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addAktivitaetenForm.DialogResult == DialogResult.OK)
            {
                if (addAktivitaetenForm.BeschreibungTextBox.Text.Length > 2 && !addAktivitaetenForm.BeschreibungTextBox.Text.Equals("")
                    && addAktivitaetenForm.StartdatumGeplantDatePicker.Text.Length > 2 && !addAktivitaetenForm.StartdatumGeplantDatePicker.Text.Equals("")
                    && addAktivitaetenForm.EnddatumGeplantDatePicker.Text.Length > 2 && !addAktivitaetenForm.EnddatumGeplantDatePicker.Text.Equals("")
                    && addAktivitaetenForm.VerantwortlicherComboBox.Text.Length > 2 && !addAktivitaetenForm.VerantwortlicherComboBox.Text.Equals(""))
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Aktivitaet> aktivitaetTableDefinition = dbContext.GetTable<Aktivitaet>();

                    //neuer Eintrag erstellen
                    string beschreibung = addAktivitaetenForm.BeschreibungTextBox.Text;
                    int fortschritt = Int32.Parse(addAktivitaetenForm.FortschrittTextBox.Text);
                    int budget = Int32.Parse(addAktivitaetenForm.BudgetTextBox.Text);
                    int mitarbeiterid = (addAktivitaetenForm.VerantwortlicherComboBox.SelectedItem as MitarbeiterComboboxItem).Value.mitarbeiterId;
                    DateTime startdatumGeplant = addAktivitaetenForm.StartdatumGeplantDatePicker.Value;
                    DateTime? startdatumEffektiv = addAktivitaetenForm.StartdatumEffektivDatePicker.Value;
                    DateTime enddatumGeplant = addAktivitaetenForm.EnddatumGeplantDatePicker.Value;
                    DateTime? enddatumEffektiv = addAktivitaetenForm.EnddatumEffektivDatePicker.Value;

                    Aktivitaet aktivitaet = new Aktivitaet();
                    aktivitaet.phaseId = phaseId;
                    aktivitaet.verantwortlicherMitarbeiterId = mitarbeiterid;
                    aktivitaet.beschreibung = beschreibung;
                    aktivitaet.fortschritt = fortschritt;
                    aktivitaet.budget = budget;
                    aktivitaet.startdatumGeplant = startdatumGeplant;
                    aktivitaet.startdatumEffektiv = startdatumEffektiv;
                    aktivitaet.enddatumGeplant = startdatumGeplant;
                    aktivitaet.enddatumEffektiv = startdatumEffektiv;

                    aktivitaetTableDefinition.InsertOnSubmit(aktivitaet);
                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    loadAktivitaetenDataGrid();
                }
            }
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            addAktivitaetenForm = new AddAktivitaetenForm(dbContext, false, -1);
            addAktivitaetenForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addAktivitaetenForm_FormClosing);
            addAktivitaetenForm.ShowDialog();
        }

        private void editActivityButton_Click(object sender, EventArgs e)
        {
            int aktvitaetId;
            DataGridViewSelectedRowCollection selectedRow;

            if (aktivitaetenDataGrid.SelectedRows.Count == 1 && aktivitaetenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = aktivitaetenDataGrid.SelectedRows;
                aktvitaetId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());

                Table<Aktivitaet> aktivitaetTableDefinition = dbContext.GetTable<Aktivitaet>();
                Table<Mitarbeiter> mitarbeiterTableDefinition = dbContext.GetTable<Mitarbeiter>();

                //Abfrage
                var zu_aktivitaet = from aktivitaet in aktivitaetTableDefinition
                                   where aktivitaet.aktivitaetId == aktvitaetId
                                   join mitarbeiter in mitarbeiterTableDefinition 
                                   on aktivitaet.verantwortlicherMitarbeiterId equals mitarbeiter.mitarbeiterId
                                   select new
                                   {
                                       aktivitaet,
                                       mitarbeiter
                                   };

                if (zu_aktivitaet.Any())
                {
                    Aktivitaet aktivitaet = zu_aktivitaet.First().aktivitaet;
                    Mitarbeiter mitarbeiter = zu_aktivitaet.First().mitarbeiter;
                    //open edit Dialog -> ein element editieren

                    addAktivitaetenForm = new AddAktivitaetenForm(dbContext, true, aktvitaetId);
                    addAktivitaetenForm.aktvitaetId = aktvitaetId;
                    
                    addAktivitaetenForm.aktvitaetId = aktivitaet.aktivitaetId;
                    addAktivitaetenForm.BeschreibungTextBox.Text = aktivitaet.beschreibung;
                    addAktivitaetenForm.FortschrittTextBox.Text = aktivitaet.fortschritt.ToString();
                    addAktivitaetenForm.BudgetTextBox.Text = aktivitaet.budget.ToString();
                    addAktivitaetenForm.StartdatumGeplantDatePicker.Value = aktivitaet.startdatumGeplant;
                    addAktivitaetenForm.EnddatumGeplantDatePicker.Value = aktivitaet.enddatumGeplant;
                    addAktivitaetenForm.VerantwortlicherComboBox.SelectedIndex = 
                        addAktivitaetenForm.VerantwortlicherComboBox.FindString(mitarbeiter.vorname + " " + mitarbeiter.nachname);
                    if (aktivitaet.startdatumEffektiv != null)
                    {
                        setDefaultDatePicker(addAktivitaetenForm.StartdatumEffektivDatePicker, aktivitaet.startdatumEffektiv);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(addAktivitaetenForm.StartdatumEffektivDatePicker);
                    }

                    if (aktivitaet.enddatumEffektiv != null)
                    {
                        setDefaultDatePicker(addAktivitaetenForm.EnddatumEffektivDatePicker, aktivitaet.enddatumEffektiv);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(addAktivitaetenForm.EnddatumEffektivDatePicker);
                    }

                    addAktivitaetenForm.Text = "Aktivitaet " + aktivitaet.aktivitaetId + " bearbeiten";
                    addAktivitaetenForm.ShowDialog();

                    aktivitaet.beschreibung = addAktivitaetenForm.BeschreibungTextBox.Text;
                    aktivitaet.fortschritt = Int32.Parse(addAktivitaetenForm.FortschrittTextBox.Text);
                    aktivitaet.budget = Int32.Parse(addAktivitaetenForm.BudgetTextBox.Text);
                    aktivitaet.startdatumGeplant = addAktivitaetenForm.StartdatumGeplantDatePicker.Value;
                    aktivitaet.enddatumGeplant = addAktivitaetenForm.EnddatumGeplantDatePicker.Value;
                    aktivitaet.startdatumEffektiv = addAktivitaetenForm.StartdatumEffektivDatePicker.Value;
                    aktivitaet.enddatumEffektiv = addAktivitaetenForm.EnddatumEffektivDatePicker.Value;

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();
                }

                // datagrid neu befüllen
                loadAktivitaetenDataGrid();
            }
        }

        private void setEmptyCustomDatePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Enabled = false;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " ";
        }

        private void setDefaultDatePicker(DateTimePicker dateTimePicker, DateTime? dateEffektiv)
        {
            dateTimePicker.Enabled = true;
            dateTimePicker.Value = dateEffektiv.Value;
        }

        private void deleteActivityButton_Click(object sender, EventArgs e)
        {
            int aktivitaetId;
            DataGridViewSelectedRowCollection selectedRow;
            if (aktivitaetenDataGrid.SelectedRows.Count == 1 && aktivitaetenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = aktivitaetenDataGrid.SelectedRows;
                aktivitaetId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Aktivitaet> my_inhalt = dbContext.GetTable<Aktivitaet>();

            //Abfrage
            var zu_loeschen =
                                from aktivitaet in my_inhalt
                                where aktivitaet.aktivitaetId == aktivitaetId
                                select aktivitaet;

            //Delete on submit aufrufen -> ein element löschen
            Aktivitaet entity = zu_loeschen.First();
            dbContext.Refresh(System.Data.Linq.RefreshMode.KeepChanges, entity);
            my_inhalt.DeleteOnSubmit(entity);

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadAktivitaetenDataGrid();
        }
    }
}
