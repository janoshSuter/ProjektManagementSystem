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

namespace ProjektManagementSystem.VorgehensmodelForms
{
    public partial class PhasenForm : Form
    {
        DataContext dbContext;
        AddPhaseForm addPhaseForm;
        int vorgehensmodelId;

        const string dateFormat = "dd.MM.yyyy";

        public PhasenForm(DataContext dbcontext, int vorgehensmodelid)
        {
            dbContext = dbcontext;
            vorgehensmodelId = vorgehensmodelid;
            InitializeComponent();
            loadPhasenDataGrid();

        }

        private void loadPhasenDataGrid() { 
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Phase> my_phase = dbContext.GetTable<Phase>();
                Table<Vorgehensmodel> my_joinVorgehensmodel = dbContext.GetTable<Vorgehensmodel>();
                Table<Vorgehensmodel_Phase> my_joinVorgehensmodelPhase = dbContext.GetTable<Vorgehensmodel_Phase>();

                //Auswerten der typisierten Liste
                var eintraege = from phasen in my_phase
                                join vorgehensmodel_phase in my_joinVorgehensmodelPhase on phasen.phaseId equals vorgehensmodel_phase.phaseId
                                join vorgehensmodel in my_joinVorgehensmodel on vorgehensmodel_phase.vorgehensmodelId equals vorgehensmodel.vorgehensmodelId
                                where vorgehensmodel.vorgehensmodelId == vorgehensmodelId
                                select new
                                { // result selector 
                                    phasen
                                };

                //Ausgabe
                this.phasenDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.phasen.phaseId.ToString(),
                        i.phasen.bezeichnung,
                        i.phasen.phasenfortschritt, i.phasen.phasenstatus,
                        i.phasen.startdatumGeplant.Date.ToString(dateFormat),
                        i.phasen.startdatumEffektiv.HasValue ? i.phasen.startdatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.phasen.enddatumGeplant.Date.ToString(dateFormat),
                        i.phasen.enddatumEffektiv.HasValue ? i.phasen.enddatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.phasen.reviewdatumGeplant.Date.ToString(dateFormat),
                        i.phasen.reviewdatumEffektiv.HasValue ? i.phasen.reviewdatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.phasen.freigabedatum.HasValue ? i.phasen.freigabedatum.Value.Date.ToString(dateFormat) : ""
                    };
                    phasenDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addPhaseButton_Click(object sender, EventArgs e)
        {
            addPhaseForm = new AddPhaseForm(dbContext, false, 0);
            addPhaseForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addPhasenForm_FormClosing);
            addPhaseForm.ShowDialog();

            loadPhasenDataGrid();
        }

