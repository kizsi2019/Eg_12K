namespace nobeldij_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Töltsön ki minden mezõt!");
            }

            if (Convert.ToInt32(textBox1.Text) < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelõ!");
            }
        }
    }
}