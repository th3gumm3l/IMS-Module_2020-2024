using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace M404_B03_Prüfungsvorbereitung
{
  class Rechnung
  {

    private double m_Masse1;
    private double m_Masse2;
    private double m_Abstand;
    private double m_Gravitationskonst;

    private double Lösung;


    public Rechnung() 
    {
      m_Masse1 = 0;
      m_Masse2 = 0;
      m_Abstand = 0;
      m_Gravitationskonst = 0;
    }


    public void setMasse1(double value)
    {
       m_Masse1 = value;
    }

    public void setMasse2(double value)
    {
      m_Masse2 = value;
    }

    public void setAbstand(double value)
    {
      m_Abstand = value;
      if (value == 0)
      {
        MessageBox.Show("Der Abstand ist 0 gewesen");
      }

    }


    public double getLoesung()
    {
      m_Abstand = Math.Pow(m_Abstand, 2);
      m_Gravitationskonst = 6.67408 * Math.Pow(10, -11);

      Lösung = m_Gravitationskonst * ((m_Masse1 * m_Masse2) / m_Abstand);

      return Lösung;
    }


  }
}
