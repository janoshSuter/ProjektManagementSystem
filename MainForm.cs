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

namespace ProjektManagementSystem
{
    public partial class MainForm : Form
    {
        DataContext dbContext;
        string savePath = "Save Files Here";

        public MainForm()
        {
            initDbContext();
            InitializeComponent();
        }

        private void initDbContext()
        {
            dbContext = new DataContext("Data Source=LAPTOP-JUBPV84E\\SQLEXPRESS; Initial Catalog = ProjektManagementSystemDB; Integrated Security = True;");
        }

        private void mitarbeiterButton_Click(object sender, EventArgs e)
        {
            MitarbeiterForm mitarbeiterForm = new MitarbeiterForm(dbContext);
            mitarbeiterForm.ShowDialog();
        }

        private void projekteButton_Click(object sender, EventArgs e)
        {
            ProjekteForm projekteForm = new ProjekteForm(dbContext);
            projekteForm.ShowDialog();
        }

        private void vorgehensModelButton_Click(object sender, EventArgs e)
        {
            VorgehensmodelForm vorgehensmodelForm = new VorgehensmodelForm(dbContext, savePath);
            vorgehensmodelForm.ShowDialog();
        }

        private void KostenartButton_Click(object sender, EventArgs e)
        {
            KostenartForm kostenartForm = new KostenartForm(dbContext);
            kostenartForm.ShowDialog();
        }

        private void SharepathButton_Click(object sender, EventArgs e)
        {
            // Prepare a dummy string, thos would appear in the dialog
            string dummyFileName = "Save Files Here";

            FolderBrowserDialog sf = new FolderBrowserDialog();
            // Feed the dummy name to the save dialog
            sf.SelectedPath = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                savePath = Path.GetDirectoryName(sf.SelectedPath);

            }
        }
    }
}
