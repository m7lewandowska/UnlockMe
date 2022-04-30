using System.Drawing;

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
            this.label = new System.Windows.Forms.Label();
            this.leftarrow = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Panel();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(400, 95);
            this.label.TabIndex = 8;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Visible = false;
            // 
            // leftarrow
            // 
            this.leftarrow.BackgroundImage = global::unlockme.Properties.Resources.leftarrow;
            this.leftarrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftarrow.Location = new System.Drawing.Point(0, 0);
            this.leftarrow.Name = "leftarrow";
            this.leftarrow.Size = new System.Drawing.Size(34, 41);
            this.leftarrow.TabIndex = 8;
            this.leftarrow.Click += new System.EventHandler(this.leftarrow_Click);
            this.leftarrow.MouseEnter += new System.EventHandler(this.leftarrow_MouseHover);
            this.leftarrow.MouseLeave += new System.EventHandler(this.leftarrow_MouseLeave);
            // 
            // settings
            // 
            this.settings.BackgroundImage = global::unlockme.Properties.Resources.settings;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(34, 41);
            this.settings.TabIndex = 7;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseHover);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            // 
            // PB_logo
            // 
            this.PB_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_logo.Image = global::unlockme.Properties.Resources.logo;
            this.PB_logo.Location = new System.Drawing.Point(0, 0);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(400, 95);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_logo.TabIndex = 6;
            this.PB_logo.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.leftarrow);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.label);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(400, 95);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel leftarrow;
    }
}
