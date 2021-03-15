
namespace ProjektManagementSystem
{
    partial class VorgehensmodelForm
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
            this.vorgehensmodelDataGridView = new System.Windows.Forms.DataGridView();
            this.MItarbeiterIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VornameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NachnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addVorgehensmodelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vorgehensmodelEditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vorgehensmodelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vorgehensmodelDataGridView
            // 
            this.vorgehensmodelDataGridView.AllowUserToAddRows = false;
            this.vorgehensmodelDataGridView.AllowUserToDeleteRows = false;
            this.vorgehensmodelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vorgehensmodelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MItarbeiterIdColumn,
            this.VornameColumn,
            this.NachnameColumn});
            this.vorgehensmodelDataGridView.Location = new System.Drawing.Point(12, 13);
            this.vorgehensmodelDataGridView.MultiSelect = false;
            this.vorgehensmodelDataGridView.Name = "vorgehensmodelDataGridView";
            this.vorgehensmodelDataGridView.ReadOnly = true;
            this.vorgehensmodelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vorgehensmodelDataGridView.Size = new System.Drawing.Size(899, 535);
            this.vorgehensmodelDataGridView.TabIndex = 0;
            // 
            // MItarbeiterIdColumn
            // 
            this.MItarbeiterIdColumn.FillWeight = 50F;
            this.MItarbeiterIdColumn.Frozen = true;
            this.MItarbeiterIdColumn.HeaderText = "Id";
            this.MItarbeiterIdColumn.MinimumWidth = 10;
            this.MItarbeiterIdColumn.Name = "MItarbeiterIdColumn";
            this.MItarbeiterIdColumn.ReadOnly = true;
            this.MItarbeiterIdColumn.Width = 50;
            // 
            // VornameColumn
            // 
            this.VornameColumn.Frozen = true;
            this.VornameColumn.HeaderText = "Name";
            this.VornameColumn.Name = "VornameColumn";
            this.VornameColumn.ReadOnly = true;
            // 
            // NachnameColumn
            // 
            this.NachnameColumn.FillWeight = 400F;
            this.NachnameColumn.HeaderText = "Beschreibung";
            this.NachnameColumn.MinimumWidth = 400;
            this.NachnameColumn.Name = "NachnameColumn";
            this.NachnameColumn.ReadOnly = true;
            this.NachnameColumn.Width = 400;
            // 
            // addVorgehensmodelButton
            // 
            this.addVorgehensmodelButton.Location = new System.Drawing.Point(13, 554);
            this.addVorgehensmodelButton.Name = "addVorgehensmodelButton";
            this.addVorgehensmodelButton.Size = new System.Drawing.Size(169, 49);
            this.addVorgehensmodelButton.TabIndex = 1;
            this.addVorgehensmodelButton.Text = "Vorgehensmodel erfassen";
            this.addVorgehensmodelButton.UseVisualStyleBackColor = true;
            this.addVorgehensmodelButton.Click += new System.EventHandler(this.addVorgehensmodelButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vorgehensmodel löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteVorgehensmodelButton_Click);
            // 
            // vorgehensmodelEditButton
            // 
            this.vorgehensmodelEditButton.Location = new System.Drawing.Point(188, 554);
            this.vorgehensmodelEditButton.Name = "vorgehensmodelEditButton";
            this.vorgehensmodelEditButton.Size = new System.Drawing.Size(169, 49);
            this.vorgehensmodelEditButton.TabIndex = 1;
            this.vorgehensmodelEditButton.Text = "Vorgehensmodel editieren";
            this.vorgehensmodelEditButton.UseVisualStyleBackColor = true;
            this.vorgehensmodelEditButton.Click += new System.EventHandler(this.editVorgehensmodelButton_Click);
            // 
            // VorgehensmodelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 615);
            this.Controls.Add(this.vorgehensmodelEditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addVorgehensmodelButton);
            this.Controls.Add(this.vorgehensmodelDataGridView);
            this.MaximumSize = new System.Drawing.Size(940, 654);
            this.MinimumSize = new System.Drawing.Size(940, 654);
            this.Name = "VorgehensmodelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vorgehensmodel Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.vorgehensmodelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vorgehensmodelDataGridView;
        private System.Windows.Forms.Button addVorgehensmodelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MItarbeiterIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VornameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NachnameColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button vorgehensmodelEditButton;
    }
}