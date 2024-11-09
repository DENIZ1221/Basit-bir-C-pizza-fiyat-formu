namespace checkbox_koşullu_örnekl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sabitPizza = 75;

            if (checkBox1Zeytin.Checked)
            {
                sabitPizza = sabitPizza + 15;
            }
            if (checkBox2Sucuk.Checked)
            {
                sabitPizza=sabitPizza + 25;
            }
            if (checkBox3Sosis.Checked)
            {
                sabitPizza += 20;
            }
            if (checkBox4Mısır.Checked)
            {
                sabitPizza += 10; 
            }
            textBox1.Text = sabitPizza.ToString();
        }
    }
}
