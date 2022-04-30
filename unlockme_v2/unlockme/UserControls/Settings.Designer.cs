namespace unlockme
{
    partial class Settings
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
            this.changePattern = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.pictureBox1_logo_bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo_bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // changePattern
            // 
            this.changePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePattern.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changePattern.ForeColor = System.Drawing.SystemColors.Control;
            this.changePattern.Location = new System.Drawing.Point(0, 81);
            this.changePattern.Name = "changePattern";
            this.changePattern.Size = new System.Drawing.Size(318, 32);
            this.changePattern.TabIndex = 0;
            this.changePattern.Text = "Zmień wzór";
            this.changePattern.UseVisualStyleBackColor = true;
            this.changePattern.Click += new System.EventHandler(this.changePattern_Click);
            // 
            // logs
            // 
            this.logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logs.ForeColor = System.Drawing.SystemColors.Control;
            this.logs.Location = new System.Drawing.Point(0, 157);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(318, 32);
            this.logs.TabIndex = 3;
            this.logs.Text = "Historia prób";
            this.logs.UseVisualStyleBackColor = true;
            this.logs.Click += new System.EventHandler(this.logs_Click);
            // 
            // test
            // 
            this.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test.ForeColor = System.Drawing.SystemColors.Control;
            this.test.Location = new System.Drawing.Point(0, 43);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(318, 32);
            this.test.TabIndex = 6;
            this.test.Text = "Testuj wzór";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // about
            // 
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about.ForeColor = System.Drawing.SystemColors.Control;
            this.about.Location = new System.Drawing.Point(0, 119);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(318, 32);
            this.about.TabIndex = 2;
            this.about.Text = "O projekcie";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
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
            this.pictureBox1_logo_bottom.TabIndex = 5;
            this.pictureBox1_logo_bottom.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.test);
            this.Controls.Add(this.pictureBox1_logo_bottom);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.about);
            this.Controls.Add(this.changePattern);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(318, 360);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo_bottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePattern;
        private System.Windows.Forms.Button logs;
        private System.Windows.Forms.PictureBox pictureBox1_logo_bottom;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button about;
    }
}
