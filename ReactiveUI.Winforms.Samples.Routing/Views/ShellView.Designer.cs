namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    partial class ShellView
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
            this.routedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
            this.btHome = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btGoBack = new System.Windows.Forms.Button();
            this.btContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // routedControlHost
            // 
            this.routedControlHost.DefaultContent = null;
            this.routedControlHost.Location = new System.Drawing.Point(3, 55);
            this.routedControlHost.Name = "routedControlHost";
            this.routedControlHost.Router = null;
            this.routedControlHost.Size = new System.Drawing.Size(794, 392);
            this.routedControlHost.TabIndex = 4;
            this.routedControlHost.ViewLocator = null;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(12, 12);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(75, 23);
            this.btHome.TabIndex = 5;
            this.btHome.Text = "Show Home";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(93, 12);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(112, 23);
            this.btAbout.TabIndex = 6;
            this.btAbout.Text = "Show About";
            this.btAbout.UseVisualStyleBackColor = true;
            // 
            // btGoBack
            // 
            this.btGoBack.Location = new System.Drawing.Point(329, 12);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(75, 23);
            this.btGoBack.TabIndex = 7;
            this.btGoBack.Text = "Go Back";
            this.btGoBack.UseVisualStyleBackColor = true;
            // 
            // btContact
            // 
            this.btContact.Location = new System.Drawing.Point(211, 12);
            this.btContact.Name = "btContact";
            this.btContact.Size = new System.Drawing.Size(112, 23);
            this.btContact.TabIndex = 8;
            this.btContact.Text = "Show Contact";
            this.btContact.UseVisualStyleBackColor = true;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btContact);
            this.Controls.Add(this.routedControlHost);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btGoBack);
            this.Name = "ShellView";
            this.Text = "ShellForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RoutedControlHost routedControlHost;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Button btContact;
    }
}