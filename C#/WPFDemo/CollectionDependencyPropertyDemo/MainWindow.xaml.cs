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

namespace CollectionDependencyPropertyDemo
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

        // 点击显示依赖属性调用结果
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            Aquarium aquarium1 = new Aquarium();
            Aquarium aquarium2 = new Aquarium();
            Fish fish1 = new Fish();
            Fish fish2 = new Fish();
            aquarium1.AquariumContents.Add(fish1);
            aquarium2.AquariumContents.Add(fish2);
            StringBuilder sb = new StringBuilder();

            sb.Append("aquarium1包含：" + aquarium1.AquariumContents.Count.ToString() + "对象\n");
            sb.Append("aquarium2包含：" + aquarium2.AquariumContents.Count.ToString() + "对象");
            Display.Text = sb.ToString();
        }
    }
}
