namespace лаба_11_з1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(trackBar1.Value);
            double res = (n * n * (n + 1) * (n + 1) / 4);
            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(trackBar1.Value);
            double sum = 0;
            for (int i=1; i <= n; i++) 
            {
                sum +=  Math.Pow(i, 3);
            }
            textBox1.Text = sum.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            label4.Text = String.Format("Текущее значение n: {0}", trackBar1.Value);
        }
    }
}
