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
    public partial class VorgehensmodelForm : Form
    {
        DataContext dbContext;
        AddVorgehensmodelForm addVorgehensmodelForm;

        public VorgehensmodelForm(DataContext dbcontext, string savePath)
        {
            dbContext = dbcontext;
            InitializeComponent();
            loadVorgehensmodelDataGrid();
        }

        private void loadVorgehensmodelDataGrid()
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
                this.vorgehensmodelDataGridView.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.vorgehensmodel.vorgehensmodelId.ToString(),
                        i.vorgehensmodel.name,
                        i.vorgehensmodel.beschreibung
                    };
                    int indexNewRow = vorgehensmodelDataGridView.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addVorgehensmodelButton_Click(object sender, EventArgs e)
        {
            addVorgehensmodelForm = new AddVorgehensmodelForm(dbContext, false);
            addVorgehensmodelForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vorgehensmodelForm_FormClosing);
            addVorgehensmodelForm.ShowDialog();
        }

        private void editVorgehensmodelButton_Click(object sender, EventArgs e)
        {
            int vorgehensmodelId;
            DataGridViewSelectedRowCollection selectedRow;
            if (vorgehensmodelDataGridView.SelectedRows.Count == 1 && vorgehensmodelDataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = vorgehensmodelDataGridView.SelectedRows;
                vorgehensmodelId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Vorgehensmodel> my_vorgehensmodel = dbContext.GetTable<Vorgehensmodel>();
            Table<Vorgehensmodel_Phase> my_vorgehensmodelPhase = dbContext.GetTable<Vorgehensmodel_Phase>();
            Table<Phase> my_phase = dbContext.GetTable<Phase>();

            //Abfrage
            var zu_vorgehensmodel = from vorgehensmodel in my_vorgehensmodel
                                    where vorgehensmodel.vorgehensmodelId == vorgehensmodelId
                                    select new
                               { 
                                   vorgehensmodel
                               };

            var zu_editieren = from phasen in my_phase
                               join vorgehensmodel_phase in my_vorgehensmodelPhase
                                    on phasen.phaseId equals vorgehensmodel_phase.phaseId
                                    into matchedVorgehensmodelPhase
                                    from vp in matchedVorgehensmodelPhase
                               join vorgehensmodel in my_vorgehensmodel
                                    on vp.vorgehensmodelId equals vorgehensmodel.vorgehensmodelId
                               where vorgehensmodel.vorgehensmodelId == vorgehensmodelId
                                select new
                                { // result selector 
                                    phasen
                                };

            if (zu_vorgehensmodel.Any()) {
                Vorgehensmodel vorgehensmodel = zu_vorgehensmodel.First().vorgehensmodel;
                //open edit Dialog -> ein element editieren
                addVorgehensmodelForm = new AddVorgehensmodelForm(dbContext, true);
                addVorgehensmodelForm.activeVorgehensmodelId = vorgehensmodel.vorgehensmodelId;
                addVorgehensmodelForm.TextBoxName.Text = vorgehensmodel.name;
                addVorgehensmodelForm.BeschreibungTextBox.Text = vorgehensmodel.beschreibung;

                addVorgehensmodelForm.Text = ""; 
                foreach (var phase in zu_editieren) 
                {
                    addVorgehensmodelForm.PhasenLabel.Text += "-" + phase.phasen.bezeichnung + "\n";
                }
                addVorgehensmodelForm.ShowDialog();

                if (addVorgehensmodelForm.DialogResult == DialogResult.OK)
                {
                    vorgehensmodel.name = addVorgehensmodelForm.TextBoxName.Text;
                    vorgehensmodel.beschreibung = addVorgehensmodelForm.BeschreibungTextBox.Text;

                    dbContext.SubmitChanges();
                }
            }

            // datagrid neu befüllen
            loadVorgehensmodelDataGrid();
        }

        private void vorgehensmodelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addVorgehensmodelForm.DialogResult == DialogResult.OK)
            {
                if (addVorgehensmodelForm.getNameTextBox().Text.Length > 1)
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Vorgehensmodel> vorgensmodelTableDefinition = dbContext.GetTable<Vorgehensmodel>();

                    //neuer Eintrag erstellen
                    string name = addVorgehensmodelForm.getNameTextBox().Text;
                    string beschreibung = addVorgehensmodelForm.getBeschreibungTextBox().Text;

                    Vorgehensmodel vorgehensmodel = new Vorgehensmodel();
                    vorgehensmodel.name = name;
                    vorgehensmodel.beschreibung = beschreibung;

                    vorgensmodelTableDefinition.InsertOnSubmit(vorgehensmodel);
                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadVorgehensmodelDataGrid();
                }
                else {
                    MessageBox.Show("Es wurden nicht alle Pflichtfelder ausgefüllt! (Diese sind mit * versehen)");
                }
            }
        }

        private void deleteVorgehensmodelButton_Click(object sender, EventArgs e)
        {
            int vorgehensmodelId;
            DataGridViewSelectedRowCollection selectedRow;
            if (vorgehensmodelDataGridView.SelectedRows.Count == 1 && vorgehensmodelDataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = vorgehensmodelDataGridView.SelectedRows;
                vorgehensmodelId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Vorgehensmodel> my_inhalt = dbContext.GetTable<Vorgehensmodel>();

            //Abfrage
            var zu_loeschen =
                                from vorgehensmodel in my_inhalt
                                where vorgehensmodel.vorgehensmodelId == vorgehensmodelId
                                select vorgehensmodel;

            //Delete on submit aufrufen -> ein element löschen
            Vorgehensmodel entity = zu_loeschen.First();
            dbContext.Refresh(System.Data.Linq.RefreshMode.KeepChanges, entity);
            my_inhalt.DeleteOnSubmit(entity);

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadVorgehensmodelDataGrid();
        }
    }
}
