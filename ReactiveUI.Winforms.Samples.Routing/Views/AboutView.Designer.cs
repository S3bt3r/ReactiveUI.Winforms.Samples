namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    partial class AboutView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lViewTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lViewTitle
            // 
            this.lViewTitle.AutoSize = true;
            this.lViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lViewTitle.Location = new System.Drawing.Point(3, 13);
            this.lViewTitle.Name = "lViewTitle";
            this.lViewTitle.Size = new System.Drawing.Size(120, 25);
            this.lViewTitle.TabIndex = 2;
            this.lViewTitle.Text = "View Name";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lViewTitle);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(489, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lViewTitle;
    }
}
