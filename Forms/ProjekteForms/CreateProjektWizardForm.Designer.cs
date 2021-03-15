
using System.Windows.Forms;

namespace ProjektManagementSystem.ProjekteForms
{
    partial class CreateProjektWizardForm
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
            this.createProjectWizard = new AeroWizard.WizardControl();
            this.wizardPage1 = new AeroWizard.WizardPage();
            this.bewilligunsdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.enddatumGeplantDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatumGeplantDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.prioritaetTextBox = new System.Windows.Forms.TextBox();
            this.projektnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wizardPage2 = new AeroWizard.WizardPage();
            this.vorgehensmodelBeschreibunglbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vorgehensmodelComboBox = new System.Windows.Forms.ComboBox();
            this.wizardPage3 = new AeroWizard.WizardPage();
            this.projektleiterComboBox = new System.Windows.Forms.ComboBox();
            this.MitarbeiterInfoLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.createProjectWizard)).BeginInit();
            this.wizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            this.wizardPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // createProjectWizard
            // 
            this.createProjectWizard.BackColor = System.Drawing.Color.White;
            this.createProjectWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createProjectWizard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProjectWizard.Location = new System.Drawing.Point(0, 0);
            this.createProjectWizard.Name = "createProjectWizard";
            this.createProjectWizard.Pages.Add(this.wizardPage1);
            this.createProjectWizard.Pages.Add(this.wizardPage2);
            this.createProjectWizard.Pages.Add(this.wizardPage3);
            this.createProjectWizard.Size = new System.Drawing.Size(662, 464);
            this.createProjectWizard.TabIndex = 0;
            this.createProjectWizard.Title = "Neues Projekt erstellen";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.bewilligunsdatumDateTimePicker);
            this.wizardPage1.Controls.Add(this.label8);
            this.wizardPage1.Controls.Add(this.enddatumGeplantDateTimePicker);
            this.wizardPage1.Controls.Add(this.startdatumGeplantDateTimePicker);
            this.wizardPage1.Controls.Add(this.beschreibungTextBox);
            this.wizardPage1.Controls.Add(this.prioritaetTextBox);
            this.wizardPage1.Controls.Add(this.projektnameTextBox);
            this.wizardPage1.Controls.Add(this.label5);
            this.wizardPage1.Controls.Add(this.label4);
            this.wizardPage1.Controls.Add(this.label3);
            this.wizardPage1.Controls.Add(this.label2);
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(615, 310);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Text = "Projektstammdaten erfassen";
            // 
            // bewilligunsdatumDateTimePicker
            // 
            this.bewilligunsdatumDateTimePicker.Location = new System.Drawing.Point(140, 142);
            this.bewilligunsdatumDateTimePicker.Name = "bewilligunsdatumDateTimePicker";
            this.bewilligunsdatumDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.bewilligunsdatumDateTimePicker.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "*Beweilgungsatum";
            // 
            // enddatumGeplantDateTimePicker
            // 
            this.enddatumGeplantDateTimePicker.Location = new System.Drawing.Point(141, 208);
            this.enddatumGeplantDateTimePicker.Name = "enddatumGeplantDateTimePicker";
            this.enddatumGeplantDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.enddatumGeplantDateTimePicker.TabIndex = 2;
            // 
            // startdatumGeplantDateTimePicker
            // 
            this.startdatumGeplantDateTimePicker.Location = new System.Drawing.Point(141, 174);
            this.startdatumGeplantDateTimePicker.Name = "startdatumGeplantDateTimePicker";
            this.startdatumGeplantDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.startdatumGeplantDateTimePicker.TabIndex = 2;
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.AcceptsReturn = true;
            this.beschreibungTextBox.Location = new System.Drawing.Point(141, 51);
            this.beschreibungTextBox.Multiline = true;
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(459, 85);
            this.beschreibungTextBox.TabIndex = 1;
            // 
            // prioritaetTextBox
            // 
            this.prioritaetTextBox.Location = new System.Drawing.Point(141, 250);
            this.prioritaetTextBox.Name = "prioritaetTextBox";
            this.prioritaetTextBox.Size = new System.Drawing.Size(100, 23);
            this.prioritaetTextBox.TabIndex = 1;
            // 
            // projektnameTextBox
            // 
            this.projektnameTextBox.Location = new System.Drawing.Point(141, 13);
            this.projektnameTextBox.Name = "projektnameTextBox";
            this.projektnameTextBox.Size = new System.Drawing.Size(200, 23);
            this.projektnameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Enddatum geplant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Startdatum geplant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Priorität";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Beschreibung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Projektname";
            // 
            // wizardPage2
            // 
            this.wizardPage2.AllowNext = false;
            this.wizardPage2.Controls.Add(this.vorgehensmodelBeschreibunglbl);
            this.wizardPage2.Controls.Add(this.label7);
            this.wizardPage2.Controls.Add(this.label6);
            this.wizardPage2.Controls.Add(this.vorgehensmodelComboBox);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(615, 310);
            this.wizardPage2.TabIndex = 1;
            this.wizardPage2.Text = "Vorgehensmodel auswählen";
            // 
            // vorgehensmodelBeschreibunglbl
            // 
            this.vorgehensmodelBeschreibunglbl.AutoSize = true;
            this.vorgehensmodelBeschreibunglbl.Location = new System.Drawing.Point(120, 108);
            this.vorgehensmodelBeschreibunglbl.Name = "vorgehensmodelBeschreibunglbl";
            this.vorgehensmodelBeschreibunglbl.Size = new System.Drawing.Size(12, 15);
            this.vorgehensmodelBeschreibunglbl.TabIndex = 1;
            this.vorgehensmodelBeschreibunglbl.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Beschreibung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "*Vorgehensmodel";
            // 
            // vorgehensmodelComboBox
            // 
            this.vorgehensmodelComboBox.FormattingEnabled = true;
            this.vorgehensmodelComboBox.Location = new System.Drawing.Point(123, 50);
            this.vorgehensmodelComboBox.Name = "vorgehensmodelComboBox";
            this.vorgehensmodelComboBox.Size = new System.Drawing.Size(354, 23);
            this.vorgehensmodelComboBox.TabIndex = 0;
            this.vorgehensmodelComboBox.SelectedIndexChanged += new System.EventHandler(this.vorgehensmodelComboBox_SelectedIndexChanged);
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.projektleiterComboBox);
            this.wizardPage3.Controls.Add(this.MitarbeiterInfoLbl);
            this.wizardPage3.Controls.Add(this.label10);
            this.wizardPage3.Controls.Add(this.label9);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(615, 310);
            this.wizardPage3.TabIndex = 2;
            this.wizardPage3.Text = "Page Title";
            this.wizardPage3.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wizardPage3_Commit);
            // 
            // projektleiterComboBox
            // 
            this.projektleiterComboBox.FormattingEnabled = true;
            this.projektleiterComboBox.Location = new System.Drawing.Point(228, 63);
            this.projektleiterComboBox.Name = "projektleiterComboBox";
            this.projektleiterComboBox.Size = new System.Drawing.Size(269, 23);
            this.projektleiterComboBox.TabIndex = 2;
            this.projektleiterComboBox.SelectedIndexChanged += new System.EventHandler(this.projektleiterComboBox_SelectedIndexChanged);
            // 
            // MitarbeiterInfoLbl
            // 
            this.MitarbeiterInfoLbl.AutoSize = true;
            this.MitarbeiterInfoLbl.Location = new System.Drawing.Point(225, 121);
            this.MitarbeiterInfoLbl.Name = "MitarbeiterInfoLbl";
            this.MitarbeiterInfoLbl.Size = new System.Drawing.Size(12, 15);
            this.MitarbeiterInfoLbl.TabIndex = 1;
            this.MitarbeiterInfoLbl.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "MItarbeiter Informationen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "*Projektleiter";
            // 
            // CreateProjektWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 464);
            this.Controls.Add(this.createProjectWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(678, 503);
            this.MinimumSize = new System.Drawing.Size(678, 503);
            this.Name = "CreateProjektWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekte Erstellen";
            ((System.ComponentModel.ISupportInitialize)(this.createProjectWizard)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl createProjectWizard;
        private AeroWizard.WizardPage wizardPage1;
        private System.Windows.Forms.TextBox projektnameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker enddatumGeplantDateTimePicker;
        private System.Windows.Forms.DateTimePicker startdatumGeplantDateTimePicker;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.TextBox prioritaetTextBox;
        private AeroWizard.WizardPage wizardPage2;
        private System.Windows.Forms.DateTimePicker bewilligunsdatumDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label vorgehensmodelBeschreibunglbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox vorgehensmodelComboBox;
        private AeroWizard.WizardPage wizardPage3;
        private System.Windows.Forms.ComboBox projektleiterComboBox;
        private System.Windows.Forms.Label MitarbeiterInfoLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}