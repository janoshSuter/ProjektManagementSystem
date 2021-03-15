using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using static ProjektManagementSystem.ProjekteDetailsForm;

namespace ProjektManagementSystem.ProjekteForms
{
    public partial class CreateProjektWizardForm : Form
    {
        DataContext dbContext;
        public CreateProjektWizardForm(DataContext dbconext)
        {
            dbContext = dbconext;
            InitializeComponent();
            loadVorgehensmodeleToComboBox();
            loadMitarbeiterToComboBox();
        }

        private void wizardPage3_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (projektnameTextBox.Text.Length > 1
                && beschreibungTextBox.Text.Length > 1
                && !BewilligunsdatumDateTimePicker.Value.ToString().Equals("")
                && !StartdatumGeplantDateTimePicker.Value.ToString().Equals("")
                && !EnddatumGeplantDateTimePicker.Value.ToString().Equals("")
                && !PrioritaetTextBox.Text.ToString().Equals("")
                && !ProjektnameTextBox.Text.ToString().Equals("")
                ) {
                Table<Projekt> projektTableDefinition = dbContext.GetTable<Projekt>();

                //neuer Eintrag erstellen
                string projektname = ProjektnameTextBox.Text;
                string beschreibung = BeschreibungTextBox.Text;
                DateTime startdatumGeplant = StartdatumGeplantDateTimePicker.Value;
                DateTime enddatumGeplant = EnddatumGeplantDateTimePicker.Value;
                DateTime bewiligungsdatum = BewilligunsdatumDateTimePicker.Value;
                int prioritaet = Int32.Parse(PrioritaetTextBox.Text);
                int vorgehensmodelId = (VorgehensmodelComboBox.SelectedItem as VorgehensmodelComboboxItem).Value.vorgehensmodelId;
                int projektleiterId = (ProjektleiterComboBox.SelectedItem as MitarbeiterComboboxItem).Value.mitarbeiterId;
                string projektStatus = "offen";
                int projektfortschritt = 0;

                Projekt projekt = new Projekt();
                projekt.projekttitel = projektname;
                projekt.beschreibung = beschreibung;
                projekt.priorität = prioritaet;
                projekt.status = projektStatus;
                projekt.startdatumGeplant = startdatumGeplant;
                projekt.enddatumGeplant = enddatumGeplant;
                projekt.bewilligungsdatum = bewiligungsdatum;
                projekt.projektfortschritt = projektfortschritt;
                projekt.vorgehensmodelId = vorgehensmodelId;
                projekt.projektleiterMitarberiterId = projektleiterId;

                projektTableDefinition.InsertOnSubmit(projekt);
                //Aenderung auf DB auslösen
                dbContext.SubmitChanges();
            }
        }

        private void loadVorgehensmodeleToComboBox()
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
                this.vorgehensmodelComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    VorgehensmodelComboboxItem item = new VorgehensmodelComboboxItem(i.vorgehensmodel);
                    vorgehensmodelComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void loadMitarbeiterToComboBox()
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
                this.projektleiterComboBox.Items.Clear();
                foreach (var i in eintraege)
                {
                    MitarbeiterComboboxItem item = new MitarbeiterComboboxItem(i.mitarbeiter);
                    projektleiterComboBox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Etwas ist schief gelaufen
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void projektleiterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mitarbeiter mitarbeiter = (ProjektleiterComboBox.SelectedItem as MitarbeiterComboboxItem).Value;
            MitarbeiterInfoLbl.Text = "Abteilung: " + mitarbeiter.abteilung + "\n"
                + "Pensum: " + mitarbeiter.arbeitspensum + "% \n" + "Funktion: " + mitarbeiter.funktionsbeschreibung;
        }
        
        private void vorgehensmodelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vorgehensmodel model = (VorgehensmodelComboBox.SelectedItem as VorgehensmodelComboboxItem).Value;
            vorgehensmodelBeschreibunglbl.Text = model.beschreibung;
        }
        public TextBox ProjektnameTextBox { get => projektnameTextBox; set => projektnameTextBox = value; }
        public DateTimePicker EnddatumGeplantDateTimePicker { get => enddatumGeplantDateTimePicker; set => enddatumGeplantDateTimePicker = value; }
        public DateTimePicker StartdatumGeplantDateTimePicker { get => startdatumGeplantDateTimePicker; set => startdatumGeplantDateTimePicker = value; }
        public TextBox BeschreibungTextBox { get => beschreibungTextBox; set => beschreibungTextBox = value; }
        public TextBox PrioritaetTextBox { get => prioritaetTextBox; set => prioritaetTextBox = value; }
        public DateTimePicker BewilligunsdatumDateTimePicker { get => bewilligunsdatumDateTimePicker; set => bewilligunsdatumDateTimePicker = value; }
        public ComboBox VorgehensmodelComboBox { get => vorgehensmodelComboBox; set => vorgehensmodelComboBox = value; }
        public ComboBox ProjektleiterComboBox { get => projektleiterComboBox; set => projektleiterComboBox = value; }
    }
}
