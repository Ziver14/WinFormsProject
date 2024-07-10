namespace WinFormsProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextChange(object sender, EventArgs e)
        {
            //textBox1.Text += (sender as Control).Name + Environment.NewLine;
            if ((sender as Control).Text == "1")
            {
                (sender as Control).Text = "2";

            }
            else
            {
                (sender as Control).Text = "1";
            }
            if (checkBox3.Checked)
            {
                textBox1.Text += (sender as Control).Name + Environment.NewLine;
            }
            else
            {
                textBox1.Text += (sender as Control).Text + Environment.NewLine;
            }


        }

        private void MenuTest_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

        }

        string fileName;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openDialog.ShowDialog() == DialogResult.OK) { fileName = openDialog.FileName; }
            textBox1.Text +=  fileName + Environment.NewLine;
            StreamReader sr = new StreamReader(fileName);
            while(!sr.EndOfStream)
            {
                textBox1.Text += sr.ReadLine() + Environment.NewLine;

            }
            sr.Close();

        }
    }
}
