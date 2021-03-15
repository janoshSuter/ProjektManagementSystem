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
    public partial class MeilensteinForm : Form
    {
        DataContext dbContext;
        private int phaseId;
        AddMeilensteinForm addMeilensteinForm;

        public MeilensteinForm(DataContext dbcontext, int phaseid)
        {
            dbContext = dbcontext;
            phaseId = phaseid;
            InitializeComponent();
            loadMeilensteinDataGrid();
        }

        
        private void loadMeilensteinDataGrid()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Meilenstein> my_meilenstein = dbContext.GetTable<Meilenstein>();

                //Auswerten der typisierten Liste
                var eintraege = from meilenstein in my_meilenstein
                                where meilenstein.phaseId == phaseId
                                select new
                                { // result selector 
                                    meilenstein
                                };

                //Ausgabe
                this.meilensteinDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = { 
                        i.meilenstein.meilensteinId.ToString(), 
                        i.meilenstein.bezeichnung, 
                        i.meilenstein.abschlussdatum    
                    };
                    int indexNewRow = meilensteinDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addMeilensteinButton_Click(object sender, EventArgs e)
        {
            addMeilensteinForm = new AddMeilensteinForm(dbContext, false, -1);
            addMeilensteinForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.meilensteinForm_FormClosing);
            addMeilensteinForm.ShowDialog();
        }

        private void meilensteinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addMeilensteinForm.DialogResult == DialogResult.OK)
            {
                if (addMeilensteinForm.BezeichnungTextBox.Text.Length > 1)
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Meilenstein> meilensteinTableDefinition = dbContext.GetTable<Meilenstein>();

                    //neuer Eintrag erstellen
                    string bezeichnung = addMeilensteinForm.BezeichnungTextBox.Text;
                    DateTime abschlussdatm = addMeilensteinForm.AbschlussdatumDateTime.Value;

                    Meilenstein meilenstein = new Meilenstein();
                    meilenstein.bezeichnung = bezeichnung;
                    meilenstein.abschlussdatum = abschlussdatm;
                    meilenstein.phaseId = phaseId;

                    meilensteinTableDefinition.InsertOnSubmit(meilenstein);
                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadMeilensteinDataGrid();
                } else
                {
                    MessageBox.Show("Es wurden nicht alle Pflichtfelder ausgefüllt! (Diese sind mit * versehen)");
                }
            }
        }

        private void deleteMeilensteinButton_Click(object sender, EventArgs e)
        {
            int meilensteinId;
            DataGridViewSelectedRowCollection selectedRow;
            if (meilensteinDataGrid.SelectedRows.Count == 1 && meilensteinDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = meilensteinDataGrid.SelectedRows;
                meilensteinId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Meilenstein> my_inhalt = dbContext.GetTable<Meilenstein>();

            //Abfrage
            var zu_loeschen =
                                from meilenstein in my_inhalt
                                where meilenstein.meilensteinId == meilensteinId
                                select meilenstein;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadMeilensteinDataGrid();
        }

        private void meilensteinEditButton_Click(object sender, EventArgs e)
        {
            int meilensteinId;
            DataGridViewSelectedRowCollection selectedRow;

            if (meilensteinDataGrid.SelectedRows.Count == 1 && meilensteinDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = meilensteinDataGrid.SelectedRows;
                meilensteinId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());

                //Connect auf Tabelle inkl. dem Mapping
                Table<Meilenstein> meilensteinTableDefinition = dbContext.GetTable<Meilenstein>();

                //Abfrage
                var zu_meilenstein = from meilenstein in meilensteinTableDefinition
                               where meilenstein.phaseId == phaseId
                               select new
                               {
                                   meilenstein
                               };

                if (zu_meilenstein.Any())
                {
                    Meilenstein meilenstein = zu_meilenstein.First().meilenstein;
                    //open edit Dialog -> ein element editieren

                    addMeilensteinForm = new AddMeilensteinForm(dbContext, true, meilensteinId);

                    addMeilensteinForm.BezeichnungTextBox.Text = meilenstein.bezeichnung;
                    addMeilensteinForm.AbschlussdatumDateTime.Text = meilenstein.abschlussdatum.ToString();

                    addMeilensteinForm.Text = "Phase " + meilenstein.bezeichnung + " bearbeiten";
                    addMeilensteinForm.AbschlussdatumDateTime.Text = "";
                    addMeilensteinForm.ShowDialog();

                    if (addMeilensteinForm.DialogResult == DialogResult.OK)
                    {
                        meilenstein.bezeichnung = addMeilensteinForm.BezeichnungTextBox.Text;
                        meilenstein.abschlussdatum = addMeilensteinForm.AbschlussdatumDateTime.Value;

                        //Aenderung auf DB auslösen
                        dbContext.SubmitChanges();
                    }
                }

                // datagrid neu befüllen
                loadMeilensteinDataGrid();
            }
        }
    }
}
