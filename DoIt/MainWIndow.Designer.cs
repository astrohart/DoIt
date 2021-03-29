
namespace DoIt
{
    partial class MainWindow
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
            this.doItButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doItButton
            // 
            this.doItButton.Location = new System.Drawing.Point(128, 62);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(75, 23);
            this.doItButton.TabIndex = 0;
            this.doItButton.Text = "&Do It!!!";
            this.doItButton.UseVisualStyleBackColor = true;
            this.doItButton.Click += new System.EventHandler(this.OnClickDoItButton);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.doItButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(330, 147);
            this.Controls.Add(this.doItButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoIt Sample Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doItButton;
    }
}

