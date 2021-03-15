
namespace ProjektManagementSystem
{
    partial class MitarbeiterForm
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
            this.mitarbeiterDataGrid = new System.Windows.Forms.DataGridView();
            this.MItarbeiterIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VornameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NachnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbteilungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArbeitspensumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunktionsbeschreibungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMitarbeiterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mitarbeiterDataGrid
            // 
            this.mitarbeiterDataGrid.AllowUserToAddRows = false;
            this.mitarbeiterDataGrid.AllowUserToDeleteRows = false;
            this.mitarbeiterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mitarbeiterDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MItarbeiterIdColumn,
            this.VornameColumn,
            this.NachnameColumn,
            this.AbteilungColumn,
            this.ArbeitspensumColumn,
            this.FunktionsbeschreibungColumn});
            this.mitarbeiterDataGrid.Location = new System.Drawing.Point(13, 13);
            this.mitarbeiterDataGrid.MultiSelect = false;
            this.mitarbeiterDataGrid.Name = "mitarbeiterDataGrid";
            this.mitarbeiterDataGrid.ReadOnly = true;
            this.mitarbeiterDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mitarbeiterDataGrid.Size = new System.Drawing.Size(839, 274);
            this.mitarbeiterDataGrid.TabIndex = 0;
            // 
            // MItarbeiterIdColumn
            // 
            this.MItarbeiterIdColumn.HeaderText = "Personalnummer";
            this.MItarbeiterIdColumn.Name = "MItarbeiterIdColumn";
            this.MItarbeiterIdColumn.ReadOnly = true;
            // 
            // VornameColumn
            // 
            this.VornameColumn.HeaderText = "Vorname";
            this.VornameColumn.Name = "VornameColumn";
            this.VornameColumn.ReadOnly = true;
            // 
            // NachnameColumn
            // 
            this.NachnameColumn.HeaderText = "Nachname";
            this.NachnameColumn.Name = "NachnameColumn";
            this.NachnameColumn.ReadOnly = true;
            // 
            // AbteilungColumn
            // 
            this.AbteilungColumn.HeaderText = "Abteilung";
            this.AbteilungColumn.Name = "AbteilungColumn";
            this.AbteilungColumn.ReadOnly = true;
            // 
            // ArbeitspensumColumn
            // 
            this.ArbeitspensumColumn.HeaderText = "Arbetispensum";
            this.ArbeitspensumColumn.Name = "ArbeitspensumColumn";
            this.ArbeitspensumColumn.ReadOnly = true;
            // 
            // FunktionsbeschreibungColumn
            // 
            this.FunktionsbeschreibungColumn.FillWeight = 200F;
            this.FunktionsbeschreibungColumn.HeaderText = "Funktionsbeschreibung";
            this.FunktionsbeschreibungColumn.Name = "FunktionsbeschreibungColumn";
            this.FunktionsbeschreibungColumn.ReadOnly = true;
            this.FunktionsbeschreibungColumn.Width = 200;
            // 
            // addMitarbeiterButton
            // 
            this.addMitarbeiterButton.Location = new System.Drawing.Point(12, 293);
            this.addMitarbeiterButton.Name = "addMitarbeiterButton";
            this.addMitarbeiterButton.Size = new System.Drawing.Size(169, 49);
            this.addMitarbeiterButton.TabIndex = 1;
            this.addMitarbeiterButton.Text = "Mitarbieter erfassen";
            this.addMitarbeiterButton.UseVisualStyleBackColor = true;
            this.addMitarbeiterButton.Click += new System.EventHandler(this.addMitarbeiterButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mitarbieter löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteMitarbeiterButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mitarbieter editieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editMitarbeiterButton_Click);
            // 
            // MitarbeiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addMitarbeiterButton);
            this.Controls.Add(this.mitarbeiterDataGrid);
            this.Name = "MitarbeiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mitarbeiterDataGrid;
        private System.Windows.Forms.Button addMitarbeiterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MItarbeiterIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VornameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NachnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbteilungColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArbeitspensumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunktionsbeschreibungColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}