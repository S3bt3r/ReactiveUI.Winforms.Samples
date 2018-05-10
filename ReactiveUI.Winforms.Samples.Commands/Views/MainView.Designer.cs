namespace ReactiveUI.Winforms.Samples.Commands.Views
{
    partial class MainView
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btParameterless = new System.Windows.Forms.Button();
            this.btWithParameter = new System.Windows.Forms.Button();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.tbWithCanExecuteParameter = new System.Windows.Forms.TextBox();
            this.btWithCanExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btParameterless
            // 
            this.btParameterless.Location = new System.Drawing.Point(39, 38);
            this.btParameterless.Name = "btParameterless";
            this.btParameterless.Size = new System.Drawing.Size(171, 23);
            this.btParameterless.TabIndex = 0;
            this.btParameterless.Text = "Parameterless Command";
            this.btParameterless.UseVisualStyleBackColor = true;
            // 
            // btWithParameter
            // 
            this.btWithParameter.Location = new System.Drawing.Point(39, 77);
            this.btWithParameter.Name = "btWithParameter";
            this.btWithParameter.Size = new System.Drawing.Size(197, 23);
            this.btWithParameter.TabIndex = 1;
            this.btWithParameter.Text = "With Parameter Command";
            this.btWithParameter.UseVisualStyleBackColor = true;
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(266, 79);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(100, 20);
            this.tbParameter.TabIndex = 2;
            this.tbParameter.Text = "The parameter";
            // 
            // tbWithCanExecuteParameter
            // 
            this.tbWithCanExecuteParameter.Location = new System.Drawing.Point(266, 118);
            this.tbWithCanExecuteParameter.Name = "tbWithCanExecuteParameter";
            this.tbWithCanExecuteParameter.Size = new System.Drawing.Size(100, 20);
            this.tbWithCanExecuteParameter.TabIndex = 4;
            // 
            // btWithCanExecute
            // 
            this.btWithCanExecute.Location = new System.Drawing.Point(39, 116);
            this.btWithCanExecute.Name = "btWithCanExecute";
            this.btWithCanExecute.Size = new System.Drawing.Size(197, 23);
            this.btWithCanExecute.TabIndex = 3;
            this.btWithCanExecute.Text = "With Can Execute Command";
            this.btWithCanExecute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Required";
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWithCanExecuteParameter);
            this.Controls.Add(this.btWithCanExecute);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.btWithParameter);
            this.Controls.Add(this.btParameterless);
            this.Name = "ShellView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btParameterless;
        private System.Windows.Forms.Button btWithParameter;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.TextBox tbWithCanExecuteParameter;
        private System.Windows.Forms.Button btWithCanExecute;
        private System.Windows.Forms.Label label1;
    }
}

