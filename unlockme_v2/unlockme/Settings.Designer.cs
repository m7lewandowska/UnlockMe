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
            this.about = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changePattern
            // 
            this.changePattern.Location = new System.Drawing.Point(142, 116);
            this.changePattern.Name = "changePattern";
            this.changePattern.Size = new System.Drawing.Size(75, 23);
            this.changePattern.TabIndex = 0;
            this.changePattern.Text = "Zmień wzór";
            this.changePattern.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(142, 290);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(75, 23);
            this.about.TabIndex = 2;
            this.about.Text = "O projekcie";
            this.about.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(142, 320);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(75, 23);
            this.logs.TabIndex = 3;
            this.logs.Text = "Historia prób";
            this.logs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zgadza się, ustawienia";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.about);
            this.Controls.Add(this.changePattern);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(318, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePattern;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button logs;
        private System.Windows.Forms.Label label1;
    }
}
