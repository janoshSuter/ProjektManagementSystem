
using System.Windows.Forms;

namespace ProjektManagementSystem.ExterneKostenForms
{
    partial class ExterneKostenForm
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
            this.externeKostenDataGrid = new System.Windows.Forms.DataGridView();
            this.PhasenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhasenTitelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StundenGeplantColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StundenEffektivColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunktionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addExterneKostenButton = new System.Windows.Forms.Button();
            this.editKostenButton = new System.Windows.Forms.Button();
            this.deleteKostenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.externeKostenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // externeKostenDataGrid
            // 
            this.externeKostenDataGrid.AllowUserToAddRows = false;
            this.externeKostenDataGrid.AllowUserToDeleteRows = false;
            this.externeKostenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.externeKostenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhasenIdColumn,
            this.PhasenTitelColumn,
            this.StundenGeplantColumn,
            this.StundenEffektivColumn,
            this.FunktionColumn});
            this.externeKostenDataGrid.Location = new System.Drawing.Point(12, 12);
            this.externeKostenDataGrid.MultiSelect = false;
            this.externeKostenDataGrid.Name = "externeKostenDataGrid";
            this.externeKostenDataGrid.ReadOnly = true;
            this.externeKostenDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.externeKostenDataGrid.Size = new System.Drawing.Size(657, 309);
            this.externeKostenDataGrid.TabIndex = 0;
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
            this.PhasenTitelColumn.HeaderText = "Kostenart";
            this.PhasenTitelColumn.Name = "PhasenTitelColumn";
            this.PhasenTitelColumn.ReadOnly = true;
            this.PhasenTitelColumn.Width = 140;
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
            // FunktionColumn
            // 
            this.FunktionColumn.FillWeight = 200F;
            this.FunktionColumn.HeaderText = "Abweichungsgrund";
            this.FunktionColumn.Name = "FunktionColumn";
            this.FunktionColumn.ReadOnly = true;
            this.FunktionColumn.Width = 200;
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
            // editKostenButton
            // 
            this.editKostenButton.Location = new System.Drawing.Point(178, 327);
            this.editKostenButton.Name = "editKostenButton";
            this.editKostenButton.Size = new System.Drawing.Size(159, 46);
            this.editKostenButton.TabIndex = 2;
            this.editKostenButton.Text = "Editieren";
            this.editKostenButton.UseVisualStyleBackColor = true;
            this.editKostenButton.Click += new System.EventHandler(this.externeKostenEditButton_Click);
            // 
            // deleteKostenButton
            // 
            this.deleteKostenButton.Location = new System.Drawing.Point(343, 327);
            this.deleteKostenButton.Name = "deleteKostenButton";
            this.deleteKostenButton.Size = new System.Drawing.Size(159, 46);
            this.deleteKostenButton.TabIndex = 3;
            this.deleteKostenButton.Text = "Löschen";
            this.deleteKostenButton.UseVisualStyleBackColor = true;
            this.deleteKostenButton.Click += new System.EventHandler(this.deleteKostenButton_Click);
            // 
            // ExterneKostenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.deleteKostenButton);
            this.Controls.Add(this.editKostenButton);
            this.Controls.Add(this.addExterneKostenButton);
            this.Controls.Add(this.externeKostenDataGrid);
            this.Name = "ExterneKostenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ressource Form";
            ((System.ComponentModel.ISupportInitialize)(this.externeKostenDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView externeKostenDataGrid;
        private System.Windows.Forms.Button addExterneKostenButton;
        private System.Windows.Forms.Button editKostenButton;
        private System.Windows.Forms.Button deleteKostenButton;
        private DataGridViewTextBoxColumn PhasenIdColumn;
        private DataGridViewTextBoxColumn PhasenTitelColumn;
        private DataGridViewTextBoxColumn StundenGeplantColumn;
        private DataGridViewTextBoxColumn StundenEffektivColumn;
        private DataGridViewTextBoxColumn FunktionColumn;
    }
}