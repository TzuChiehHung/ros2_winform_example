using System.Threading;
using ROS2;

namespace ros2_winform_example
{
    class ROS2Interface
    {

        public ROS2Interface()
        {
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }

        public delegate void Notify(string data);
        public event Notify ReceivedMsg;

        protected virtual void OnReceivedMsg(string data) //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ReceivedMsg?.Invoke(data);
        }

        private void ThreadTask()
        {
            RCLdotnet.Init();
            INode node = RCLdotnet.CreateNode("listener");
            ISubscription<std_msgs.msg.String> chatter_sub = node.CreateSubscription<std_msgs.msg.String>("chatter", msg => Callback(msg));
            RCLdotnet.Spin(node);
        }
        void Callback(std_msgs.msg.String msg)
        {
            OnReceivedMsg(msg.Data);
        }
    }
}
