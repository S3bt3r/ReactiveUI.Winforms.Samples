
namespace ReactiveUI.Winforms.Samples.Core.Routing.Views
{
    partial class HomeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lViewTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lViewTitle
            // 
            this.lViewTitle.AutoSize = true;
            this.lViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lViewTitle.Location = new System.Drawing.Point(4, 12);
            this.lViewTitle.Name = "lViewTitle";
            this.lViewTitle.Size = new System.Drawing.Size(152, 31);
            this.lViewTitle.TabIndex = 0;
            this.lViewTitle.Text = "View Name";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lViewTitle);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(888, 503);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lViewTitle;
    }
}
