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
        string fileName;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveDialog.ShowDialog() == DialogResult.Cancel)
            { return; }
            fileName = saveDialog.FileName;
            System.IO.File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show("Файл сохранен");

        }

        //string fileName;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK) { fileName = openDialog.FileName; }
            textBox1.Text += fileName + Environment.NewLine;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                textBox1.Text += sr.ReadLine() + Environment.NewLine;

            }
            sr.Close();

        }

        //Этот метод делает убегающую кнопку при нажатии
        //private void btnRun_MouseClick(object sender, EventArgs e)
        //{
        //    Random r = new Random();
        //    btnRun.Left = r.Next(0, this.Size.Width - btnRun.Width);
        //    btnRun.Top = r.Next(0, this.Size.Height - btnRun.Height);
        //}

        //Этот метод делает убегающую кнопку при наведении на него курсора мыши
        private void btnRun_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            btnRun.Left = r.Next(0, this.Size.Width - btnRun.Width);
            btnRun.Top = r.Next(0, this.Size.Height - btnRun.Height);
        }
    }
}
