
using System.Windows.Forms;

namespace ProjektManagementSystem
{
    partial class AddVorgehensmodelForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.editPhasenButton = new System.Windows.Forms.Button();
            this.phasenZumTitelLabel = new System.Windows.Forms.Label();
            this.phasenLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 36);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Ok";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.Location = new System.Drawing.Point(13, 41);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(75, 13);
            this.labelBeschreibung.TabIndex = 6;
            this.labelBeschreibung.Text = "Beschreibung:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(57, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(255, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.AcceptsReturn = true;
            this.beschreibungTextBox.Location = new System.Drawing.Point(16, 57);
            this.beschreibungTextBox.Multiline = true;
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(296, 119);
            this.beschreibungTextBox.TabIndex = 2;
            // 
            // editPhasenButton
            // 
            this.editPhasenButton.Location = new System.Drawing.Point(221, 206);
            this.editPhasenButton.Name = "editPhasenButton";
            this.editPhasenButton.Size = new System.Drawing.Size(91, 36);
            this.editPhasenButton.TabIndex = 3;
            this.editPhasenButton.Text = "Phasen bearbeiten";
            this.editPhasenButton.UseVisualStyleBackColor = true;
            this.editPhasenButton.Click += new System.EventHandler(this.editPhasenButton_Click);
            // 
            // phasenZumTitelLabel
            // 
            this.phasenZumTitelLabel.AutoSize = true;
            this.phasenZumTitelLabel.Location = new System.Drawing.Point(13, 206);
            this.phasenZumTitelLabel.Name = "phasenZumTitelLabel";
            this.phasenZumTitelLabel.Size = new System.Drawing.Size(147, 13);
            this.phasenZumTitelLabel.TabIndex = 11;
            this.phasenZumTitelLabel.Text = "Phasen zum Vorgehensmodel";
            // 
            // phasenLbl
            // 
            this.phasenLbl.AutoSize = true;
            this.phasenLbl.Location = new System.Drawing.Point(34, 230);
            this.phasenLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.phasenLbl.Name = "phasenLbl";
            this.phasenLbl.Size = new System.Drawing.Size(10, 13);
            this.phasenLbl.TabIndex = 11;
            this.phasenLbl.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddVorgehensmodelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 428);
            this.Controls.Add(this.phasenLbl);
            this.Controls.Add(this.phasenZumTitelLabel);
            this.Controls.Add(this.editPhasenButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.beschreibungTextBox);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(340, 467);
            this.MinimumSize = new System.Drawing.Size(340, 467);
            this.Name = "AddVorgehensmodelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vorgensmodel hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.Button editPhasenButton;
        private System.Windows.Forms.Label phasenZumTitelLabel;
        private System.Windows.Forms.Label phasenLbl;
        private Button button1;
    }
}