using System;
using System.IO;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data.Linq;

namespace ProjektManagementSystem
{
    public partial class AddDokumenteForm : Form
    {
        string strSavePath = @"C:\PMS\";
        DataTable dtData;
        DataContext dbContext;
        int aktivitaetId;
        int phaseId;
        int projektId;
        int meilensteinId;

        public AddDokumenteForm(DataContext dbcontext, int aktivitaetid, int phaseid, int projektid, int meilenstenid)
        {
            InitializeComponent();
            dbContext = dbcontext;
            aktivitaetId = aktivitaetid;
            phaseId = phaseid;
            projektId = projektid;
            meilensteinId = meilenstenid;
        }

        private void FileUpload_Load(object sender, EventArgs e)
        {
            dtData = createTable();
        }

        private DataTable createTable()
        {
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("cname", typeof(string));
            dtReturn.Columns.Add("cpath", typeof(string));
            dtReturn.Columns.Add("csaveto", typeof(string));
            return dtReturn;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dgvFileDataGrid.Rows.Count > 0)
            {
                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strSavePath);
                }
                int numRes = 0;
                for (int i = 0; i < dgvFileDataGrid.Rows.Count; i++)
                {
                    try
                    {
                        string oldPath = dgvFileDataGrid.Rows[i].Cells["filePath"].Value.ToString();
                        string fileSavePath = dgvFileDataGrid.Rows[i].Cells["fileSavePath"].Value.ToString();
                        File.Copy(oldPath, fileSavePath, true);
                        saveDokumentDataInDb(fileSavePath);
                        numRes++;
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Es ist ein Problem beim Speichern aufgetretten: \n"  + ex.StackTrace);
                    }
                }
                MessageBox.Show(numRes.ToString() + " Datei wurde gespeichert!");
                dtData.Rows.Clear();
                dgvFileDataGrid.DataSource = dtData;
            }
        }

        private void saveDokumentDataInDb(string fileSavePath)
        {
            string documentName = Path.GetFileName(fileSavePath);
            //Connect auf Tabelle inkl. dem Mapping
            Table<Dokument> dokumentTableDefinition = dbContext.GetTable<Dokument>();

            //neuer Eintrag erstellen

            Dokument dokument = new Dokument();
            dokument.name = documentName;
            dokument.dokumentpfad = fileSavePath;
            if (meilensteinId != -1)
            {
                dokument.meilensteinId = meilensteinId;
            }
            else if (phaseId != -1)
            {

                dokument.phaseId = phaseId;
/*                dokument.aktivitaetId = null;
                dokument.projektId = null;
                dokument.meilensteinId = null;*/
            }
            else if (aktivitaetId != -1)
            {
                dokument.aktivitaetId = aktivitaetId;
            }
            else {
                dokument.projektId = projektId;
            }
    
            dokumentTableDefinition.InsertOnSubmit(dokument);
            //Aenderung auf DB auslösen
            dbContext.SubmitChanges();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dtData.Rows.Clear();
            dgvFileDataGrid.DataSource = dtData;
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select file";
            fileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            fileDialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", fileDialog.Filter, "", "All Files", "*.*");
            // Code for image filter  
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                fileDialog.Filter = string.Format("{0}{1}{2} ({3})|{3}", fileDialog.Filter, "|", codecName, c.FilenameExtension);
            }
            // Code for files filter  
            fileDialog.Filter = fileDialog.Filter + "|CSV Files (*.csv)|*.csv";
            fileDialog.Filter = fileDialog.Filter + "|Excel Files (.xls ,.xlsx)|  *.xls ;*.xlsx";
            fileDialog.Filter = fileDialog.Filter + "|PDF Files (.pdf)|*.pdf";
            fileDialog.Filter = fileDialog.Filter + "|Text Files (*.txt)|*.txt";
            fileDialog.Filter = fileDialog.Filter + "|Word Files (.docx ,.doc)|*.docx;*.doc";
            fileDialog.Filter = fileDialog.Filter + "|XML Files (*.xml)|*.xml";

            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    if (file != string.Empty)
                    {
                        DataRow drRow = dtData.NewRow();
                        drRow["cname"] = Path.GetFileNameWithoutExtension(file);
                        drRow["cpath"] = file;
                        drRow["csaveto"] = strSavePath + Path.GetFileName(file);
                        dtData.Rows.Add(drRow);
                    }
                }
            }
            dgvFileDataGrid.DataSource = dtData;
        }
    }
}