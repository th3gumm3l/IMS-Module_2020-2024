namespace SwissTransportGUI
{
    partial class VerbindungForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerbindungForm));
            this.vSuchanzeigen_gpbx = new System.Windows.Forms.GroupBox();
            this.vSuchanzeigen_dgv = new System.Windows.Forms.DataGridView();
            this.Abfahrt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teilen_colBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.vMainSearch_btn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.vSearchAnkunftsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.vSearchAbfahrtsOrt_cbx = new System.Windows.Forms.ComboBox();
            this.vSuchanzeigen_gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSuchanzeigen_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vSuchanzeigen_gpbx
            // 
            this.vSuchanzeigen_gpbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vSuchanzeigen_gpbx.Controls.Add(this.vSuchanzeigen_dgv);
            this.vSuchanzeigen_gpbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vSuchanzeigen_gpbx.Location = new System.Drawing.Point(11, 375);
            this.vSuchanzeigen_gpbx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vSuchanzeigen_gpbx.Name = "vSuchanzeigen_gpbx";
            this.vSuchanzeigen_gpbx.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vSuchanzeigen_gpbx.Size = new System.Drawing.Size(1870, 612);
            this.vSuchanzeigen_gpbx.TabIndex = 0;
            this.vSuchanzeigen_gpbx.TabStop = false;
            this.vSuchanzeigen_gpbx.Text = "Suchanzeigen";
            // 
            // vSuchanzeigen_dgv
            // 
            this.vSuchanzeigen_dgv.AllowUserToAddRows = false;
            this.vSuchanzeigen_dgv.AllowUserToDeleteRows = false;
            this.vSuchanzeigen_dgv.AllowUserToResizeColumns = false;
            this.vSuchanzeigen_dgv.AllowUserToResizeRows = false;
            this.vSuchanzeigen_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vSuchanzeigen_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vSuchanzeigen_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vSuchanzeigen_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vSuchanzeigen_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt_col,
            this.Ankunft_col,
            this.Dauer_col,
            this.Gleis_col,
            this.Verspätung_col,
            this.Teilen_colBtn});
            this.vSuchanzeigen_dgv.Location = new System.Drawing.Point(7, 38);
            this.vSuchanzeigen_dgv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vSuchanzeigen_dgv.Name = "vSuchanzeigen_dgv";
            this.vSuchanzeigen_dgv.ReadOnly = true;
            this.vSuchanzeigen_dgv.RowHeadersVisible = false;
            this.vSuchanzeigen_dgv.RowHeadersWidth = 4;
            this.vSuchanzeigen_dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vSuchanzeigen_dgv.RowTemplate.Height = 41;
            this.vSuchanzeigen_dgv.RowTemplate.ReadOnly = true;
            this.vSuchanzeigen_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vSuchanzeigen_dgv.Size = new System.Drawing.Size(1842, 553);
            this.vSuchanzeigen_dgv.StandardTab = true;
            this.vSuchanzeigen_dgv.TabIndex = 0;
            this.vSuchanzeigen_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vSuchanzeigen_dgv_CellContentClick);
            // 
            // Abfahrt_col
            // 
            this.Abfahrt_col.HeaderText = "Abfahrt";
            this.Abfahrt_col.MinimumWidth = 10;
            this.Abfahrt_col.Name = "Abfahrt_col";
            this.Abfahrt_col.ReadOnly = true;
            this.Abfahrt_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abfahrt_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Ankunft_col
            // 
            this.Ankunft_col.HeaderText = "Ankuft";
            this.Ankunft_col.MinimumWidth = 10;
            this.Ankunft_col.Name = "Ankunft_col";
            this.Ankunft_col.ReadOnly = true;
            this.Ankunft_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ankunft_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Dauer_col
            // 
            this.Dauer_col.HeaderText = "Dauer";
            this.Dauer_col.MinimumWidth = 10;
            this.Dauer_col.Name = "Dauer_col";
            this.Dauer_col.ReadOnly = true;
            this.Dauer_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dauer_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Gleis_col
            // 
            this.Gleis_col.HeaderText = "Gleis";
            this.Gleis_col.MinimumWidth = 10;
            this.Gleis_col.Name = "Gleis_col";
            this.Gleis_col.ReadOnly = true;
            this.Gleis_col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gleis_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Verspätung_col
            // 
            this.Verspätung_col.HeaderText = "Verspätung";
            this.Verspätung_col.MinimumWidth = 10;
            this.Verspätung_col.Name = "Verspätung_col";
            this.Verspätung_col.ReadOnly = true;
            // 
            // Teilen_colBtn
            // 
            this.Teilen_colBtn.HeaderText = "Teilen";
            this.Teilen_colBtn.MinimumWidth = 10;
            this.Teilen_colBtn.Name = "Teilen_colBtn";
            this.Teilen_colBtn.ReadOnly = true;
            this.Teilen_colBtn.Text = "Teilen";
            this.Teilen_colBtn.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vMainSearch_btn);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.vSearchAnkunftsOrt_cbx);
            this.panel1.Controls.Add(this.vSearchAbfahrtsOrt_cbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 369);
            this.panel1.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(1341, 152);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(192, 39);
            this.timePicker.TabIndex = 5;
            this.timePicker.Value = new System.DateTime(2022, 4, 28, 15, 49, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geben Sie ihre gewünschte Verbindung ein";
            // 
            // vMainSearch_btn
            // 
            this.vMainSearch_btn.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vMainSearch_btn.Location = new System.Drawing.Point(1569, 265);
            this.vMainSearch_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vMainSearch_btn.Name = "vMainSearch_btn";
            this.vMainSearch_btn.Size = new System.Drawing.Size(292, 68);
            this.vMainSearch_btn.TabIndex = 4;
            this.vMainSearch_btn.Text = "Suchen";
            this.vMainSearch_btn.UseVisualStyleBackColor = true;
            this.vMainSearch_btn.Click += new System.EventHandler(this.vMainSearch_btn_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(1109, 152);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(177, 39);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2022, 4, 28, 0, 0, 0, 0);
            // 
            // vSearchAnkunftsOrt_cbx
            // 
            this.vSearchAnkunftsOrt_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vSearchAnkunftsOrt_cbx.FormattingEnabled = true;
            this.vSearchAnkunftsOrt_cbx.Location = new System.Drawing.Point(620, 156);
            this.vSearchAnkunftsOrt_cbx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vSearchAnkunftsOrt_cbx.Name = "vSearchAnkunftsOrt_cbx";
            this.vSearchAnkunftsOrt_cbx.Size = new System.Drawing.Size(361, 36);
            this.vSearchAnkunftsOrt_cbx.TabIndex = 2;
            this.vSearchAnkunftsOrt_cbx.Text = "Ankunftsort";
            this.vSearchAnkunftsOrt_cbx.Enter += new System.EventHandler(this.vSearchAnkunftsOrt_cbx_Enter);
            this.vSearchAnkunftsOrt_cbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vSearchAnkunftsOrt_cbx_KeyUp);
            this.vSearchAnkunftsOrt_cbx.Leave += new System.EventHandler(this.vSearchAnkunftsOrt_cbx_Leave);
            // 
            // vSearchAbfahrtsOrt_cbx
            // 
            this.vSearchAbfahrtsOrt_cbx.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vSearchAbfahrtsOrt_cbx.FormattingEnabled = true;
            this.vSearchAbfahrtsOrt_cbx.Location = new System.Drawing.Point(121, 156);
            this.vSearchAbfahrtsOrt_cbx.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.vSearchAbfahrtsOrt_cbx.Name = "vSearchAbfahrtsOrt_cbx";
            this.vSearchAbfahrtsOrt_cbx.Size = new System.Drawing.Size(361, 36);
            this.vSearchAbfahrtsOrt_cbx.TabIndex = 1;
            this.vSearchAbfahrtsOrt_cbx.Text = "Abfahrtsort";
            this.vSearchAbfahrtsOrt_cbx.Enter += new System.EventHandler(this.vSearchAbfahrtsOrt_cbx_Enter);
            this.vSearchAbfahrtsOrt_cbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vSearchAbfahrtsOrt_cbx_KeyUp);
            this.vSearchAbfahrtsOrt_cbx.Leave += new System.EventHandler(this.vSearchAbfahrtsOrt_cbx_Leave);
            // 
            // VerbindungForm
            // 
            this.AcceptButton = this.vMainSearch_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vSuchanzeigen_gpbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerbindungForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schuler BahnApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerbindungForm_FormClosing);
            this.vSuchanzeigen_gpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSuchanzeigen_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox vSuchanzeigen_gpbx;
        private Panel panel1;
        private ComboBox vSearchAbfahrtsOrt_cbx;
        private ComboBox vSearchAnkunftsOrt_cbx;
        private Button vMainSearch_btn;
        private DateTimePicker datePicker;
        private DataGridView vSuchanzeigen_dgv;
        private Label label1;
        private DataGridViewTextBoxColumn Abfahrt_col;
        private DataGridViewTextBoxColumn Ankunft_col;
        private DataGridViewTextBoxColumn Dauer_col;
        private DataGridViewTextBoxColumn Gleis_col;
        private DataGridViewTextBoxColumn Verspätung_col;
        private DataGridViewButtonColumn Teilen_colBtn;
        private DateTimePicker timePicker;
    }
}