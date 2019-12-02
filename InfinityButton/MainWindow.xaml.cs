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

namespace InfinityButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void FindMe(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            button.Margin = new Thickness(random.Next(0, 600), random.Next(0, 305), 0, 0);
            button.Height = random.Next(50, 100);
            button.Width = random.Next(50, 100);
        }
    }
}
