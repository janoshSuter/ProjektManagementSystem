
namespace ProjektManagementSystem
{
    partial class AddKostenartForm
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
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(95, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 36);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Ok";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bezeichnungTextBox
            // 
            this.bezeichnungTextBox.Location = new System.Drawing.Point(95, 12);
            this.bezeichnungTextBox.Name = "bezeichnungTextBox";
            this.bezeichnungTextBox.Size = new System.Drawing.Size(173, 20);
            this.bezeichnungTextBox.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "*Bezeichnung";
            // 
            // AddKostenartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 79);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.bezeichnungTextBox);
            this.Controls.Add(this.labelName);
            this.Name = "AddKostenartForm";
            this.Text = "Kostenart hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bezeichnungTextBox;
        private System.Windows.Forms.Label labelName;
    }
}