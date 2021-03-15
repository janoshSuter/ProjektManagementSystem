using ProjektManagementSystem.ProjekteForms;
using System;
//zusätzlicher Namespace
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using static ProjektManagementSystem.ProjekteDetailsForm;

namespace ProjektManagementSystem
{
    public partial class ProjekteForm : Form
    {
        AddVorgehensmodelForm vorgehensmodelForm;
        ProjekteDetailsForm projektDetailsForm;
        DataContext dbContext;
        CreateProjektWizardForm projektWizard;

        const string dateFormat = "dd.MM.yyyy";

        public ProjekteForm(DataContext dbcontext)
        {
            dbContext = dbcontext;
            InitializeComponent();
            loadProjekteDataGrid();
        }

        private void loadProjekteDataGrid()
        {
            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Projekt> my_projekt = dbContext.GetTable<Projekt>();
                Table<Vorgehensmodel> my_joinVorgehensmodel = dbContext.GetTable<Vorgehensmodel>();

                //Auswerten der typisierten Liste
                var eintraege = from projekt in my_projekt
                                join vorgehensmodel in my_joinVorgehensmodel on projekt.vorgehensmodelId equals vorgehensmodel.vorgehensmodelId
                                select new
                                { // result selector 
                                    projekt,
                                    vorgehensmodel
                                };

                //Ausgabe
                this.projekteDataGridView.Rows.Clear();
                foreach (var i in eintraege)
                {
                    object[] newRow = { 
                        i.projekt.projektId.ToString(), 
                        i.projekt.projekttitel, 
                        i.projekt.beschreibung, i.projekt.priorität, 
                        i.projekt.bewilligungsdatum.Date.ToString(dateFormat), 
                        i.projekt.status, 
                        i.projekt.projektfortschritt,
                        i.projekt.startdatumGeplant.Date.ToString(dateFormat),
                        i.projekt.startdatumEffektiv.HasValue ? i.projekt.startdatumEffektiv.Value.Date.ToString(dateFormat) : "",
                        i.projekt.enddatumGeplant.Date.ToString(dateFormat),
                        i.projekt.enddatumEffektiv.HasValue ? i.projekt.enddatumEffektiv.Value.Date.ToString(dateFormat) : ""
                    };
                    int indexNewRow = projekteDataGridView.Rows.Add(newRow);
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
            vorgehensmodelForm = new AddVorgehensmodelForm(dbContext, false);
            vorgehensmodelForm.ShowDialog();

            if (vorgehensmodelForm.getNameTextBox().Text.Length > 2 && !vorgehensmodelForm.getBeschreibungTextBox().Text.Equals(""))
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Vorgehensmodel> vorgensmodelTableDefinition = dbContext.GetTable<Vorgehensmodel>();

                //neuer Eintrag erstellen
                string name = vorgehensmodelForm.getNameTextBox().Text;
                string beschreibung = vorgehensmodelForm.getBeschreibungTextBox().Text;

                Vorgehensmodel vorgehensmodel = new Vorgehensmodel();
                vorgehensmodel.name = name;
                vorgehensmodel.beschreibung = beschreibung;

                vorgensmodelTableDefinition.InsertOnSubmit(vorgehensmodel);
                //Aenderung auf DB auslösen
                dbContext.SubmitChanges();

                // datagrid neu befüllen
                loadProjekteDataGrid();
            }
        }

        private void deleteProjektButton_Click(object sender, EventArgs e)
        {
            int projektId;
            DataGridViewSelectedRowCollection selectedRow;
            if (projekteDataGridView.SelectedRows.Count == 1 && projekteDataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                selectedRow = projekteDataGridView.SelectedRows;
                projektId = Int32.Parse(selectedRow[0].Cells[0].Value.ToString());
            }
            else
            {
                return;
            }
            //Connect auf Tabelle inkl. dem Mapping
            Table<Projekt> my_inhalt = dbContext.GetTable<Projekt>();

            //Abfrage
            var zu_loeschen =
                                from projekt in my_inhalt
                                where projekt.projektId == projektId
                                select projekt;

            //Delete on submit aufrufen -> ein element löschen
            my_inhalt.DeleteOnSubmit(zu_loeschen.First());

            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();

            // datagrid neu befüllen
            loadProjekteDataGrid();
        }

        private void addProjektButton_Click(object sender, EventArgs e)
        {
            projektWizard = new CreateProjektWizardForm(dbContext);
            projektWizard.ShowDialog();

            loadProjekteDataGrid();
        }

