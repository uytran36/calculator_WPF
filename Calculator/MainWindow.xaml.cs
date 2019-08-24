using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        decimal num1 = 0;
        decimal num2 = 0;
        decimal num3 = 0;
        string operation = "";
        bool ispoint = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                if(ispoint == true)
                {
                    num1 = num1 + (decimal)0.1;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 1;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.1;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 1;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button2Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.2;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 2;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.2;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 2;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button3Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.3;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 3;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.3;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 3;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button4Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.4;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 4;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.4;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 4;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button5Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.5;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 5;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.5;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 5;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button6Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.6;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 6;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.6;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 6;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button7Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.7;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 7;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.7;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 7;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button8Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.8;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 8;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.8;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 8;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button9Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (ispoint == true)
                {
                    num1 = num1 + (decimal)0.9;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 9;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.9;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 9;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void button0Click(object sender, RoutedEventArgs e)
        {
           if(operation == "")
            {
                if(ispoint == true)
                {
                    num1 = num1 + (decimal)0.0;
                    outputText.Text = num1.ToString();
                    ispoint = false;
                }
                else
                {
                    num1 = (num1 * 10) + 0;
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (ispoint == true)
                {
                    num2 = num2 + (decimal)0.0;
                    outputText.Text = num2.ToString();
                    ispoint = false;
                }
                else
                {
                    num2 = (num2 * 10) + 0;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void buttonPlusClick(object sender, RoutedEventArgs e)
        {
            operation = "+";
            outputText.Text = "0";
        }
        private void buttonMinusClick(object sender, RoutedEventArgs e)
        {
            operation = "-";
            outputText.Text = "0";
        }
        private void buttonMulClick(object sender, RoutedEventArgs e)
        {
            operation = "*";
            outputText.Text = "0";
        }
        private void buttonDivClick(object sender, RoutedEventArgs e)
        {
            operation = "/";
            outputText.Text = "0";
        }
        private void buttonSquareClick(object sender, RoutedEventArgs e)
        {
            operation = "^2";
            outputText.Text = "0";
        }
        private void buttonEqualClick(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    outputText.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    outputText.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    outputText.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    outputText.Text = (num1 / num2).ToString();
                    break;
            }
        }
        private void buttonClearEntryClick(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
            outputText.Text = "0";
        }
        private void buttonClearClick(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            outputText.Text = "0";
        }
        private void buttonBackspaceClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if(num1/10 > 1)
                {
                    num1 = (num1 - (num1 % 10)) / 10;                 
                    outputText.Text = num1.ToString();                
                }
                else
                {
                    num1 = 0;                   
                    outputText.Text = num1.ToString();
                }
            }
            else
            {
                if (num2 / 10 > 1)
                {
                    num2 = (num2 - (num2 % 10)) / 10;

                    outputText.Text = num2.ToString();
                }
                else
                {
                    num2 = 0;
                    outputText.Text = num2.ToString();
                }
            }
        }
        private void buttonNegativeClick(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = (num1 * -1);
                outputText.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * -1);
                outputText.Text = num2.ToString();
            }
        }
        private void percentClick(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = (num1 / 100);
                outputText.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 100);
                outputText.Text = num2.ToString();
            }
        }
        private void squarerootClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                double i, number;
                number = double.Parse(outputText.Text);
                i = Math.Round(Math.Sqrt(number), 2);
                num1 = (decimal)i;
                outputText.Text = num1.ToString();
            }
            else
            {

                double i, number;
                number = double.Parse(outputText.Text);
                i = Math.Round(Math.Sqrt(number), 2);
                num2 = (decimal)i;
                outputText.Text = num2.ToString();
            }

        }
        private void squareClick(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = num1 * num1;
                outputText.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * num2;
                outputText.Text = num2.ToString();
            }
        }
        private void cubeClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = num1 * num1 * num1;
                outputText.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * num2 * num2;
                outputText.Text = num2.ToString();
            }
        }
        private void fractionClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = 1 / num1;
                outputText.Text = num1.ToString();
            }
            else
            {
                num2 = 1 / num2;
                outputText.Text = num2.ToString();
            }
        }
        private void input(string a)
        {
            if (outputText.Text == "0")
            {
                outputText.Text = a;          
            }
                
            else
            {
                outputText.Text += a;
            }
        }
        private void buttonPointClick(object sender, RoutedEventArgs e)
        {
            if(outputText.Text != "")
            {
                if(!outputText.Text.Contains("."))
                {
                    if (outputText.Text == "0")
                    {
                        input("0.");
                        ispoint = true;
                    }
                    else
                    {
                        input(".");
                        ispoint = true;
                    }
                }
            }
        }
    }

}
