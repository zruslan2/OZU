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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long a, b;
        int [,] ko;
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ko = null;
            a = 0;
            b = 0;

            a = long.Parse(textBox0.Text);
            b = a*1000000 / 32000/4;
            ko = new int[32000, b];
            for(int i=0; i<=31199;i++)
            {
               
                for(int y=0;y<=b-1;y++)
                {
                    ko[i,y] = i;
                    //ko[32000, y] = y;
                }
            }

            var test = ko;
        }

        public MainWindow()
        {
            InitializeComponent();

        }
    }
}
