using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            calculate.Sub1grade = comboBox1.Text;
            calculate.Sub2grade = comboBox2.Text;
            calculate.Sub3grade = comboBox3.Text;
            calculate.Sub4grade = comboBox4.Text;
            calculate.Sub5grade = comboBox5.Text;
            calculate.Sub6grade = comboBox6.Text;
            calculate.Sub7grade = comboBox7.Text;
            calculate.Sub8grade = comboBox8.Text;
            calculate.Sub9grade = comboBox9.Text;
            calculate.Sub10grade = comboBox10.Text;
            calculate.Sub11grade = comboBox11.Text;
            calculate.Sub12grade = comboBox12.Text;
            calculate.Sub13grade = comboBox13.Text;
            calculate.Credittot = int.Parse(textBox1.Text);

            double gpa = calculate.gpa();
            label16.Text = gpa.ToString("0.00");

        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            string message = 
                "Introduction to Computer Science                    3\n" +
                "Mathematics for Computing                              3\n" +
                "Programming Fundamentals                              3\n" +
                "Electronics and Computer Architecture             4\n" +
                "Object Oriented Programming                           2\n" +
                "Database Management Systems                         4\n" +
                "Computer Networks                                            3\n" +
                "GUI Application Development                            4\n" +
                "Software Engineering                                          4\n" +
                "Enterprise Application Development-1              4\n" +
                "Operating Systems                                                4\n" +
                "Developing Modern Web                                    4\n" +
                "Business Solution Development Project             3";

            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            comboBox13.Text = "";
            textBox1.Text = "45";
            label16.Text = "";
        }
    }
}
