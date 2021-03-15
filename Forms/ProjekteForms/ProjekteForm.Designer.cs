
namespace ProjektManagementSystem
{
    partial class ProjekteForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.projekteDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioritaetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeiligungsdatumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjektfortschrittColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdatumGeplanntColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffektivesStartdatumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnddatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffektivesEnddatumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProjektButton = new System.Windows.Forms.Button();
            this.buchAuslesenButton = new System.Windows.Forms.Button();
            this.addProjektButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projekteDataGridView
            // 
            this.projekteDataGridView.AllowUserToAddRows = false;
            this.projekteDataGridView.AllowUserToDeleteRows = false;
            this.projekteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projekteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.TitelColumn,
            this.ColumnBeschreibung,
            this.PrioritaetColumn,
            this.BeiligungsdatumColumn,
            this.StatusColumn,
            this.ProjektfortschrittColumn,
            this.StartdatumGeplanntColumn,
            this.EffektivesStartdatumColumn,
            this.EnddatumGeplantColumn,
            this.EffektivesEnddatumColumn});
            this.projekteDataGridView.Location = new System.Drawing.Point(12, 37);
            this.projekteDataGridView.MultiSelect = false;
            this.projekteDataGridView.Name = "projekteDataGridView";
            this.projekteDataGridView.ReadOnly = true;
            this.projekteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projekteDataGridView.Size = new System.Drawing.Size(1228, 325);
            this.projekteDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.FillWeight = 50F;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 50;
            // 
            // TitelColumn
            // 
            this.TitelColumn.HeaderText = "Titel";
            this.TitelColumn.Name = "TitelColumn";
            this.TitelColumn.ReadOnly = true;
            // 
            // ColumnBeschreibung
            // 
            this.ColumnBeschreibung.FillWeight = 210F;
            this.ColumnBeschreibung.HeaderText = "Beschreibung";
            this.ColumnBeschreibung.Name = "ColumnBeschreibung";
            this.ColumnBeschreibung.ReadOnly = true;
            this.ColumnBeschreibung.Width = 210;
            // 
            // PrioritaetColumn
            // 
            this.PrioritaetColumn.FillWeight = 60F;
            this.PrioritaetColumn.HeaderText = "Priorität";
            this.PrioritaetColumn.Name = "PrioritaetColumn";
            this.PrioritaetColumn.ReadOnly = true;
            this.PrioritaetColumn.Width = 60;
            // 
            // BeiligungsdatumColumn
            // 
            this.BeiligungsdatumColumn.HeaderText = "Bewilligungsdatum";
            this.BeiligungsdatumColumn.Name = "BeiligungsdatumColumn";
            this.BeiligungsdatumColumn.ReadOnly = true;
            this.BeiligungsdatumColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // ProjektfortschrittColumn
            // 
            this.ProjektfortschrittColumn.HeaderText = "Projektfortschritt";
            this.ProjektfortschrittColumn.Name = "ProjektfortschrittColumn";
            this.ProjektfortschrittColumn.ReadOnly = true;
            // 
            // StartdatumGeplanntColumn
            // 
            this.StartdatumGeplanntColumn.HeaderText = "Geplanntes Startdatum";
            this.StartdatumGeplanntColumn.Name = "StartdatumGeplanntColumn";
            this.StartdatumGeplanntColumn.ReadOnly = true;
            // 
            // EffektivesStartdatumColumn
            // 
            this.EffektivesStartdatumColumn.HeaderText = "Effektives Startdatum";
            this.EffektivesStartdatumColumn.Name = "EffektivesStartdatumColumn";
            this.EffektivesStartdatumColumn.ReadOnly = true;
            // 
            // EnddatumGeplantColumn
            // 
            this.EnddatumGeplantColumn.HeaderText = "Geplantes Enddatum";
            this.EnddatumGeplantColumn.Name = "EnddatumGeplantColumn";
            this.EnddatumGeplantColumn.ReadOnly = true;
            // 
            // EffektivesEnddatumColumn
            // 
            this.EffektivesEnddatumColumn.HeaderText = "Effektives Enddatum";
            this.EffektivesEnddatumColumn.Name = "EffektivesEnddatumColumn";
            this.EffektivesEnddatumColumn.ReadOnly = true;
            // 
            // deleteProjektButton
            // 
            this.deleteProjektButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteProjektButton.Enabled = false;
            this.deleteProjektButton.Location = new System.Drawing.Point(12, 484);
            this.deleteProjektButton.Name = "deleteProjektButton";
            this.deleteProjektButton.Size = new System.Drawing.Size(194, 48);
            this.deleteProjektButton.TabIndex = 20;
            this.deleteProjektButton.Text = "Projekt Löschen";
            this.deleteProjektButton.UseVisualStyleBackColor = false;
            this.deleteProjektButton.Click += new System.EventHandler(this.deleteProjektButton_Click);
            // 
            // buchAuslesenButton
            // 
            this.buchAuslesenButton.Location = new System.Drawing.Point(12, 376);
            this.buchAuslesenButton.Name = "buchAuslesenButton";
            this.buchAuslesenButton.Size = new System.Drawing.Size(194, 48);
            this.buchAuslesenButton.TabIndex = 17;
            this.buchAuslesenButton.Text = "Projektdetails bearbeiten";
            this.buchAuslesenButton.UseVisualStyleBackColor = true;
            this.buchAuslesenButton.Click += new System.EventHandler(this.projektEditButton_Click);
            // 
            // addProjektButton
            // 
            this.addProjektButton.Location = new System.Drawing.Point(12, 430);
            this.addProjektButton.Name = "addProjektButton";
            this.addProjektButton.Size = new System.Drawing.Size(194, 48);
            this.addProjektButton.TabIndex = 18;
            this.addProjektButton.Text = "Neues Projekt erstellen";
            this.addProjektButton.UseVisualStyleBackColor = true;
            this.addProjektButton.Click += new System.EventHandler(this.addProjektButton_Click);
            // 
            // ProjekteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 541);
            this.Controls.Add(this.deleteProjektButton);
            this.Controls.Add(this.buchAuslesenButton);
            this.Controls.Add(this.addProjektButton);
            this.Controls.Add(this.projekteDataGridView);
            this.MaximumSize = new System.Drawing.Size(1268, 580);
            this.MinimumSize = new System.Drawing.Size(1268, 580);
            this.Name = "ProjekteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProjekte";
            ((System.ComponentModel.ISupportInitialize)(this.projekteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projekteDataGridView;
        private System.Windows.Forms.Button deleteProjektButton;
        private System.Windows.Forms.Button buchAuslesenButton;
        private System.Windows.Forms.Button addProjektButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioritaetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeiligungsdatumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjektfortschrittColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdatumGeplanntColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffektivesStartdatumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnddatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffektivesEnddatumColumn;
    }
}

