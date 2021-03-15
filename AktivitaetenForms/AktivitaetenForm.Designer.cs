
namespace ProjektManagementSystem.VorgehensmodelForms
{
    partial class AktivitaetenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aktivitaetenDataGrid = new System.Windows.Forms.DataGridView();
            this.AktivitätenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerantwortlicherMitarbeiterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeschreibungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdatumEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnddatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnddatumEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FortschrittColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.editActivityButton = new System.Windows.Forms.Button();
            this.deleteActivityButton = new System.Windows.Forms.Button();
            this.vorgehenmodelTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aktivitaetenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // aktivitaetenDataGrid
            // 
            this.aktivitaetenDataGrid.AllowUserToAddRows = false;
            this.aktivitaetenDataGrid.AllowUserToDeleteRows = false;
            this.aktivitaetenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivitaetenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AktivitätenIdColumn,
            this.VerantwortlicherMitarbeiterColumn,
            this.BeschreibungColumn,
            this.StartdatumEffektivColumn,
            this.StartdatumGeplantColumn,
            this.EnddatumGeplantColumn,
            this.EnddatumEffektivColumn,
            this.BudgetColumn,
            this.FortschrittColumn});
            this.aktivitaetenDataGrid.Location = new System.Drawing.Point(12, 36);
            this.aktivitaetenDataGrid.MaximumSize = new System.Drawing.Size(1101, 351);
            this.aktivitaetenDataGrid.MinimumSize = new System.Drawing.Size(1101, 351);
            this.aktivitaetenDataGrid.MultiSelect = false;
            this.aktivitaetenDataGrid.Name = "aktivitaetenDataGrid";
            this.aktivitaetenDataGrid.ReadOnly = true;
            this.aktivitaetenDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aktivitaetenDataGrid.Size = new System.Drawing.Size(1101, 351);
            this.aktivitaetenDataGrid.TabIndex = 0;
            // 
            // AktivitätenIdColumn
            // 
            this.AktivitätenIdColumn.HeaderText = "AktivitätenId";
            this.AktivitätenIdColumn.Name = "AktivitätenIdColumn";
            this.AktivitätenIdColumn.ReadOnly = true;
            // 
            // VerantwortlicherMitarbeiterColumn
            // 
            this.VerantwortlicherMitarbeiterColumn.FillWeight = 160F;
            this.VerantwortlicherMitarbeiterColumn.HeaderText = "Verantwortlicher Mitarbeiter";
            this.VerantwortlicherMitarbeiterColumn.Name = "VerantwortlicherMitarbeiterColumn";
            this.VerantwortlicherMitarbeiterColumn.ReadOnly = true;
            this.VerantwortlicherMitarbeiterColumn.Width = 160;
            // 
            // BeschreibungColumn
            // 
            this.BeschreibungColumn.HeaderText = "Beschreibung";
            this.BeschreibungColumn.Name = "BeschreibungColumn";
            this.BeschreibungColumn.ReadOnly = true;
            // 
            // StartdatumEffektivColumn
            // 
            this.StartdatumEffektivColumn.FillWeight = 120F;
            this.StartdatumEffektivColumn.HeaderText = "Startdatum Effektiv";
            this.StartdatumEffektivColumn.Name = "StartdatumEffektivColumn";
            this.StartdatumEffektivColumn.ReadOnly = true;
            this.StartdatumEffektivColumn.Width = 120;
            // 
            // StartdatumGeplantColumn
            // 
            this.StartdatumGeplantColumn.FillWeight = 130F;
            this.StartdatumGeplantColumn.HeaderText = "Startdatum Geplant";
            this.StartdatumGeplantColumn.Name = "StartdatumGeplantColumn";
            this.StartdatumGeplantColumn.ReadOnly = true;
            this.StartdatumGeplantColumn.Width = 130;
            // 
            // EnddatumGeplantColumn
            // 
            this.EnddatumGeplantColumn.FillWeight = 120F;
            this.EnddatumGeplantColumn.HeaderText = "Enddatum Geplant";
            this.EnddatumGeplantColumn.Name = "EnddatumGeplantColumn";
            this.EnddatumGeplantColumn.ReadOnly = true;
            this.EnddatumGeplantColumn.Width = 120;
            // 
            // EnddatumEffektivColumn
            // 
            this.EnddatumEffektivColumn.FillWeight = 120F;
            this.EnddatumEffektivColumn.HeaderText = "Enddatum Effektiv";
            this.EnddatumEffektivColumn.Name = "EnddatumEffektivColumn";
            this.EnddatumEffektivColumn.ReadOnly = true;
            this.EnddatumEffektivColumn.Width = 120;
            // 
            // BudgetColumn
            // 
            this.BudgetColumn.HeaderText = "Budget";
            this.BudgetColumn.Name = "BudgetColumn";
            this.BudgetColumn.ReadOnly = true;
            // 
            // FortschrittColumn
            // 
            this.FortschrittColumn.HeaderText = "Fortschritt";
            this.FortschrittColumn.Name = "FortschrittColumn";
            this.FortschrittColumn.ReadOnly = true;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(12, 393);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(171, 39);
            this.addActivityButton.TabIndex = 1;
            this.addActivityButton.Text = "Aktivität hinzufügen";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // editActivityButton
            // 
            this.editActivityButton.Location = new System.Drawing.Point(189, 393);
            this.editActivityButton.Name = "editActivityButton";
            this.editActivityButton.Size = new System.Drawing.Size(171, 39);
            this.editActivityButton.TabIndex = 1;
            this.editActivityButton.Text = "Aktivität editieren";
            this.editActivityButton.UseVisualStyleBackColor = true;
            this.editActivityButton.Click += new System.EventHandler(this.editActivityButton_Click);
            // 
            // deleteActivityButton
            // 
            this.deleteActivityButton.Location = new System.Drawing.Point(366, 393);
            this.deleteActivityButton.Name = "deleteActivityButton";
            this.deleteActivityButton.Size = new System.Drawing.Size(171, 39);
            this.deleteActivityButton.TabIndex = 1;
            this.deleteActivityButton.Text = "Aktivität löschen";
            this.deleteActivityButton.UseVisualStyleBackColor = true;
            this.deleteActivityButton.Click += new System.EventHandler(this.deleteActivityButton_Click);
            // 
            // vorgehenmodelTitleLabel
            // 
            this.vorgehenmodelTitleLabel.AutoSize = true;
            this.vorgehenmodelTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vorgehenmodelTitleLabel.Location = new System.Drawing.Point(12, 7);
            this.vorgehenmodelTitleLabel.Name = "vorgehenmodelTitleLabel";
            this.vorgehenmodelTitleLabel.Size = new System.Drawing.Size(103, 24);
            this.vorgehenmodelTitleLabel.TabIndex = 2;
            this.vorgehenmodelTitleLabel.Text = "Aktivitäten: ";
            // 
            // AktivitaetenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 441);
            this.Controls.Add(this.vorgehenmodelTitleLabel);
            this.Controls.Add(this.deleteActivityButton);
            this.Controls.Add(this.editActivityButton);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.aktivitaetenDataGrid);
            this.MaximumSize = new System.Drawing.Size(1141, 480);
            this.MinimumSize = new System.Drawing.Size(1141, 480);
            this.Name = "AktivitaetenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VorgehensmodelAktivitaeten";
            ((System.ComponentModel.ISupportInitialize)(this.aktivitaetenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aktivitaetenDataGrid;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.Button editActivityButton;
        private System.Windows.Forms.Button deleteActivityButton;
        private System.Windows.Forms.Label vorgehenmodelTitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AktivitätenIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerantwortlicherMitarbeiterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeschreibungColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdatumEffektivColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnddatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnddatumEffektivColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BudgetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FortschrittColumn;
    }
}