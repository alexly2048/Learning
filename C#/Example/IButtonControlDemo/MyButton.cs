using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IButtonControlDemo
{
    public class MyButton : ButtonBase, IButtonControl
    {
        public DialogResult myDialogResult;

        public MyButton()
        {
            this.FlatStyle = FlatStyle.Popup;
            this.BackColor = System.Drawing.Color.Aqua;
        }

        public DialogResult DialogResult
        {
            get
            {
                return this.myDialogResult;
            }
            set
            {
                if (Enum.IsDefined(typeof(DialogResult), value))
                {
                    this.myDialogResult = value;
                }
            }
        }

       

        public void NotifyDefault(bool value)
        {
            if (this.IsDefault != value)
            {
                this.IsDefault = value;
            }
        }

        public void PerformClick()
        {
            if (this.CanSelect)
            {
                this.OnClick(EventArgs.Empty); 
            }
        }
    }
}
