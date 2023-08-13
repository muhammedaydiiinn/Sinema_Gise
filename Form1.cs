namespace Degiskenler_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(textMısır.Text);
            bilet = Convert.ToInt16(textBilet.Text);
            su = Convert.ToInt16(textSu.Text);
            cay = Convert.ToInt16(textCay.Text);

            toplam = misir * 15 + cay * 8 + su * 5 + bilet * 70;
            lblToplam.Text = toplam + " ₺";

            kasaTutar += toplam;
            lblKasa.Text = kasaTutar + " ₺";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBilet.Text = "";
            textSu.Text = "";
            textMısır.Text = "";
            textCay.Text = "";
            textMısır.Focus();

        }
    }
}