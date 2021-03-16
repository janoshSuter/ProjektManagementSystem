
using System.Windows.Forms;

namespace ProjektManagementSystem.VorgehensmodelForms
{
    partial class AddPhaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aktivitaetenTitelLabel = new System.Windows.Forms.Label();
            this.aktivitaetenLabel = new System.Windows.Forms.Label();
            this.bezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.phasenFortschrittTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.startdatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reviewdatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reviewdatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.freigabedatumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.editAktivitaetenButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.AbrruchButton = new System.Windows.Forms.Button();
            this.activateStartEffektivButton = new System.Windows.Forms.Button();
            this.activateEndEffektivButton = new System.Windows.Forms.Button();
            this.activateFreigabeButton = new System.Windows.Forms.Button();
            this.meilensteinTitelLabel = new System.Windows.Forms.Label();
            this.meilensteineLabel = new System.Windows.Forms.Label();
            this.editMeilensteineButton = new System.Windows.Forms.Button();
            this.linkLabelDokumente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Bezeichnung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Phasenfortschritt (in %)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Phasenstatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Startdatum Effektiv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Startdatum Geplant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enddatum Effektiv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "*Enddatum Geplant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "*Reviewdatum Geplant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Reviewdatum Effektiv";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Freigabedatum";
            // 
            // aktivitaetenTitelLabel
            // 
            this.aktivitaetenTitelLabel.AutoSize = true;
            this.aktivitaetenTitelLabel.Location = new System.Drawing.Point(382, 249);
            this.aktivitaetenTitelLabel.Name = "aktivitaetenTitelLabel";
            this.aktivitaetenTitelLabel.Size = new System.Drawing.Size(57, 13);
            this.aktivitaetenTitelLabel.TabIndex = 1;
            this.aktivitaetenTitelLabel.Text = "Aktivitäten";
            // 
            // aktivitaetenLabel
            // 
            this.aktivitaetenLabel.AutoSize = true;
            this.aktivitaetenLabel.Location = new System.Drawing.Point(402, 275);
            this.aktivitaetenLabel.Name = "aktivitaetenLabel";
            this.aktivitaetenLabel.Size = new System.Drawing.Size(10, 13);
            this.aktivitaetenLabel.TabIndex = 1;
            this.aktivitaetenLabel.Text = "-";
            // 
            // bezeichnungTextBox
            // 
            this.bezeichnungTextBox.Location = new System.Drawing.Point(155, 13);
            this.bezeichnungTextBox.Name = "bezeichnungTextBox";
            this.bezeichnungTextBox.Size = new System.Drawing.Size(200, 20);
            this.bezeichnungTextBox.TabIndex = 1;
            // 
            // phasenFortschrittTextBox
            // 
            this.phasenFortschrittTextBox.Location = new System.Drawing.Point(155, 42);
            this.phasenFortschrittTextBox.MaxLength = 3;
            this.phasenFortschrittTextBox.Name = "phasenFortschrittTextBox";
            this.phasenFortschrittTextBox.Size = new System.Drawing.Size(199, 20);
            this.phasenFortschrittTextBox.TabIndex = 3;
            this.phasenFortschrittTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(526, 13);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(199, 20);
            this.statusTextBox.TabIndex = 2;
            // 
            // startdatumEffektivDatePicker
            // 
            this.startdatumEffektivDatePicker.Location = new System.Drawing.Point(525, 95);
            this.startdatumEffektivDatePicker.Name = "startdatumEffektivDatePicker";
            this.startdatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumEffektivDatePicker.TabIndex = 5;
            // 
            // startdatumGeplantDatePicker
            // 
            this.startdatumGeplantDatePicker.Location = new System.Drawing.Point(154, 95);
            this.startdatumGeplantDatePicker.Name = "startdatumGeplantDatePicker";
            this.startdatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumGeplantDatePicker.TabIndex = 4;
            // 
            // enddatumEffektivDatePicker
            // 
            this.enddatumEffektivDatePicker.Location = new System.Drawing.Point(525, 132);
            this.enddatumEffektivDatePicker.Name = "enddatumEffektivDatePicker";
            this.enddatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.enddatumEffektivDatePicker.TabIndex = 8;
            // 
            // enddatumGeplantDatePicker
            // 
            this.enddatumGeplantDatePicker.Location = new System.Drawing.Point(154, 132);
            this.enddatumGeplantDatePicker.Name = "enddatumGeplantDatePicker";
            this.enddatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.enddatumGeplantDatePicker.TabIndex = 7;
            // 
            // reviewdatumEffektivDatePicker
            // 
            this.reviewdatumEffektivDatePicker.Location = new System.Drawing.Point(524, 167);
            this.reviewdatumEffektivDatePicker.Name = "reviewdatumEffektivDatePicker";
            this.reviewdatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reviewdatumEffektivDatePicker.TabIndex = 12;
            // 
            // reviewdatumGeplantDatePicker
            // 
            this.reviewdatumGeplantDatePicker.Location = new System.Drawing.Point(154, 170);
            this.reviewdatumGeplantDatePicker.Name = "reviewdatumGeplantDatePicker";
            this.reviewdatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.reviewdatumGeplantDatePicker.TabIndex = 11;
            // 
            // freigabedatumDatePicker
            // 
            this.freigabedatumDatePicker.Location = new System.Drawing.Point(154, 209);
            this.freigabedatumDatePicker.Name = "freigabedatumDatePicker";
            this.freigabedatumDatePicker.Size = new System.Drawing.Size(200, 20);
            this.freigabedatumDatePicker.TabIndex = 14;
            // 
            // editAktivitaetenButton
            // 
            this.editAktivitaetenButton.Location = new System.Drawing.Point(636, 242);
            this.editAktivitaetenButton.Name = "editAktivitaetenButton";
            this.editAktivitaetenButton.Size = new System.Drawing.Size(121, 46);
            this.editAktivitaetenButton.TabIndex = 15;
            this.editAktivitaetenButton.Text = "Aktivitäten Bearbeiten";
            this.editAktivitaetenButton.UseVisualStyleBackColor = true;
            this.editAktivitaetenButton.Click += new System.EventHandler(this.editAktivitaetenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(636, 420);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 37);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AbrruchButton
            // 
            this.AbrruchButton.Location = new System.Drawing.Point(503, 420);
            this.AbrruchButton.Name = "AbrruchButton";
            this.AbrruchButton.Size = new System.Drawing.Size(127, 37);
            this.AbrruchButton.TabIndex = 16;
            this.AbrruchButton.Text = "Abbrechen";
            this.AbrruchButton.UseVisualStyleBackColor = true;
            this.AbrruchButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // activateStartEffektivButton
            // 
            this.activateStartEffektivButton.Location = new System.Drawing.Point(731, 95);
            this.activateStartEffektivButton.Name = "activateStartEffektivButton";
            this.activateStartEffektivButton.Size = new System.Drawing.Size(26, 20);
            this.activateStartEffektivButton.TabIndex = 6;
            this.activateStartEffektivButton.Text = "+";
            this.activateStartEffektivButton.UseVisualStyleBackColor = true;
            this.activateStartEffektivButton.Click += new System.EventHandler(this.activateStartEffektivDatePicker_Click);
            // 
            // activateEndEffektivButton
            // 
            this.activateEndEffektivButton.Location = new System.Drawing.Point(730, 132);
            this.activateEndEffektivButton.Name = "activateEndEffektivButton";
            this.activateEndEffektivButton.Size = new System.Drawing.Size(26, 20);
            this.activateEndEffektivButton.TabIndex = 9;
            this.activateEndEffektivButton.Text = "+";
            this.activateEndEffektivButton.UseVisualStyleBackColor = true;
            this.activateEndEffektivButton.Click += new System.EventHandler(this.activateEndEffektiveDatePicker_Click);
            // 
            // activateFreigabeButton
            // 
            this.activateFreigabeButton.Location = new System.Drawing.Point(730, 167);
            this.activateFreigabeButton.Name = "activateFreigabeButton";
            this.activateFreigabeButton.Size = new System.Drawing.Size(26, 20);
            this.activateFreigabeButton.TabIndex = 13;
            this.activateFreigabeButton.Text = "+";
            this.activateFreigabeButton.UseVisualStyleBackColor = true;
            this.activateFreigabeButton.Click += new System.EventHandler(this.activateFreigabeDatePicker_Click);
            // 
            // meilensteinTitelLabel
            // 
            this.meilensteinTitelLabel.AutoSize = true;
            this.meilensteinTitelLabel.Location = new System.Drawing.Point(13, 242);
            this.meilensteinTitelLabel.Name = "meilensteinTitelLabel";
            this.meilensteinTitelLabel.Size = new System.Drawing.Size(66, 13);
            this.meilensteinTitelLabel.TabIndex = 1;
            this.meilensteinTitelLabel.Text = "Meilensteine";
            // 
            // meilensteineLabel
            // 
            this.meilensteineLabel.AutoSize = true;
            this.meilensteineLabel.Location = new System.Drawing.Point(43, 275);
            this.meilensteineLabel.Name = "meilensteineLabel";
            this.meilensteineLabel.Size = new System.Drawing.Size(10, 13);
            this.meilensteineLabel.TabIndex = 1;
            this.meilensteineLabel.Text = "-";
            // 
            // editMeilensteineButton
            // 
            this.editMeilensteineButton.Location = new System.Drawing.Point(234, 242);
            this.editMeilensteineButton.Name = "editMeilensteineButton";
            this.editMeilensteineButton.Size = new System.Drawing.Size(121, 46);
            this.editMeilensteineButton.TabIndex = 15;
            this.editMeilensteineButton.Text = "Meilensteine Bearbeiten";
            this.editMeilensteineButton.UseVisualStyleBackColor = true;
            this.editMeilensteineButton.Click += new System.EventHandler(this.editMeilensteinenButton_Click);
            // 
            // linkLabelDokumente
            // 
            this.linkLabelDokumente.AutoSize = true;
            this.linkLabelDokumente.Location = new System.Drawing.Point(381, 212);
            this.linkLabelDokumente.Name = "linkLabelDokumente";
            this.linkLabelDokumente.Size = new System.Drawing.Size(142, 13);
            this.linkLabelDokumente.TabIndex = 20;
            this.linkLabelDokumente.TabStop = true;
            this.linkLabelDokumente.Text = "Phasendokumente einsehen";
            this.linkLabelDokumente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddPhaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 466);
            this.Controls.Add(this.linkLabelDokumente);
            this.Controls.Add(this.activateFreigabeButton);
            this.Controls.Add(this.activateEndEffektivButton);
            this.Controls.Add(this.activateStartEffektivButton);
            this.Controls.Add(this.AbrruchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editMeilensteineButton);
            this.Controls.Add(this.editAktivitaetenButton);
            this.Controls.Add(this.freigabedatumDatePicker);
            this.Controls.Add(this.reviewdatumGeplantDatePicker);
            this.Controls.Add(this.reviewdatumEffektivDatePicker);
            this.Controls.Add(this.enddatumGeplantDatePicker);
            this.Controls.Add(this.enddatumEffektivDatePicker);
            this.Controls.Add(this.startdatumGeplantDatePicker);
            this.Controls.Add(this.startdatumEffektivDatePicker);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.phasenFortschrittTextBox);
            this.Controls.Add(this.meilensteineLabel);
            this.Controls.Add(this.bezeichnungTextBox);
            this.Controls.Add(this.meilensteinTitelLabel);
            this.Controls.Add(this.aktivitaetenLabel);
            this.Controls.Add(this.aktivitaetenTitelLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(785, 505);
            this.MinimumSize = new System.Drawing.Size(785, 505);
            this.Name = "AddPhaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label aktivitaetenTitelLabel;
        private System.Windows.Forms.Label aktivitaetenLabel;
        private System.Windows.Forms.TextBox bezeichnungTextBox;
        private System.Windows.Forms.TextBox phasenFortschrittTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker startdatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker startdatumGeplantDatePicker;
        private System.Windows.Forms.DateTimePicker enddatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker enddatumGeplantDatePicker;
        private System.Windows.Forms.DateTimePicker reviewdatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker reviewdatumGeplantDatePicker;
        private System.Windows.Forms.DateTimePicker freigabedatumDatePicker;
        private System.Windows.Forms.Button editAktivitaetenButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button AbrruchButton;
        private System.Windows.Forms.Button activateStartEffektivButton;
        private System.Windows.Forms.Button activateEndEffektivButton;
        private System.Windows.Forms.Button activateFreigabeButton;
        private Label meilensteinTitelLabel;
        private Label meilensteineLabel;
        private Button editMeilensteineButton;
        private LinkLabel linkLabelDokumente;
    }
}