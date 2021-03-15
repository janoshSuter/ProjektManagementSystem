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
    public partial class ExterneKostenForm : Form
    {
        DataContext dbContext;
        AddExterneKostenForm addExterneKostenForm;
        int aktivitaetId;

        const string dateFormat = "dd.MM.yyyy";

        public ExterneKostenForm(DataContext dbcontext, int aktivitaetid)
        {
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            InitializeComponent();
            loadExterneKostenDataGrid();
        }

        private void loadExterneKostenDataGrid() { 
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<ExterneKosten> externeKostenTableDefinition = dbContext.GetTable<ExterneKosten>();
                Table<Kostenart> kostenartTableDefinition = dbContext.GetTable<Kostenart>();

                //Auswerten der typisierten Liste
                var eintraege = from externeKosten in externeKostenTableDefinition
                                join kostenart in kostenartTableDefinition on externeKosten.kostenartId equals kostenart.kostenartId
                                where externeKosten.aktivitaetId == aktivitaetId
                                select new
                                { // result selector 
                                    externeKosten,
                                    kostenart
                                };

                //Ausgabe
                this.externeKostenDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.externeKosten.externeKostenId.ToString(),
                        i.kostenart.bezeichnung,
                        i.externeKosten.geplannteKosten, 
                        i.externeKosten.effektiveKosten,
                        i.externeKosten.abweichungsbegruendung
                    };
                    externeKostenDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addExterneKostenButton_Click(object sender, EventArgs e)
        {
            addExterneKostenForm = new AddExterneKostenForm(dbContext, false, 0);
            addExterneKostenForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addExterneKostenForm_FormClosing);
            addExterneKostenForm.ShowDialog();

            loadExterneKostenDataGrid();
        }

        private void addExterneKostenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addExterneKostenForm.editMode && addExterneKostenForm.DialogResult == DialogResult.OK)
            {
                if (!addExterneKostenForm.AbweichungsgrundTextBox.Text.Equals("") &&
                    !addExterneKostenForm.KostenEffektivTextBox.Text.Equals("") &&
                    addExterneKostenForm.KostenGeplantTextBox.Text.Length >= 1 &&
                    addExterneKostenForm.KostenEffektivTextBox.Text.Length >= 1)
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<ExterneKosten> ressourceTableDefinition = dbContext.GetTable<ExterneKosten>();

                    //neuer Eintrag erstellen
                    string abweichungsgrund = addExterneKostenForm.AbweichungsgrundTextBox.Text;
                    decimal geplanteKosten = Decimal.Parse(addExterneKostenForm.KostenGeplantTextBox.Text);
                    decimal effektivKosten = Decimal.Parse(addExterneKostenForm.KostenEffektivTextBox.Text);
                    int kostenartId = ((KostenartComboboxItem) addExterneKostenForm.KostenartComboBox.SelectedItem).Value.kostenartId;

                    ExterneKosten exteneKosten = new ExterneKosten();
                    exteneKosten.abweichungsbegruendung = abweichungsgrund;
                    exteneKosten.geplannteKosten = geplanteKosten;
                    exteneKosten.effektiveKosten = effektivKosten;
                    exteneKosten.kostenartId = kostenartId;
                    exteneKosten.aktivitaetId = aktivitaetId;

                    ressourceTableDefinition.InsertOnSubmit(exteneKosten);

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadExterneKostenDataGrid();
                }
            }
        }

        private void externeKostenEditButton_Click(object sender, EventArgs e)
        {
            int externeKosteneId;
            DataGridViewSelectedRowCollection selectedRow;

            if (externeKostenDataGrid.SelectedRows.Count == 1 && externeKostenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = externeKostenDataGrid.SelectedRows;
                externeKosteneId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());

                //Connect auf Tabelle inkl. dem Mapping
                Table<ExterneKosten> externeKostenTableDefinition = dbContext.GetTable<ExterneKosten>();
                Table<Kostenart> kostenartTableDefinition = dbContext.GetTable<Kostenart>();

                //Abfrage
                var zu_ressource = from externeKosten in externeKostenTableDefinition
                                   where externeKosten.externeKostenId == externeKosteneId
                                   join kostenart in kostenartTableDefinition
                                   on externeKosten.kostenartId equals kostenart.kostenartId
                                   select new
                                    {
                                        externeKosten,
                                        kostenart
                                    };


                if (zu_ressource.Any())
                {
                    ExterneKosten externeKosten = zu_ressource.First().externeKosten;
                    Kostenart kostenart = zu_ressource.First().kostenart;
                    //open edit Dialog -> ein element editieren

                    addExterneKostenForm = new AddExterneKostenForm(dbContext, true, externeKosteneId);

                    addExterneKostenForm.AbweichungsgrundTextBox.Text = externeKosten.abweichungsbegruendung.ToString();
                    addExterneKostenForm.KostenGeplantTextBox.Text = externeKosten.geplannteKosten.ToString();
                    addExterneKostenForm.KostenEffektivTextBox.Text = externeKosten.effektiveKosten.ToString();
                    addExterneKostenForm.KostenartComboBox.SelectedIndex = addExterneKostenForm.KostenartComboBox.FindString(kostenart.bezeichnung);

                    addExterneKostenForm.ShowDialog();

                    if (addExterneKostenForm.DialogResult == DialogResult.OK)
                    {
                        externeKosten.abweichungsbegruendung = addExterneKostenForm.AbweichungsgrundTextBox.Text;
                        externeKosten.geplannteKosten = Decimal.Parse(addExterneKostenForm.KostenGeplantTextBox.Text);
                        externeKosten.effektiveKosten = Decimal.Parse(addExterneKostenForm.KostenEffektivTextBox.Text);
                        externeKosten.kostenartId = ((KostenartComboboxItem) addExterneKostenForm.KostenartComboBox.SelectedItem).Value.kostenartId;

                        //Aenderung auf DB auslösen
                        dbContext.SubmitChanges();
                    }
                }

                // datagrid neu befüllen
                loadExterneKostenDataGrid();
            }
        }

        private void deleteKostenButton_Click(object sender, EventArgs e)
        {
            int externeKostenId;
            DataGridViewSelectedRowCollection selectedRow;
            if (externeKostenDataGrid.SelectedRows.Count == 1 && externeKostenDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = externeKostenDataGrid.SelectedRows;
                externeKostenId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<ExterneKosten> my_inhalt = dbContext.GetTable<ExterneKosten>();

            //Abfrage
            var zu_loeschen =
                                from externeKosten in my_inhalt
                                where externeKosten.externeKostenId == externeKostenId
                                select externeKosten;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadExterneKostenDataGrid();
        }
    }
}
