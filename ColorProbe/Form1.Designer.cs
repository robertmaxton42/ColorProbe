namespace ColorProbe
{
    partial class probeForm
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
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(13, 28);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(15, 15);
            this.colorLabel.TabIndex = 0;
            // 
            // probeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 132);
            this.Controls.Add(this.colorLabel);
            this.Name = "probeForm";
            this.Text = "Color Probe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
    }
}

