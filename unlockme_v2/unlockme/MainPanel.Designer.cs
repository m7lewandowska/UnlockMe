namespace unlockme
{
    partial class MainPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.PNL1_settings = new System.Windows.Forms.Panel();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            flowLayoutPanel1.CausesValidation = false;
            flowLayoutPanel1.Controls.Add(this.PNL1_settings);
            flowLayoutPanel1.Controls.Add(this.PB_logo);
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(400, 95);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // PNL1_settings
            // 
            this.PNL1_settings.BackgroundImage = global::unlockme.Properties.Resources.settings;
            this.PNL1_settings.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PNL1_settings.Location = new System.Drawing.Point(3, 3);
            this.PNL1_settings.Name = "PNL1_settings";
            this.PNL1_settings.Size = new System.Drawing.Size(32, 42);
            this.PNL1_settings.TabIndex = 3;
            this.PNL1_settings.UseWaitCursor = true;
            this.PNL1_settings.Click += new System.EventHandler(this.PNL1_settings_Click);
            // 
            // PB_logo
            // 
            this.PB_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_logo.Image = global::unlockme.Properties.Resources.logo;
            this.PB_logo.Location = new System.Drawing.Point(41, 3);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(312, 88);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_logo.TabIndex = 4;
            this.PB_logo.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(flowLayoutPanel1);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(400, 96);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL1_settings;
        private System.Windows.Forms.PictureBox PB_logo;
    }
}
