using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace AddOwnerTypeDependencyPropertyDemo
{
    public class AddOwnerType:Control
    {
        public AddOwnerType() { }

        public static readonly DependencyProperty StateProperty = Base.StateProperty.AddOwner(typeof(AddOwnerType), new PropertyMetadata(true));

        public Boolean State
        {
            get { return (Boolean)this.GetValue(StateProperty); }
            set { this.SetValue(StateProperty, value); }
        }
    }
}
