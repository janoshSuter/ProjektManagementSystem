
using System.Windows.Forms;

namespace ProjektManagementSystem
{
    partial class ProjekteDetailsForm
    {

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.projektTitelTextBox = new System.Windows.Forms.TextBox();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endDatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatumEffektivDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.startdatumGeplantDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.fortschrittTextBox = new System.Windows.Forms.TextBox();
            this.bewilligungsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.activateStartEffektivDatePicker = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vorgehensmodelComboBox = new System.Windows.Forms.ComboBox();
            this.projektleiterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekttitel";
            // 
            // projektTitelTextBox
            // 
            this.projektTitelTextBox.Location = new System.Drawing.Point(140, 16);
            this.projektTitelTextBox.Name = "projektTitelTextBox";
            this.projektTitelTextBox.Size = new System.Drawing.Size(258, 20);
            this.projektTitelTextBox.TabIndex = 1;
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.AcceptsReturn = true;
            this.beschreibungTextBox.Location = new System.Drawing.Point(140, 56);
            this.beschreibungTextBox.Multiline = true;
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(258, 60);
            this.beschreibungTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beschreibung";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(140, 166);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // prioTextBox
            // 
            this.prioTextBox.Location = new System.Drawing.Point(140, 131);
            this.prioTextBox.Name = "prioTextBox";
            this.prioTextBox.Size = new System.Drawing.Size(100, 20);
            this.prioTextBox.TabIndex = 5;
            this.prioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prioriät";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enddatum geplant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bewilligungsdatum";
            // 
            // endDatumGeplantDatePicker
            // 
            this.endDatumGeplantDatePicker.Enabled = false;
            this.endDatumGeplantDatePicker.Location = new System.Drawing.Point(140, 250);
            this.endDatumGeplantDatePicker.Name = "endDatumGeplantDatePicker";
            this.endDatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatumGeplantDatePicker.TabIndex = 11;
            // 
            // endDatumEffektivDatePicker
            // 
            this.endDatumEffektivDatePicker.Location = new System.Drawing.Point(538, 243);
            this.endDatumEffektivDatePicker.Name = "endDatumEffektivDatePicker";
            this.endDatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatumEffektivDatePicker.TabIndex = 14;
            // 
            // startdatumEffektivDatePicker
            // 
            this.startdatumEffektivDatePicker.Location = new System.Drawing.Point(538, 199);
            this.startdatumEffektivDatePicker.Name = "startdatumEffektivDatePicker";
            this.startdatumEffektivDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumEffektivDatePicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enddatum effektiv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Startdatum effektiv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Vorgehensmodel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Projektleiter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Startdatum geplant";
            // 
            // startdatumGeplantDatePicker
            // 
            this.startdatumGeplantDatePicker.Enabled = false;
            this.startdatumGeplantDatePicker.Location = new System.Drawing.Point(140, 206);
            this.startdatumGeplantDatePicker.Name = "startdatumGeplantDatePicker";
            this.startdatumGeplantDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumGeplantDatePicker.TabIndex = 15;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(506, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 36);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(641, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 36);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(29, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(139, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Projektdokumente einsehen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Fortschritt";
            // 
            // fortschrittTextBox
            // 
            this.fortschrittTextBox.Location = new System.Drawing.Point(140, 293);
            this.fortschrittTextBox.Name = "fortschrittTextBox";
            this.fortschrittTextBox.Size = new System.Drawing.Size(100, 20);
            this.fortschrittTextBox.TabIndex = 5;
            // 
            // bewilligungsDatePicker
            // 
            this.bewilligungsDatePicker.Location = new System.Drawing.Point(538, 16);
            this.bewilligungsDatePicker.Name = "bewilligungsDatePicker";
            this.bewilligungsDatePicker.Size = new System.Drawing.Size(200, 20);
            this.bewilligungsDatePicker.TabIndex = 15;
            // 
            // activateStartEffektivDatePicker
            // 
            this.activateStartEffektivDatePicker.Location = new System.Drawing.Point(744, 199);
            this.activateStartEffektivDatePicker.Name = "activateStartEffektivDatePicker";
            this.activateStartEffektivDatePicker.Size = new System.Drawing.Size(26, 20);
            this.activateStartEffektivDatePicker.TabIndex = 18;
            this.activateStartEffektivDatePicker.Text = "+";
            this.activateStartEffektivDatePicker.UseVisualStyleBackColor = true;
            this.activateStartEffektivDatePicker.Click += new System.EventHandler(this.activateStartEffektivDatePicker_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.activateEndEffektiveDatePicker_Click);
            // 
            // vorgehensmodelComboBox
            // 
            this.vorgehensmodelComboBox.Enabled = false;
            this.vorgehensmodelComboBox.FormattingEnabled = true;
            this.vorgehensmodelComboBox.Location = new System.Drawing.Point(538, 59);
            this.vorgehensmodelComboBox.Name = "vorgehensmodelComboBox";
            this.vorgehensmodelComboBox.Size = new System.Drawing.Size(200, 21);
            this.vorgehensmodelComboBox.TabIndex = 19;
            this.vorgehensmodelComboBox.SelectedIndexChanged += new System.EventHandler(this.vorgehensmodelComboBox_SelectedIndexChanged);
            // 
            // projektleiterComboBox
            // 
            this.projektleiterComboBox.FormattingEnabled = true;
            this.projektleiterComboBox.Location = new System.Drawing.Point(538, 97);
            this.projektleiterComboBox.Name = "projektleiterComboBox";
            this.projektleiterComboBox.Size = new System.Drawing.Size(200, 21);
            this.projektleiterComboBox.TabIndex = 19;
            this.projektleiterComboBox.SelectedIndexChanged += new System.EventHandler(this.projektleiterComboBox_SelectedIndexChanged);
            // 
            // ProjekteDetailsForm
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(782, 389);
            this.Controls.Add(this.projektleiterComboBox);
            this.Controls.Add(this.vorgehensmodelComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activateStartEffektivDatePicker);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.endDatumEffektivDatePicker);
            this.Controls.Add(this.startdatumGeplantDatePicker);
            this.Controls.Add(this.bewilligungsDatePicker);
            this.Controls.Add(this.startdatumEffektivDatePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endDatumGeplantDatePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fortschrittTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.prioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beschreibungTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projektTitelTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProjekteDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projektTitelTextBox;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker bewilligungsDatePicker;
        private System.Windows.Forms.DateTimePicker endDatumGeplantDatePicker;
        private System.Windows.Forms.DateTimePicker endDatumEffektivDatePicker;
        private System.Windows.Forms.DateTimePicker startdatumEffektivDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker startdatumGeplantDatePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Label label12;
        private TextBox fortschrittTextBox;
        private Button activateStartEffektivDatePicker;
        private Button button1;
        private ComboBox vorgehensmodelComboBox;
        private ComboBox projektleiterComboBox;
    }
}

