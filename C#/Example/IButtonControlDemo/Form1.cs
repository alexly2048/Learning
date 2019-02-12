using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IButtonControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        void initControls()
        {
        //    Button defaultButton = new Button();
        //    defaultButton.Text = "测试";
        //    defaultButton.Size = new Size(20, 30);
        //    defaultButton.Location = new Point(50, 50);
        //    this.Controls.Add(defaultButton);

            MyButton button = new MyButton();
            button.Text = "自定义按钮";
            button.Size = new Size(100, 200);
            button.Location = new Point(20, 20);
            button.NotifyDefault(false);
            this.Controls.Add(button);
        }
    }
}
