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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(probeForm));
            this.colorLabel = new System.Windows.Forms.Label();
            this.hueHSVLabelLabel = new System.Windows.Forms.Label();
            this.hueHSVLabel = new System.Windows.Forms.Label();
            this.satHSVLabelLabel = new System.Windows.Forms.Label();
            this.valHSVLabelLabel = new System.Windows.Forms.Label();
            this.satHSVLabel = new System.Windows.Forms.Label();
            this.valHSVLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabelLabel = new System.Windows.Forms.Label();
            this.greenLabelLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.redLabelLabel = new System.Windows.Forms.Label();
            this.getColorTimer = new System.Windows.Forms.Timer(this.components);
            this.lumHSLLabel = new System.Windows.Forms.Label();
            this.satHSLLabel = new System.Windows.Forms.Label();
            this.lumHSLLabelLabel = new System.Windows.Forms.Label();
            this.satHSLLabelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(13, 28);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(15, 15);
            this.colorLabel.TabIndex = 0;
            // 
            // hueHSVLabelLabel
            // 
            this.hueHSVLabelLabel.AutoSize = true;
            this.hueHSVLabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.hueHSVLabelLabel.Location = new System.Drawing.Point(34, 28);
            this.hueHSVLabelLabel.Name = "hueHSVLabelLabel";
            this.hueHSVLabelLabel.Size = new System.Drawing.Size(33, 13);
            this.hueHSVLabelLabel.TabIndex = 1;
            this.hueHSVLabelLabel.Text = "Hue: ";
            // 
            // hueHSVLabel
            // 
            this.hueHSVLabel.AutoSize = true;
            this.hueHSVLabel.Location = new System.Drawing.Point(59, 28);
            this.hueHSVLabel.Name = "hueHSVLabel";
            this.hueHSVLabel.Size = new System.Drawing.Size(19, 13);
            this.hueHSVLabel.TabIndex = 2;
            this.hueHSVLabel.Text = "33";
            // 
            // satHSVLabelLabel
            // 
            this.satHSVLabelLabel.AutoSize = true;
            this.satHSVLabelLabel.Location = new System.Drawing.Point(34, 41);
            this.satHSVLabelLabel.Name = "satHSVLabelLabel";
            this.satHSVLabelLabel.Size = new System.Drawing.Size(26, 13);
            this.satHSVLabelLabel.TabIndex = 3;
            this.satHSVLabelLabel.Text = "Sat:";
            // 
            // valHSVLabelLabel
            // 
            this.valHSVLabelLabel.AutoSize = true;
            this.valHSVLabelLabel.Location = new System.Drawing.Point(34, 54);
            this.valHSVLabelLabel.Name = "valHSVLabelLabel";
            this.valHSVLabelLabel.Size = new System.Drawing.Size(25, 13);
            this.valHSVLabelLabel.TabIndex = 4;
            this.valHSVLabelLabel.Text = "Val:";
            // 
            // satHSVLabel
            // 
            this.satHSVLabel.AutoSize = true;
            this.satHSVLabel.Location = new System.Drawing.Point(59, 41);
            this.satHSVLabel.Name = "satHSVLabel";
            this.satHSVLabel.Size = new System.Drawing.Size(36, 13);
            this.satHSVLabel.TabIndex = 5;
            this.satHSVLabel.Text = "100 %";
            // 
            // valHSVLabel
            // 
            this.valHSVLabel.AutoSize = true;
            this.valHSVLabel.Location = new System.Drawing.Point(59, 54);
            this.valHSVLabel.Name = "valHSVLabel";
            this.valHSVLabel.Size = new System.Drawing.Size(19, 13);
            this.valHSVLabel.TabIndex = 6;
            this.valHSVLabel.Text = "55";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(193, 54);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(46, 13);
            this.blueLabel.TabIndex = 12;
            this.blueLabel.Text = "234/DD";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(193, 41);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(38, 13);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "44/EE";
            // 
            // blueLabelLabel
            // 
            this.blueLabelLabel.AutoSize = true;
            this.blueLabelLabel.Location = new System.Drawing.Point(168, 54);
            this.blueLabelLabel.Name = "blueLabelLabel";
            this.blueLabelLabel.Size = new System.Drawing.Size(25, 13);
            this.blueLabelLabel.TabIndex = 10;
            this.blueLabelLabel.Text = "Blu:";
            // 
            // greenLabelLabel
            // 
            this.greenLabelLabel.AutoSize = true;
            this.greenLabelLabel.Location = new System.Drawing.Point(168, 41);
            this.greenLabelLabel.Name = "greenLabelLabel";
            this.greenLabelLabel.Size = new System.Drawing.Size(27, 13);
            this.greenLabelLabel.TabIndex = 9;
            this.greenLabelLabel.Text = "Grn:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(193, 28);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(36, 13);
            this.redLabel.TabIndex = 8;
            this.redLabel.Text = "33/FF";
            // 
            // redLabelLabel
            // 
            this.redLabelLabel.AutoSize = true;
            this.redLabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabelLabel.Location = new System.Drawing.Point(168, 28);
            this.redLabelLabel.Name = "redLabelLabel";
            this.redLabelLabel.Size = new System.Drawing.Size(30, 13);
            this.redLabelLabel.TabIndex = 7;
            this.redLabelLabel.Text = "Red:";
            // 
            // getColorTimer
            // 
            this.getColorTimer.Enabled = true;
            this.getColorTimer.Interval = 50;
            this.getColorTimer.Tick += new System.EventHandler(this.getColorTimer_Tick);
            // 
            // lumHSLLabel
            // 
            this.lumHSLLabel.AutoSize = true;
            this.lumHSLLabel.Location = new System.Drawing.Point(126, 54);
            this.lumHSLLabel.Name = "lumHSLLabel";
            this.lumHSLLabel.Size = new System.Drawing.Size(19, 13);
            this.lumHSLLabel.TabIndex = 18;
            this.lumHSLLabel.Text = "55";
            // 
            // satHSLLabel
            // 
            this.satHSLLabel.AutoSize = true;
            this.satHSLLabel.Location = new System.Drawing.Point(126, 41);
            this.satHSLLabel.Name = "satHSLLabel";
            this.satHSLLabel.Size = new System.Drawing.Size(36, 13);
            this.satHSLLabel.TabIndex = 17;
            this.satHSLLabel.Text = "100 %";
            // 
            // lumHSLLabelLabel
            // 
            this.lumHSLLabelLabel.AutoSize = true;
            this.lumHSLLabelLabel.Location = new System.Drawing.Point(101, 54);
            this.lumHSLLabelLabel.Name = "lumHSLLabelLabel";
            this.lumHSLLabelLabel.Size = new System.Drawing.Size(30, 13);
            this.lumHSLLabelLabel.TabIndex = 16;
            this.lumHSLLabelLabel.Text = "Lum:";
            // 
            // satHSLLabelLabel
            // 
            this.satHSLLabelLabel.AutoSize = true;
            this.satHSLLabelLabel.Location = new System.Drawing.Point(101, 41);
            this.satHSLLabelLabel.Name = "satHSLLabelLabel";
            this.satHSLLabelLabel.Size = new System.Drawing.Size(26, 13);
            this.satHSLLabelLabel.TabIndex = 15;
            this.satHSLLabelLabel.Text = "Sat:";
            // 
            // probeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 88);
            this.Controls.Add(this.lumHSLLabel);
            this.Controls.Add(this.satHSLLabel);
            this.Controls.Add(this.lumHSLLabelLabel);
            this.Controls.Add(this.satHSLLabelLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabelLabel);
            this.Controls.Add(this.greenLabelLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redLabelLabel);
            this.Controls.Add(this.valHSVLabel);
            this.Controls.Add(this.satHSVLabel);
            this.Controls.Add(this.valHSVLabelLabel);
            this.Controls.Add(this.satHSVLabelLabel);
            this.Controls.Add(this.hueHSVLabel);
            this.Controls.Add(this.hueHSVLabelLabel);
            this.Controls.Add(this.colorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "probeForm";
            this.Text = "Color Probe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label hueHSVLabelLabel;
        private System.Windows.Forms.Label hueHSVLabel;
        private System.Windows.Forms.Label satHSVLabelLabel;
        private System.Windows.Forms.Label valHSVLabelLabel;
        private System.Windows.Forms.Label satHSVLabel;
        private System.Windows.Forms.Label valHSVLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabelLabel;
        private System.Windows.Forms.Label greenLabelLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label redLabelLabel;
        private System.Windows.Forms.Timer getColorTimer;
        private System.Windows.Forms.Label lumHSLLabel;
        private System.Windows.Forms.Label satHSLLabel;
        private System.Windows.Forms.Label lumHSLLabelLabel;
        private System.Windows.Forms.Label satHSLLabelLabel;
    }
}

