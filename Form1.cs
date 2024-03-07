namespace Mod3_1302220072
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angka;
        int hasil = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka = int.Parse(label1.Text);
            this.label1.Text += this.label1.Text;
            this.label1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hasil = angka + int.Parse(label1.Text);
            label1.Text = hasil.ToString();
        }
    }
}
