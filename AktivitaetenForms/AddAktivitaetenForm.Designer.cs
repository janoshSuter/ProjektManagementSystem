
using System.Windows.Forms;

namespace ProjektManagementSystem.VorgehensmodelForms
{
    partial class AddAktivitaetenForm
    {

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.DateTimePicker startdatumGeplantDatePicker;
        private System.Windows.Forms.DateTimePicker startdatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker enddatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker enddatumGeplantDatePicker;
        private System.Windows.Forms.ComboBox verantwortlicherComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fortschrittTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AbbruchButton;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.startdatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.verantwortlicherComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fortschrittTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AbbruchButton = new System.Windows.Forms.Button();
            this.activateStartEffektivDatePicker = new System.Windows.Forms.Button();
            this.activateEnddateEffektivDatePicker = new System.Windows.Forms.Button();
            this.kostenEditButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.externeKostenLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ressourcenLabel = new System.Windows.Forms.Label();
            this.ressourceEditButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verantwortlicher Mitarbeiter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Beschreibung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Starddatum Geplant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Starddatum Effektiv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enddatum Geplant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enddatum Effektiv";
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.AcceptsReturn = true;
            this.beschreibungTextBox.Location = new System.Drawing.Point(16, 63);
            this.beschreibungTextBox.Multiline = true;
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(699, 66);
            this.beschreibungTextBox.TabIndex = 3;
            // 
            // startdatumGeplantDatePicker
            // 
            this.startdatumGeplantDatePicker.Location = new System.Drawing.Point(139, 216);
            this.startdatumGeplantDatePicker.Name = "startdatumGeplantDatePicker";
            this.startdatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumGeplantDatePicker.TabIndex = 5;
            // 
            // startdatumEffektivDatePicker
            // 
            this.startdatumEffektivDatePicker.Location = new System.Drawing.Point(483, 218);
            this.startdatumEffektivDatePicker.Name = "startdatumEffektivDatePicker";
            this.startdatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumEffektivDatePicker.TabIndex = 6;
            // 
            // enddatumEffektivDatePicker
            // 
            this.enddatumEffektivDatePicker.Location = new System.Drawing.Point(483, 262);
            this.enddatumEffektivDatePicker.Name = "enddatumEffektivDatePicker";
            this.enddatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.enddatumEffektivDatePicker.TabIndex = 9;
            // 
            // enddatumGeplantDatePicker
            // 
            this.enddatumGeplantDatePicker.Location = new System.Drawing.Point(139, 265);
            this.enddatumGeplantDatePicker.Name = "enddatumGeplantDatePicker";
            this.enddatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.enddatumGeplantDatePicker.TabIndex = 8;
            // 
            // verantwortlicherComboBox
            // 
            this.verantwortlicherComboBox.FormattingEnabled = true;
            this.verantwortlicherComboBox.Location = new System.Drawing.Point(157, 15);
            this.verantwortlicherComboBox.Name = "verantwortlicherComboBox";
            this.verantwortlicherComboBox.Size = new System.Drawing.Size(182, 21);
            this.verantwortlicherComboBox.TabIndex = 1;
            this.verantwortlicherComboBox.SelectedIndexChanged += new System.EventHandler(this.verantwortlicherComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Budget (CHF): ";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(483, 140);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(113, 20);
            this.budgetTextBox.TabIndex = 4;
            this.budgetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fortschritt (in %) ";
            // 
            // fortschrittTextBox
            // 
            this.fortschrittTextBox.Location = new System.Drawing.Point(483, 15);
            this.fortschrittTextBox.MaxLength = 3;
            this.fortschrittTextBox.Name = "fortschrittTextBox";
            this.fortschrittTextBox.Size = new System.Drawing.Size(113, 20);
            this.fortschrittTextBox.TabIndex = 2;
            this.fortschrittTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(604, 508);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 32);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "OK";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AbbruchButton
            // 
            this.AbbruchButton.Location = new System.Drawing.Point(486, 508);
            this.AbbruchButton.Name = "AbbruchButton";
            this.AbbruchButton.Size = new System.Drawing.Size(112, 32);
            this.AbbruchButton.TabIndex = 15;
            this.AbbruchButton.Text = "Abbrechen";
            this.AbbruchButton.UseVisualStyleBackColor = true;
            this.AbbruchButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // activateStartEffektivDatePicker
            // 
            this.activateStartEffektivDatePicker.Location = new System.Drawing.Point(689, 217);
            this.activateStartEffektivDatePicker.Name = "activateStartEffektivDatePicker";
            this.activateStartEffektivDatePicker.Size = new System.Drawing.Size(26, 20);
            this.activateStartEffektivDatePicker.TabIndex = 7;
            this.activateStartEffektivDatePicker.Text = "+";
            this.activateStartEffektivDatePicker.UseVisualStyleBackColor = true;
            this.activateStartEffektivDatePicker.Click += new System.EventHandler(this.activateStartEffektivDatePicker_Click);
            // 
            // activateEnddateEffektivDatePicker
            // 
            this.activateEnddateEffektivDatePicker.Location = new System.Drawing.Point(689, 262);
            this.activateEnddateEffektivDatePicker.Name = "activateEnddateEffektivDatePicker";
            this.activateEnddateEffektivDatePicker.Size = new System.Drawing.Size(26, 20);
            this.activateEnddateEffektivDatePicker.TabIndex = 10;
            this.activateEnddateEffektivDatePicker.Text = "+";
            this.activateEnddateEffektivDatePicker.UseVisualStyleBackColor = true;
            this.activateEnddateEffektivDatePicker.Click += new System.EventHandler(this.activateEndEffektiveDatePicker_Click);
            // 
            // kostenEditButton
            // 
            this.kostenEditButton.Location = new System.Drawing.Point(604, 288);
            this.kostenEditButton.Name = "kostenEditButton";
            this.kostenEditButton.Size = new System.Drawing.Size(112, 42);
            this.kostenEditButton.TabIndex = 12;
            this.kostenEditButton.Text = "Kosten bearbeiten";
            this.kostenEditButton.UseVisualStyleBackColor = true;
            this.kostenEditButton.Click += new System.EventHandler(this.externeKostenBearbeitenButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Externe Kosten";
            // 
            // externeKostenLabel
            // 
            this.externeKostenLabel.AutoSize = true;
            this.externeKostenLabel.Location = new System.Drawing.Point(414, 326);
            this.externeKostenLabel.Name = "externeKostenLabel";
            this.externeKostenLabel.Size = new System.Drawing.Size(10, 13);
            this.externeKostenLabel.TabIndex = 0;
            this.externeKostenLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ressourcen";
            // 
            // ressourcenLabel
            // 
            this.ressourcenLabel.AutoSize = true;
            this.ressourcenLabel.Location = new System.Drawing.Point(60, 335);
            this.ressourcenLabel.Name = "ressourcenLabel";
            this.ressourcenLabel.Size = new System.Drawing.Size(10, 13);
            this.ressourcenLabel.TabIndex = 0;
            this.ressourcenLabel.Text = "-";
            // 
            // ressourceEditButton
            // 
            this.ressourceEditButton.Location = new System.Drawing.Point(227, 291);
            this.ressourceEditButton.Name = "ressourceEditButton";
            this.ressourceEditButton.Size = new System.Drawing.Size(112, 42);
            this.ressourceEditButton.TabIndex = 11;
            this.ressourceEditButton.Text = "Ressourcen bearbeiten";
            this.ressourceEditButton.UseVisualStyleBackColor = true;
            this.ressourceEditButton.Click += new System.EventHandler(this.ressourcenBearbeitenButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 518);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Aktivitaetendokumente einsehen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddAktivitaetenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 552);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.activateEnddateEffektivDatePicker);
            this.Controls.Add(this.activateStartEffektivDatePicker);
            this.Controls.Add(this.AbbruchButton);
            this.Controls.Add(this.ressourceEditButton);
            this.Controls.Add(this.kostenEditButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.fortschrittTextBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.verantwortlicherComboBox);
            this.Controls.Add(this.enddatumGeplantDatePicker);
            this.Controls.Add(this.enddatumEffektivDatePicker);
            this.Controls.Add(this.startdatumEffektivDatePicker);
            this.Controls.Add(this.startdatumGeplantDatePicker);
            this.Controls.Add(this.beschreibungTextBox);
            this.Controls.Add(this.ressourcenLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.externeKostenLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAktivitaetenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAkvititaetenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button activateStartEffektivDatePicker;
        private Button activateEnddateEffektivDatePicker;
        private Button kostenEditButton;
        private Label label9;
        private Label externeKostenLabel;
        private Label label11;
        private Label ressourcenLabel;
        private Button ressourceEditButton;
        private LinkLabel linkLabel1;
    }
}