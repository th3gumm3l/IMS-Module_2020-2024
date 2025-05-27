namespace SwissTransportGUI
{
    public partial class StartseiteForm : Form
    {
        public StartseiteForm()
        {
            InitializeComponent();
        }

        private void Verbindungen_btn_Click(object sender, EventArgs e)
        {
            var verbindungForm = new VerbindungForm(this);
            verbindungForm.Show();

            this.Hide();
        }

        private void Stationen_btn_Click(object sender, EventArgs e)
        {
            var stationForm = new StationForm(this);
            stationForm.Show();

            this.Hide();
        }

        private void SbbLogoPic_imgbx_Click(object sender, EventArgs e)
        {

        }
    }
}