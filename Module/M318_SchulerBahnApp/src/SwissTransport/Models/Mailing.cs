namespace SwissTransport.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mailing
    {
        private string _abfahrtsort;
        private string _ankunftsort;
        private string _dauer;
        private string _gleis;
        private string _verspaetung;

        public Mailing(string abfahrtsort, string ankunftsort, string dauer, string gleis, string verspaetung)
        {
            this._abfahrtsort = abfahrtsort;
            this._ankunftsort = ankunftsort;
            this._dauer = dauer;
            this._gleis = gleis;
            this._verspaetung = verspaetung;
        }

        public string Url
        {
            get
            {
                return $"mailto:{"mail@domain.com"}?subject={"Informationen für die Verbindung"}" +
                    $"&body=Abfahrtsort ={this._abfahrtsort} \n Ankunftsort ={this._ankunftsort} \n " +
                    $"Dauer ={this._dauer} \n Gleis ={this._gleis}\n Verspätung ={this._verspaetung}";
            }
        }

        public void OpenMailClientandFillIn()
        {
            Process.Start(new ProcessStartInfo(this.Url) { UseShellExecute = true });
        }
    }
}
