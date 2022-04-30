namespace unlockme
{
    partial class SizeChooser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4x4 = new System.Windows.Forms.Panel();
            this.panel3x3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(200, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4x4
            // 
            this.panel4x4.BackColor = System.Drawing.Color.Transparent;
            this.panel4x4.BackgroundImage = global::unlockme.Properties.Resources.pattern4x4;
            this.panel4x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4x4.Location = new System.Drawing.Point(180, 104);
            this.panel4x4.Name = "panel4x4";
            this.panel4x4.Size = new System.Drawing.Size(112, 107);
            this.panel4x4.TabIndex = 1;
            this.panel4x4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChooseSize);
            // 
            // panel3x3
            // 
            this.panel3x3.BackColor = System.Drawing.Color.Transparent;
            this.panel3x3.BackgroundImage = global::unlockme.Properties.Resources.pattern3x3;
            this.panel3x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3x3.Location = new System.Drawing.Point(36, 104);
            this.panel3x3.Name = "panel3x3";
            this.panel3x3.Size = new System.Drawing.Size(107, 107);
            this.panel3x3.TabIndex = 0;
            this.panel3x3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChooseSize);
            // 
            // SizeChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4x4);
            this.Controls.Add(this.panel3x3);
            this.Name = "SizeChooser";
            this.Size = new System.Drawing.Size(329, 367);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3x3;
        private System.Windows.Forms.Panel panel4x4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
