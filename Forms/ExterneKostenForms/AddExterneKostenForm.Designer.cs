
using System.Windows.Forms;

namespace ProjektManagementSystem.ExterneKostenForms
{
    partial class AddExterneKostenForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.abweichungsgrundTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.AbrruchButton = new System.Windows.Forms.Button();
            this.kostenartComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kostenGeplantTextBox = new System.Windows.Forms.TextBox();
            this.kostenEffektivTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kostenart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Abweichungsbegründung";
            // 
            // abweichungsgrundTextBox
            // 
            this.abweichungsgrundTextBox.AcceptsReturn = true;
            this.abweichungsgrundTextBox.Location = new System.Drawing.Point(141, 55);
            this.abweichungsgrundTextBox.Multiline = true;
            this.abweichungsgrundTextBox.Name = "abweichungsgrundTextBox";
            this.abweichungsgrundTextBox.Size = new System.Drawing.Size(495, 51);
            this.abweichungsgrundTextBox.TabIndex = 4;
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
            this.AbrruchButton.TabIndex = 5;
            this.AbrruchButton.Text = "Abbrechen";
            this.AbrruchButton.UseVisualStyleBackColor = true;
            this.AbrruchButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // kostenartComboBox
            // 
            this.kostenartComboBox.FormattingEnabled = true;
            this.kostenartComboBox.Location = new System.Drawing.Point(141, 19);
            this.kostenartComboBox.Name = "kostenartComboBox";
            this.kostenartComboBox.Size = new System.Drawing.Size(199, 21);
            this.kostenartComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Kosten geplant:";
            // 
            // kostenGeplantTextBox
            // 
            this.kostenGeplantTextBox.Location = new System.Drawing.Point(467, 19);
            this.kostenGeplantTextBox.MaxLength = 2;
            this.kostenGeplantTextBox.Name = "kostenGeplantTextBox";
            this.kostenGeplantTextBox.Size = new System.Drawing.Size(42, 20);
            this.kostenGeplantTextBox.TabIndex = 4;
            this.kostenGeplantTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // kostenEffektivTextBox
            // 
            this.kostenEffektivTextBox.Location = new System.Drawing.Point(594, 20);
            this.kostenEffektivTextBox.MaxLength = 3;
            this.kostenEffektivTextBox.Name = "kostenEffektivTextBox";
            this.kostenEffektivTextBox.Size = new System.Drawing.Size(42, 20);
            this.kostenEffektivTextBox.TabIndex = 5;
            this.kostenEffektivTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "effektiv:";
            // 
            // AddExterneKostenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 161);
            this.Controls.Add(this.kostenartComboBox);
            this.Controls.Add(this.AbrruchButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.abweichungsgrundTextBox);
            this.Controls.Add(this.kostenEffektivTextBox);
            this.Controls.Add(this.kostenGeplantTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(675, 200);
            this.MinimumSize = new System.Drawing.Size(675, 200);
            this.Name = "AddExterneKostenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExterneKostenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abweichungsgrundTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button AbrruchButton;
        private ComboBox kostenartComboBox;
        private Label label4;
        private TextBox kostenGeplantTextBox;
        private TextBox kostenEffektivTextBox;
        private Label label7;
    }
}