using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektManagementSystem.ProjekteDetailsForm;

namespace ProjektManagementSystem.DokumenteForms
{
    public partial class DokumenteForm : Form
    {
        DataContext dbContext;
        AddDokumenteForm addDokumenteForm;
        int aktivitaetId;
        int phaseId;
        int projektId;
        int meilensteinId;
        private string savePath;

        public DokumenteForm(DataContext dbcontext, string usersavepath, int aktivitaetid, int phaseid, int projektid, int meilensteinid)
        {
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            phaseId = phaseid;
            projektId = projektid;
            meilensteinId = meilensteinid;
            savePath = usersavepath;
            InitializeComponent();
            loadDokumenteDataGrid();
        }

        private void loadDokumenteDataGrid() { 
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Dokument> dokumenteTableDefinition = dbContext.GetTable<Dokument>();
                List<Dokument> eintraege = new List<Dokument>();

                //Auswerten der typisierten Liste
                if (aktivitaetId != -1)
                {
                    eintraege = getDokumentByAktivitaet(dokumenteTableDefinition);
                }
                else if (phaseId != -1)
                {
                    eintraege = getDokumentByPhase(dokumenteTableDefinition);
                }
                else if (projektId != -1)
                {
                    eintraege = getDokumentByProjekt(dokumenteTableDefinition);
                }
                else
                {
                    eintraege = getDokumentByMeilenstein(dokumenteTableDefinition);
                }

                //Ausgabe
                this.dokumenteDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = {
                        i.dokumentId.ToString(),
                        i.name,
                        i.dokumentpfad
                    };
                    dokumenteDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private List<Dokument> getDokumentByAktivitaet(Table<Dokument> dokumenteTableDefinition)
        {
            List<Dokument> myDocuments = new List<Dokument>();
            Table<Aktivitaet> aktivitaetenTableDefinition = dbContext.GetTable<Aktivitaet>();

            var entries = from dokument in dokumenteTableDefinition
                            join aktivitaet in aktivitaetenTableDefinition on dokument.aktivitaetId equals aktivitaet.aktivitaetId
                            where dokument.aktivitaetId == aktivitaetId
                            select new
                            { // result selector 
                                dokument
                            };

            foreach (var entry in entries)
            {
                myDocuments.Add(entry.dokument);
            }
            return myDocuments;
        }
        
        private List<Dokument> getDokumentByMeilenstein(Table<Dokument> dokumenteTableDefinition)
        {
            List<Dokument> myDocuments = new List<Dokument>();
            Table<Meilenstein> projektTableDefinition = dbContext.GetTable<Meilenstein>();

            var entries = from dokument in dokumenteTableDefinition
                          join meilenstein in projektTableDefinition on dokument.meilensteinId equals meilenstein.meilensteinId
                          where dokument.meilensteinId == meilensteinId
                          select new
                          { // result selector 
                              dokument
                          };

            foreach (var entry in entries)
            {
                myDocuments.Add(entry.dokument);
            }
            return myDocuments;
        }
        
        private List<Dokument> getDokumentByProjekt(Table<Dokument> dokumenteTableDefinition)
        {
            List<Dokument> myDocuments = new List<Dokument>();
            Table<Projekt> projektTableDefinition = dbContext.GetTable<Projekt>();

            var entries = from dokument in dokumenteTableDefinition
                          join projekt in projektTableDefinition on dokument.projektId equals projekt.projektId
                          where dokument.projektId == projektId
                          select new
                          { // result selector 
                              dokument
                          };

            foreach (var entry in entries)
            {
                myDocuments.Add(entry.dokument);
            }
            return myDocuments;
        }
        
        private List<Dokument> getDokumentByPhase(Table<Dokument> dokumenteTableDefinition)
        {
            List<Dokument> myDocuments = new List<Dokument>();
            Table<Phase> phaseTableDefinition = dbContext.GetTable<Phase>();

            var entries = from dokument in dokumenteTableDefinition
                          join phase in phaseTableDefinition on dokument.phaseId equals phase.phaseId
                          where dokument.phaseId == phaseId
                          select new
                          { // result selector 
                              dokument
                          };

            foreach (var entry in entries)
            {
                myDocuments.Add(entry.dokument);
            }
            return myDocuments;
        }

        private void addExterneKostenButton_Click(object sender, EventArgs e)
        {
            //addDokumenteForm = new AddDokumenteForm(dbContext, false, 0);
            addDokumenteForm = new AddDokumenteForm(dbContext, savePath, aktivitaetId, phaseId, projektId, meilensteinId);
            addDokumenteForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addDokumentForm_FormClosing);
            addDokumenteForm.ShowDialog();

            loadDokumenteDataGrid();
        }

        private void addDokumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!addDokumenteForm.editMode && addDokumenteForm.DialogResult == DialogResult.OK)
            if (addDokumenteForm.DialogResult == DialogResult.OK)
            {
                if (true)
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Dokument> ressourceTableDefinition = dbContext.GetTable<Dokument>();

                    //neuer Eintrag erstellen
                    //addDokumenteForm.asd

                    Dokument dokument = new Dokument();
                    dokument.dokumentId = aktivitaetId;

                    ressourceTableDefinition.InsertOnSubmit(dokument);

                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadDokumenteDataGrid();
                }
            }
        }

        private void deleteDokumentButton_Click(object sender, EventArgs e)
        {
            int dokumentId;
            DataGridViewSelectedRowCollection selectedRow;
            if (dokumenteDataGrid.SelectedRows.Count == 1 && dokumenteDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = dokumenteDataGrid.SelectedRows;
                dokumentId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Dokument> my_inhalt = dbContext.GetTable<Dokument>();

            //Abfrage
            var zu_loeschen =
                                from dokument in my_inhalt
                                where dokument.dokumentId == dokumentId
                                select dokument;

            //Delete on submit aufrufen -> ein element löschen
            Dokument deleteDokument = zu_loeschen.First();
            my_inhalt.DeleteOnSubmit(deleteDokument);
            deleteFile(deleteDokument);

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadDokumenteDataGrid();
        }

        // Files to be deleted  from share
        private void deleteFile(Dokument deleteDokument)
        {
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(deleteDokument.dokumentpfad))
                {
                    // If file found, delete it    
                    File.Delete(deleteDokument.dokumentpfad);
                    MessageBox.Show("File deleted.");
                }
                else MessageBox.Show("Could not delete File from Directory " + deleteDokument.dokumentpfad + ". File not found");
            }
            catch (IOException ioExp)
            {
                MessageBox.Show("Folgender Fehler ist aufgetretten: "  + ioExp.Message);
            }
        }
    }
}
