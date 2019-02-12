using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CollectionDependencyPropertyDemo
{
    public class Aquarium: DependencyObject
    {

        // 添加构造函数，为每个示例创建单独的List<Framework>，保证每个示例独立型
        public Aquarium() : base()
        {
            SetValue(AquariumContentsPropertyKey, new List<FrameworkElement>());
        }

        private static readonly DependencyPropertyKey AquariumContentsPropertyKey =
            DependencyProperty.RegisterReadOnly(
                "AquariumContents",
                typeof(List<FrameworkElement>),
                typeof(Aquarium),
                new FrameworkPropertyMetadata(new List<FrameworkElement>())
                );

        public static readonly DependencyProperty AquariumContentsProperty =
            AquariumContentsPropertyKey.DependencyProperty;

        public List<FrameworkElement> AquariumContents
        {
            get { return (List<FrameworkElement>)GetValue(AquariumContentsProperty); }
        }
    }
}
