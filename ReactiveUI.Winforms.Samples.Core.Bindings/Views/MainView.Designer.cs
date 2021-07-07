
namespace ReactiveUI.Winforms.Samples.Core.Bindings.Views
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
            this.tbInputOne = new System.Windows.Forms.TextBox();
            this.lOutputOne = new System.Windows.Forms.Label();
            this.dtpInputTwo = new System.Windows.Forms.DateTimePicker();
            this.lOutputTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputOne
            // 
            this.tbInputOne.Location = new System.Drawing.Point(61, 12);
            this.tbInputOne.Name = "tbInputOne";
            this.tbInputOne.Size = new System.Drawing.Size(125, 27);
            this.tbInputOne.TabIndex = 0;
            // 
            // lOutputOne
            // 
            this.lOutputOne.AutoSize = true;
            this.lOutputOne.Location = new System.Drawing.Point(251, 15);
            this.lOutputOne.Name = "lOutputOne";
            this.lOutputOne.Size = new System.Drawing.Size(50, 20);
            this.lOutputOne.TabIndex = 1;
            this.lOutputOne.Text = "label1";
            // 
            // dtpInputTwo
            // 
            this.dtpInputTwo.Location = new System.Drawing.Point(61, 45);
            this.dtpInputTwo.Name = "dtpInputTwo";
            this.dtpInputTwo.Size = new System.Drawing.Size(250, 27);
            this.dtpInputTwo.TabIndex = 2;
            // 
            // lOutputTwo
            // 
            this.lOutputTwo.AutoSize = true;
            this.lOutputTwo.Location = new System.Drawing.Point(376, 50);
            this.lOutputTwo.Name = "lOutputTwo";
            this.lOutputTwo.Size = new System.Drawing.Size(50, 20);
            this.lOutputTwo.TabIndex = 3;
            this.lOutputTwo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "output";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lOutputTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInputTwo);
            this.Controls.Add(this.lOutputOne);
            this.Controls.Add(this.tbInputOne);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputOne;
        private System.Windows.Forms.Label lOutputOne;
        private System.Windows.Forms.DateTimePicker dtpInputTwo;
        private System.Windows.Forms.Label lOutputTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

