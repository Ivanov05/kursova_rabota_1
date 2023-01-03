namespace kursova_rabota_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Rectangle);
            t.Start();
        }
        private void Rectangle()
        {
        }
    }
}