
using System.Windows.Forms;

namespace ProjektManagementSystem
{
    partial class AddMeilensteinForm
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
            this.bezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abschlussdatumDateTime = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.linkLabelDokumente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(220, 108);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 36);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Speichern";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bezeichnungTextBox
            // 
            this.bezeichnungTextBox.Location = new System.Drawing.Point(109, 12);
            this.bezeichnungTextBox.Name = "bezeichnungTextBox";
            this.bezeichnungTextBox.Size = new System.Drawing.Size(216, 20);
            this.bezeichnungTextBox.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Bezeichnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Abschlussdatum";
            // 
            // abschlussdatumDateTime
            // 
            this.abschlussdatumDateTime.Location = new System.Drawing.Point(109, 49);
            this.abschlussdatumDateTime.Name = "abschlussdatumDateTime";
            this.abschlussdatumDateTime.Size = new System.Drawing.Size(216, 20);
            this.abschlussdatumDateTime.TabIndex = 11;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(109, 108);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 36);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabelDokumente.AutoSize = true;
            this.linkLabelDokumente.Location = new System.Drawing.Point(13, 88);
            this.linkLabelDokumente.Name = "linkLabel1";
            this.linkLabelDokumente.Size = new System.Drawing.Size(159, 13);
            this.linkLabelDokumente.TabIndex = 18;
            this.linkLabelDokumente.TabStop = true;
            this.linkLabelDokumente.Text = "Meilensteindokumente einsehen";
            this.linkLabelDokumente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddMeilensteinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 150);
            this.Controls.Add(this.linkLabelDokumente);
            this.Controls.Add(this.abschlussdatumDateTime);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bezeichnungTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Name = "AddMeilensteinForm";
            this.Text = "Meilenstein hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bezeichnungTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker abschlussdatumDateTime;
        private System.Windows.Forms.Button cancelButton;
        private LinkLabel linkLabelDokumente;
    }
}