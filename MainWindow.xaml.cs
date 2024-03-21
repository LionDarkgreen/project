using System;
using System.Numerics;  
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
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

namespace SimpleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
            {
                textLabel.Text = "";
                textLabel.Background = Brushes.Transparent;
            }

            else if (str == "Check")
            {
                if (textLabel.Text == "")
                {
                    textLabel.ToolTip = "Введите число";
                    textLabel.Background = Brushes.DarkRed;
                }
                else if (textLabel.Text == "Число простое" || textLabel.Text == "Число непростое")
                {
                    textLabel.ToolTip = "Очистите строку";
                    textLabel.Background = Brushes.DarkRed;
                }
                else
                {
                    textLabel.ToolTip = "";
                    textLabel.Background = Brushes.Transparent;
                    bool prost = true;
                    int n = int.Parse(textLabel.Text);
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            prost = false;
                            break;
                        }
                    }
                    if (prost)
                        textLabel.Text = "Число простое";

                    else
                        textLabel.Text = "Число непростое";
                }
            }
            else if (textLabel.Text == "Число простое" || textLabel.Text == "Число непростое")
            {
                textLabel.ToolTip = "Очистите строку";
                textLabel.Background = Brushes.DarkRed;
            }
            else
                textLabel.Text += str;
        }
        
    }
}
