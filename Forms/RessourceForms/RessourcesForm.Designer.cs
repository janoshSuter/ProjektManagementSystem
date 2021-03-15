
using System.Windows.Forms;

namespace ProjektManagementSystem.RessourceForms
{
    partial class RessourceForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PhasenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhasenTitelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PensumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunktionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StundenGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StundenEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PensumColumn,
            this.FunktionColumn,
            this.StundenGeplantColumn,
            this.StundenEffektivColumn});
            this.phasenDataGrid.Location = new System.Drawing.Point(12, 12);
            this.phasenDataGrid.MultiSelect = false;
            this.phasenDataGrid.Name = "phasenDataGrid";
            this.phasenDataGrid.ReadOnly = true;
            this.phasenDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phasenDataGrid.Size = new System.Drawing.Size(657, 309);
            this.phasenDataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ressource Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addRessourceButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ressource Editieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ressourceEditButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ressource Löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deletePhaseButton_Click);
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
            this.PhasenTitelColumn.HeaderText = "Mitarbeiter";
            this.PhasenTitelColumn.Name = "PhasenTitelColumn";
            this.PhasenTitelColumn.ReadOnly = true;
            this.PhasenTitelColumn.Width = 140;
            // 
            // PensumColumn
            // 
            this.PensumColumn.HeaderText = "Pensum";
            this.PensumColumn.Name = "PensumColumn";
            this.PensumColumn.ReadOnly = true;
            // 
            // FunktionColumn
            // 
            this.FunktionColumn.HeaderText = "Funktion";
            this.FunktionColumn.Name = "FunktionColumn";
            this.FunktionColumn.ReadOnly = true;
            // 
            // StundenGeplantColumn
            // 
            this.StundenGeplantColumn.HeaderText = "Stunden Geplant";
            this.StundenGeplantColumn.Name = "StundenGeplantColumn";
            this.StundenGeplantColumn.ReadOnly = true;
            // 
            // StundenEffektivColumn
            // 
            this.StundenEffektivColumn.HeaderText = "Stunden Effektiv";
            this.StundenEffektivColumn.Name = "StundenEffektivColumn";
            this.StundenEffektivColumn.ReadOnly = true;
            // 
            // RessourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phasenDataGrid);
            this.Name = "RessourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ressource Form";
            ((System.ComponentModel.ISupportInitialize)(this.phasenDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phasenDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DataGridViewTextBoxColumn PhasenIdColumn;
        private DataGridViewTextBoxColumn PhasenTitelColumn;
        private DataGridViewTextBoxColumn PensumColumn;
        private DataGridViewTextBoxColumn FunktionColumn;
        private DataGridViewTextBoxColumn StundenGeplantColumn;
        private DataGridViewTextBoxColumn StundenEffektivColumn;
    }
}