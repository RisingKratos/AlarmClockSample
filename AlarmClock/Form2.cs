using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form2 : Form
    {
        public char yourChoice;
        public Form2()
        {
            InitializeComponent();
            Form1 form = this.Owner as Form1;
            int x = new int();
            x = form.time;
            for (int i = 0; i < 16; i++) 
            {
                form.time += 90;
                if(Math.Abs(x - form.setTime) <= 90)
                {
                    if (x < form.setTime)
                    {
                        label1.Text = (x / 60).ToString();
                        label2.Text = (x % 60).ToString();
                    }
                    if (x > form.setTime)
                    {
                        label3.Text = (x / 60).ToString();
                        label4.Text = (x % 60).ToString();
                    }
                }
            }
        }

        private void ClosestLessTime_Click(object sender, EventArgs e)
        {
            Form1 form = this.Owner as Form1;
            form.setHour = Convert.ToInt32(label1.Text);
            form.setMinute = Convert.ToInt32(label2.Text);
            yourChoice = 'l';
        }

        private void ClosestMoreTime_Click(object sender, EventArgs e)
        {
            Form1 form = this.Owner as Form1;
            form.setHour = Convert.ToInt32(label3.Text);
            form.setMinute = Convert.ToInt32(label4.Text);
            yourChoice = 'm';
        }
    }
}
