namespace Hero_Quest
{
    public partial class Form1 : Form
    {
        string heroname;
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void SetName_Click(object sender, EventArgs e)
        {
            heroname = NameText.Text;
            OutputLabel.Text = "Have a Good Day!" + heroname;

        }

        private void OutputLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
