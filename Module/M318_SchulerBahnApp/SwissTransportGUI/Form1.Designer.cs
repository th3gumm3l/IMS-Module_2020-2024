namespace SwissTransportGUI
{
    partial class StartseiteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartseiteForm));
            this.SbbLogoPic_imgbx = new System.Windows.Forms.PictureBox();
            this.Verbindungen_btn = new System.Windows.Forms.Button();
            this.Stationen_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SbbLogoPic_imgbx)).BeginInit();
            this.SuspendLayout();
            // 
            // SbbLogoPic_imgbx
            // 
            this.SbbLogoPic_imgbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SbbLogoPic_imgbx.Image = ((System.Drawing.Image)(resources.GetObject("SbbLogoPic_imgbx.Image")));
            this.SbbLogoPic_imgbx.Location = new System.Drawing.Point(40, 10);
            this.SbbLogoPic_imgbx.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SbbLogoPic_imgbx.Name = "SbbLogoPic_imgbx";
            this.SbbLogoPic_imgbx.Size = new System.Drawing.Size(460, 145);
            this.SbbLogoPic_imgbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SbbLogoPic_imgbx.TabIndex = 0;
            this.SbbLogoPic_imgbx.TabStop = false;
            this.SbbLogoPic_imgbx.Click += new System.EventHandler(this.SbbLogoPic_imgbx_Click);
            // 
            // Verbindungen_btn
            // 
            this.Verbindungen_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Verbindungen_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Verbindungen_btn.FlatAppearance.BorderSize = 0;
            this.Verbindungen_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindungen_btn.Location = new System.Drawing.Point(53, 177);
            this.Verbindungen_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Verbindungen_btn.Name = "Verbindungen_btn";
            this.Verbindungen_btn.Size = new System.Drawing.Size(205, 187);
            this.Verbindungen_btn.TabIndex = 1;
            this.Verbindungen_btn.Text = "Verbindungen suchen";
            this.Verbindungen_btn.UseVisualStyleBackColor = false;
            this.Verbindungen_btn.Click += new System.EventHandler(this.Verbindungen_btn_Click);
            // 
            // Stationen_btn
            // 
            this.Stationen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stationen_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Stationen_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Stationen_btn.FlatAppearance.BorderSize = 0;
            this.Stationen_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stationen_btn.Location = new System.Drawing.Point(279, 177);
            this.Stationen_btn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Stationen_btn.Name = "Stationen_btn";
            this.Stationen_btn.Size = new System.Drawing.Size(205, 187);
            this.Stationen_btn.TabIndex = 2;
            this.Stationen_btn.Text = "Abfahrtstafel";
            this.Stationen_btn.UseVisualStyleBackColor = false;
            this.Stationen_btn.Click += new System.EventHandler(this.Stationen_btn_Click);
            // 
            // StartseiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 549);
            this.Controls.Add(this.Stationen_btn);
            this.Controls.Add(this.Verbindungen_btn);
            this.Controls.Add(this.SbbLogoPic_imgbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartseiteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schuler BahnApp";
            ((System.ComponentModel.ISupportInitialize)(this.SbbLogoPic_imgbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox SbbLogoPic_imgbx;
        private Button Verbindungen_btn;
        private Button Stationen_btn;
    }
}