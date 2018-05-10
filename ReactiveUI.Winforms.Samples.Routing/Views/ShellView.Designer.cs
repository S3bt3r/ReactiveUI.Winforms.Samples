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
            this.btReactiveUI = new System.Windows.Forms.Button();
            this.btGoBack = new System.Windows.Forms.Button();
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
            // btReactiveUI
            // 
            this.btReactiveUI.Location = new System.Drawing.Point(93, 12);
            this.btReactiveUI.Name = "btReactiveUI";
            this.btReactiveUI.Size = new System.Drawing.Size(112, 23);
            this.btReactiveUI.TabIndex = 6;
            this.btReactiveUI.Text = "Show ReactiveUI";
            this.btReactiveUI.UseVisualStyleBackColor = true;
            // 
            // btGoBack
            // 
            this.btGoBack.Location = new System.Drawing.Point(211, 12);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(75, 23);
            this.btGoBack.TabIndex = 7;
            this.btGoBack.Text = "Go Back";
            this.btGoBack.UseVisualStyleBackColor = true;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.routedControlHost);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btReactiveUI);
            this.Controls.Add(this.btGoBack);
            this.Name = "ShellView";
            this.Text = "ShellForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RoutedControlHost routedControlHost;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btReactiveUI;
        private System.Windows.Forms.Button btGoBack;
    }
}