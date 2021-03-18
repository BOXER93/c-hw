using System;
using System.Windows.Forms;




namespace math02
{
    public partial class UserControl1 : System.Windows.Forms.Form
    {
        public UserControl1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int c;
            if (comboBox1.Text == "+")
            {
                c = a + b;
                textBox4.Text = c.ToString();  //将int转为string类型。
            }
            else if (comboBox1.Text == "-")
            {
                c = a - b;
                textBox4.Text = c.ToString();
            }
            else if (comboBox1.Text == "*")
            {
                c = a * b;
                textBox4.Text = c.ToString();

            }
            else
            {
                c = a / b;
                textBox4.Text = c.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
