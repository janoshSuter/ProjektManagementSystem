
namespace ProjektManagementSystem
{
    partial class AddMitarbeiterForm
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
            this.VornameTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.abteilungTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arbeitspensumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.funktionsbeschreibungTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(95, 264);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 36);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Ok";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // VornameTextBox
            // 
            this.VornameTextBox.Location = new System.Drawing.Point(118, 12);
            this.VornameTextBox.Name = "VornameTextBox";
            this.VornameTextBox.Size = new System.Drawing.Size(150, 20);
            this.VornameTextBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "*Voranme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "*Nachname:";
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.Location = new System.Drawing.Point(118, 38);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nachnameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Abteilung:";
            // 
            // abteilungTextBox
            // 
            this.abteilungTextBox.Location = new System.Drawing.Point(118, 64);
            this.abteilungTextBox.Name = "abteilungTextBox";
            this.abteilungTextBox.Size = new System.Drawing.Size(150, 20);
            this.abteilungTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Arbeitspensum (in %):";
            // 
            // arbeitspensumTextBox
            // 
            this.arbeitspensumTextBox.Location = new System.Drawing.Point(118, 90);
            this.arbeitspensumTextBox.Name = "arbeitspensumTextBox";
            this.arbeitspensumTextBox.Size = new System.Drawing.Size(150, 20);
            this.arbeitspensumTextBox.TabIndex = 4;
            this.arbeitspensumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Funktionbeschreibung:";
            // 
            // funktionsbeschreibungTextBox
            // 
            this.funktionsbeschreibungTextBox.AcceptsReturn = true;
            this.funktionsbeschreibungTextBox.Location = new System.Drawing.Point(12, 135);
            this.funktionsbeschreibungTextBox.Multiline = true;
            this.funktionsbeschreibungTextBox.Name = "funktionsbeschreibungTextBox";
            this.funktionsbeschreibungTextBox.Size = new System.Drawing.Size(256, 123);
            this.funktionsbeschreibungTextBox.TabIndex = 5;
            // 
            // AddMitarbeiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 307);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.funktionsbeschreibungTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arbeitspensumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.abteilungTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VornameTextBox);
            this.Controls.Add(this.labelName);
            this.Name = "AddMitarbeiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vorgensmodel hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox VornameTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox abteilungTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arbeitspensumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox funktionsbeschreibungTextBox;
    }
}