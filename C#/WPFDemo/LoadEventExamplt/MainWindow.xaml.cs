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

namespace LoadEventExamplt
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object send, RoutedEventArgs e)
        {
            Button myButton = new Button();
            myButton.Content = "Click Me";
            myButton.Background = new SolidColorBrush(Colors.Black);
            myButton.Foreground = new SolidColorBrush(Colors.Green);
            myButton.FontFamily = new FontFamily("Arial");

            root.Children.Add(myButton);
            RowDefinition rowDefinition = new RowDefinition();
            rowDefinition.Height = GridLength.Auto;
            root.RowDefinitions.Add(rowDefinition);
            RowDefinition rowDef = new RowDefinition();
            root.RowDefinitions.Add(rowDef);
            Grid.SetRow(myButton, 0);
   //         Grid.SetRowSpan(myButton, 2);
            

        }
    }
}
