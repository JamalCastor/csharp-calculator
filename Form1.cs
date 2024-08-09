using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Displays form1
        }

        private void button1_Click(object sender, EventArgs e) //Button 1 
        {
            textBox1.Text += button1.Text; //Collecting all ones until you hit enter.

        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Text = "Test";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Collecting all twos until you hit enter.
        {
            textBox1.Text += button2.Text;

        }
        private void button16_Click(object sender, EventArgs e)
        //Add button
        {
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
            textBox4.Text = button16.Text;
            //textBox2.Visible = true;
            //textBox4.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        //Enter button
        {
            int number = 0;
            if (textBox4.Text == "+")
            {
                number = int.Parse(textBox2.Text) + int.Parse(textBox1.Text);
            }
            else if (textBox4.Text == "-")
            {
                number = int.Parse(textBox2.Text) - int.Parse(textBox1.Text);
            }
            else if (textBox4.Text == "*")
            {
                number = int.Parse(textBox2.Text) * int.Parse(textBox1.Text);
            }
            else if (textBox4.Text == "/")
            {
                number = int.Parse(textBox2.Text) / int.Parse(textBox1.Text);
            }

            textBox3.Text = number.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            //textBox3.Visible = true;
            //textBox1.Visible = false;
            //textBox2.Visible = false;
            //textBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) //Collecting all threes until you hit enter.
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)  //Collecting all fours until you hit enter.
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e) //Collecting all fivess until you hit enter.
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e) //Collecting all sixes until you hit enter.
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e) //Collecting all sevens until you hit enter.
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e) //Collecting all eights until you hit enter.
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e) //Collecting all nines until you hit enter.
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e) //Collecting all zeroes until you hit enter.
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Clear button
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Substract button
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
            textBox4.Text = button14.Text;
            //textBox4.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Multiply button
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
            textBox4.Text = button13.Text;
            // textBox4.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Division button
            textBox2.Text = textBox1.Text;
            textBox1.Text = "";
            textBox4.Text = button12.Text;
            //textBox4.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        //Final answer
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
