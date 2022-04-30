namespace unlockme
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.mainPanel1 = new unlockme.MainPanel();
            this.settings1 = new unlockme.Settings();
            this.unlocker4x41 = new unlockme.Unlocker4x4();
            this.unlocker1 = new unlockme.Unlocker();
            this.sizeChooser1 = new unlockme.SizeChooser();
            this.about1 = new unlockme.UserControls.About();
            this.SuspendLayout();
            // 
            // mainPanel1
            // 
            this.mainPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.mainPanel1.Location = new System.Drawing.Point(0, -1);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(400, 96);
            this.mainPanel1.State = "main";
            this.mainPanel1.TabIndex = 4;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.settings1.Location = new System.Drawing.Point(37, 120);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(318, 360);
            this.settings1.TabIndex = 3;
            // 
            // unlocker4x41
            // 
            this.unlocker4x41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.unlocker4x41.Location = new System.Drawing.Point(37, 120);
            this.unlocker4x41.Name = "unlocker4x41";
            this.unlocker4x41.Size = new System.Drawing.Size(318, 360);
            this.unlocker4x41.TabIndex = 2;
            // 
            // unlocker1
            // 
            this.unlocker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.unlocker1.Location = new System.Drawing.Point(37, 120);
            this.unlocker1.Name = "unlocker1";
            this.unlocker1.Size = new System.Drawing.Size(338, 361);
            this.unlocker1.TabIndex = 1;
            // 
            // sizeChooser1
            // 
            this.sizeChooser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sizeChooser1.FieldSize = "";
            this.sizeChooser1.Location = new System.Drawing.Point(37, 120);
            this.sizeChooser1.Name = "sizeChooser1";
            this.sizeChooser1.Size = new System.Drawing.Size(329, 367);
            this.sizeChooser1.TabIndex = 5;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.Transparent;
            this.about1.Location = new System.Drawing.Point(37, 120);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(318, 360);
            this.about1.TabIndex = 6;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(399, 511);
            this.Controls.Add(this.sizeChooser1);
            this.Controls.Add(this.mainPanel1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.unlocker4x41);
            this.Controls.Add(this.unlocker1);
            this.Controls.Add(this.about1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 550);
            this.MinimumSize = new System.Drawing.Size(415, 550);
            this.Name = "View";
            this.Text = "UnlockMe";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Unlocker unlocker1;
        private Unlocker4x4 unlocker4x41;
        private Settings settings1;
        private MainPanel mainPanel1;
        private SizeChooser sizeChooser1;
        private UserControls.About about1;
    }
}

