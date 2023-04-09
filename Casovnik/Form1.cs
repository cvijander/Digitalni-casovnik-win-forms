namespace Casovnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tacnoVreme = DateTime.Now;
            label1.Text = PrikaziVreme(tacnoVreme);
        }

        private string PrikaziVreme(DateTime tacnoVreme)
        {
            int h = tacnoVreme.Hour;
            int m = tacnoVreme.Minute;
            int s = tacnoVreme.Second;
            int ms = tacnoVreme.Millisecond;

            string th = "", tm = "", ts = "", tms = "";

            if (h < 10) th = "0" + h;
            else th = "" + h;
            if (m < 10) tm = "0" + m;
            else tm = "" + m;
            if (s < 10) ts = "0" + s;
            else ts = "" + s;
            if (ms < 10) tms = "00" + ms;
            else if (ms < 100) tms = "0" + ms;
            else tms = "" + ms;
            return th + ":" + tm + ":" + ts + "." + tms.ToString();
        }
    }
}