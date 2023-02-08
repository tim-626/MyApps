namespace MyAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lib = new MyLibWin.MyLibWin();
            label1.Text = lib.DoSomethingWin();
        }
    }
}