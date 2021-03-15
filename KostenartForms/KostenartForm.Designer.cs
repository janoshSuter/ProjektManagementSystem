
namespace ProjektManagementSystem
{
    partial class KostenartForm
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
            this.kostenartDataGrid = new System.Windows.Forms.DataGridView();
            this.MItarbeiterIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BezeichnungColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addKostenartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kostenartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kostenartDataGrid
            // 
            this.kostenartDataGrid.AllowUserToAddRows = false;
            this.kostenartDataGrid.AllowUserToDeleteRows = false;
            this.kostenartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kostenartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MItarbeiterIdColumn,
            this.BezeichnungColumn});
            this.kostenartDataGrid.Location = new System.Drawing.Point(13, 13);
            this.kostenartDataGrid.MultiSelect = false;
            this.kostenartDataGrid.Name = "kostenartDataGrid";
            this.kostenartDataGrid.ReadOnly = true;
            this.kostenartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kostenartDataGrid.Size = new System.Drawing.Size(400, 148);
            this.kostenartDataGrid.TabIndex = 0;
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
            this.BezeichnungColumn.FillWeight = 300F;
            this.BezeichnungColumn.Frozen = true;
            this.BezeichnungColumn.HeaderText = "Bezeichnung";
            this.BezeichnungColumn.Name = "BezeichnungColumn";
            this.BezeichnungColumn.ReadOnly = true;
            this.BezeichnungColumn.Width = 300;
            // 
            // addKostenartButton
            // 
            this.addKostenartButton.Location = new System.Drawing.Point(12, 167);
            this.addKostenartButton.Name = "addKostenartButton";
            this.addKostenartButton.Size = new System.Drawing.Size(195, 49);
            this.addKostenartButton.TabIndex = 1;
            this.addKostenartButton.Text = "Kostenart erfassen";
            this.addKostenartButton.UseVisualStyleBackColor = true;
            this.addKostenartButton.Click += new System.EventHandler(this.addKostenartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kostenart löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteKostenartButton);
            // 
            // KostenartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addKostenartButton);
            this.Controls.Add(this.kostenartDataGrid);
            this.Name = "KostenartForm";
            this.Text = "Kostenart Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.kostenartDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kostenartDataGrid;
        private System.Windows.Forms.Button addKostenartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MItarbeiterIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BezeichnungColumn;
        private System.Windows.Forms.Button button1;
    }
}