using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public int get_nums()
        //{
        //    int num1 = Convert.ToInt32(textBox1.Text);
        //    int num2 = Convert.ToInt32(textBox2.Text);

        //    return { num1, num2};
        //}

        private void add_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 + num2;

            //MessageBox.Show($"Your result is : {result.ToString()}");

            label4.Text = $"Your Addition Result is : {result.ToString()}";
            label4.Visible = true;

        }

       

        private void subs_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 - num2;
            label4.Text = $"Your Substraction Result is : {result.ToString()}";
            label4.Visible = true;
            //MessageBox.Show($"Your result is : {result.ToString()}");
        }
       
        private void multi_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 * num2;
            label4.Text = $"Your Multiplication Result is : {result.ToString()}";
            label4.Visible = true;
            //MessageBox.Show($"Your result is : {result.ToString()}");
        }
        private void div_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int result = num1 / num2;

            label4.Text = $"Your Division Result is : {result.ToString()}";
            label4.Visible = true;
            //MessageBox.Show($"Your result is : {result.ToString()}");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
