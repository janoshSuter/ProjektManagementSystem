
namespace ProjektManagementSystem
{
    partial class MeilensteinForm
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
            this.meilensteinDataGrid = new System.Windows.Forms.DataGridView();
            this.MItarbeiterIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BezeichnungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbschlussdatumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addKostenartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meilensteinDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // meilensteinDataGrid
            // 
            this.meilensteinDataGrid.AllowUserToAddRows = false;
            this.meilensteinDataGrid.AllowUserToDeleteRows = false;
            this.meilensteinDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meilensteinDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MItarbeiterIdColumn,
            this.BezeichnungColumn,
            this.AbschlussdatumColumn});
            this.meilensteinDataGrid.Location = new System.Drawing.Point(13, 13);
            this.meilensteinDataGrid.MultiSelect = false;
            this.meilensteinDataGrid.Name = "meilensteinDataGrid";
            this.meilensteinDataGrid.ReadOnly = true;
            this.meilensteinDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.meilensteinDataGrid.Size = new System.Drawing.Size(420, 148);
            this.meilensteinDataGrid.TabIndex = 0;
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
            // BezeichnungColumn
            // 
            this.BezeichnungColumn.FillWeight = 200F;
            this.BezeichnungColumn.Frozen = true;
            this.BezeichnungColumn.HeaderText = "Bezeichnung";
            this.BezeichnungColumn.Name = "BezeichnungColumn";
            this.BezeichnungColumn.ReadOnly = true;
            this.BezeichnungColumn.Width = 200;
            // 
            // AbschlussdatumColumn
            // 
            this.AbschlussdatumColumn.Frozen = true;
            this.AbschlussdatumColumn.HeaderText = "Abschlussdatum";
            this.AbschlussdatumColumn.Name = "AbschlussdatumColumn";
            this.AbschlussdatumColumn.ReadOnly = true;
            // 
            // addKostenartButton
            // 
            this.addKostenartButton.Location = new System.Drawing.Point(12, 167);
            this.addKostenartButton.Name = "addKostenartButton";
            this.addKostenartButton.Size = new System.Drawing.Size(137, 42);
            this.addKostenartButton.TabIndex = 1;
            this.addKostenartButton.Text = "Meilenstein erfassen";
            this.addKostenartButton.UseVisualStyleBackColor = true;
            this.addKostenartButton.Click += new System.EventHandler(this.addMeilensteinButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Meilenstein löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteMeilensteinButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Meilenstein editieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.meilensteinEditButton_Click);
            // 
            // MeilensteinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 217);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addKostenartButton);
            this.Controls.Add(this.meilensteinDataGrid);
            this.Name = "MeilensteinForm";
            this.Text = "Meilensteine Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.meilensteinDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView meilensteinDataGrid;
        private System.Windows.Forms.Button addKostenartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MItarbeiterIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BezeichnungColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbschlussdatumColumn;
        private System.Windows.Forms.Button button2;
    }
}