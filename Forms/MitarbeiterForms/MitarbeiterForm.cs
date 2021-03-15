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

namespace ProjektManagementSystem
{
    public partial class MitarbeiterForm : Form
    {
        DataContext dbContext;
        AddMitarbeiterForm addMitarbeiterForm;

        public MitarbeiterForm(DataContext dbcontext)
        {
            dbContext = dbcontext;
            InitializeComponent();
            loadMitarbeiterDataGrid();
        }


        private void loadMitarbeiterDataGrid()
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
                this.mitarbeiterDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.mitarbeiter.mitarbeiterId.ToString(),
                        i.mitarbeiter.vorname,
                        i.mitarbeiter.nachname,
                        i.mitarbeiter.abteilung,
                        i.mitarbeiter.arbeitspensum.ToString() + "%",
                        i.mitarbeiter.funktionsbeschreibung,
                    };
                    int indexNewRow = mitarbeiterDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }


        private void addMitarbeiterButton_Click(object sender, EventArgs e)
        {
            addMitarbeiterForm = new AddMitarbeiterForm(false);
            addMitarbeiterForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mitarbeiterForm_FormClosing);
            addMitarbeiterForm.ShowDialog();
        }

        private void mitarbeiterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addMitarbeiterForm.DialogResult == DialogResult.OK)
            {
                if (addMitarbeiterForm.getVornameTextBox().Text.Length > 2 && !addMitarbeiterForm.getVornameTextBox().Text.Equals("")
                    && addMitarbeiterForm.getAbteilungTextBox().Text.Length > 2 && !addMitarbeiterForm.getAbteilungTextBox().Text.Equals("")
                    && addMitarbeiterForm.getNachnameTextBox().Text.Length > 2 && !addMitarbeiterForm.getNachnameTextBox().Text.Equals("")
                    && addMitarbeiterForm.getFunktionsbeschreibungTextBox().Text.Length > 2 && !addMitarbeiterForm.getFunktionsbeschreibungTextBox().Text.Equals("")
                    && !addMitarbeiterForm.getArbeitspesnumTextBox().Text.Equals(""))
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Mitarbeiter> mitarbeiterTableDefinition = dbContext.GetTable<Mitarbeiter>();

                    //neuer Eintrag erstellen
                    string vorname = addMitarbeiterForm.getVornameTextBox().Text;
                    string nachname = addMitarbeiterForm.getNachnameTextBox().Text;
                    string abteilung = addMitarbeiterForm.getAbteilungTextBox().Text;
                    int arbeitspensum = Int32.Parse(addMitarbeiterForm.getArbeitspesnumTextBox().Text);
                    string funktionsbeschreibung = addMitarbeiterForm.getFunktionsbeschreibungTextBox().Text;

                    Mitarbeiter mitarbeiter = new Mitarbeiter();
                    mitarbeiter.vorname = vorname;
                    mitarbeiter.nachname = nachname;
                    mitarbeiter.abteilung = abteilung;
                    mitarbeiter.arbeitspensum = arbeitspensum;
                    mitarbeiter.funktionsbeschreibung = funktionsbeschreibung;

                    mitarbeiterTableDefinition.InsertOnSubmit(mitarbeiter);
                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadMitarbeiterDataGrid();
                }
            }
        }

        private void deleteMitarbeiterButton_Click(object sender, EventArgs e)
        {
            int mitarbeiterId;
            DataGridViewSelectedRowCollection selectedRow;
            if (mitarbeiterDataGrid.SelectedRows.Count == 1 && mitarbeiterDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = mitarbeiterDataGrid.SelectedRows;
                mitarbeiterId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Mitarbeiter> my_inhalt = dbContext.GetTable<Mitarbeiter>();

            //Abfrage
            var zu_loeschen =
                                from mitarbeiter in my_inhalt
                                where mitarbeiter.mitarbeiterId == mitarbeiterId
                                select mitarbeiter;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadMitarbeiterDataGrid();
        }

        private void editMitarbeiterButton_Click(object sender, EventArgs e)
        {
            int mitarbeiterId;
            DataGridViewSelectedRowCollection selectedRow;
            if (mitarbeiterDataGrid.SelectedRows.Count == 1 && mitarbeiterDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = mitarbeiterDataGrid.SelectedRows;
                mitarbeiterId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Mitarbeiter> mitarbeiterTableDefinition = dbContext.GetTable<Mitarbeiter>();

            //Abfrage
            var zu_mitarbeiter = from mitarbeiter in mitarbeiterTableDefinition
                                    where mitarbeiter.mitarbeiterId == mitarbeiterId
                                    select new
                                    {
                                        mitarbeiter
                                    };

            if (zu_mitarbeiter.Any())
            {
                Mitarbeiter mitarbeiter = zu_mitarbeiter.First().mitarbeiter;
                //open edit Dialog -> ein element editieren
                addMitarbeiterForm = new AddMitarbeiterForm(true);
                addMitarbeiterForm.getVornameTextBox().Text = mitarbeiter.vorname;
                addMitarbeiterForm.getNachnameTextBox().Text = mitarbeiter.nachname;
                addMitarbeiterForm.getArbeitspesnumTextBox().Text = mitarbeiter.arbeitspensum.ToString();
                addMitarbeiterForm.getAbteilungTextBox().Text = mitarbeiter.abteilung;
                addMitarbeiterForm.getFunktionsbeschreibungTextBox().Text = mitarbeiter.funktionsbeschreibung;

                addMitarbeiterForm.ShowDialog();

                if (addMitarbeiterForm.DialogResult == DialogResult.OK)
                {
                    mitarbeiter.vorname = addMitarbeiterForm.getVornameTextBox().Text;
                    mitarbeiter.nachname = addMitarbeiterForm.getNachnameTextBox().Text;
                    mitarbeiter.arbeitspensum = Int32.Parse(addMitarbeiterForm.getArbeitspesnumTextBox().Text);
                    mitarbeiter.abteilung = addMitarbeiterForm.getAbteilungTextBox().Text;
                    mitarbeiter.funktionsbeschreibung = addMitarbeiterForm.getFunktionsbeschreibungTextBox().Text;

                    dbContext.SubmitChanges();
                }
            }

            // datagrid neu befüllen
            loadMitarbeiterDataGrid();
        }
    }
}
