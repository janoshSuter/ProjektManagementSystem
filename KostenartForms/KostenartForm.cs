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
    public partial class KostenartForm : Form
    {
        DataContext dbContext;
        AddKostenartForm addKostenartForm;

        public KostenartForm(DataContext dbcontext)
        {
            dbContext = dbcontext;
            InitializeComponent();
            loadKostenartDataGrid();
        }

        
        private void loadKostenartDataGrid()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Kostenart> my_kostenart = dbContext.GetTable<Kostenart>();

                //Auswerten der typisierten Liste
                var eintraege = from kostenart in my_kostenart
                                select new
                                { // result selector 
                                    kostenart
                                };

                //Ausgabe
                this.kostenartDataGrid.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = { 
                        i.kostenart.kostenartId.ToString(), 
                        i.kostenart.bezeichnung    
                    };
                    int indexNewRow = kostenartDataGrid.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void addKostenartButton_Click(object sender, EventArgs e)
        {
            addKostenartForm = new AddKostenartForm();
            addKostenartForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kostenartForm_FormClosing);
            addKostenartForm.ShowDialog();
        }

        private void kostenartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (addKostenartForm.DialogResult == DialogResult.OK)
            {
                if (addKostenartForm.getBezeichnungTextBox().Text.Length > 2 && !addKostenartForm.getBezeichnungTextBox().Text.Equals(""))
                {
                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Kostenart> kostenartTableDefinition = dbContext.GetTable<Kostenart>();

                    //neuer Eintrag erstellen
                    string name = addKostenartForm.getBezeichnungTextBox().Text;
                    string bezeichnung = addKostenartForm.getBezeichnungTextBox().Text;

                    Kostenart kostenart = new Kostenart();
                    kostenart.bezeichnung = bezeichnung;

                    kostenartTableDefinition.InsertOnSubmit(kostenart);
                    //Aenderung auf DB auslösen
                    dbContext.SubmitChanges();

                    // datagrid neu befüllen
                    loadKostenartDataGrid();
                }
            }
        }

        private void deleteKostenartButton(object sender, EventArgs e)
        {
            int kostenartId;
            DataGridViewSelectedRowCollection selectedRow;
            if (kostenartDataGrid.SelectedRows.Count == 1 && kostenartDataGrid.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = kostenartDataGrid.SelectedRows;
                kostenartId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Kostenart> my_inhalt = dbContext.GetTable<Kostenart>();

            //Abfrage
            var zu_loeschen =
                                from kostenart in my_inhalt
                                where kostenart.kostenartId == kostenartId
                                select kostenart;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadKostenartDataGrid();
        }
    }
}
