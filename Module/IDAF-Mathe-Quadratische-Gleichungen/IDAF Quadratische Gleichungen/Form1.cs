using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDAF_Quadratische_Gleichungen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbx_EingabeA.Text);
            double b = Convert.ToDouble(tbx_EingabeB.Text);
            double c = Convert.ToDouble(tbx_EingabeC.Text);
            
            if (Math.Pow(b, 2)-4 * a * c == 0)
            {
                grResBox.Text = "Es gibt nur eine Lösung";
                MessageBox.Show("Es gibt nur eine Lösung");
                tbx_AusgabeX1.Text = "0";
                tbx_AusgabeX2.Text = Convert.ToString(-b / (2 * a));
            }
            else if (Math.Pow(b, 2) - 4 * a * c > 0)
            {
                grResBox.Text = "Es gibt zwei Lösungen";
                tbx_AusgabeX1.Text = Convert.ToString(((-b) + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a));
                tbx_AusgabeX2.Text = Convert.ToString(((-b) - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a));
            }
            else
            {
                grResBox.Text = "Es gibt keine Lösung";
                MessageBox.Show("Es gibt keine Lösung");
                tbx_AusgabeX1.Text = "0";
                tbx_AusgabeX2.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_AusgabeX1.Text = "";
            tbx_AusgabeX2.Text = "";
            tbx_EingabeA.Text = "";
            tbx_EingabeB.Text = "";
            tbx_EingabeC.Text = "";
            grResBox.Text = "";
        }
    }
}