        private void projektEditButton_Click(object sender, EventArgs e)
        {
            if (projekteDataGridView.SelectedRows.Count == 0 || projekteDataGridView.SelectedRows[0].Cells[0].Value == null) {
                return;
            }

            try
            {
                //Connect auf Tabelle inkl. dem Mapping
                Table<Projekt> my_projekt = dbContext.GetTable<Projekt>();
                Table<Vorgehensmodel> my_joinVorgehensmodel = dbContext.GetTable<Vorgehensmodel>();
                Table<Mitarbeiter> my_joinMitarbeiter = dbContext.GetTable<Mitarbeiter>();
                int projektid = Int32.Parse(projekteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                projektDetailsForm = new ProjekteDetailsForm(dbContext, projektid);
                projektDetailsForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.projektDetailsForm_FormClosing);

                //Auswerten der typisierten Liste
                var eintraege = from projekt in my_projekt
                                where projekt.projektId == projektid
                                join vorgehensmodel in my_joinVorgehensmodel on projekt.vorgehensmodelId equals vorgehensmodel.vorgehensmodelId
                                join mitarbeiter in my_joinMitarbeiter on projekt.projektleiterMitarberiterId equals mitarbeiter.mitarbeiterId
                                select new
                                { // result selector 
                                    projekt,
                                    vorgehensmodel,
                                    mitarbeiter
                                };

                //Ausgabe
                if (eintraege.Count() > 0)
                {   
                    Projekt projekt = eintraege.FirstOrDefault().projekt;
                    Vorgehensmodel vorgehensmodel = eintraege.First().vorgehensmodel;
                    Mitarbeiter mitarbeiter = eintraege.First().mitarbeiter;
                    projektDetailsForm.Text = "ProjektId: " + projekt.projektId.ToString();
                    projektDetailsForm.ProjektTitelTextBox.Text = projekt.projekttitel;
                    projektDetailsForm.BeschreibungTextBox.Text = projekt.beschreibung;
                    projektDetailsForm.PrioTextBox.Text = projekt.priorität.ToString();
                    projektDetailsForm.StatusTextBox.Text = projekt.status;
                    projektDetailsForm.FortschrittTextBox.Text = projekt.projektfortschritt.ToString();
                    projektDetailsForm.VorgehensmodelComboBox.SelectedIndex = 
                        projektDetailsForm.VorgehensmodelComboBox.FindString(vorgehensmodel.name);
                    projektDetailsForm.BewilligunsDatePicker.Value = projekt.bewilligungsdatum;
                    projektDetailsForm.StartdatumGeplantDatePicker.Value = projekt.startdatumGeplant;
                    projektDetailsForm.EnddatumGeplantDatePicker.Value = projekt.enddatumGeplant;
                    projektDetailsForm.ProjektleiterComboBox.SelectedIndex = 
                        projektDetailsForm.ProjektleiterComboBox.FindString(mitarbeiter.vorname + " " + mitarbeiter.nachname);

                    if (projekt.startdatumEffektiv != null) 
                    {
                        setDefaultDatePicker(projektDetailsForm.StartdatumEffektivDatePicker, projekt);
                    }
                    else 
                    {
                        setEmptyCustomDatePicker(projektDetailsForm.StartdatumEffektivDatePicker);
                    }

                    if (projekt.enddatumEffektiv != null)
                    {
                        setDefaultDatePicker(projektDetailsForm.EnddatumEffektivDatePicker, projekt);
                    }
                    else
                    {
                        setEmptyCustomDatePicker(projektDetailsForm.EnddatumEffektivDatePicker);
                    }

                    projektDetailsForm.ShowDialog();
                    
                    if (projektDetailsForm.DialogResult == DialogResult.OK)
                    {
                        projekt.projekttitel = projektDetailsForm.ProjektTitelTextBox.Text;
                        projekt.beschreibung = projektDetailsForm.BeschreibungTextBox.Text;
                        projekt.priorität = Int32.Parse(projektDetailsForm.PrioTextBox.Text);
                        projekt.status = projektDetailsForm.StatusTextBox.Text;
                        projekt.projektfortschritt = Int32.Parse(projektDetailsForm.FortschrittTextBox.Text);
                        projekt.vorgehensmodelId = (projektDetailsForm.VorgehensmodelComboBox.SelectedItem as VorgehensmodelComboboxItem).Value.vorgehensmodelId;
                        projekt.bewilligungsdatum = projektDetailsForm.BewilligunsDatePicker.Value;
                        projekt.startdatumGeplant = projektDetailsForm.StartdatumGeplantDatePicker.Value;
                        projekt.startdatumEffektiv = projektDetailsForm.StartdatumEffektivDatePicker.Value;
                        projekt.enddatumGeplant = projektDetailsForm.EnddatumGeplantDatePicker.Value;
                        projekt.enddatumEffektiv = projektDetailsForm.EnddatumEffektivDatePicker.Value;
                        projekt.projektleiterMitarberiterId = (projektDetailsForm.ProjektleiterComboBox.SelectedItem as MitarbeiterComboboxItem).Value.mitarbeiterId;

                        dbContext.SubmitChanges();
                    }
                }

                loadProjekteDataGrid();
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

        private void setDefaultDatePicker(DateTimePicker dateTimePicker, Projekt projekt)
        {
            dateTimePicker.Enabled = true;
            dateTimePicker.Value = (DateTime) projekt.startdatumEffektiv;
        }

        private void projektDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (projektDetailsForm.DialogResult == DialogResult.OK)
            {
                if (projektDetailsForm.BeschreibungTextBox.Text.Length > 2 && !projektDetailsForm.BeschreibungTextBox.Text.Equals("")
                    && projektDetailsForm.ProjektTitelTextBox.Text.Length > 2 && !projektDetailsForm.ProjektTitelTextBox.Text.Equals("")
                    && projektDetailsForm.PrioTextBox.Text.Length >= 1 && !projektDetailsForm.PrioTextBox.Text.Equals("")
                    && projektDetailsForm.BewilligunsDatePicker.Text.Length > 2 && !projektDetailsForm.BewilligunsDatePicker.Text.Equals("")
                    && projektDetailsForm.StatusTextBox.Text.Length > 2 && !projektDetailsForm.StatusTextBox.Text.Equals("")
                    && projektDetailsForm.EnddatumGeplantDatePicker.Text.Length > 2 && !projektDetailsForm.EnddatumGeplantDatePicker.Text.Equals("")
                    && projektDetailsForm.StartdatumGeplantDatePicker.Text.Length > 2 && !projektDetailsForm.StartdatumGeplantDatePicker.Text.Equals("")
                    && projektDetailsForm.ProjektleiterComboBox.Text.Length > 2 && !projektDetailsForm.ProjektleiterComboBox.Text.Equals(""))
                {

                    //Connect auf Tabelle inkl. dem Mapping
                    Table<Projekt> my_projekt = dbContext.GetTable<Projekt>();
                    Table<Vorgehensmodel> my_joinVorgehensmodel = dbContext.GetTable<Vorgehensmodel>();
                    Table<Mitarbeiter> my_joinMitarbeiter = dbContext.GetTable<Mitarbeiter>();
                    int id = Int32.Parse(projekteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    //Auswerten der typisierten Liste
                    var eintraege = from projekt in my_projekt
                                    where projekt.projektId == id
                                    join vorgehensmodel in my_joinVorgehensmodel on projekt.vorgehensmodelId equals vorgehensmodel.vorgehensmodelId
                                    join mitarbeiter in my_joinMitarbeiter on projekt.projektleiterMitarberiterId equals mitarbeiter.mitarbeiterId
                                    select new
                                    { // result selector 
                                        projekt,
                                        vorgehensmodel,
                                        mitarbeiter
                                    };

                    if (eintraege.Any())
                    {
                        Projekt projekt = eintraege.FirstOrDefault().projekt;
                        //Eintrag bearbeiten
                        string beschreibung = projektDetailsForm.BeschreibungTextBox.Text;
                        string titel = projektDetailsForm.ProjektTitelTextBox.Text;
                        int prioritaet = Int32.Parse(projektDetailsForm.PrioTextBox.Text);
                        int fortschritt = Int32.Parse(projektDetailsForm.FortschrittTextBox.Text);
                        string status = projektDetailsForm.StatusTextBox.Text;
                        DateTime startdatumGeplant = projektDetailsForm.StartdatumGeplantDatePicker.Value;
                        DateTime? startdatumEffektiv = projektDetailsForm.StartdatumEffektivDatePicker.Value;
                        DateTime enddatumGeplant = projektDetailsForm.EnddatumGeplantDatePicker.Value;
                        DateTime? enddatumEffektiv = projektDetailsForm.EnddatumEffektivDatePicker.Value;
                        DateTime bewilligunsdatum = projektDetailsForm.BewilligunsDatePicker.Value;
                        int vorgehensmodelId = (projektDetailsForm.VorgehensmodelComboBox.SelectedItem as VorgehensmodelComboboxItem).Value.vorgehensmodelId;
                        int projektleiterId = (projektDetailsForm.ProjektleiterComboBox.SelectedItem as MitarbeiterComboboxItem).Value.mitarbeiterId;

                        projekt.beschreibung = beschreibung;
                        projekt.projekttitel = titel;
                        projekt.priorität = prioritaet;
                        projekt.projektfortschritt = fortschritt;
                        projekt.status = status;
                        projekt.startdatumGeplant = startdatumGeplant;
                        projekt.startdatumEffektiv = startdatumEffektiv;
                        projekt.enddatumGeplant = enddatumGeplant;
                        projekt.enddatumEffektiv = enddatumEffektiv;
                        projekt.bewilligungsdatum = bewilligunsdatum;
                        projekt.vorgehensmodelId = vorgehensmodelId;
                        projekt.projektleiterMitarberiterId = projektleiterId;

                        //Aenderung auf DB auslösen
                        dbContext.SubmitChanges();

                        // datagrid neu befüllen
                        loadProjekteDataGrid();
                    }
                } else
                {
                    MessageBox.Show("Objekt konnte nicht gepsichert werden, bitte alle Pflichtfelder ausfüllen.");
                }
            }
        }
    }
}
