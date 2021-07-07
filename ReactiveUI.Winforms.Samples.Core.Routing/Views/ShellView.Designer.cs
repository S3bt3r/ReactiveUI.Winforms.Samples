
namespace ReactiveUI.Winforms.Samples.Core.Routing
{
    partial class ShellView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.routedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
            this.btHome = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btContact = new System.Windows.Forms.Button();
            this.btGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // routedControlHost
            // 
            this.routedControlHost.DefaultContent = null;
            this.routedControlHost.Location = new System.Drawing.Point(4, 68);
            this.routedControlHost.Name = "routedControlHost";
            this.routedControlHost.Router = null;
            this.routedControlHost.Size = new System.Drawing.Size(1059, 482);
            this.routedControlHost.TabIndex = 0;
            this.routedControlHost.ViewLocator = null;
            // 
            // btHome
            // 
            this.btHome.AutoSize = true;
            this.btHome.Location = new System.Drawing.Point(12, 12);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(100, 30);
            this.btHome.TabIndex = 1;
            this.btHome.Text = "Show Home";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // btAbout
            // 
            this.btAbout.AutoSize = true;
            this.btAbout.Location = new System.Drawing.Point(118, 12);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(100, 30);
            this.btAbout.TabIndex = 1;
            this.btAbout.Text = "Show About";
            this.btAbout.UseVisualStyleBackColor = true;
            // 
            // btContact
            // 
            this.btContact.AutoSize = true;
            this.btContact.Location = new System.Drawing.Point(224, 12);
            this.btContact.Name = "btContact";
            this.btContact.Size = new System.Drawing.Size(110, 30);
            this.btContact.TabIndex = 1;
            this.btContact.Text = "Show Contact";
            this.btContact.UseVisualStyleBackColor = true;
            // 
            // btGoBack
            // 
            this.btGoBack.AutoSize = true;
            this.btGoBack.Location = new System.Drawing.Point(340, 12);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(94, 30);
            this.btGoBack.TabIndex = 1;
            this.btGoBack.Text = "Go Back";
            this.btGoBack.UseVisualStyleBackColor = true;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.btContact);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.routedControlHost);
            this.Name = "ShellView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoutedControlHost routedControlHost;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btContact;
        private System.Windows.Forms.Button btGoBack;
    }
}

