namespace Discover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }
    }
}
