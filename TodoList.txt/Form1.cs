namespace TodoList.txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //richTextBox1.Items.Add(textValue_add.Text);

            if (string.IsNullOrEmpty(textValue_add.Text))
                return;
            richTextBox1.Text += textValue_add.Text + "\n";
            textValue_add.Clear();
            textValue_add.Focus();
        }

        private void textValue_remove_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textValue_add.Text))
                return;
                richTextBox1.Clear();
            //    return;
            //richTextBox1.Clear();
            //textValue_add.Clear();
            //textValue_add.Focus();
        }
    }
}