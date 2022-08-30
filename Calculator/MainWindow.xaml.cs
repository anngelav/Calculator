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
        private string Operation;

        public double FirstNumber { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = Convert.ToString(FirstNumber); 
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
        }
        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            string s1 =Convert.ToString(TextBox1.Text);
            string s2;
            s2 = s1.Remove(s1.Length - 1);
            TextBox1.Text = s2;
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(TextBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                TextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    TextBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    TextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "7";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "7";
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "8";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "8";
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "9";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "9";
            }
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "0";
            Operation = "/";
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "4";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "4";
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "5";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "5";
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "6";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "6";
            }
        }
        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "0";
            Operation = "*";
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "1";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "1";
            }
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "2";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "2";
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "3";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "3";
            }
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "0";
            Operation = "+";
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "0" && TextBox1.Text != null)
            {
                TextBox1.Text = "0";
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "0";
            }
        }
        private void Point_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "0";
            Operation = "-";
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
