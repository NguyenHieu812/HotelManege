namespace Ql_KhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fm = new FormLogin();
            fm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}