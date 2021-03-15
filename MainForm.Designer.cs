
namespace ProjektManagementSystem
{
    partial class MainForm
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
            this.projekteButton = new System.Windows.Forms.Button();
            this.mitarbeiterBUtton = new System.Windows.Forms.Button();
            this.vorgehensModelButton = new System.Windows.Forms.Button();
            this.KostenartButton = new System.Windows.Forms.Button();
            this.pathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projekteButton
            // 
            this.projekteButton.Location = new System.Drawing.Point(12, 12);
            this.projekteButton.Name = "projekteButton";
            this.projekteButton.Size = new System.Drawing.Size(490, 52);
            this.projekteButton.TabIndex = 0;
            this.projekteButton.Text = "Projektübersicht";
            this.projekteButton.UseVisualStyleBackColor = true;
            this.projekteButton.Click += new System.EventHandler(this.projekteButton_Click);
            // 
            // mitarbeiterBUtton
            // 
            this.mitarbeiterBUtton.Location = new System.Drawing.Point(12, 70);
            this.mitarbeiterBUtton.Name = "mitarbeiterBUtton";
            this.mitarbeiterBUtton.Size = new System.Drawing.Size(490, 52);
            this.mitarbeiterBUtton.TabIndex = 1;
            this.mitarbeiterBUtton.Text = "Mitarbeiterübersicht";
            this.mitarbeiterBUtton.UseVisualStyleBackColor = true;
            this.mitarbeiterBUtton.Click += new System.EventHandler(this.mitarbeiterButton_Click);
            // 
            // vorgehensModelButton
            // 
            this.vorgehensModelButton.Location = new System.Drawing.Point(12, 128);
            this.vorgehensModelButton.Name = "vorgehensModelButton";
            this.vorgehensModelButton.Size = new System.Drawing.Size(490, 52);
            this.vorgehensModelButton.TabIndex = 2;
            this.vorgehensModelButton.Text = "Vorgehensmodelübersicht";
            this.vorgehensModelButton.UseVisualStyleBackColor = true;
            this.vorgehensModelButton.Click += new System.EventHandler(this.vorgehensModelButton_Click);
            // 
            // KostenartButton
            // 
            this.KostenartButton.Location = new System.Drawing.Point(12, 186);
            this.KostenartButton.Name = "KostenartButton";
            this.KostenartButton.Size = new System.Drawing.Size(490, 52);
            this.KostenartButton.TabIndex = 3;
            this.KostenartButton.Text = "Kostenartübersicht";
            this.KostenartButton.UseVisualStyleBackColor = true;
            this.KostenartButton.Click += new System.EventHandler(this.KostenartButton_Click);
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(12, 244);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(490, 52);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "Share-Verzeichnispfad setzen";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.SharepathButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.KostenartButton);
            this.Controls.Add(this.vorgehensModelButton);
            this.Controls.Add(this.mitarbeiterBUtton);
            this.Controls.Add(this.projekteButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Übersicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projekteButton;
        private System.Windows.Forms.Button mitarbeiterBUtton;
        private System.Windows.Forms.Button vorgehensModelButton;
        private System.Windows.Forms.Button KostenartButton;
        private System.Windows.Forms.Button pathButton;
    }
}