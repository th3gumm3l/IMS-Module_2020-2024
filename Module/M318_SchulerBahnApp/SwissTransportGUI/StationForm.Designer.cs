namespace SwissTransportGUI
{
    partial class StationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sMainSearch_btn = new System.Windows.Forms.Button();
            this.sStationsuchen_cbx = new System.Windows.Forms.ComboBox();
            this.sSuchanzeigen_gpbx = new System.Windows.Forms.GroupBox();
            this.sSuchanzeigen_dgv = new System.Windows.Forms.DataGridView();
            this.Ankunftsort_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UhrzeitDatum_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.sSuchanzeigen_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sSuchanzeigen_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sMainSearch_btn);
            this.panel1.Controls.Add(this.sStationsuchen_cbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 358);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(548, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abfahrtstafel";
            // 
            // sMainSearch_btn
            // 
            this.sMainSearch_btn.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sMainSearch_btn.Location = new System.Drawing.Point(557, 226);
            this.sMainSearch_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sMainSearch_btn.Name = "sMainSearch_btn";
            this.sMainSearch_btn.Size = new System.Drawing.Size(186, 70);
            this.sMainSearch_btn.TabIndex = 1;
            this.sMainSearch_btn.Text = "Suchen";
            this.sMainSearch_btn.UseVisualStyleBackColor = true;
            this.sMainSearch_btn.Click += new System.EventHandler(this.sMainSearch_btn_Click);
            // 
            // sStationsuchen_cbx
            // 
            this.sStationsuchen_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sStationsuchen_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sStationsuchen_cbx.FormattingEnabled = true;
            this.sStationsuchen_cbx.Location = new System.Drawing.Point(414, 141);
            this.sStationsuchen_cbx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sStationsuchen_cbx.Name = "sStationsuchen_cbx";
            this.sStationsuchen_cbx.Size = new System.Drawing.Size(487, 36);
            this.sStationsuchen_cbx.TabIndex = 0;
            this.sStationsuchen_cbx.Text = "Station eingeben";
            this.sStationsuchen_cbx.Enter += new System.EventHandler(this.sStationsuchen_cbx_Enter);
            this.sStationsuchen_cbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sStationsuchen_cbx_KeyUp);
            this.sStationsuchen_cbx.Leave += new System.EventHandler(this.sStationsuchen_cbx_Leave);
            // 
            // sSuchanzeigen_gpbx
            // 
            this.sSuchanzeigen_gpbx.Controls.Add(this.sSuchanzeigen_dgv);
            this.sSuchanzeigen_gpbx.Location = new System.Drawing.Point(11, 365);
            this.sSuchanzeigen_gpbx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sSuchanzeigen_gpbx.Name = "sSuchanzeigen_gpbx";
            this.sSuchanzeigen_gpbx.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sSuchanzeigen_gpbx.Size = new System.Drawing.Size(1306, 715);
            this.sSuchanzeigen_gpbx.TabIndex = 1;
            this.sSuchanzeigen_gpbx.TabStop = false;
            this.sSuchanzeigen_gpbx.Text = "Suchanzeigen";
            // 
            // sSuchanzeigen_dgv
            // 
            this.sSuchanzeigen_dgv.AllowUserToAddRows = false;
            this.sSuchanzeigen_dgv.AllowUserToDeleteRows = false;
            this.sSuchanzeigen_dgv.AllowUserToResizeColumns = false;
            this.sSuchanzeigen_dgv.AllowUserToResizeRows = false;
            this.sSuchanzeigen_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sSuchanzeigen_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sSuchanzeigen_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sSuchanzeigen_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sSuchanzeigen_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ankunftsort_col,
            this.UhrzeitDatum_col});
            this.sSuchanzeigen_dgv.Location = new System.Drawing.Point(6, 38);
            this.sSuchanzeigen_dgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sSuchanzeigen_dgv.Name = "sSuchanzeigen_dgv";
            this.sSuchanzeigen_dgv.ReadOnly = true;
            this.sSuchanzeigen_dgv.RowHeadersVisible = false;
            this.sSuchanzeigen_dgv.RowHeadersWidth = 82;
            this.sSuchanzeigen_dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sSuchanzeigen_dgv.RowTemplate.Height = 41;
            this.sSuchanzeigen_dgv.RowTemplate.ReadOnly = true;
            this.sSuchanzeigen_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sSuchanzeigen_dgv.Size = new System.Drawing.Size(1285, 670);
            this.sSuchanzeigen_dgv.TabIndex = 0;
            // 
            // Ankunftsort_col
            // 
            this.Ankunftsort_col.HeaderText = "Ankunftsort";
            this.Ankunftsort_col.MinimumWidth = 10;
            this.Ankunftsort_col.Name = "Ankunftsort_col";
            this.Ankunftsort_col.ReadOnly = true;
            this.Ankunftsort_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ankunftsort_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // UhrzeitDatum_col
            // 
            this.UhrzeitDatum_col.HeaderText = "Datum & Uhrzeit";
            this.UhrzeitDatum_col.MinimumWidth = 10;
            this.UhrzeitDatum_col.Name = "UhrzeitDatum_col";
            this.UhrzeitDatum_col.ReadOnly = true;
            this.UhrzeitDatum_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UhrzeitDatum_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StationForm
            // 
            this.AcceptButton = this.sMainSearch_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 1090);
            this.Controls.Add(this.sSuchanzeigen_gpbx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schuber BahnApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StationForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sSuchanzeigen_gpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sSuchanzeigen_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox sStationsuchen_cbx;
        private GroupBox sSuchanzeigen_gpbx;
        private DataGridView sSuchanzeigen_dgv;
        private Button sMainSearch_btn;
        private Label label1;
        private DataGridViewTextBoxColumn Ankunftsort_col;
        private DataGridViewTextBoxColumn UhrzeitDatum_col;
    }
}