        private void addPhasenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addPhaseForm.editMode && addPhaseForm.DialogResult == DialogResult.OK)
            {
                if (addPhaseForm.BezeichnungTextBox.Text.Length > 2 && !addPhaseForm.BezeichnungTextBox.Text.Equals("") &&
                    addPhaseForm.PhasenFortschrittTextBox.Text.Length >= 1 && !addPhaseForm.PhasenFortschrittTextBox.Text.Equals("") &&
                    addPhaseForm.StatusTextBox.Text.Length > 2 && !addPhaseForm.StatusTextBox.Text.Equals("") &&
                    addPhaseForm.StartdatumGeplantDatePicker.Text.Length > 2 && !addPhaseForm.StartdatumGeplantDatePicker.Text.Equals("") &&
                    addPhaseForm.EnddatumGeplantDatePicker.Text.Length > 2 && !addPhaseForm.EnddatumGeplantDatePicker.Text.Equals("") &&
                    addPhaseForm.ReviewdatumGeplantDatePicker.Text.Length > 2 && !addPhaseForm.ReviewdatumGeplantDatePicker.Text.Equals(""))
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Phase> phaseTableDefinition = dbContext.GetTable<Phase>();

                    //neuer Eintrag erstellen
                    string bezeichnung = addPhaseForm.BezeichnungTextBox.Text;
                    int fortschritt = Int32.Parse(addPhaseForm.PhasenFortschrittTextBox.Text);
                    string status = addPhaseForm.StatusTextBox.Text;
                    DateTime startdatumGeplant = addPhaseForm.StartdatumGeplantDatePicker.Value;
                    DateTime enddatumGeplant = addPhaseForm.EnddatumGeplantDatePicker.Value;
                    DateTime reviewdatumGeplant = addPhaseForm.ReviewdatumGeplantDatePicker.Value;

                    DateTime? freigabedatum = null;
                    if (addPhaseForm.FreigabedatumDatePicker.Enabled) {
                        freigabedatum = addPhaseForm.FreigabedatumDatePicker.Value;
                    }

                    DateTime? startdatumEffeftiv = null;
                    if (addPhaseForm.StartdatumEffektivDatePicker.Enabled)
                    {
                        startdatumEffeftiv = addPhaseForm.StartdatumEffektivDatePicker.Value;
                    }
                    DateTime? enddatumEffektiv = null;
                    if (addPhaseForm.EnddatumEffektivDatePicker.Enabled)
                    {
                        enddatumEffektiv = addPhaseForm.EnddatumEffektivDatePicker.Value;
                    }
                    DateTime? reviewdatumEffektiv = null;
                    if (addPhaseForm.ReviewdatumEffektivDatePicker.Enabled)
                    {
                        enddatumEffektiv = addPhaseForm.ReviewdatumEffektivDatePicker.Value;
                    }

                    Phase phase = new Phase();
                    phase.bezeichnung = bezeichnung;
                    phase.phasenfortschritt = fortschritt;
                    phase.phasenstatus = status;
                    phase.startdatumGeplant = startdatumGeplant;
                    phase.startdatumEffektiv = startdatumEffeftiv ?? null;
                    phase.enddatumGeplant = enddatumGeplant;
                    phase.enddatumEffektiv = enddatumEffektiv ?? null;
                    phase.reviewdatumGeplant = reviewdatumGeplant;
                    phase.reviewdatumEffektiv = reviewdatumEffektiv ?? null;
                    phase.freigabedatum = freigabedatum ?? null;

                    phaseTableDefinition.InsertOnSubmit(phase);

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    updateVorgehensmodelPhaseReference(phase.phaseId);

                    // datagrid neu befüllen
                    loadPhasenDataGrid();
                }
            }
        }

        private void updateVorgehensmodelPhaseReference(int phaseId)
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Vorgehensmodel_Phase> vorgehensmodelPhaseTableDefinition = dbContext.GetTable<Vorgehensmodel_Phase>();

                Vorgehensmodel_Phase vorgehensmodelPhase = new Vorgehensmodel_Phase();

                vorgehensmodelPhase.vorgehensmodelId = vorgehensmodelId;
                vorgehensmodelPhase.phaseId = phaseId;

                vorgehensmodelPhaseTableDefinition.InsertOnSubmit(vorgehensmodelPhase);
                //Aenderung auf DB auslösen
                dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
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

        private void phasenEditButton_Click(object sender, EventArgs e)
        {
            int phasenId;
            DataGridViewSelectedRowCollection selectedRow;

            if (phasenDataGrid.SelectedRows.Count == 1 && phasenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = phasenDataGrid.SelectedRows;
                phasenId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());

                //Connect auf Tabelle inkl. dem Mapping
                Table<Phase> phaseTableDefinition = dbContext.GetTable<Phase>();
                Table<Aktivitaet> aktivitaetTableDefinition = dbContext.GetTable<Aktivitaet>();

                //Abfrage
                var zu_phase = from phasen in phaseTableDefinition
                                    where phasen.phaseId == phasenId
                                    select new
                                    {
                                        phasen
                                    };

                var zu_phasenAktivitaeten = from aktivitaet in aktivitaetTableDefinition
                               where aktivitaet.phaseId == phasenId
                               select new
                               {
                                   aktivitaet
                               };


                if (zu_phase.Any())
                {
                    Phase phase = zu_phase.First().phasen;
                    //open edit Dialog -> ein element editieren

                    addPhaseForm = new AddPhaseForm(dbContext, true, phasenId);

                    addPhaseForm.phaseId = phase.phaseId;
                    addPhaseForm.BezeichnungTextBox.Text = phase.bezeichnung;
                    addPhaseForm.StatusTextBox.Text = phase.phasenstatus;
                    addPhaseForm.PhasenFortschrittTextBox.Text = phase.phasenfortschritt.ToString();
                    addPhaseForm.StartdatumGeplantDatePicker.Value = phase.startdatumGeplant;
                    addPhaseForm.EnddatumGeplantDatePicker.Value = phase.enddatumGeplant;
                    addPhaseForm.ReviewdatumGeplantDatePicker.Value = phase.reviewdatumGeplant;
                    if (phase.startdatumEffektiv != null)
                    {
                        setDefaultDatePicker(addPhaseForm.StartdatumEffektivDatePicker, phase.startdatumEffektiv);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(addPhaseForm.StartdatumEffektivDatePicker);
                    }

                    if (phase.enddatumEffektiv != null)
                    {
                        setDefaultDatePicker(addPhaseForm.EnddatumEffektivDatePicker, phase.enddatumEffektiv);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(addPhaseForm.EnddatumEffektivDatePicker);
                    }
                    
                    if (phase.reviewdatumEffektiv != null)
                    {
                        setDefaultDatePicker(addPhaseForm.ReviewdatumEffektivDatePicker, phase.reviewdatumEffektiv);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(addPhaseForm.ReviewdatumEffektivDatePicker);
                    }

                    addPhaseForm.Text = "Phase " + phase.bezeichnung + " bearbeiten";
                    addPhaseForm.AktivitaetLabel.Text = "";
                    foreach (var aktivitaet in zu_phasenAktivitaeten)
                    {
                        addPhaseForm.AktivitaetLabel.Text += "- " + aktivitaet.aktivitaet.beschreibung + "\n";
                    }
                    addPhaseForm.ShowDialog();

                    phase.bezeichnung = addPhaseForm.BezeichnungTextBox.Text;
                    phase.phasenfortschritt = Int32.Parse(addPhaseForm.PhasenFortschrittTextBox.Text);
                    phase.phasenstatus = addPhaseForm.StatusTextBox.Text;
                    phase.startdatumGeplant = addPhaseForm.StartdatumGeplantDatePicker.Value;
                    phase.enddatumGeplant = addPhaseForm.EnddatumGeplantDatePicker.Value;
                    phase.reviewdatumGeplant = addPhaseForm.ReviewdatumGeplantDatePicker.Value;
                    phase.startdatumEffektiv = addPhaseForm.StartdatumEffektivDatePicker.Value;
                    phase.enddatumEffektiv = addPhaseForm.EnddatumEffektivDatePicker.Value;
                    phase.reviewdatumEffektiv = addPhaseForm.ReviewdatumEffektivDatePicker.Value;

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();
                }

                // datagrid neu befüllen
                loadPhasenDataGrid();
            }
        }

        private void deletePhaseButton_Click(object sender, EventArgs e)
        {
            int phaseId;
            DataGridViewSelectedRowCollection selectedRow;
            if (phasenDataGrid.SelectedRows.Count == 1 && phasenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = phasenDataGrid.SelectedRows;
                phaseId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Phase> my_inhalt = dbContext.GetTable<Phase>();

            //Abfrage
            var zu_loeschen =
                                from phasen in my_inhalt
                                where phasen.phaseId == phaseId
                                select phasen;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadPhasenDataGrid();
        }

    }
}
