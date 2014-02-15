namespace EeeasyControl
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.logopart2 = new System.Windows.Forms.PictureBox();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.RotateNorm = new System.Windows.Forms.PictureBox();
            this.Rotate90 = new System.Windows.Forms.PictureBox();
            this.Rotate180 = new System.Windows.Forms.PictureBox();
            this.Rotate240 = new System.Windows.Forms.PictureBox();
            this.ControlPic = new System.Windows.Forms.PictureBox();
            this.MorePic = new System.Windows.Forms.PictureBox();
            this.CSEPic = new System.Windows.Forms.PictureBox();
            this.ApplicationsPic = new System.Windows.Forms.PictureBox();
            this.CBarPic = new System.Windows.Forms.PictureBox();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.StartPic = new System.Windows.Forms.PictureBox();
            this.ClosingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logopart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateNorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate240)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logopart2
            // 
            this.logopart2.Image = global::EeeasyControl.Properties.Resources.contol;
            this.logopart2.Location = new System.Drawing.Point(593, 29);
            this.logopart2.Name = "logopart2";
            this.logopart2.Size = new System.Drawing.Size(19, 33);
            this.logopart2.TabIndex = 13;
            this.logopart2.TabStop = false;
            this.logopart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::EeeasyControl.Properties.Resources.Eeeasy1;
            this.LogoPic.Location = new System.Drawing.Point(593, 61);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(19, 38);
            this.LogoPic.TabIndex = 12;
            this.LogoPic.TabStop = false;
            this.LogoPic.Click += new System.EventHandler(this.LogoPic_Click);
            this.LogoPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // RotateNorm
            // 
            this.RotateNorm.Image = global::EeeasyControl.Properties.Resources.rotate_norm_low1;
            this.RotateNorm.Location = new System.Drawing.Point(237, 15);
            this.RotateNorm.Name = "RotateNorm";
            this.RotateNorm.Size = new System.Drawing.Size(105, 70);
            this.RotateNorm.TabIndex = 10;
            this.RotateNorm.TabStop = false;
            this.RotateNorm.Visible = false;
            this.RotateNorm.Click += new System.EventHandler(this.RotateNorm_Click);
            this.RotateNorm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Rotate90
            // 
            this.Rotate90.Image = global::EeeasyControl.Properties.Resources.rotate_90_low1;
            this.Rotate90.Location = new System.Drawing.Point(15, 15);
            this.Rotate90.Name = "Rotate90";
            this.Rotate90.Size = new System.Drawing.Size(105, 70);
            this.Rotate90.TabIndex = 9;
            this.Rotate90.TabStop = false;
            this.Rotate90.Visible = false;
            this.Rotate90.Click += new System.EventHandler(this.Rotate90_Click);
            this.Rotate90.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Rotate180
            // 
            this.Rotate180.Image = global::EeeasyControl.Properties.Resources.rotate_180_low1;
            this.Rotate180.Location = new System.Drawing.Point(126, 15);
            this.Rotate180.Name = "Rotate180";
            this.Rotate180.Size = new System.Drawing.Size(105, 70);
            this.Rotate180.TabIndex = 8;
            this.Rotate180.TabStop = false;
            this.Rotate180.Visible = false;
            this.Rotate180.Click += new System.EventHandler(this.Rotate180_Click);
            this.Rotate180.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Rotate240
            // 
            this.Rotate240.Image = global::EeeasyControl.Properties.Resources.rotate_240_low1;
            this.Rotate240.Location = new System.Drawing.Point(348, 15);
            this.Rotate240.Name = "Rotate240";
            this.Rotate240.Size = new System.Drawing.Size(105, 70);
            this.Rotate240.TabIndex = 7;
            this.Rotate240.TabStop = false;
            this.Rotate240.Visible = false;
            this.Rotate240.Click += new System.EventHandler(this.Rotate240_Click);
            this.Rotate240.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // ControlPic
            // 
            this.ControlPic.Image = global::EeeasyControl.Properties.Resources.control_low;
            this.ControlPic.Location = new System.Drawing.Point(459, 15);
            this.ControlPic.Name = "ControlPic";
            this.ControlPic.Size = new System.Drawing.Size(105, 70);
            this.ControlPic.TabIndex = 6;
            this.ControlPic.TabStop = false;
            this.ControlPic.Visible = false;
            this.ControlPic.Click += new System.EventHandler(this.ControlPic_Click);
            this.ControlPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // MorePic
            // 
            this.MorePic.Image = global::EeeasyControl.Properties.Resources.more_low;
            this.MorePic.Location = new System.Drawing.Point(459, 15);
            this.MorePic.Name = "MorePic";
            this.MorePic.Size = new System.Drawing.Size(105, 70);
            this.MorePic.TabIndex = 5;
            this.MorePic.TabStop = false;
            this.MorePic.Click += new System.EventHandler(this.MorePic_Click);
            this.MorePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // CSEPic
            // 
            this.CSEPic.Image = global::EeeasyControl.Properties.Resources.cse_low1;
            this.CSEPic.Location = new System.Drawing.Point(348, 15);
            this.CSEPic.Name = "CSEPic";
            this.CSEPic.Size = new System.Drawing.Size(105, 70);
            this.CSEPic.TabIndex = 4;
            this.CSEPic.TabStop = false;
            this.CSEPic.Click += new System.EventHandler(this.CSEPic_Click);
            this.CSEPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // ApplicationsPic
            // 
            this.ApplicationsPic.Image = global::EeeasyControl.Properties.Resources.allprg_low;
            this.ApplicationsPic.Location = new System.Drawing.Point(237, 15);
            this.ApplicationsPic.Name = "ApplicationsPic";
            this.ApplicationsPic.Size = new System.Drawing.Size(105, 70);
            this.ApplicationsPic.TabIndex = 3;
            this.ApplicationsPic.TabStop = false;
            this.ApplicationsPic.Click += new System.EventHandler(this.ApplicationsPic_Click);
            this.ApplicationsPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // CBarPic
            // 
            this.CBarPic.Image = global::EeeasyControl.Properties.Resources.cbar_low;
            this.CBarPic.Location = new System.Drawing.Point(126, 15);
            this.CBarPic.Name = "CBarPic";
            this.CBarPic.Size = new System.Drawing.Size(105, 70);
            this.CBarPic.TabIndex = 2;
            this.CBarPic.TabStop = false;
            this.CBarPic.Click += new System.EventHandler(this.CBarPic_Click);
            this.CBarPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // ClosePic
            // 
            this.ClosePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosePic.Image = global::EeeasyControl.Properties.Resources.close_low;
            this.ClosePic.Location = new System.Drawing.Point(567, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(45, 20);
            this.ClosePic.TabIndex = 1;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            this.ClosePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // StartPic
            // 
            this.StartPic.Image = global::EeeasyControl.Properties.Resources.winkey_low1;
            this.StartPic.Location = new System.Drawing.Point(15, 15);
            this.StartPic.Name = "StartPic";
            this.StartPic.Size = new System.Drawing.Size(105, 70);
            this.StartPic.TabIndex = 0;
            this.StartPic.TabStop = false;
            this.StartPic.Click += new System.EventHandler(this.StartPic_Click);
            this.StartPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // ClosingTimer
            // 
            this.ClosingTimer.Enabled = true;
            this.ClosingTimer.Interval = 1000;
            this.ClosingTimer.Tick += new System.EventHandler(this.ClosingTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(615, 100);
            this.Controls.Add(this.logopart2);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.RotateNorm);
            this.Controls.Add(this.Rotate90);
            this.Controls.Add(this.Rotate180);
            this.Controls.Add(this.Rotate240);
            this.Controls.Add(this.ControlPic);
            this.Controls.Add(this.MorePic);
            this.Controls.Add(this.CSEPic);
            this.Controls.Add(this.ApplicationsPic);
            this.Controls.Add(this.CBarPic);
            this.Controls.Add(this.ClosePic);
            this.Controls.Add(this.StartPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.Main_Click);
            this.MouseLeave += new System.EventHandler(this.Main_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.logopart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateNorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate240)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPic;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.PictureBox CBarPic;
        private System.Windows.Forms.PictureBox ApplicationsPic;
        private System.Windows.Forms.PictureBox CSEPic;
        private System.Windows.Forms.PictureBox MorePic;
        private System.Windows.Forms.PictureBox ControlPic;
        private System.Windows.Forms.PictureBox Rotate240;
        private System.Windows.Forms.PictureBox Rotate180;
        private System.Windows.Forms.PictureBox Rotate90;
        private System.Windows.Forms.PictureBox RotateNorm;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox logopart2;
        private System.Windows.Forms.Timer ClosingTimer;
    }
}

