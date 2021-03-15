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
    public partial class RessourceForm : Form
    {
        DataContext dbContext;
        AddRessourceForm addRessourceForm;
        int aktivitaetId;

        const string dateFormat = "dd.MM.yyyy";

        public RessourceForm(DataContext dbcontext, int aktivitaetid)
        {
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            InitializeComponent();
            loadRessourcenDataGrid();
        }

        private void loadRessourcenDataGrid() { 
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Ressource> ressourceTableDefinition = dbContext.GetTable<Ressource>();
                Table<Mitarbeiter> mitarbeiterTableDefinition = dbContext.GetTable<Mitarbeiter>();

                //Auswerten der typisierten Liste
                var eintraege = from ressource in ressourceTableDefinition
                                join mitarbeiter in mitarbeiterTableDefinition on ressource.mitarbeiterRessourceid equals mitarbeiter.mitarbeiterId
                                where ressource.aktivitaetId == aktivitaetId
                                select new
                                { // result selector 
                                    ressource,
                                    mitarbeiter
                                };

                //Ausgabe
                this.phasenDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.ressource.ressourceId.ToString(),
                        i.mitarbeiter.vorname + " " + i.mitarbeiter.nachname,
                        i.ressource.pensum, 
                        i.ressource.funktion,
                        i.ressource.geplanteZeit.ToString(),
                        i.ressource.effektiveZeit.ToString()
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

        private void addRessourceButton_Click(object sender, EventArgs e)
        {
            addRessourceForm = new AddRessourceForm(dbContext, false, 0);
            addRessourceForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addRessourceForm_FormClosing);
            addRessourceForm.ShowDialog();

            loadRessourcenDataGrid();
        }

        private void addRessourceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addRessourceForm.editMode && addRessourceForm.DialogResult == DialogResult.OK)
            {
                if (!addRessourceForm.PensumTextBox.Text.Equals("") &&
                    addRessourceForm.FunktionTextBox.Text.Length >= 1 && 
                    !addRessourceForm.MitarbeiterComboBox.Text.Equals("") &&
                    addRessourceForm.StundenGeplantTextBox.Text.Length >= 1 &&
                    addRessourceForm.StundenEffektivTextBox.Text.Length >= 1)
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Ressource> ressourceTableDefinition = dbContext.GetTable<Ressource>();

                    //neuer Eintrag erstellen
                    int pensum = Int32.Parse(addRessourceForm.PensumTextBox.Text);
                    string funktion = addRessourceForm.FunktionTextBox.Text;
                    decimal geplanteZeit = Decimal.Parse(addRessourceForm.StundenGeplantTextBox.Text);
                    decimal effektivZeit = Decimal.Parse(addRessourceForm.StundenEffektivTextBox.Text);
                    int mitarbeiterId = ((MitarbeiterComboboxItem) addRessourceForm.MitarbeiterComboBox.SelectedItem).Value.mitarbeiterId;

                    Ressource ressource = new Ressource();
                    ressource.pensum = pensum;
                    ressource.funktion = funktion;
                    ressource.geplanteZeit = geplanteZeit;
                    ressource.effektiveZeit = effektivZeit;
                    ressource.mitarbeiterRessourceid = mitarbeiterId;
                    ressource.aktivitaetId = aktivitaetId;

                    ressourceTableDefinition.InsertOnSubmit(ressource);

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadRessourcenDataGrid();
                }
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

        private void ressourceEditButton_Click(object sender, EventArgs e)
        {
            int selectedRessourceId;
            DataGridViewSelectedRowCollection selectedRow;

            if (phasenDataGrid.SelectedRows.Count == 1 && phasenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = phasenDataGrid.SelectedRows;
                selectedRessourceId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());

                //Connect auf Tabelle inkl. dem Mapping
                Table<Ressource> ressourceTableDefinition = dbContext.GetTable<Ressource>();
                Table<Mitarbeiter> mitarbeiterTableDefinition = dbContext.GetTable<Mitarbeiter>();

                //Abfrage
                var zu_ressource = from ressource in ressourceTableDefinition
                                   where ressource.ressourceId == selectedRessourceId
                                   join mitarbeiter in mitarbeiterTableDefinition
                                   on ressource.mitarbeiterRessourceid equals mitarbeiter.mitarbeiterId
                                   select new
                                    {
                                        ressource,
                                        mitarbeiter
                                    };


                if (zu_ressource.Any())
                {
                    Ressource ressource = zu_ressource.First().ressource;
                    Mitarbeiter mitarbeiter = zu_ressource.First().mitarbeiter;
                    //open edit Dialog -> ein element editieren

                    addRessourceForm = new AddRessourceForm(dbContext, true, selectedRessourceId);

                    addRessourceForm.PensumTextBox.Text = ressource.pensum.ToString();
                    addRessourceForm.FunktionTextBox.Text = ressource.funktion.ToString();
                    addRessourceForm.StundenGeplantTextBox.Text = ressource.geplanteZeit.ToString();
                    addRessourceForm.StundenEffektivTextBox.Text = ressource.effektiveZeit.ToString();
                    addRessourceForm.MitarbeiterComboBox.SelectedIndex = addRessourceForm.MitarbeiterComboBox.FindString(mitarbeiter.vorname + " " + mitarbeiter.nachname);

                    addRessourceForm.ShowDialog();

                    if (addRessourceForm.DialogResult == DialogResult.OK)
                    {
                        ressource.pensum = Int32.Parse(addRessourceForm.PensumTextBox.Text);
                        ressource.funktion = addRessourceForm.FunktionTextBox.Text;
                        ressource.geplanteZeit = Decimal.Parse(addRessourceForm.StundenGeplantTextBox.Text);
                        ressource.effektiveZeit = Decimal.Parse(addRessourceForm.StundenEffektivTextBox.Text);
                        ressource.mitarbeiterRessourceid = ((MitarbeiterComboboxItem) addRessourceForm.MitarbeiterComboBox.SelectedItem).Value.mitarbeiterId;

                        //Aenderung auf DB auslösen
                        dbContext.SubmitChanges();
                    }
                }

                // datagrid neu befüllen
                loadRessourcenDataGrid();
            }
        }

        private void deletePhaseButton_Click(object sender, EventArgs e)
        {
            int reccourceId;
            DataGridViewSelectedRowCollection selectedRow;
            if (phasenDataGrid.SelectedRows.Count == 1 && phasenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = phasenDataGrid.SelectedRows;
                reccourceId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Ressource> my_inhalt = dbContext.GetTable<Ressource>();

            //Abfrage
            var zu_loeschen =
                                from ressource in my_inhalt
                                where ressource.ressourceId == reccourceId
                                select ressource;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadRessourcenDataGrid();
        }

    }
}
