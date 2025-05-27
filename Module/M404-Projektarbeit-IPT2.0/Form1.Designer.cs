
namespace M404_B03_Prüfungsvorbereitung
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.grossesFeldLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.letzterEintragLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnBeenden = new System.Windows.Forms.Button();
      this.btnBerechnen = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.btnHinzufügenRTX = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbxResultat = new System.Windows.Forms.TextBox();
      this.tbxAbstandPlaneten = new System.Windows.Forms.TextBox();
      this.tbxMasse2 = new System.Windows.Forms.TextBox();
      this.tbxMasse1 = new System.Windows.Forms.TextBox();
      this.rtxAusgabe = new System.Windows.Forms.RichTextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.menuStrip1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 97);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(600, 38);
      this.label1.TabIndex = 0;
      this.label1.Text = "Gravitationskraft zweier Massenpunkte";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // dateiToolStripMenuItem
      // 
      this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.dateiToolStripMenuItem.Text = "Datei";
      // 
      // öffnenToolStripMenuItem
      // 
      this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
      this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.öffnenToolStripMenuItem.Text = "Öffnen";
      this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
      // 
      // speichernUnterToolStripMenuItem
      // 
      this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
      this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.speichernUnterToolStripMenuItem.Text = "Speichern Unter";
      this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // bearbeitenToolStripMenuItem
      // 
      this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grossesFeldLeerenToolStripMenuItem,
            this.letzterEintragLöschenToolStripMenuItem});
      this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
      this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
      // 
      // grossesFeldLeerenToolStripMenuItem
      // 
      this.grossesFeldLeerenToolStripMenuItem.Name = "grossesFeldLeerenToolStripMenuItem";
      this.grossesFeldLeerenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.grossesFeldLeerenToolStripMenuItem.Text = "Grosses Feld leeren";
      this.grossesFeldLeerenToolStripMenuItem.Click += new System.EventHandler(this.grossesFeldLeerenToolStripMenuItem_Click);
      // 
      // letzterEintragLöschenToolStripMenuItem
      // 
      this.letzterEintragLöschenToolStripMenuItem.Name = "letzterEintragLöschenToolStripMenuItem";
      this.letzterEintragLöschenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.letzterEintragLöschenToolStripMenuItem.Text = "Letzter Eintrag löschen";
      this.letzterEintragLöschenToolStripMenuItem.Click += new System.EventHandler(this.letzterEintragLöschenToolStripMenuItem_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnBeenden);
      this.panel2.Controls.Add(this.btnBerechnen);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 356);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 94);
      this.panel2.TabIndex = 1;
      // 
      // btnBeenden
      // 
      this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBeenden.Location = new System.Drawing.Point(632, 22);
      this.btnBeenden.Name = "btnBeenden";
      this.btnBeenden.Size = new System.Drawing.Size(145, 50);
      this.btnBeenden.TabIndex = 6;
      this.btnBeenden.Text = "Beenden";
      this.btnBeenden.UseVisualStyleBackColor = true;
      this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
      // 
      // btnBerechnen
      // 
      this.btnBerechnen.BackColor = System.Drawing.SystemColors.Control;
      this.btnBerechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBerechnen.Location = new System.Drawing.Point(25, 22);
      this.btnBerechnen.Name = "btnBerechnen";
      this.btnBerechnen.Size = new System.Drawing.Size(126, 50);
      this.btnBerechnen.TabIndex = 4;
      this.btnBerechnen.Text = "Berechnen";
      this.btnBerechnen.UseVisualStyleBackColor = false;
      this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(284, 6);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(93, 50);
      this.btnClear.TabIndex = 5;
      this.btnClear.Text = "Felder leeren";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.btnHinzufügenRTX);
      this.panel3.Controls.Add(this.label5);
      this.panel3.Controls.Add(this.btnClear);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Controls.Add(this.label2);
      this.panel3.Controls.Add(this.tbxResultat);
      this.panel3.Controls.Add(this.tbxAbstandPlaneten);
      this.panel3.Controls.Add(this.tbxMasse2);
      this.panel3.Controls.Add(this.tbxMasse1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 97);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(383, 259);
      this.panel3.TabIndex = 2;
      // 
      // btnHinzufügenRTX
      // 
      this.btnHinzufügenRTX.Location = new System.Drawing.Point(284, 203);
      this.btnHinzufügenRTX.Name = "btnHinzufügenRTX";
      this.btnHinzufügenRTX.Size = new System.Drawing.Size(93, 50);
      this.btnHinzufügenRTX.TabIndex = 9;
      this.btnHinzufügenRTX.Text = "Hinzufügen";
      this.btnHinzufügenRTX.UseVisualStyleBackColor = true;
      this.btnHinzufügenRTX.Click += new System.EventHandler(this.btnHinzufügenRTX_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(22, 179);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 17);
      this.label5.TabIndex = 7;
      this.label5.Text = "Resultat";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(109, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Abstand der Planeten";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "2. Masse";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "1. Masse";
      // 
      // tbxResultat
      // 
      this.tbxResultat.Location = new System.Drawing.Point(25, 199);
      this.tbxResultat.Name = "tbxResultat";
      this.tbxResultat.ReadOnly = true;
      this.tbxResultat.Size = new System.Drawing.Size(162, 20);
      this.tbxResultat.TabIndex = 3;
      // 
      // tbxAbstandPlaneten
      // 
      this.tbxAbstandPlaneten.Location = new System.Drawing.Point(25, 126);
      this.tbxAbstandPlaneten.Name = "tbxAbstandPlaneten";
      this.tbxAbstandPlaneten.Size = new System.Drawing.Size(162, 20);
      this.tbxAbstandPlaneten.TabIndex = 2;
      // 
      // tbxMasse2
      // 
      this.tbxMasse2.Location = new System.Drawing.Point(25, 76);
      this.tbxMasse2.Name = "tbxMasse2";
      this.tbxMasse2.Size = new System.Drawing.Size(162, 20);
      this.tbxMasse2.TabIndex = 1;
      // 
      // tbxMasse1
      // 
      this.tbxMasse1.Location = new System.Drawing.Point(25, 27);
      this.tbxMasse1.Name = "tbxMasse1";
      this.tbxMasse1.Size = new System.Drawing.Size(162, 20);
      this.tbxMasse1.TabIndex = 0;
      // 
      // rtxAusgabe
      // 
      this.rtxAusgabe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtxAusgabe.Location = new System.Drawing.Point(383, 97);
      this.rtxAusgabe.Name = "rtxAusgabe";
      this.rtxAusgabe.ReadOnly = true;
      this.rtxAusgabe.Size = new System.Drawing.Size(417, 259);
      this.rtxAusgabe.TabIndex = 3;
      this.rtxAusgabe.Text = "";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.rtxAusgabe);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Gravitationskraft zweier Massenpunkte";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shortcuts);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnBeenden;
    private System.Windows.Forms.Button btnBerechnen;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox tbxResultat;
    private System.Windows.Forms.TextBox tbxAbstandPlaneten;
    private System.Windows.Forms.TextBox tbxMasse2;
    private System.Windows.Forms.TextBox tbxMasse1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox rtxAusgabe;
    private System.Windows.Forms.Button btnHinzufügenRTX;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem grossesFeldLeerenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem letzterEintragLöschenToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

