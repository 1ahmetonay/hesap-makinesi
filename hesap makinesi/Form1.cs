namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            lblsonuc.Text += "-";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
           // textBox2.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            //textBox2.Text = "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
           // textBox2.Text = "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
           // textBox2.Text = "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
           // textBox2.Text = "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
           // textBox2.Text = "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
           // textBox2.Text = "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            //textBox2.Text = "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            //textBox2.Text = "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            //textBox2.Text = "9";
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = "";
        }

        private void btnmod_Click(object sender, EventArgs e)
        {

        }
    }
}