using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        string watermark = "Springs Junk Gen C++";

        public Form1()
        {
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "wstring" || textBox1.Text == "string" || textBox1.Text == "void" || textBox1.Text == "int" || textBox1.Text == "long" || textBox1.Text == "char" || textBox1.Text == "func+junk" || textBox1.Text == "bool" || textBox1.Text == "float")
            {
                Gen();
            }
            else if (textBox1.Text == "" || textBox1.Text == "Type")
            {
                MessageBox.Show("Empty Text", watermark);
            }
            else
            {
                MessageBox.Show("Not a valid option", watermark);
            }

        }
        int counter;
        const string q = "\"";
        void Gen()
        {
            if (textBox1.Text == "string")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += $"string {FunctionName} = {q}{num2 + FunctionName + FunctionName}{q};\n";
                    counter++;
                }

            }
            else if (textBox1.Text == "wstring")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += $"wstring {FunctionName} = L{q}{FunctionName + FunctionName + FunctionName}{q};\n";
                    counter++;
                }
            }
            else if (textBox1.Text == "void")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += ("void " + FunctionName + FunctionName + FunctionName +"() { }\n");
                    counter++;
                }
            }
            else if (textBox1.Text == "int")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += ($"int {FunctionName} = {num2};\n");
                    counter++;
                }
            }
            else if (textBox1.Text == "long")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += ($"long {FunctionName + num2 + FunctionName + num1} = {num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 + num2 };\n");
                    counter++;
                }
            }
            else if (textBox1.Text == "char")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += $"const char* {FunctionName + FunctionName} = {q}{FunctionName + num2 + FunctionName + FunctionName}{q};\n";
                    counter++;
                }
            }
            else if (textBox1.Text == "bool")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    int num4 = random.Next(5, 50);
                    int num5 = random.Next(1, 2);
                    string FunctionName = RandomString(30);

                    if (num4 > 15)
                    {
                        richTextBox1.Text += $"bool {FunctionName + num1} = true;\n";
                    }
                    else if (num4 < 15)
                    {
                        richTextBox1.Text += $"bool {FunctionName + num1} = false;\n";
                    }
                    if(num5 != 1)
                    {
                        richTextBox1.Text += $"bool {FunctionName + FunctionName};\n";
                    }
                    else
                    {
                        richTextBox1.Text += $"bool {FunctionName};\n";
                    }

                    counter++;
                }
            }
            else if (textBox1.Text == "func+junk")
            {
                while (counter != numb.Value)
                {

                }
            }
            else if  (textBox1.Text == "float")
            {
                while (counter != numb.Value)
                {
                    Random random = new Random();
                    int num1 = random.Next(1, 26);
                    int num2 = random.Next(1000, 50000000);
                    string FunctionName = RandomString(30);


                    richTextBox1.Text += $"float {FunctionName + FunctionName} = {num1 + num2 + num1 + num2}.f;\n";
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Error Occuerd", watermark);
            }
        }
    }
}
