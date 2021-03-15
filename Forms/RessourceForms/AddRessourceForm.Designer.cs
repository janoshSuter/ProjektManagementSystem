
using System.Windows.Forms;

namespace ProjektManagementSystem.RessourceForms
{
    partial class AddRessourceForm
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
            this.funktionTextBox = new System.Windows.Forms.TextBox();
            this.pensumTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.AbrruchButton = new System.Windows.Forms.Button();
            this.mitarbeiterComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stundenGeplantTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stundenEffektivTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Mitarbeiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Funktion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Pensum";
            // 
            // funktionTextBox
            // 
            this.funktionTextBox.Location = new System.Drawing.Point(87, 55);
            this.funktionTextBox.MaxLength = 600;
            this.funktionTextBox.Name = "funktionTextBox";
            this.funktionTextBox.Size = new System.Drawing.Size(199, 20);
            this.funktionTextBox.TabIndex = 3;
            // 
            // pensumTextBox
            // 
            this.pensumTextBox.Location = new System.Drawing.Point(441, 16);
            this.pensumTextBox.Name = "pensumTextBox";
            this.pensumTextBox.Size = new System.Drawing.Size(195, 20);
            this.pensumTextBox.TabIndex = 2;
            this.pensumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(515, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AbrruchButton
            // 
            this.AbrruchButton.Location = new System.Drawing.Point(382, 112);
            this.AbrruchButton.Name = "AbrruchButton";
            this.AbrruchButton.Size = new System.Drawing.Size(127, 37);
            this.AbrruchButton.TabIndex = 6;
            this.AbrruchButton.Text = "Abbrechen";
            this.AbrruchButton.UseVisualStyleBackColor = true;
            this.AbrruchButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mitarbeiterComboBox
            // 
            this.mitarbeiterComboBox.FormattingEnabled = true;
            this.mitarbeiterComboBox.Location = new System.Drawing.Point(87, 19);
            this.mitarbeiterComboBox.Name = "mitarbeiterComboBox";
            this.mitarbeiterComboBox.Size = new System.Drawing.Size(199, 21);
            this.mitarbeiterComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Stunden geplant:";
            // 
            // stundenGeplantTextBox
            // 
            this.stundenGeplantTextBox.Location = new System.Drawing.Point(444, 55);
            this.stundenGeplantTextBox.MaxLength = 4;
            this.stundenGeplantTextBox.Name = "stundenGeplantTextBox";
            this.stundenGeplantTextBox.Size = new System.Drawing.Size(42, 20);
            this.stundenGeplantTextBox.TabIndex = 4;
            this.stundenGeplantTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "h";
            // 
            // stundenEffektivTextBox
            // 
            this.stundenEffektivTextBox.Location = new System.Drawing.Point(594, 55);
            this.stundenEffektivTextBox.MaxLength = 4;
            this.stundenEffektivTextBox.Name = "stundenEffektivTextBox";
            this.stundenEffektivTextBox.Size = new System.Drawing.Size(42, 20);
            this.stundenEffektivTextBox.TabIndex = 5;
            this.stundenEffektivTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "effektiv:";
            // 
            // AddRessourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 161);
            this.Controls.Add(this.mitarbeiterComboBox);
            this.Controls.Add(this.AbrruchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pensumTextBox);
            this.Controls.Add(this.stundenEffektivTextBox);
            this.Controls.Add(this.stundenGeplantTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.funktionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(675, 200);
            this.MinimumSize = new System.Drawing.Size(675, 200);
            this.Name = "AddRessourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRessourceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox funktionTextBox;
        private System.Windows.Forms.TextBox pensumTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button AbrruchButton;
        private ComboBox mitarbeiterComboBox;
        private Label label4;
        private TextBox stundenGeplantTextBox;
        private Label label5;
        private Label label6;
        private TextBox stundenEffektivTextBox;
        private Label label7;
    }
}