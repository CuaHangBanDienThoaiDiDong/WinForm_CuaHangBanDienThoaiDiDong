using System;
using System.Windows.Forms;
using System.Drawing;

namespace AddControl
{
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            this.Text = "Current Time:";
            this.Location = new System.Drawing.Point(10, 10);
            this.AutoSize = true;

            Timer timer = new Timer();
            timer.Interval = 1000; // Cập nhật thời gian mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text =  "- " + DateTime.Now.ToString("HH:mm:ss");
        }


    }
}
