namespace Kütüphane_Yönet
{
    public partial class Yonetim : Form
    {
        public Yonetim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kişiler kişiler = new Kişiler();
            kişiler.Show();


           


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emanetler emanetler = new Emanetler();
            emanetler.Show();
        }
    }
}
