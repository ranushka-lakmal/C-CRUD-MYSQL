namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category  category = new Category();
            category.Show();
            
            Form1 form = new Form1();
            this.Hide();    

        }
    }
}