namespace EeeasyControl
{
    partial class About
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
            this.AboutText = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.ForeColor = System.Drawing.Color.Black;
            this.AboutText.Location = new System.Drawing.Point(12, 9);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(24, 13);
            this.AboutText.TabIndex = 0;
            this.AboutText.Text = "text";
            this.AboutText.Click += new System.EventHandler(this.AboutText_Click);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.ForeColor = System.Drawing.Color.Black;
            this.X.Location = new System.Drawing.Point(252, 4);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 1;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.About_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 74);
            this.Controls.Add(this.X);
            this.Controls.Add(this.AboutText);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Click += new System.EventHandler(this.About_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutText;
        private System.Windows.Forms.Label X;
    }
}