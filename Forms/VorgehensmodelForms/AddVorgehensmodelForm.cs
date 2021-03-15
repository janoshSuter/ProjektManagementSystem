using ProjektManagementSystem.VorgehensmodelForms;
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
    public partial class AddVorgehensmodelForm : Form
    {
        PhasenForm vorgehensmodelPhasenForm;
        DataContext dbContext;
        int vorgehensmodelId;
        private string savePath;

        public int activeVorgehensmodelId { get => vorgehensmodelId; set => vorgehensmodelId = value; }
        public TextBox TextBoxName { get => textBoxName; set => textBoxName = value; }
        public TextBox BeschreibungTextBox { get => beschreibungTextBox; set => beschreibungTextBox = value; }
        public Label PhasenLabel { get => phasenLbl; set => phasenLbl = value; }


        public AddVorgehensmodelForm(DataContext dbcontext, string userSavePath, bool editmode)
        {
            dbContext = dbcontext;
            savePath = userSavePath;
            InitializeComponent();
            updateUi(editmode);
        }

        private void updateUi(bool editmode)
        {
            editPhasenButton.Visible = editmode;
            phasenZumTitelLabel.Visible = editmode;
            if (!editmode)
            {
                phasenLbl.Text = "Die Phasen können später, dem Vorgehensmodel hinzugefügt werden";
            }

            Table<Vorgehensmodel> my_vorgehensmodel = dbContext.GetTable<Vorgehensmodel>();
            Table<Vorgehensmodel_Phase> my_vorgehensmodelPhase = dbContext.GetTable<Vorgehensmodel_Phase>();
            Table<Phase> my_phase = dbContext.GetTable<Phase>();

            var zu_phasen = from phasen in my_phase
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

            phasenLbl.Text = "";
            foreach (var phase in zu_phasen)
            {
                phasenLbl.Text += "- " + phase.phasen.bezeichnung + "\n";
            }
        }

        private void editPhasenButton_Click(object sender, EventArgs e)
        {
            vorgehensmodelPhasenForm = new PhasenForm(dbContext, savePath, activeVorgehensmodelId);
            vorgehensmodelPhasenForm.ShowDialog();

            updateUi(true);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public TextBox getNameTextBox()
        {
            return textBoxName;
        }

        public TextBox getBeschreibungTextBox()
        {
            return beschreibungTextBox;
        }
    }
}
