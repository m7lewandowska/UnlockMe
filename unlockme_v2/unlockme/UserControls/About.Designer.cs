namespace unlockme.UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.about_text = new System.Windows.Forms.Label();
            this.pictureBox1_logo_bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo_bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // about_text
            // 
            this.about_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about_text.ForeColor = System.Drawing.SystemColors.Control;
            this.about_text.Location = new System.Drawing.Point(3, 0);
            this.about_text.Name = "about_text";
            this.about_text.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.about_text.Size = new System.Drawing.Size(318, 275);
            this.about_text.TabIndex = 0;
            // 
            // pictureBox1_logo_bottom
            // 
            this.pictureBox1_logo_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1_logo_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1_logo_bottom.Image = global::unlockme.Properties.Resources.bottom_logo;
            this.pictureBox1_logo_bottom.Location = new System.Drawing.Point(0, 278);
            this.pictureBox1_logo_bottom.Name = "pictureBox1_logo_bottom";
            this.pictureBox1_logo_bottom.Size = new System.Drawing.Size(318, 82);
            this.pictureBox1_logo_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1_logo_bottom.TabIndex = 6;
            this.pictureBox1_logo_bottom.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1_logo_bottom);
            this.Controls.Add(this.about_text);
            this.Name = "About";
            this.Size = new System.Drawing.Size(318, 360);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo_bottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label about_text;
        private System.Windows.Forms.PictureBox pictureBox1_logo_bottom;
    }
}
