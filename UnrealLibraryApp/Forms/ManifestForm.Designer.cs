
namespace UnrealLibraryApp
{
    partial class ManifestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManifestForm));
            this.textBoxManifest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxManifest
            // 
            this.textBoxManifest.AcceptsReturn = true;
            this.textBoxManifest.Location = new System.Drawing.Point(13, 13);
            this.textBoxManifest.Multiline = true;
            this.textBoxManifest.Name = "textBoxManifest";
            this.textBoxManifest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxManifest.Size = new System.Drawing.Size(443, 485);
            this.textBoxManifest.TabIndex = 0;
            // 
            // ManifestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 510);
            this.Controls.Add(this.textBoxManifest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManifestForm";
            this.Text = "К. Маркс и Ф. Энгельс - Манифест Коммунистической партии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManifestForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxManifest;
    }
}