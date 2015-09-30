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
            this.hueLabelLabel = new System.Windows.Forms.Label();
            this.hueLabel = new System.Windows.Forms.Label();
            this.satLabelLabel = new System.Windows.Forms.Label();
            this.valLabelLabel = new System.Windows.Forms.Label();
            this.satLabel = new System.Windows.Forms.Label();
            this.valLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabelLabel = new System.Windows.Forms.Label();
            this.greenLabelLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.redLabelLabel = new System.Windows.Forms.Label();
            this.getColorTimer = new System.Windows.Forms.Timer(this.components);
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
            // hueLabelLabel
            // 
            this.hueLabelLabel.AutoSize = true;
            this.hueLabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.hueLabelLabel.Location = new System.Drawing.Point(34, 28);
            this.hueLabelLabel.Name = "hueLabelLabel";
            this.hueLabelLabel.Size = new System.Drawing.Size(33, 13);
            this.hueLabelLabel.TabIndex = 1;
            this.hueLabelLabel.Text = "Hue: ";
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(59, 28);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(19, 13);
            this.hueLabel.TabIndex = 2;
            this.hueLabel.Text = "33";
            // 
            // satLabelLabel
            // 
            this.satLabelLabel.AutoSize = true;
            this.satLabelLabel.Location = new System.Drawing.Point(34, 41);
            this.satLabelLabel.Name = "satLabelLabel";
            this.satLabelLabel.Size = new System.Drawing.Size(26, 13);
            this.satLabelLabel.TabIndex = 3;
            this.satLabelLabel.Text = "Sat:";
            // 
            // valLabelLabel
            // 
            this.valLabelLabel.AutoSize = true;
            this.valLabelLabel.Location = new System.Drawing.Point(34, 54);
            this.valLabelLabel.Name = "valLabelLabel";
            this.valLabelLabel.Size = new System.Drawing.Size(25, 13);
            this.valLabelLabel.TabIndex = 4;
            this.valLabelLabel.Text = "Val:";
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.Location = new System.Drawing.Point(59, 41);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(36, 13);
            this.satLabel.TabIndex = 5;
            this.satLabel.Text = "100 %";
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(59, 54);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(19, 13);
            this.valLabel.TabIndex = 6;
            this.valLabel.Text = "55";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(119, 54);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(46, 13);
            this.blueLabel.TabIndex = 12;
            this.blueLabel.Text = "234/DD";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(119, 41);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(38, 13);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "44/EE";
            // 
            // blueLabelLabel
            // 
            this.blueLabelLabel.AutoSize = true;
            this.blueLabelLabel.Location = new System.Drawing.Point(94, 54);
            this.blueLabelLabel.Name = "blueLabelLabel";
            this.blueLabelLabel.Size = new System.Drawing.Size(25, 13);
            this.blueLabelLabel.TabIndex = 10;
            this.blueLabelLabel.Text = "Blu:";
            // 
            // greenLabelLabel
            // 
            this.greenLabelLabel.AutoSize = true;
            this.greenLabelLabel.Location = new System.Drawing.Point(94, 41);
            this.greenLabelLabel.Name = "greenLabelLabel";
            this.greenLabelLabel.Size = new System.Drawing.Size(27, 13);
            this.greenLabelLabel.TabIndex = 9;
            this.greenLabelLabel.Text = "Grn:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(119, 28);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(36, 13);
            this.redLabel.TabIndex = 8;
            this.redLabel.Text = "33/FF";
            // 
            // redLabelLabel
            // 
            this.redLabelLabel.AutoSize = true;
            this.redLabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabelLabel.Location = new System.Drawing.Point(94, 28);
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
            // probeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 88);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabelLabel);
            this.Controls.Add(this.greenLabelLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redLabelLabel);
            this.Controls.Add(this.valLabel);
            this.Controls.Add(this.satLabel);
            this.Controls.Add(this.valLabelLabel);
            this.Controls.Add(this.satLabelLabel);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.hueLabelLabel);
            this.Controls.Add(this.colorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "probeForm";
            this.Text = "Color Probe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label hueLabelLabel;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label satLabelLabel;
        private System.Windows.Forms.Label valLabelLabel;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabelLabel;
        private System.Windows.Forms.Label greenLabelLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label redLabelLabel;
        private System.Windows.Forms.Timer getColorTimer;
    }
}

