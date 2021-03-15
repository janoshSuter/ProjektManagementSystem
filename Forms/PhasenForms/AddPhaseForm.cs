using ProjektManagementSystem.DokumenteForms;
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
    public partial class AddPhaseForm : Form
    {
        DokumenteForm dokumenteForm;
        AktivitaetenForm aktivitaetenForm;
        MeilensteinForm meilensteinForm;
        DataContext dbContext;
        internal int phaseId;
        public bool editMode;

        public AddPhaseForm(DataContext dbcontext, bool editmode, int phaseid)
        {
            dbContext = dbcontext;
            phaseId = phaseid;
            editMode = editmode;
            InitializeComponent();
            updateUi();
        }


        private void activateStartEffektivDatePicker_Click(object sender, EventArgs e)
        {
            startdatumEffektivDatePicker.Enabled = true;
            startdatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            startdatumEffektivDatePicker.Value = DateTime.Now;

        }

        private void activateEndEffektiveDatePicker_Click(object sender, EventArgs e)
        {
            enddatumEffektivDatePicker.Enabled = true;
            enddatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            enddatumEffektivDatePicker.Value = DateTime.Now;
        }
        
        private void activateFreigabeDatePicker_Click(object sender, EventArgs e)
        {
            reviewdatumEffektivDatePicker.Enabled = true;
            reviewdatumEffektivDatePicker.Format = DateTimePickerFormat.Long;
            reviewdatumEffektivDatePicker.Value = DateTime.Now;
        }

        private void editAktivitaetenButton_Click(object sender, EventArgs e)
        {
            aktivitaetenForm = new AktivitaetenForm(dbContext, phaseId);
            aktivitaetenForm.ShowDialog();
            updateUi();
        }
        
        private void editMeilensteinenButton_Click(object sender, EventArgs e)
        {
            meilensteinForm = new MeilensteinForm(dbContext, phaseId);
            meilensteinForm.ShowDialog();
            updateUi();
        }

        private void updateUi()
        {
            editAktivitaetenButton.Visible = editMode;
            aktivitaetenTitelLabel.Visible = editMode;
            editMeilensteineButton.Visible = editMode;
            meilensteineLabel.Visible = editMode;
            linkLabelDokumente.Visible = editMode;
            StartdatumGeplantDatePicker.Enabled = !editMode;
            EnddatumGeplantDatePicker.Enabled = !editMode;
            ReviewdatumGeplantDatePicker.Enabled = !editMode;
            if (!editMode)
            {
                aktivitaetenTitelLbl.Text = "Die Aktivitäten können später der Phase hinzugefügt werden";
                setEmptyCustomDatePicker(StartdatumEffektivDatePicker);
                setEmptyCustomDatePicker(EnddatumEffektivDatePicker);
                setEmptyCustomDatePicker(ReviewdatumEffektivDatePicker);
            }

            aktivitaetLabelUpdate();
            meilensteineLabelUpdate();
        }

        private void aktivitaetLabelUpdate()
        {
            Table<Aktivitaet> aktivitaetTableDefinition = dbContext.GetTable<Aktivitaet>();
            var zu_phasenAktivitaeten = from aktivitaet in aktivitaetTableDefinition
                                        where aktivitaet.phaseId == phaseId
                                        select new
                                        {
                                            aktivitaet
                                        };

            AktivitaetLabel.Text = "";
            foreach (var aktivitaet in zu_phasenAktivitaeten)
            {
                AktivitaetLabel.Text += "- " + aktivitaet.aktivitaet.beschreibung + "\n";
            }
        }
        
        private void meilensteineLabelUpdate()
        {
            Table<Meilenstein> meilensteinTableDefinition = dbContext.GetTable<Meilenstein>();
            var zu_phasenMeilenstein = from meilenstein in meilensteinTableDefinition
                                        where meilenstein.phaseId == phaseId
                                        select new
                                        {
                                            meilenstein
                                        };

            meilensteineLabel.Text = "";
            foreach (var meilenstein in zu_phasenMeilenstein)
            {
                meilensteineLabel.Text += "- " + meilenstein.meilenstein.bezeichnung + "\n";
            }
        }

        private void setEmptyCustomDatePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Enabled = false;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = " ";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public TextBox BezeichnungTextBox { get => bezeichnungTextBox; set => bezeichnungTextBox = value; }
        public TextBox PhasenFortschrittTextBox { get => phasenFortschrittTextBox; set => phasenFortschrittTextBox = value; }
        public TextBox StatusTextBox { get => statusTextBox; set => statusTextBox = value; }
        public DateTimePicker StartdatumEffektivDatePicker { get => startdatumEffektivDatePicker; set => startdatumEffektivDatePicker = value; }
        public DateTimePicker StartdatumGeplantDatePicker { get => startdatumGeplantDatePicker; set => startdatumGeplantDatePicker = value; }
        public DateTimePicker EnddatumEffektivDatePicker { get => enddatumEffektivDatePicker; set => enddatumEffektivDatePicker = value; }
        public DateTimePicker EnddatumGeplantDatePicker { get => enddatumGeplantDatePicker; set => enddatumGeplantDatePicker = value; }
        public DateTimePicker ReviewdatumEffektivDatePicker { get => reviewdatumEffektivDatePicker; set => reviewdatumEffektivDatePicker = value; }
        public DateTimePicker ReviewdatumGeplantDatePicker { get => reviewdatumGeplantDatePicker; set => reviewdatumGeplantDatePicker = value; }
        public DateTimePicker FreigabedatumDatePicker { get => freigabedatumDatePicker; set => freigabedatumDatePicker = value; }
        public Label AktivitaetLabel { get => aktivitaetenTitelLbl; set => aktivitaetenTitelLbl = value; }
        public Label MeilensteineLabel { get => meilensteineLabel; set => meilensteineLabel = value; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dokumenteForm = new DokumenteForm(dbContext, -1,  phaseId, -1, -1);
            dokumenteForm.ShowDialog();
        }
    }
}
