
using System.Windows.Forms;

namespace ProjektManagementSystem.DokumenteForms
{
    partial class DokumenteForm
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
            this.dokumenteDataGrid = new System.Windows.Forms.DataGridView();
            this.addExterneKostenButton = new System.Windows.Forms.Button();
            this.deleteKostenButton = new System.Windows.Forms.Button();
            this.PhasenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhasenTitelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunktionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dokumenteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // externeKostenDataGrid
            // 
            this.dokumenteDataGrid.AllowUserToAddRows = false;
            this.dokumenteDataGrid.AllowUserToDeleteRows = false;
            this.dokumenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokumenteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhasenIdColumn,
            this.PhasenTitelColumn,
            this.FunktionColumn});
            this.dokumenteDataGrid.Location = new System.Drawing.Point(12, 12);
            this.dokumenteDataGrid.MultiSelect = false;
            this.dokumenteDataGrid.Name = "externeKostenDataGrid";
            this.dokumenteDataGrid.ReadOnly = true;
            this.dokumenteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dokumenteDataGrid.Size = new System.Drawing.Size(657, 309);
            this.dokumenteDataGrid.TabIndex = 0;
            // 
            // addExterneKostenButton
            // 
            this.addExterneKostenButton.Location = new System.Drawing.Point(13, 328);
            this.addExterneKostenButton.Name = "addExterneKostenButton";
            this.addExterneKostenButton.Size = new System.Drawing.Size(159, 46);
            this.addExterneKostenButton.TabIndex = 2;
            this.addExterneKostenButton.Text = "Hiinzufügen";
            this.addExterneKostenButton.UseVisualStyleBackColor = true;
            this.addExterneKostenButton.Click += new System.EventHandler(this.addExterneKostenButton_Click);
            // 
            // deleteKostenButton
            // 
            this.deleteKostenButton.Location = new System.Drawing.Point(178, 327);
            this.deleteKostenButton.Name = "deleteKostenButton";
            this.deleteKostenButton.Size = new System.Drawing.Size(159, 46);
            this.deleteKostenButton.TabIndex = 3;
            this.deleteKostenButton.Text = "Löschen";
            this.deleteKostenButton.UseVisualStyleBackColor = true;
            this.deleteKostenButton.Click += new System.EventHandler(this.deleteDokumentButton_Click);
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
            this.PhasenTitelColumn.FillWeight = 140F;
            this.PhasenTitelColumn.HeaderText = "Name";
            this.PhasenTitelColumn.Name = "PhasenTitelColumn";
            this.PhasenTitelColumn.ReadOnly = true;
            this.PhasenTitelColumn.Width = 140;
            // 
            // FunktionColumn
            // 
            this.FunktionColumn.FillWeight = 400F;
            this.FunktionColumn.HeaderText = "Documenten Pfad";
            this.FunktionColumn.Name = "FunktionColumn";
            this.FunktionColumn.ReadOnly = true;
            this.FunktionColumn.Width = 400;
            // 
            // DokumenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.deleteKostenButton);
            this.Controls.Add(this.addExterneKostenButton);
            this.Controls.Add(this.dokumenteDataGrid);
            this.Name = "DokumenteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokumente Form";
            ((System.ComponentModel.ISupportInitialize)(this.dokumenteDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dokumenteDataGrid;
        private System.Windows.Forms.Button addExterneKostenButton;
        private System.Windows.Forms.Button deleteKostenButton;
        private DataGridViewTextBoxColumn PhasenIdColumn;
        private DataGridViewTextBoxColumn PhasenTitelColumn;
        private DataGridViewTextBoxColumn FunktionColumn;
    }
}