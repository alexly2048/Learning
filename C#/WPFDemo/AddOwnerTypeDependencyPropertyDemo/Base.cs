using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace AddOwnerTypeDependencyPropertyDemo
{
    public class Base:ButtonBase
    {
        public Base():base()
        {

        }
        public Boolean State
        {
            get { return (Boolean)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }
        public static readonly DependencyProperty StateProperty = DependencyProperty.Register(
            "State",
            typeof(Boolean),
            typeof(Base),
            new PropertyMetadata(false)
            );
    }
}
