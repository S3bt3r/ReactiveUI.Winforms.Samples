
namespace ReactiveUI.Winforms.Samples.Core.Commands
{
    partial class MainView
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
            this.tbWithCanExecuteParameter = new System.Windows.Forms.TextBox();
            this.btParameterless = new System.Windows.Forms.Button();
            this.btWithParameter = new System.Windows.Forms.Button();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.btWithCanExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWithCanExecuteParameter
            // 
            this.tbWithCanExecuteParameter.Location = new System.Drawing.Point(225, 86);
            this.tbWithCanExecuteParameter.Name = "tbWithCanExecuteParameter";
            this.tbWithCanExecuteParameter.Size = new System.Drawing.Size(125, 27);
            this.tbWithCanExecuteParameter.TabIndex = 0;
            // 
            // btParameterless
            // 
            this.btParameterless.AutoSize = true;
            this.btParameterless.Location = new System.Drawing.Point(12, 12);
            this.btParameterless.Name = "btParameterless";
            this.btParameterless.Size = new System.Drawing.Size(183, 30);
            this.btParameterless.TabIndex = 1;
            this.btParameterless.Text = "Parameterless Command";
            this.btParameterless.UseVisualStyleBackColor = true;
            // 
            // btWithParameter
            // 
            this.btWithParameter.AutoSize = true;
            this.btWithParameter.Location = new System.Drawing.Point(12, 48);
            this.btWithParameter.Name = "btWithParameter";
            this.btWithParameter.Size = new System.Drawing.Size(194, 30);
            this.btWithParameter.TabIndex = 2;
            this.btWithParameter.Text = "With Parameter Command";
            this.btWithParameter.UseVisualStyleBackColor = true;
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(225, 48);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(125, 27);
            this.tbParameter.TabIndex = 3;
            this.tbParameter.Text = "The parameter";
            // 
            // btWithCanExecute
            // 
            this.btWithCanExecute.AutoSize = true;
            this.btWithCanExecute.Location = new System.Drawing.Point(12, 84);
            this.btWithCanExecute.Name = "btWithCanExecute";
            this.btWithCanExecute.Size = new System.Drawing.Size(207, 30);
            this.btWithCanExecute.TabIndex = 4;
            this.btWithCanExecute.Text = "With Can Execute Command";
            this.btWithCanExecute.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Required";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWithCanExecute);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.btWithParameter);
            this.Controls.Add(this.btParameterless);
            this.Controls.Add(this.tbWithCanExecuteParameter);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWithCanExecuteParameter;
        private System.Windows.Forms.Button btParameterless;
        private System.Windows.Forms.Button btWithParameter;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.Button btWithCanExecute;
        private System.Windows.Forms.Label label1;
    }
}

