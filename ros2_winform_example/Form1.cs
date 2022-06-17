using System;
using System.Windows.Forms;

namespace ros2_winform_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ROS2Interface ros2 = new ROS2Interface();
            ros2.ReceivedMsg += Ros2_ReceivedMsg;
        }

        private void Ros2_ReceivedMsg(string data)
        {
            this.Invoke(new Action(() => { label1.Text = data; }));
        }
    }
}
