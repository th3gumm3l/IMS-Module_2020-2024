using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  

namespace M404_B03_Prüfungsvorbereitung
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnBerechnen_Click(object sender, EventArgs e)
    {
      //Objekt erstellen
      Rechnung Rechnung1 = new Rechnung();

      //Werte einlesen
      try
      {
        Rechnung1.setMasse1(Convert.ToDouble(tbxMasse1.Text));
        Rechnung1.setMasse2(Convert.ToDouble(tbxMasse2.Text));
        Rechnung1.setAbstand(Convert.ToDouble(tbxAbstandPlaneten.Text));
      }

      catch (FormatException)
      {
        MessageBox.Show("Es wurde keine gültige Zahl eingelesen!");
      }

      catch (OverflowException)
      {
        MessageBox.Show("Die eingegebenen Zahlen sind zu hoch");
      }


      //Resultat Ausgabe
      double Resultat = Rechnung1.getLoesung();

      tbxResultat.Text = Convert.ToString(Resultat);


    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      tbxAbstandPlaneten.Clear();
      tbxMasse1.Clear();
      tbxMasse2.Clear();
      tbxResultat.Clear();
    }

    private void btnBeenden_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnHinzufügenRTX_Click(object sender, EventArgs e)
    {      
      //Eingabe in Richtextbox
      rtxAusgabe.AppendText(tbxResultat.Text);
      rtxAusgabe.AppendText("\t");

      rtxAusgabe.AppendText(tbxMasse1.Text);
      rtxAusgabe.AppendText("\t");

      rtxAusgabe.AppendText(tbxMasse2.Text);
      rtxAusgabe.AppendText("\n");

    }

    private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofp = new OpenFileDialog();
      ofp.Filter = "Text Files|*.txt| All Files |*.*";

      if (ofp.ShowDialog() == DialogResult.OK)
      {
        StreamReader Sreader = new StreamReader(File.OpenRead(ofp.FileName));

        rtxAusgabe.Text = Sreader.ReadToEnd();
        ofp.Dispose();
      }

    }

    private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e) 
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "Text File |*.txt";

      if (sfd.ShowDialog() == DialogResult.OK)
      {
        try
        {
          StreamWriter Swriter = new StreamWriter(File.Create(sfd.FileName));
          Swriter.Write(rtxAusgabe.Text);
          Swriter.Dispose();
        }

        catch (IOException ex)
        {
          MessageBox.Show("Konnte nicht gespeichert werden\n" + ex.Message);
        }
      }

    }

    private void grossesFeldLeerenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      rtxAusgabe.Clear();
      rtxAusgabe.ScrollBars = RichTextBoxScrollBars.None;
    }

    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Shortcuts(object sender, KeyEventArgs e)
    {
      if (e.Control && e.Shift && e.KeyCode == Keys.S)
       {
         speichernUnterToolStripMenuItem.PerformClick();
       }      


      else if (e.Control && e.KeyCode == Keys.W)
      {
        btnBeenden.PerformClick();
      }

    }

    private void letzterEintragLöschenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      
    }
  }
}
