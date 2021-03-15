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

namespace ProjektManagementSystem
{
    public partial class AddMeilensteinForm : Form
    {
        private DataContext dbContext;
        private bool editMode;
        private readonly int meilensteinId;
        private DokumenteForm dokumenteForm;

        public AddMeilensteinForm(DataContext dbcontext, bool editmode, int meilensteinid)
        {
            InitializeComponent();
            dbContext = dbcontext;
            editMode = editmode;
            meilensteinId = meilensteinid;
            upateUi();
        }

        private void upateUi()
        {
            linkLabelDokumente.Visible = editMode;
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

        public TextBox BezeichnungTextBox { get => bezeichnungTextBox; set => bezeichnungTextBox = value; }
        public DateTimePicker AbschlussdatumDateTime { get => abschlussdatumDateTime; set => abschlussdatumDateTime = value; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dokumenteForm = new DokumenteForm(dbContext, -1, -1, -1, meilensteinId);
            dokumenteForm.ShowDialog();
        }
    }
}
