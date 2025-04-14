namespace task3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 newForm1 = new frm2();
            newForm1.Show();

        }

        private void from2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 newForm1 = new frm3();
            newForm1.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}