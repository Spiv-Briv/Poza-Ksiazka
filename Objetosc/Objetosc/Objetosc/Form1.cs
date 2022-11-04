namespace Objetosc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Kalk_Click(object sender, EventArgs e)
        {
            float h = float.Parse(this.Hgt.Text);
            float w = float.Parse(this.Wdt.Text);
            float d = float.Parse(this.Dpt.Text);
            float wynik = h * w * d;
            string j = "cm3";
            if (wynik >= 1000)
            {
                wynik /= 1000;
                j = "dm3";
            }
            if (wynik >= 1000)
            {
                wynik /= 1000;
                j = "m3";
            }

            MessageBox.Show(wynik + j, "Objêtoœæ wynosi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, 0);
        }
    }
}