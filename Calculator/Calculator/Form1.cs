using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);

                if (comboBox1.SelectedItem == null || comboBox1.SelectedIndex == -1)
                {
                    throw new InvalidOperationException("Please select an operator.");
                }

                string selectedOperator = comboBox1.SelectedItem.ToString();
                double result = 0;
                switch (selectedOperator)
                {
                    case "add":
                        result = number1 + number2;
                        break;
                    case "sub":
                        result = number1 - number2;
                        break;
                    case "mul":
                        result = number1 * number2;
                        break;
                    case "div":
                        try
                        {
                            result = (double)number1 / number2;
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        break;
                }

                string resultText = $"Result of {selectedOperator} operation: {result}";
                Result resultPage = new Result(resultText);
                resultPage.ShowDialog();

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
            }

        }
    }
}
