
using System.Windows.Forms;

namespace ProjektManagementSystem.VorgehensmodelForms
{
    partial class PhasenForm
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
            this.phasenDataGrid = new System.Windows.Forms.DataGridView();
            this.PhasenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhasenTitelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FortschrittColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdatumEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnddatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnddatumEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewdatumGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewdatumEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeigabedatumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhasenAktivitaetLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phasenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // phasenDataGrid
            // 
            this.phasenDataGrid.AllowUserToAddRows = false;
            this.phasenDataGrid.AllowUserToDeleteRows = false;
            this.phasenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phasenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhasenIdColumn,
            this.PhasenTitelColumn,
            this.FortschrittColumn,
            this.StatusColumn,
            this.StartdatumGeplantColumn,
            this.StartdatumEffektivColumn,
            this.EnddatumGeplantColumn,
            this.EnddatumEffektivColumn,
            this.ReviewdatumGeplantColumn,
            this.ReviewdatumEffektivColumn,
            this.FeigabedatumColumn});
            this.phasenDataGrid.Location = new System.Drawing.Point(12, 57);
            this.phasenDataGrid.MaximumSize = new System.Drawing.Size(1168, 347);
            this.phasenDataGrid.MinimumSize = new System.Drawing.Size(1168, 347);
            this.phasenDataGrid.MultiSelect = false;
            this.phasenDataGrid.Name = "phasenDataGrid";
            this.phasenDataGrid.ReadOnly = true;
            this.phasenDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phasenDataGrid.Size = new System.Drawing.Size(1168, 347);
            this.phasenDataGrid.TabIndex = 0;
            // 
            // PhasenIdColumn
            // 
            this.PhasenIdColumn.FillWeight = 60F;
            this.PhasenIdColumn.HeaderText = "Id";
            this.PhasenIdColumn.Name = "PhasenIdColumn";
            this.PhasenIdColumn.ReadOnly = true;
            this.PhasenIdColumn.Width = 60;
            // 
            // PhasenTitelColumn
            // 
            this.PhasenTitelColumn.HeaderText = "Phase";
            this.PhasenTitelColumn.Name = "PhasenTitelColumn";
            this.PhasenTitelColumn.ReadOnly = true;
            // 
            // FortschrittColumn
            // 
            this.FortschrittColumn.HeaderText = "Fortschritt";
            this.FortschrittColumn.Name = "FortschrittColumn";
            this.FortschrittColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // StartdatumGeplantColumn
            // 
            this.StartdatumGeplantColumn.HeaderText = "StartdatumGeplant";
            this.StartdatumGeplantColumn.Name = "StartdatumGeplantColumn";
            this.StartdatumGeplantColumn.ReadOnly = true;
            // 
            // StartdatumEffektivColumn
            // 
            this.StartdatumEffektivColumn.HeaderText = "StartdatumEffektiv";
            this.StartdatumEffektivColumn.Name = "StartdatumEffektivColumn";
            this.StartdatumEffektivColumn.ReadOnly = true;
            // 
            // EnddatumGeplantColumn
            // 
            this.EnddatumGeplantColumn.HeaderText = "EnddatumGeplant";
            this.EnddatumGeplantColumn.Name = "EnddatumGeplantColumn";
            this.EnddatumGeplantColumn.ReadOnly = true;
            // 
            // EnddatumEffektivColumn
            // 
            this.EnddatumEffektivColumn.HeaderText = "EnddatumEffektiv";
            this.EnddatumEffektivColumn.Name = "EnddatumEffektivColumn";
            this.EnddatumEffektivColumn.ReadOnly = true;
            // 
            // ReviewdatumGeplantColumn
            // 
            this.ReviewdatumGeplantColumn.FillWeight = 120F;
            this.ReviewdatumGeplantColumn.HeaderText = "ReviewdatumGeplant";
            this.ReviewdatumGeplantColumn.Name = "ReviewdatumGeplantColumn";
            this.ReviewdatumGeplantColumn.ReadOnly = true;
            this.ReviewdatumGeplantColumn.Width = 120;
            // 
            // ReviewdatumEffektivColumn
            // 
            this.ReviewdatumEffektivColumn.FillWeight = 120F;
            this.ReviewdatumEffektivColumn.HeaderText = "ReviewdatumEffektiv";
            this.ReviewdatumEffektivColumn.Name = "ReviewdatumEffektivColumn";
            this.ReviewdatumEffektivColumn.ReadOnly = true;
            this.ReviewdatumEffektivColumn.Width = 120;
            // 
            // FeigabedatumColumn
            // 
            this.FeigabedatumColumn.HeaderText = "Feigabedatum";
            this.FeigabedatumColumn.Name = "FeigabedatumColumn";
            this.FeigabedatumColumn.ReadOnly = true;
            // 
            // PhasenAktivitaetLbl
            // 
            this.PhasenAktivitaetLbl.AutoSize = true;
            this.PhasenAktivitaetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PhasenAktivitaetLbl.Location = new System.Drawing.Point(12, 28);
            this.PhasenAktivitaetLbl.Name = "PhasenAktivitaetLbl";
            this.PhasenAktivitaetLbl.Size = new System.Drawing.Size(86, 26);
            this.PhasenAktivitaetLbl.TabIndex = 1;
            this.PhasenAktivitaetLbl.Text = "Phase: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Phase Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addPhaseButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Phase Editieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.phasenEditButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Phase Löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deletePhaseButton_Click);
            // 
            // PhasenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhasenAktivitaetLbl);
            this.Controls.Add(this.phasenDataGrid);
            this.MaximumSize = new System.Drawing.Size(1208, 509);
            this.MinimumSize = new System.Drawing.Size(1208, 509);
            this.Name = "PhasenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VorgehensmodelPhasenForm";
            ((System.ComponentModel.ISupportInitialize)(this.phasenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView phasenDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhasenIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhasenTitelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FortschrittColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdatumEffektivColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnddatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnddatumEffektivColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewdatumGeplantColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewdatumEffektivColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeigabedatumColumn;
        private System.Windows.Forms.Label PhasenAktivitaetLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}